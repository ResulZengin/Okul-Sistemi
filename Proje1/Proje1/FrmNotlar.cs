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
    public partial class FrmNotlar : Form
    {
        public FrmNotlar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-VJO627U\SQLEXPRESS;Initial Catalog=BonusOkul;Integrated Security=True");
        public string numara;

        private void FrmNotlar_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select DERSAD,SINAV1,SINAV2,SINAV3,PROJE,ORTALAMA,DURUM From TBLNOTLAR INNER JOIN TBLDERS ON TBLNOTLAR.DERSID=TBLDERS.DERSID WHERE OGRID=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", numara);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            baglanti.Open();
            //Öğrencinin Adını Soyadını Forma Yazdırma
            SqlCommand komut2 = new SqlCommand("Select * From TBLOGRENCILER where OGRID=@p1",baglanti);
            komut2.Parameters.AddWithValue("@p1",numara);
            SqlDataReader dr = komut2.ExecuteReader();
            while (dr.Read())
            {
                this.Text = dr[1]+" " + dr[2].ToString();
            }
            baglanti.Close(); 

        }
    }
}
