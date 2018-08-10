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
    public partial class FrmOgrKayit : Form
    {
        public FrmOgrKayit()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();
        

        private void FrmOgrKayit_Load(object sender, EventArgs e)
        {
            //Bolumleri listeleme
            
            SqlCommand Bolumler = new SqlCommand("Select BolumAd From Bolumler", bgl.baglanti());
            SqlDataReader oku = Bolumler.ExecuteReader();
            while (oku.Read())
            {
                OgrBolum.Items.Add(oku[0].ToString());
            }
            bgl.baglanti().Close();


            //boş odaları listeleme
            
            SqlCommand Odalar = new SqlCommand("Select OdaNo From Odalar where OdaKapasite != OdaAktif", bgl.baglanti());
            SqlDataReader oku2 = Odalar.ExecuteReader();
            while (oku2.Read())
            {
                OgrOdaNo.Items.Add(oku2[0].ToString());
            }
            bgl.baglanti().Close();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                
                SqlCommand Kaydet = new SqlCommand("insert into Ogrenci (OgrAd,OgrSoyad,OgrTC,OgrTelefon,OgrDogum,OgrBolum,OgrMail,OgrOdaNo,OgrVeliAdSoyad,OgrVeliTelefon,OgrVeliAdres) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)", bgl.baglanti());
                Kaydet.Parameters.AddWithValue("@p1", TxtOgrAd.Text);
                Kaydet.Parameters.AddWithValue("@p2", TxtOgrSoyad.Text);
                Kaydet.Parameters.AddWithValue("@p3", MaskTC.Text);
                Kaydet.Parameters.AddWithValue("@p4", maskOgrTelefon.Text);
                Kaydet.Parameters.AddWithValue("@p5", maskOgrDogum.Text);
                Kaydet.Parameters.AddWithValue("@p6", OgrBolum.Text);
                Kaydet.Parameters.AddWithValue("@p7", OgrMail.Text);
                Kaydet.Parameters.AddWithValue("@p8", OgrOdaNo.Text);
                Kaydet.Parameters.AddWithValue("@p9", TxtVeliAdSoyad.Text);
                Kaydet.Parameters.AddWithValue("@p10", maskVeliTelefon.Text);
                Kaydet.Parameters.AddWithValue("@p11", RichAdres.Text);
                if (String.IsNullOrEmpty(TxtOgrAd.Text) && String.IsNullOrEmpty(TxtOgrSoyad.Text) && String.IsNullOrEmpty(MaskTC.Text) && String.IsNullOrEmpty(OgrBolum.Text) && String.IsNullOrEmpty(OgrMail.Text) && String.IsNullOrEmpty(OgrOdaNo.Text) && String.IsNullOrEmpty(TxtVeliAdSoyad.Text) && String.IsNullOrEmpty(RichAdres.Text)) { //Masked formlarda hata araştır
                    MessageBox.Show("Boş Alan Bırakmayınız");
                }
                else
                {
                    Kaydet.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    MessageBox.Show("İşlem Başarılı!");
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
                }
               
                

                //ÖğrID labele atama
                SqlCommand komut = new SqlCommand("select OgrID from Ogrenci", bgl.baglanti());
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    label6.Text = oku[0].ToString();
                }
                bgl.baglanti().Close();


                //Öğrenci Borç Alanı Oluşturma
                SqlCommand komutkaydet2 = new SqlCommand("insert into Borclar (OgrID,OgrAd,OgrSoyad) values (@b1,@b2,@b3)", bgl.baglanti());
                komutkaydet2.Parameters.AddWithValue("@b1", label6.Text);
                komutkaydet2.Parameters.AddWithValue("@b2", TxtOgrAd.Text);
                komutkaydet2.Parameters.AddWithValue("@b3", TxtOgrSoyad.Text);
                komutkaydet2.ExecuteNonQuery();
                bgl.baglanti().Close();
                

            }
            catch (Exception)
            {

                MessageBox.Show("ERROR!");
            }

            SqlCommand komutOda = new SqlCommand("update Odalar set OdaAktif=OdaAktif+1 where OdaNo=@oda1",bgl.baglanti());
            komutOda.Parameters.AddWithValue("@oda1", OgrOdaNo.Text);
            komutOda.ExecuteNonQuery();
            bgl.baglanti().Close();
            


            //FrmAnaForm fr = new FrmAnaForm();
            //fr.Refresh();




        }

    }
}
