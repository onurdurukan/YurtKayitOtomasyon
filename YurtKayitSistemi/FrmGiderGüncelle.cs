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
    public partial class FrmGiderGüncelle : Form
    {
        public FrmGiderGüncelle()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();
        public string ID, elektrik, dogalgaz, su, internet, gida, diger, personel;

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("update Giderler set Elektrik=@p1, Su=@p2, Dogalgaz=@p3, internet=@p4, Gıda=@p5, Personel=@p6, Diger=@p7 where OdemeID=@p8", bgl.baglanti());
                komut.Parameters.AddWithValue("@p8", TxtGiderID.Text);
                komut.Parameters.AddWithValue("@p1", TxtElektrik.Text);
                komut.Parameters.AddWithValue("@p2", TxtSu.Text);
                komut.Parameters.AddWithValue("@p3", TxtDogalGaz.Text);
                komut.Parameters.AddWithValue("@p4", TxtInternet.Text);
                komut.Parameters.AddWithValue("@p5", TxtGida.Text);
                komut.Parameters.AddWithValue("@p6", TxtPersonel.Text);
                komut.Parameters.AddWithValue("@p7", TxtDiger.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Kaydetme İşlemi Başarılı!");
            }
            catch (Exception)
            {

                MessageBox.Show("HATA!!!");
            }
            }

        private void FrmGiderGüncelle_Load(object sender, EventArgs e)
        {
            TxtGiderID.Text = ID;
            TxtElektrik.Text = elektrik;
            TxtDogalGaz.Text = dogalgaz;
            TxtSu.Text = su;
            TxtInternet.Text = internet;
            TxtGida.Text = gida;
            TxtDiger.Text = diger;
            TxtPersonel.Text = personel;
                
        }
    }
}
