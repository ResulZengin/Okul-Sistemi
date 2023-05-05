using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proje1
{
    public partial class FrmSınavNotlar : Form
    {
        public FrmSınavNotlar()
        {
            InitializeComponent();
        }
      
        DataSet1TableAdapters.TBLNOTLARTableAdapter ds = new DataSet1TableAdapters.TBLNOTLARTableAdapter();
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-VJO627U\SQLEXPRESS;Initial Catalog=BonusOkul;Integrated Security=True");
        private void BtnAra_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.NotlİSTESİ(int.Parse(TxtID.Text));
        }

        private void FrmSınavNotlar_Load(object sender, EventArgs e)
        {
            
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From TBLDERS", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            CmbDers.DisplayMember = "DERSAD";
            CmbDers.ValueMember = "DERSID";
            CmbDers.DataSource = dt;
            baglanti.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        int notid;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            notid =int.Parse (dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            TxtID.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            TxtSınav1.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            TxtSınav2.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            TxtSınav3.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            TxtProje.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            TxtOrtalama.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            TxtDurum.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
        }
        int not1, not2, not3, proje;

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmOgretmen fr = new FrmOgretmen();
            fr.Show();
        }

        double ort;
        private void BtnHesapla_Click(object sender, EventArgs e)
        {
            
            not1 =Convert.ToInt16 (TxtSınav1.Text);
            not2 = Convert.ToInt16(TxtSınav2.Text);
            not3 = Convert.ToInt16(TxtSınav3.Text);
            proje=Convert.ToInt16(TxtProje.Text);
            ort=(not1+not2+not3+proje)/4;
            TxtOrtalama.Text = ort.ToString();
            if (ort>=50)
            {
                TxtDurum.Text = "True";
            }
            else
            {
                TxtDurum.Text= "False";
            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            ds.NotGuncelle(byte.Parse(CmbDers.SelectedValue.ToString()),int.Parse(TxtID.Text),byte.Parse(TxtSınav1.Text), byte.Parse(TxtSınav2.Text), byte.Parse(TxtSınav3.Text), byte.Parse(TxtProje.Text),decimal.Parse(TxtOrtalama.Text),bool.Parse(TxtDurum.Text),notid);
        }
    }
}
