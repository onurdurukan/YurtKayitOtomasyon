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
    public partial class FrmGider : Form
    {
        public FrmGider()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();

        private void FrmGider_Load(object sender, EventArgs e)
        {

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("insert into Giderler (Elektrik, Su, Dogalgaz, internet, Gıda, Personel, Diger) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", TxtElektrik.Text);
                komut.Parameters.AddWithValue("@p2", TxtSu.Text);
                komut.Parameters.AddWithValue("@p3", TxtDogalGaz.Text);
                komut.Parameters.AddWithValue("@p4", TxtInternet.Text);
                komut.Parameters.AddWithValue("@p5", TxtGida.Text);
                komut.Parameters.AddWithValue("@p6", TxtPersonel.Text);
                komut.Parameters.AddWithValue("@p7", TxtDiger.Text);
                if (String.IsNullOrEmpty(TxtElektrik.Text) && String.IsNullOrEmpty(TxtSu.Text) && String.IsNullOrEmpty(TxtDogalGaz.Text) && String.IsNullOrEmpty(TxtInternet.Text) && String.IsNullOrEmpty(TxtGida.Text) && String.IsNullOrEmpty(TxtPersonel.Text) && String.IsNullOrEmpty(TxtDiger.Text))
                {
                    MessageBox.Show("Boş Alan Bırakmayınız");
                }
                else
                {
                    komut.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    MessageBox.Show("Kaydetme İşlemi Başarılı!");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("HATA!!");
            }
            
            //29 Ders Devam et
        }
    }
}
