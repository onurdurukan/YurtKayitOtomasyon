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
    public partial class FrmOdemeler : Form
    {
        public FrmOdemeler()
        {
            InitializeComponent();
        }

        private void FrmOdemeler_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtKayitDataSet5.Borclar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.borclarTableAdapter1.Fill(this.yurtKayitDataSet5.Borclar);
            // TODO: Bu kod satırı 'yurtKayitDataSet4.Borclar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.borclarTableAdapter.Fill(this.yurtKayitDataSet4.Borclar);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            string adi, soyadi, kalan, id;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            adi = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            soyadi = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            kalan = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            TxtAdi.Text = adi;
            TxtSoyadi.Text = soyadi;
            TxtOgrID.Text = id;
            TxtKalan.Text = kalan;

        }
        SqlBaglantim bgl = new SqlBaglantim();
        private void BtnOdemeAl_Click(object sender, EventArgs e)
        {
            int odenen, kalan,borc;
            odenen = Convert.ToInt16(TxtOdenen.Text);
            kalan=Convert.ToInt16(TxtKalan.Text);
            borc = kalan - odenen;
            TxtKalan.Text = borc.ToString();

            //Veri tabanı güncelleme
            SqlCommand komut = new SqlCommand("update Borclar set OgrKalanBorc=@p1 where OgrID=@p2",bgl.baglanti());
            komut.Parameters.AddWithValue("@p2", TxtOgrID.Text);
            komut.Parameters.AddWithValue("@p1", TxtKalan.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show(TxtAdi.Text+" "+TxtSoyadi.Text+" "+ "isimli öğrencinin "+TxtOdenen.Text + " TL borcu tahsil edildi");
            this.borclarTableAdapter1.Fill(this.yurtKayitDataSet5.Borclar);

            //Kasa Tablosuna ödeme ekleme

            SqlCommand komut2 = new SqlCommand("insert into Kasa (OdemeAy,OdemeMiktar) values (@k1,@k2)",bgl.baglanti());
            komut2.Parameters.AddWithValue("@k1", TxtOdenenAy.Text);
            komut2.Parameters.AddWithValue("@k2", TxtOdenen.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            
        }
    }
}
