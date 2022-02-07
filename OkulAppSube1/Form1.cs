using BLL;
using MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OkulAppSube1
{
    public partial class Form1 : Form
    {
        string cstr = ConfigurationManager.ConnectionStrings["cstr"].ConnectionString;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            OgrenciBL obl = new OgrenciBL();
            try
            {
                MessageBox.Show(obl.Kaydet(new Ogrenci { Ad = txtAd.Text.Trim(), Soyad = txtSoyad.Text.Trim(), Numara = txtNumara.Text.Trim(), Sinifid = Convert.ToInt32(cmbSiniflar.SelectedValue) }) ? "Ekleme Başarılı" : "Ekleme Başarısız!");
            }
            catch (SqlException)
            {
                MessageBox.Show("Veritabanı Hatası");
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bilinmeyen Hata!");
            }
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            OgrenciBL obl = new OgrenciBL();
            Ogrenci ogr = obl.OgrenciGetir(txtBul.Text.Trim());
            if (ogr!=null) 
            {
                txtAd.Text = ogr.Ad;
                txtSoyad.Text = ogr.Soyad;
                txtNumara.Text = ogr.Numara;
                cmbSiniflar.SelectedValue = ogr.Sinifid;
            }
            else
            {
                MessageBox.Show("Öğrenci bulunamadı!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection cn = null;
            try
            {
                cn = new SqlConnection(cstr);
                cn.Open();
                SqlCommand cmd = new SqlCommand($"Select SinifId,SinifAd,Kontenjan from tblSiniflar", cn);

                SqlDataReader dr = cmd.ExecuteReader();
                var lst = new List<Sinif>();

                while (dr.Read())
                {
                    var snf = new Sinif();
                    snf.Kontenjan = Convert.ToInt32(dr["Kontenjan"]);
                    snf.Sinifad = dr["SinifAd"].ToString();
                    snf.Sinifid = Convert.ToInt32(dr["SinifId"]);
                    lst.Add(snf);
                }
                dr.Close();
                cmbSiniflar.DisplayMember = "Sinifad";
                cmbSiniflar.ValueMember = "Sinifid";
                cmbSiniflar.DataSource = lst;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (cn != null && cn.State != ConnectionState.Closed)//Null Check
                {
                    cn.Close();
                }
            }
        }
    }
}
//DRY: Don't Repeat Yourself