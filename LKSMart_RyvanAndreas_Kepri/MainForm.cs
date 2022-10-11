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

namespace LKSMart_RyvanAndreas_Kepri
{
    public partial class MainForm : Form
    {
        SqlConnection con = new SqlConnection(Connect.connection);
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ProfilForm pf = new ProfilForm();
            pf.Show();
            this.Hide();
        }

        private void btlogout_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "Welcome, " + Connect.nama;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToString();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ShopForm sf = new ShopForm();
            sf.Show();
            this.Hide();
        }
    }
}
