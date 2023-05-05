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

namespace Proje1
{
    public partial class FrmOgrenci : Form
    {
        public FrmOgrenci()
        {
            InitializeComponent();
        }
         SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-VJO627U\SQLEXPRESS;Initial Catalog=BonusOkul;Integrated Security=True");
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmOgretmen fr=new FrmOgretmen();
            fr.Show();
            
        }
        DataSet1TableAdapters.DataTable1TableAdapter ds =new DataSet1TableAdapters.DataTable1TableAdapter();
        private void FrmOgrenci_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.OgrenciListesi();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From TBLKULUPLER",baglanti);
            SqlDataAdapter da= new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox1.DisplayMember = "KULUPAD";
            comboBox1.ValueMember = "KULUPID";
            comboBox1.DataSource = dt;
            baglanti.Close();
        }
        string c="";
        private void BtnEkle_Click(object sender, EventArgs e)
        {
            
           
            ds.OgrenciEkle(TxtAd.Text,TxtSoyad.Text,byte.Parse(comboBox1.SelectedValue.ToString()),c);
            MessageBox.Show("Öğrenci Ekleme Yapıldı");

        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.OgrenciListesi();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           // TxtID.Text = comboBox1.SelectedValue.ToString();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            ds.Ogrencisil(int.Parse(TxtID.Text));
                
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            TxtAd.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            TxtSoyad.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            if (dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString()=="Kız")
            {
                radioButton2.Checked = true;
            }
            if (dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString()=="Erkek")
            {
                radioButton1.Checked = true;
            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            ds.OgrenciGuncelle(TxtAd.Text,TxtSoyad.Text,byte.Parse(comboBox1.SelectedValue.ToString()),c,int.Parse(TxtID.Text));
            MessageBox.Show("Öğrenci Bilgisi Güncellendi");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                c = "Kız";
            }
          
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           
            if (radioButton1.Checked == true)
            {
                c = "Erkek";
            }
        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
           dataGridView1.DataSource= ds.OgrenciGetir(TxtAra.Text);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
