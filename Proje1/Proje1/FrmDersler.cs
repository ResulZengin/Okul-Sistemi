using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje1
{
    public partial class FrmDersler : Form
    {
        public FrmDersler()
        {
            InitializeComponent();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmOgretmen fr=new FrmOgretmen();
            fr.Show();
        }
        DataSet1TableAdapters.TBLDERSTableAdapter ds = new DataSet1TableAdapters.TBLDERSTableAdapter();
        private void FrmDersler_Load(object sender, EventArgs e)
        {
           
            dataGridView1.DataSource = ds.DersListesi();
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
         dataGridView1.DataSource = ds.DersListesi();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            ds.DersEkle(TxtDersAd.Text);
            MessageBox.Show("Ders Ekleme İşlemi Yapılmıştır");
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmOgretmen fr= new FrmOgretmen();
            fr.Show();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            ds.DersSil(byte.Parse (TxtDersID.Text));
            MessageBox.Show("Ders Silme İşlemini Gerçekleştirdiniz");
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            ds.DersGuncelle(TxtDersAd.Text,byte.Parse(TxtDersID.Text));
            MessageBox.Show("Ders Güncelleme İşlemi Gerşçekleşmiştir");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtDersID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            TxtDersAd.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
    }
}
