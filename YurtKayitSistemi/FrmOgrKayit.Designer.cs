namespace YurtKayitSistemi
{
    partial class FrmOgrKayit
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOgrKayit));
            this.Label = new System.Windows.Forms.Label();
            this.TxtOgrAd = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.TxtOgrSoyad = new System.Windows.Forms.TextBox();
            this.OgrTC = new System.Windows.Forms.Label();
            this.MaskTC = new System.Windows.Forms.MaskedTextBox();
            this.OgrTelefon = new System.Windows.Forms.Label();
            this.maskOgrTelefon = new System.Windows.Forms.MaskedTextBox();
            this.OgrDogum = new System.Windows.Forms.Label();
            this.maskOgrDogum = new System.Windows.Forms.MaskedTextBox();
            this.TxtOgrBolum = new System.Windows.Forms.Label();
            this.OgrBolum = new System.Windows.Forms.ComboBox();
            this.TxtOgrMail = new System.Windows.Forms.Label();
            this.OgrMail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OgrOdaNo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtVeliAdSoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.maskVeliTelefon = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.RichAdres = new System.Windows.Forms.RichTextBox();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label.Location = new System.Drawing.Point(280, 26);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(126, 23);
            this.Label.TabIndex = 0;
            this.Label.Text = "Öğrenci Adı :";
            // 
            // TxtOgrAd
            // 
            this.TxtOgrAd.BackColor = System.Drawing.Color.Snow;
            this.TxtOgrAd.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtOgrAd.Location = new System.Drawing.Point(432, 23);
            this.TxtOgrAd.Name = "TxtOgrAd";
            this.TxtOgrAd.Size = new System.Drawing.Size(266, 31);
            this.TxtOgrAd.TabIndex = 1;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(250, 63);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(156, 23);
            this.Label4.TabIndex = 0;
            this.Label4.Text = "Öğrenci Soyadı :";
            // 
            // TxtOgrSoyad
            // 
            this.TxtOgrSoyad.BackColor = System.Drawing.Color.Snow;
            this.TxtOgrSoyad.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtOgrSoyad.Location = new System.Drawing.Point(432, 60);
            this.TxtOgrSoyad.Name = "TxtOgrSoyad";
            this.TxtOgrSoyad.Size = new System.Drawing.Size(266, 31);
            this.TxtOgrSoyad.TabIndex = 2;
            // 
            // OgrTC
            // 
            this.OgrTC.AutoSize = true;
            this.OgrTC.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OgrTC.Location = new System.Drawing.Point(288, 100);
            this.OgrTC.Name = "OgrTC";
            this.OgrTC.Size = new System.Drawing.Size(118, 23);
            this.OgrTC.TabIndex = 0;
            this.OgrTC.Text = "Öğrenci TC :";
            // 
            // MaskTC
            // 
            this.MaskTC.BackColor = System.Drawing.Color.Snow;
            this.MaskTC.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MaskTC.Location = new System.Drawing.Point(432, 97);
            this.MaskTC.Mask = "00000000000";
            this.MaskTC.Name = "MaskTC";
            this.MaskTC.Size = new System.Drawing.Size(266, 31);
            this.MaskTC.TabIndex = 3;
            // 
            // OgrTelefon
            // 
            this.OgrTelefon.AutoSize = true;
            this.OgrTelefon.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OgrTelefon.Location = new System.Drawing.Point(317, 137);
            this.OgrTelefon.Name = "OgrTelefon";
            this.OgrTelefon.Size = new System.Drawing.Size(89, 23);
            this.OgrTelefon.TabIndex = 0;
            this.OgrTelefon.Text = "Telefon :";
            // 
            // maskOgrTelefon
            // 
            this.maskOgrTelefon.BackColor = System.Drawing.Color.Snow;
            this.maskOgrTelefon.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskOgrTelefon.Location = new System.Drawing.Point(432, 134);
            this.maskOgrTelefon.Mask = "(999) 000-0000";
            this.maskOgrTelefon.Name = "maskOgrTelefon";
            this.maskOgrTelefon.Size = new System.Drawing.Size(266, 31);
            this.maskOgrTelefon.TabIndex = 4;
            // 
            // OgrDogum
            // 
            this.OgrDogum.AutoSize = true;
            this.OgrDogum.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OgrDogum.Location = new System.Drawing.Point(262, 174);
            this.OgrDogum.Name = "OgrDogum";
            this.OgrDogum.Size = new System.Drawing.Size(144, 23);
            this.OgrDogum.TabIndex = 0;
            this.OgrDogum.Text = "Doğum Tarihi :";
            // 
            // maskOgrDogum
            // 
            this.maskOgrDogum.BackColor = System.Drawing.Color.Snow;
            this.maskOgrDogum.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskOgrDogum.Location = new System.Drawing.Point(432, 171);
            this.maskOgrDogum.Mask = "00/00/0000";
            this.maskOgrDogum.Name = "maskOgrDogum";
            this.maskOgrDogum.Size = new System.Drawing.Size(266, 31);
            this.maskOgrDogum.TabIndex = 5;
            this.maskOgrDogum.ValidatingType = typeof(System.DateTime);
            // 
            // TxtOgrBolum
            // 
            this.TxtOgrBolum.AutoSize = true;
            this.TxtOgrBolum.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtOgrBolum.Location = new System.Drawing.Point(250, 212);
            this.TxtOgrBolum.Name = "TxtOgrBolum";
            this.TxtOgrBolum.Size = new System.Drawing.Size(155, 23);
            this.TxtOgrBolum.TabIndex = 0;
            this.TxtOgrBolum.Text = "Öğrenci Bölüm :";
            // 
            // OgrBolum
            // 
            this.OgrBolum.BackColor = System.Drawing.Color.Snow;
            this.OgrBolum.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OgrBolum.FormattingEnabled = true;
            this.OgrBolum.Location = new System.Drawing.Point(432, 209);
            this.OgrBolum.Name = "OgrBolum";
            this.OgrBolum.Size = new System.Drawing.Size(266, 31);
            this.OgrBolum.TabIndex = 6;
            // 
            // TxtOgrMail
            // 
            this.TxtOgrMail.AutoSize = true;
            this.TxtOgrMail.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtOgrMail.Location = new System.Drawing.Point(326, 249);
            this.TxtOgrMail.Name = "TxtOgrMail";
            this.TxtOgrMail.Size = new System.Drawing.Size(79, 23);
            this.TxtOgrMail.TabIndex = 0;
            this.TxtOgrMail.Text = "E-Mail :";
            // 
            // OgrMail
            // 
            this.OgrMail.BackColor = System.Drawing.Color.Snow;
            this.OgrMail.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OgrMail.Location = new System.Drawing.Point(432, 246);
            this.OgrMail.Name = "OgrMail";
            this.OgrMail.Size = new System.Drawing.Size(266, 31);
            this.OgrMail.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(254, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Oda Numarası :";
            // 
            // OgrOdaNo
            // 
            this.OgrOdaNo.BackColor = System.Drawing.Color.Snow;
            this.OgrOdaNo.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OgrOdaNo.FormattingEnabled = true;
            this.OgrOdaNo.Location = new System.Drawing.Point(432, 283);
            this.OgrOdaNo.Name = "OgrOdaNo";
            this.OgrOdaNo.Size = new System.Drawing.Size(266, 31);
            this.OgrOdaNo.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(240, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Veli Adı - Soyadı :";
            // 
            // TxtVeliAdSoyad
            // 
            this.TxtVeliAdSoyad.BackColor = System.Drawing.Color.Snow;
            this.TxtVeliAdSoyad.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtVeliAdSoyad.Location = new System.Drawing.Point(432, 320);
            this.TxtVeliAdSoyad.Name = "TxtVeliAdSoyad";
            this.TxtVeliAdSoyad.Size = new System.Drawing.Size(266, 31);
            this.TxtVeliAdSoyad.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(278, 360);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Veli Telefon :";
            // 
            // maskVeliTelefon
            // 
            this.maskVeliTelefon.BackColor = System.Drawing.Color.Snow;
            this.maskVeliTelefon.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskVeliTelefon.Location = new System.Drawing.Point(432, 357);
            this.maskVeliTelefon.Mask = "(999) 000-0000";
            this.maskVeliTelefon.Name = "maskVeliTelefon";
            this.maskVeliTelefon.Size = new System.Drawing.Size(266, 31);
            this.maskVeliTelefon.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(331, 397);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Adres :";
            // 
            // RichAdres
            // 
            this.RichAdres.BackColor = System.Drawing.Color.Snow;
            this.RichAdres.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RichAdres.Location = new System.Drawing.Point(432, 394);
            this.RichAdres.Name = "RichAdres";
            this.RichAdres.Size = new System.Drawing.Size(266, 84);
            this.RichAdres.TabIndex = 11;
            this.RichAdres.Text = "";
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKaydet.Location = new System.Drawing.Point(581, 484);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(117, 35);
            this.BtnKaydet.TabIndex = 12;
            this.BtnKaydet.Text = "KAYDET";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(348, 439);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "label6";
            // 
            // FrmOgrKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(742, 531);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.RichAdres);
            this.Controls.Add(this.OgrOdaNo);
            this.Controls.Add(this.OgrBolum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maskOgrDogum);
            this.Controls.Add(this.TxtOgrBolum);
            this.Controls.Add(this.OgrDogum);
            this.Controls.Add(this.maskVeliTelefon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.maskOgrTelefon);
            this.Controls.Add(this.OgrTelefon);
            this.Controls.Add(this.MaskTC);
            this.Controls.Add(this.OgrTC);
            this.Controls.Add(this.TxtVeliAdSoyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OgrMail);
            this.Controls.Add(this.TxtOgrMail);
            this.Controls.Add(this.TxtOgrSoyad);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.TxtOgrAd);
            this.Controls.Add(this.Label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmOgrKayit";
            this.Text = "Öğrenci Kayıt";
            this.Load += new System.EventHandler(this.FrmOgrKayit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.TextBox TxtOgrAd;
        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.TextBox TxtOgrSoyad;
        private System.Windows.Forms.Label OgrTC;
        private System.Windows.Forms.MaskedTextBox MaskTC;
        private System.Windows.Forms.Label OgrTelefon;
        private System.Windows.Forms.MaskedTextBox maskOgrTelefon;
        private System.Windows.Forms.Label OgrDogum;
        private System.Windows.Forms.MaskedTextBox maskOgrDogum;
        private System.Windows.Forms.Label TxtOgrBolum;
        private System.Windows.Forms.ComboBox OgrBolum;
        private System.Windows.Forms.Label TxtOgrMail;
        private System.Windows.Forms.TextBox OgrMail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox OgrOdaNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtVeliAdSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox maskVeliTelefon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox RichAdres;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.Label label6;
    }
}

