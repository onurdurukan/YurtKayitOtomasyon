using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YurtKayitSistemi
{
    public partial class FrmGiderListesi : Form
    {
        public FrmGiderListesi()
        {
            InitializeComponent();
        }

        private void FrmGiderListesi_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtKayitDataSet7.Giderler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.giderlerTableAdapter.Fill(this.yurtKayitDataSet7.Giderler);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            FrmGiderGüncelle guncelle = new FrmGiderGüncelle();
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            guncelle.ID = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            guncelle.elektrik = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            guncelle.su = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            guncelle.dogalgaz = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            guncelle.internet = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            guncelle.gida = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            guncelle.personel = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            guncelle.diger = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            guncelle.Show();
            

        }
    }
}
