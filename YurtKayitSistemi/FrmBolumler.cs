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
    public partial class FrmBolumler : Form
    {
        public FrmBolumler()
        {
            InitializeComponent();
        }

        SqlBaglantim bgl = new SqlBaglantim();
        private void FrmBolumler_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtKayitDataSet1.Bolumler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.bolumlerTableAdapter.Fill(this.yurtKayitDataSet1.Bolumler);

        }
        int secilen;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string ID, BolumAd;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            ID = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            BolumAd= dataGridView1.Rows[secilen].Cells[1].Value.ToString();

            TxtBolumID.Text = ID;
            TxtBolumAd.Text = BolumAd;
        }

        private void PcbBolumEkle_Click(object sender, EventArgs e)
        {
            try
            {
                
                SqlCommand komut1 = new SqlCommand("insert into Bolumler (BolumAd) values (@p1)", bgl.baglanti());
                komut1.Parameters.AddWithValue("@p1", TxtBolumAd.Text);
                komut1.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Bölüm Eklendi");
                this.bolumlerTableAdapter.Fill(this.yurtKayitDataSet1.Bolumler);

            }
            catch (Exception)
            {

                MessageBox.Show("ERROR!");
            }
        }

        private void PcbBolumSil_Click(object sender, EventArgs e)
        {
            try
            {
                
                SqlCommand komut2 = new SqlCommand("delete from Bolumler where BolumID=@p1", bgl.baglanti());
                komut2.Parameters.AddWithValue("@p1", TxtBolumID.Text);
                komut2.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Bölüm Silindi");
                this.bolumlerTableAdapter.Fill(this.yurtKayitDataSet1.Bolumler);

            }
            catch (Exception)
            {

                MessageBox.Show("ERROR!");
            }
        }

        private void PcbBolumDuzelt_Click(object sender, EventArgs e)
        {
            try
            {
                
                SqlCommand komut3 = new SqlCommand("update Bolumler Set BolumAd=@p1 where BolumID=@p2", bgl.baglanti());
                komut3.Parameters.AddWithValue("@p2", TxtBolumID.Text);
                komut3.Parameters.AddWithValue("@p1", TxtBolumAd.Text);
                komut3.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Bölüm Güncellendi");
                this.bolumlerTableAdapter.Fill(this.yurtKayitDataSet1.Bolumler);

            }
            catch (Exception)
            {

                MessageBox.Show("ERROR!");
            }
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
