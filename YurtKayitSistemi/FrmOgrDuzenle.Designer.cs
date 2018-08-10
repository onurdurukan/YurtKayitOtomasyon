namespace YurtKayitSistemi
{
    partial class FrmOgrDuzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOgrDuzenle));
            this.label6 = new System.Windows.Forms.Label();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.RichAdres = new System.Windows.Forms.RichTextBox();
            this.OgrOdaNo = new System.Windows.Forms.ComboBox();
            this.OgrBolum = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.maskOgrDogum = new System.Windows.Forms.MaskedTextBox();
            this.TxtOgrBolum = new System.Windows.Forms.Label();
            this.OgrDogum = new System.Windows.Forms.Label();
            this.maskVeliTelefon = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.maskOgrTelefon = new System.Windows.Forms.MaskedTextBox();
            this.OgrTelefon = new System.Windows.Forms.Label();
            this.MaskTC = new System.Windows.Forms.MaskedTextBox();
            this.OgrTC = new System.Windows.Forms.Label();
            this.TxtVeliAdSoyad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.OgrMail = new System.Windows.Forms.TextBox();
            this.TxtOgrMail = new System.Windows.Forms.Label();
            this.TxtOgrSoyad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtOgrAd = new System.Windows.Forms.TextBox();
            this.Label = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtOgrID = new System.Windows.Forms.TextBox();
            this.BtnSil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(266, 462);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 30;
            this.label6.Text = "label6";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKaydet.Location = new System.Drawing.Point(477, 507);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(139, 35);
            this.BtnKaydet.TabIndex = 13;
            this.BtnKaydet.Text = "GÜNCELLE";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // RichAdres
            // 
            this.RichAdres.BackColor = System.Drawing.Color.Snow;
            this.RichAdres.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RichAdres.Location = new System.Drawing.Point(350, 417);
            this.RichAdres.Name = "RichAdres";
            this.RichAdres.Size = new System.Drawing.Size(266, 84);
            this.RichAdres.TabIndex = 12;
            this.RichAdres.Text = "";
            this.RichAdres.TextChanged += new System.EventHandler(this.RichAdres_TextChanged);
            // 
            // OgrOdaNo
            // 
            this.OgrOdaNo.BackColor = System.Drawing.Color.Snow;
            this.OgrOdaNo.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OgrOdaNo.FormattingEnabled = true;
            this.OgrOdaNo.Location = new System.Drawing.Point(350, 306);
            this.OgrOdaNo.Name = "OgrOdaNo";
            this.OgrOdaNo.Size = new System.Drawing.Size(266, 31);
            this.OgrOdaNo.TabIndex = 9;
            this.OgrOdaNo.SelectedIndexChanged += new System.EventHandler(this.OgrOdaNo_SelectedIndexChanged);
            // 
            // OgrBolum
            // 
            this.OgrBolum.BackColor = System.Drawing.Color.Snow;
            this.OgrBolum.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OgrBolum.FormattingEnabled = true;
            this.OgrBolum.Location = new System.Drawing.Point(350, 232);
            this.OgrBolum.Name = "OgrBolum";
            this.OgrBolum.Size = new System.Drawing.Size(266, 31);
            this.OgrBolum.TabIndex = 7;
            this.OgrBolum.SelectedIndexChanged += new System.EventHandler(this.OgrBolum_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(172, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 23);
            this.label2.TabIndex = 16;
            this.label2.Text = "Oda Numarası :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // maskOgrDogum
            // 
            this.maskOgrDogum.BackColor = System.Drawing.Color.Snow;
            this.maskOgrDogum.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskOgrDogum.Location = new System.Drawing.Point(350, 194);
            this.maskOgrDogum.Mask = "00/00/0000";
            this.maskOgrDogum.Name = "maskOgrDogum";
            this.maskOgrDogum.Size = new System.Drawing.Size(266, 31);
            this.maskOgrDogum.TabIndex = 6;
            this.maskOgrDogum.ValidatingType = typeof(System.DateTime);
            this.maskOgrDogum.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskOgrDogum_MaskInputRejected);
            // 
            // TxtOgrBolum
            // 
            this.TxtOgrBolum.AutoSize = true;
            this.TxtOgrBolum.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtOgrBolum.Location = new System.Drawing.Point(168, 235);
            this.TxtOgrBolum.Name = "TxtOgrBolum";
            this.TxtOgrBolum.Size = new System.Drawing.Size(155, 23);
            this.TxtOgrBolum.TabIndex = 17;
            this.TxtOgrBolum.Text = "Öğrenci Bölüm :";
            this.TxtOgrBolum.Click += new System.EventHandler(this.TxtOgrBolum_Click);
            // 
            // OgrDogum
            // 
            this.OgrDogum.AutoSize = true;
            this.OgrDogum.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OgrDogum.Location = new System.Drawing.Point(180, 197);
            this.OgrDogum.Name = "OgrDogum";
            this.OgrDogum.Size = new System.Drawing.Size(144, 23);
            this.OgrDogum.TabIndex = 14;
            this.OgrDogum.Text = "Doğum Tarihi :";
            this.OgrDogum.Click += new System.EventHandler(this.OgrDogum_Click);
            // 
            // maskVeliTelefon
            // 
            this.maskVeliTelefon.BackColor = System.Drawing.Color.Snow;
            this.maskVeliTelefon.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskVeliTelefon.Location = new System.Drawing.Point(350, 380);
            this.maskVeliTelefon.Mask = "(999) 000-0000";
            this.maskVeliTelefon.Name = "maskVeliTelefon";
            this.maskVeliTelefon.Size = new System.Drawing.Size(266, 31);
            this.maskVeliTelefon.TabIndex = 11;
            this.maskVeliTelefon.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskVeliTelefon_MaskInputRejected);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(249, 420);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 23);
            this.label5.TabIndex = 13;
            this.label5.Text = "Adres :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(187, 388);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Veli Telefon :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // maskOgrTelefon
            // 
            this.maskOgrTelefon.BackColor = System.Drawing.Color.Snow;
            this.maskOgrTelefon.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskOgrTelefon.Location = new System.Drawing.Point(350, 157);
            this.maskOgrTelefon.Mask = "(999) 000-0000";
            this.maskOgrTelefon.Name = "maskOgrTelefon";
            this.maskOgrTelefon.Size = new System.Drawing.Size(266, 31);
            this.maskOgrTelefon.TabIndex = 5;
            this.maskOgrTelefon.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskOgrTelefon_MaskInputRejected);
            // 
            // OgrTelefon
            // 
            this.OgrTelefon.AutoSize = true;
            this.OgrTelefon.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OgrTelefon.Location = new System.Drawing.Point(235, 160);
            this.OgrTelefon.Name = "OgrTelefon";
            this.OgrTelefon.Size = new System.Drawing.Size(89, 23);
            this.OgrTelefon.TabIndex = 12;
            this.OgrTelefon.Text = "Telefon :";
            this.OgrTelefon.Click += new System.EventHandler(this.OgrTelefon_Click);
            // 
            // MaskTC
            // 
            this.MaskTC.BackColor = System.Drawing.Color.Snow;
            this.MaskTC.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MaskTC.Location = new System.Drawing.Point(350, 120);
            this.MaskTC.Mask = "00000000000";
            this.MaskTC.Name = "MaskTC";
            this.MaskTC.Size = new System.Drawing.Size(266, 31);
            this.MaskTC.TabIndex = 4;
            this.MaskTC.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.MaskTC_MaskInputRejected);
            // 
            // OgrTC
            // 
            this.OgrTC.AutoSize = true;
            this.OgrTC.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OgrTC.Location = new System.Drawing.Point(206, 123);
            this.OgrTC.Name = "OgrTC";
            this.OgrTC.Size = new System.Drawing.Size(118, 23);
            this.OgrTC.TabIndex = 11;
            this.OgrTC.Text = "Öğrenci TC :";
            this.OgrTC.Click += new System.EventHandler(this.OgrTC_Click);
            // 
            // TxtVeliAdSoyad
            // 
            this.TxtVeliAdSoyad.BackColor = System.Drawing.Color.Snow;
            this.TxtVeliAdSoyad.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtVeliAdSoyad.Location = new System.Drawing.Point(350, 343);
            this.TxtVeliAdSoyad.Name = "TxtVeliAdSoyad";
            this.TxtVeliAdSoyad.Size = new System.Drawing.Size(266, 31);
            this.TxtVeliAdSoyad.TabIndex = 10;
            this.TxtVeliAdSoyad.TextChanged += new System.EventHandler(this.TxtVeliAdSoyad_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(158, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Veli Adı - Soyadı :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // OgrMail
            // 
            this.OgrMail.BackColor = System.Drawing.Color.Snow;
            this.OgrMail.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OgrMail.Location = new System.Drawing.Point(350, 269);
            this.OgrMail.Name = "OgrMail";
            this.OgrMail.Size = new System.Drawing.Size(266, 31);
            this.OgrMail.TabIndex = 8;
            this.OgrMail.TextChanged += new System.EventHandler(this.OgrMail_TextChanged);
            // 
            // TxtOgrMail
            // 
            this.TxtOgrMail.AutoSize = true;
            this.TxtOgrMail.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtOgrMail.Location = new System.Drawing.Point(244, 272);
            this.TxtOgrMail.Name = "TxtOgrMail";
            this.TxtOgrMail.Size = new System.Drawing.Size(79, 23);
            this.TxtOgrMail.TabIndex = 9;
            this.TxtOgrMail.Text = "E-Mail :";
            this.TxtOgrMail.Click += new System.EventHandler(this.TxtOgrMail_Click);
            // 
            // TxtOgrSoyad
            // 
            this.TxtOgrSoyad.BackColor = System.Drawing.Color.Snow;
            this.TxtOgrSoyad.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtOgrSoyad.Location = new System.Drawing.Point(350, 83);
            this.TxtOgrSoyad.Name = "TxtOgrSoyad";
            this.TxtOgrSoyad.Size = new System.Drawing.Size(266, 31);
            this.TxtOgrSoyad.TabIndex = 3;
            this.TxtOgrSoyad.TextChanged += new System.EventHandler(this.TxtOgrSoyad_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(168, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 23);
            this.label7.TabIndex = 8;
            this.label7.Text = "Öğrenci Soyadı :";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // TxtOgrAd
            // 
            this.TxtOgrAd.BackColor = System.Drawing.Color.Snow;
            this.TxtOgrAd.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtOgrAd.Location = new System.Drawing.Point(350, 46);
            this.TxtOgrAd.Name = "TxtOgrAd";
            this.TxtOgrAd.Size = new System.Drawing.Size(266, 31);
            this.TxtOgrAd.TabIndex = 2;
            this.TxtOgrAd.TextChanged += new System.EventHandler(this.TxtOgrAd_TextChanged);
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label.Location = new System.Drawing.Point(198, 49);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(126, 23);
            this.Label.TabIndex = 15;
            this.Label.Text = "Öğrenci Adı :";
            this.Label.Click += new System.EventHandler(this.Label_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(198, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 23);
            this.label8.TabIndex = 15;
            this.label8.Text = "Öğrenci ID :";
            this.label8.Click += new System.EventHandler(this.Label_Click);
            // 
            // TxtOgrID
            // 
            this.TxtOgrID.BackColor = System.Drawing.Color.Snow;
            this.TxtOgrID.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtOgrID.Location = new System.Drawing.Point(350, 9);
            this.TxtOgrID.Name = "TxtOgrID";
            this.TxtOgrID.Size = new System.Drawing.Size(266, 31);
            this.TxtOgrID.TabIndex = 1;
            this.TxtOgrID.TextChanged += new System.EventHandler(this.TxtOgrAd_TextChanged);
            // 
            // BtnSil
            // 
            this.BtnSil.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSil.Location = new System.Drawing.Point(350, 508);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(109, 34);
            this.BtnSil.TabIndex = 14;
            this.BtnSil.Text = "SİL";
            this.BtnSil.UseVisualStyleBackColor = true;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // FrmOgrDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(816, 556);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.RichAdres);
            this.Controls.Add(this.OgrOdaNo);
            this.Controls.Add(this.OgrBolum);
            this.Controls.Add(this.label2);
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
            this.Controls.Add(this.label4);
            this.Controls.Add(this.OgrMail);
            this.Controls.Add(this.TxtOgrMail);
            this.Controls.Add(this.TxtOgrSoyad);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtOgrID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtOgrAd);
            this.Controls.Add(this.Label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmOgrDuzenle";
            this.Text = "Ögrenci Düzenleme";
            this.Load += new System.EventHandler(this.FrmOgrDuzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.RichTextBox RichAdres;
        private System.Windows.Forms.ComboBox OgrOdaNo;
        private System.Windows.Forms.ComboBox OgrBolum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskOgrDogum;
        private System.Windows.Forms.Label TxtOgrBolum;
        private System.Windows.Forms.Label OgrDogum;
        private System.Windows.Forms.MaskedTextBox maskVeliTelefon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox maskOgrTelefon;
        private System.Windows.Forms.Label OgrTelefon;
        private System.Windows.Forms.MaskedTextBox MaskTC;
        private System.Windows.Forms.Label OgrTC;
        private System.Windows.Forms.TextBox TxtVeliAdSoyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox OgrMail;
        private System.Windows.Forms.Label TxtOgrMail;
        private System.Windows.Forms.TextBox TxtOgrSoyad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtOgrAd;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtOgrID;
        private System.Windows.Forms.Button BtnSil;
    }
}