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
    public partial class FrmSifreYonet : Form
    {
        public FrmSifreYonet()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();
        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void toolTip1_Popup_1(object sender, PopupEventArgs e)
        {

        }

        private void FrmSifreYonet_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtKayitDataSet8.Admin' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.adminTableAdapter.Fill(this.yurtKayitDataSet8.Admin);

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Admin (YoneticiAd, YoneticiSifre) values (@p1,@p2)",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtYoneticiAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtYoneticiSifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Yönetici " + TxtYoneticiAd.Text + " eklendi");
            this.adminTableAdapter.Fill(this.yurtKayitDataSet8.Admin);
            TxtYoneticiAd.Clear();
            TxtYoneticiSifre.Clear();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            string ID, ad, sifre;
            ID = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            sifre = dataGridView1.Rows[secilen].Cells[2].Value.ToString();

            TxtYoneticiID.Text = ID;
            TxtYoneticiAd.Text = ad;
            TxtYoneticiSifre.Text = sifre;
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from Admin where YoneticiID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtYoneticiID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Yönetici " + TxtYoneticiAd.Text + " silindi");
            this.adminTableAdapter.Fill(this.yurtKayitDataSet8.Admin);
            TxtYoneticiID.Clear();
            TxtYoneticiAd.Clear();
            TxtYoneticiSifre.Clear();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Admin set YoneticiAd=@p1, YoneticiSifre=@p2 where YoneticiID=@p3", bgl.baglanti());
            komut.Parameters.AddWithValue("@p3", TxtYoneticiID.Text);
            komut.Parameters.AddWithValue("@p1", TxtYoneticiAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtYoneticiSifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Yönetici " + TxtYoneticiAd.Text + " güncellendi");
            this.adminTableAdapter.Fill(this.yurtKayitDataSet8.Admin);
            TxtYoneticiID.Clear();
            TxtYoneticiAd.Clear();
            TxtYoneticiSifre.Clear();
        }
    }
}
