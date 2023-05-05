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
    public partial class FrmOgretmen : Form
    {
        public FrmOgretmen()
        {
            InitializeComponent();
        }

        private void BtnKulupıslemler_Click(object sender, EventArgs e)
        {
            FrmKulupIslemlerı fr =new FrmKulupIslemlerı();
            fr.Show();
        }

        private void BtnDersıslemler_Click(object sender, EventArgs e)
        {
            FrmDersler fr = new FrmDersler();
            fr.Show();
            this.Hide();
        }

        private void BtnOgrencııslemelerı_Click(object sender, EventArgs e)
        {
            FrmOgrenci fr=new FrmOgrenci();
            fr.Show();
            this.Hide();
        }

        private void BtnSınacNotları_Click(object sender, EventArgs e)
        {
            FrmSınavNotlar frm = new FrmSınavNotlar();
            frm.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
