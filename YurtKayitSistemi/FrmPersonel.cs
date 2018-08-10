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
    public partial class FrmPersonel : Form
    {
        public FrmPersonel()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();
        private void FrmPersonel_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtKayitDataSet9.Personel' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.personelTableAdapter.Fill(this.yurtKayitDataSet9.Personel);

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Personel (PersonelAdSoyad,PersonelDepartman) values (@p1,@p2)",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtPersonelAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtPersonelDepartman.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show(TxtPersonelAd.Text + " isimli personel " + TxtPersonelDepartman.Text + " olarak eklendi"); 
            this.personelTableAdapter.Fill(this.yurtKayitDataSet9.Personel);
            TxtPersonelID.Clear();
            TxtPersonelAd.Clear();
            TxtPersonelDepartman.Clear();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from Personel where PersonelID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtPersonelID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show(TxtPersonelAd.Text + " isimli personel silindi" );
            this.personelTableAdapter.Fill(this.yurtKayitDataSet9.Personel);
            TxtPersonelID.Clear();
            TxtPersonelAd.Clear();
            TxtPersonelDepartman.Clear();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            string ID, Ad, Departman;
            ID = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            Ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            Departman = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            TxtPersonelID.Text = ID;
            TxtPersonelAd.Text = Ad;
            TxtPersonelDepartman.Text = Departman;

        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Personel set PersonelAdSoyad=@p1, PersonelDepartman=@p2 where PersonelID=@p3", bgl.baglanti());
            komut.Parameters.AddWithValue("@p3", TxtPersonelID.Text);
            komut.Parameters.AddWithValue("@p1", TxtPersonelAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtPersonelDepartman.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show(TxtPersonelAd.Text + " isimli personel güncellendi");
            this.personelTableAdapter.Fill(this.yurtKayitDataSet9.Personel);
            TxtPersonelID.Clear();
            TxtPersonelAd.Clear();
            TxtPersonelDepartman.Clear();

        }
    }
}
