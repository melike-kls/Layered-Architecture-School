using DAL;
using MODEL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Bussiness Logic Layer
namespace BLL
{
    public class OgrenciBL
    {

        public bool Kaydet(Ogrenci ogr)
        {
            if (ogr == null)
            {
                throw new NullReferenceException("Ogrenci eklerken referans null geldi");
            }

            try
            {
                Helper hlp = new Helper();
                int sonuc = hlp.ExecuteNonQuery($"Insert into tblOgrenciler (Ad,Soyad,Numara,SinifId) values ('{ogr.Ad}','{ogr.Soyad}','{ogr.Numara}',{ogr.Sinifid})");
                return sonuc > 0;
            }
            catch (Exception)
            {
                throw;
            }

        }

        public bool Guncelle(Ogrenci ogr)
        {
            if (ogr == null)
            {
                throw new NullReferenceException("Ogrenci güncellerken referans null geldi");
            }

            try
            {
                Helper hlp = new Helper();
                int sonuc = hlp.ExecuteNonQuery($"Update tblOgrenciler set Ad='{ogr.Ad}',Soyad='{ogr.Soyad}',Numara='{ogr.Numara}',Sinifid={ogr.Sinifid} where Ogrenciid={ogr.Ogrenciid}");
                return sonuc > 0;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool OgrenciSil(int ogrenciid)
        {
            try
            {
                Helper hlp = new Helper();
                int sonuc = hlp.ExecuteNonQuery($"Delete from tblOgrenciler where Ogrenciid={ogrenciid}");
                return sonuc > 0;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Ogrenci OgrenciGetir(string numara)
        {
            Ogrenci ogr = null;
            Helper hlp = new Helper();
            SqlDataReader dr = hlp.ExecuteReader($"Select * from tblOgrenciler where Numara='{numara}'");
            if (dr.Read())
            {
                ogr = new Ogrenci();
                ogr.Ad = dr["Ad"].ToString();
                ogr.Soyad = dr["Soyad"].ToString();
                ogr.Numara = dr["Numara"].ToString();
                ogr.Ogrenciid = Convert.ToInt32(dr["Ogrenciid"]);
                ogr.Sinifid = Convert.ToInt32(dr["Sinifid"]);
            }
            dr.Close();
            return ogr;
        }

        public List<Ogrenci> OgrenciListesi()
        {
            return null;
        }
    }
}
