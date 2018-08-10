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
    public partial class FrmAdminGiris : Form
    {
        public FrmAdminGiris()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();
        private void BtnGiris_Click(object sender, EventArgs e)
        {
          
                SqlCommand komut = new SqlCommand("select * from Admin where YoneticiAd=@p1 and YoneticiSifre=@p2", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", TxtYetkiliAdi.Text);
                komut.Parameters.AddWithValue("@p2", TxtYetkiliSifre.Text);
                komut.ExecuteNonQuery();
                SqlDataReader oku = komut.ExecuteReader();
                if (oku.Read())
                {
                    FrmAnaForm fr = new FrmAnaForm();
                    fr.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hata!!");
                TxtYetkiliAdi.Clear();
                TxtYetkiliSifre.Clear();
                TxtYetkiliAdi.Focus();
                }
                              
           
            bgl.baglanti().Close();

        }

        private void FrmAdminGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
