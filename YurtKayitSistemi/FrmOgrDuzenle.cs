using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace YurtKayitSistemi
{
    public partial class FrmOgrDuzenle : Form
    {
        public FrmOgrDuzenle()
        {
            InitializeComponent();
        }
        public string id, adi,soyadi,TC,telefon,dogum,bolum,email,odaNo,veliAd,VeliTel,VeliAdres;
        private void FrmOgrDuzenle_Load(object sender, EventArgs e)
        {
            TxtOgrID.Text = id;
            TxtOgrAd.Text = adi;
            TxtOgrSoyad.Text = soyadi;
            maskOgrDogum.Text = dogum;
            maskOgrTelefon.Text = telefon;
            MaskTC.Text = TC;
            OgrBolum.Text = bolum;
            OgrOdaNo.Text = odaNo;
            OgrMail.Text = email;
            TxtVeliAdSoyad.Text = veliAd;
            maskVeliTelefon.Text = VeliTel;
            RichAdres.Text = VeliAdres;



        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        SqlBaglantim bgl = new SqlBaglantim();
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("update Ogrenci set OgrAd=@p2, OgrSoyad=@p3, OgrTC=@p4, OgrTelefon=@p5, OgrDogum=@p6, OgrBolum=@p7, OgrMail=@p8, OgrOdaNo=@p9, OgrVeliAdSoyad=@p10, OgrVeliTelefon=@p11,OgrVeliAdres=@p12 where OgrID=@p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", TxtOgrID.Text);
                komut.Parameters.AddWithValue("@p2", TxtOgrAd.Text);
                komut.Parameters.AddWithValue("@p3", TxtOgrSoyad.Text);
                komut.Parameters.AddWithValue("@p4", MaskTC.Text);
                komut.Parameters.AddWithValue("@p5", maskOgrTelefon.Text);
                komut.Parameters.AddWithValue("@p6", maskOgrDogum.Text);
                komut.Parameters.AddWithValue("@p7", OgrBolum.Text);
                komut.Parameters.AddWithValue("@p8", OgrMail.Text);
                komut.Parameters.AddWithValue("@p9", OgrOdaNo.Text);
                komut.Parameters.AddWithValue("@p10", TxtVeliAdSoyad.Text);
                komut.Parameters.AddWithValue("@p11", maskVeliTelefon.Text);
                komut.Parameters.AddWithValue("@p12", RichAdres.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show(TxtOgrID.Text + " numaralı öğrencinin bilgileri güncellendi");
                Close();
            }
            catch (Exception)
            {

                MessageBox.Show("HATA!!");
                Close();
            }
           
        }

        private void RichAdres_TextChanged(object sender, EventArgs e)
        {

        }

        private void OgrOdaNo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void OgrBolum_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void maskOgrDogum_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void TxtOgrBolum_Click(object sender, EventArgs e)
        {

        }

        private void OgrDogum_Click(object sender, EventArgs e)
        {

        }

        private void maskVeliTelefon_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void maskOgrTelefon_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komutSil = new SqlCommand("delete from Ogrenci where OgrID=@k1",bgl.baglanti());
            komutSil.Parameters.AddWithValue("@k1", TxtOgrID.Text);
            komutSil.ExecuteNonQuery();
            bgl.baglanti().Close();
            TxtOgrID.Clear();
            TxtOgrAd.Clear();
            TxtOgrSoyad.Clear();
            MaskTC.Clear();
            maskOgrTelefon.Clear();
            maskOgrDogum.Clear();
            OgrBolum.ResetText();
            OgrMail.Clear();
            OgrOdaNo.ResetText();
            TxtVeliAdSoyad.Clear();
            maskVeliTelefon.Clear();
            RichAdres.Clear();
            MessageBox.Show("Kayıt silindi");



            SqlCommand komutOda = new SqlCommand("update Odalar set OdaAktif=OdaAktif-1 where OdaNo=@oda1", bgl.baglanti());
            komutOda.Parameters.AddWithValue("@oda1", OgrOdaNo.Text);
            komutOda.ExecuteNonQuery();
            bgl.baglanti().Close();

        }

        private void OgrTelefon_Click(object sender, EventArgs e)
        {

        }

        private void MaskTC_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void OgrTC_Click(object sender, EventArgs e)
        {

        }

        private void TxtVeliAdSoyad_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void OgrMail_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtOgrMail_Click(object sender, EventArgs e)
        {

        }

        private void TxtOgrSoyad_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void TxtOgrAd_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label_Click(object sender, EventArgs e)
        {

        }
    }
}
