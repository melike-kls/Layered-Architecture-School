namespace OkulAppSube1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblAd = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblNumara = new System.Windows.Forms.Label();
            this.lblSinifId = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtNumara = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.lblBul = new System.Windows.Forms.Label();
            this.txtBul = new System.Windows.Forms.TextBox();
            this.btnBul = new System.Windows.Forms.Button();
            this.cmbSiniflar = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(122, 50);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(20, 13);
            this.lblAd.TabIndex = 0;
            this.lblAd.Text = "Ad";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(122, 76);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(37, 13);
            this.lblSoyad.TabIndex = 1;
            this.lblSoyad.Text = "Soyad";
            // 
            // lblNumara
            // 
            this.lblNumara.AutoSize = true;
            this.lblNumara.Location = new System.Drawing.Point(122, 102);
            this.lblNumara.Name = "lblNumara";
            this.lblNumara.Size = new System.Drawing.Size(44, 13);
            this.lblNumara.TabIndex = 2;
            this.lblNumara.Text = "Numara";
            // 
            // lblSinifId
            // 
            this.lblSinifId.AutoSize = true;
            this.lblSinifId.Location = new System.Drawing.Point(102, 128);
            this.lblSinifId.Name = "lblSinifId";
            this.lblSinifId.Size = new System.Drawing.Size(64, 13);
            this.lblSinifId.TabIndex = 3;
            this.lblSinifId.Text = "Sınıf Seçiniz";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(182, 43);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 20);
            this.txtAd.TabIndex = 4;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(182, 69);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtSoyad.TabIndex = 5;
            // 
            // txtNumara
            // 
            this.txtNumara.Location = new System.Drawing.Point(182, 95);
            this.txtNumara.Name = "txtNumara";
            this.txtNumara.Size = new System.Drawing.Size(100, 20);
            this.txtNumara.TabIndex = 6;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(182, 147);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(100, 23);
            this.btnKaydet.TabIndex = 8;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // lblBul
            // 
            this.lblBul.AutoSize = true;
            this.lblBul.Location = new System.Drawing.Point(109, 273);
            this.lblBul.Name = "lblBul";
            this.lblBul.Size = new System.Drawing.Size(52, 13);
            this.lblBul.TabIndex = 9;
            this.lblBul.Text = "No Giriniz";
            // 
            // txtBul
            // 
            this.txtBul.Location = new System.Drawing.Point(173, 270);
            this.txtBul.Name = "txtBul";
            this.txtBul.Size = new System.Drawing.Size(100, 20);
            this.txtBul.TabIndex = 10;
            // 
            // btnBul
            // 
            this.btnBul.Location = new System.Drawing.Point(289, 267);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(75, 23);
            this.btnBul.TabIndex = 11;
            this.btnBul.Text = "BUL";
            this.btnBul.UseVisualStyleBackColor = true;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // cmbSiniflar
            // 
            this.cmbSiniflar.FormattingEnabled = true;
            this.cmbSiniflar.Location = new System.Drawing.Point(182, 120);
            this.cmbSiniflar.Name = "cmbSiniflar";
            this.cmbSiniflar.Size = new System.Drawing.Size(100, 21);
            this.cmbSiniflar.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 318);
            this.Controls.Add(this.cmbSiniflar);
            this.Controls.Add(this.btnBul);
            this.Controls.Add(this.txtBul);
            this.Controls.Add(this.lblBul);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtNumara);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.lblSinifId);
            this.Controls.Add(this.lblNumara);
            this.Controls.Add(this.lblSoyad);
            this.Controls.Add(this.lblAd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblNumara;
        private System.Windows.Forms.Label lblSinifId;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtNumara;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label lblBul;
        private System.Windows.Forms.TextBox txtBul;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.ComboBox cmbSiniflar;
    }
}

