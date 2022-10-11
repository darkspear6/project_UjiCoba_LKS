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
    public partial class ProfilForm : Form
    {
        SqlConnection con = new SqlConnection(Connect.connection);
        public ProfilForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbnama.Enabled = true;
            string query = "UPDATE Customer SET name = '" + tbnama.Text + "' WHERE pin_number = '"+Connect.pin+"'";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void tbnama_TextChanged(object sender, EventArgs e)
        {
            tbnama.Text = "" + Connect.nama;
        }

        private void tbnama_Click(object sender, EventArgs e)
        {
            if (tbnama.Text == Connect.nama)
            {
                tbnama.Text = null;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Customer SET pin_number = '" + tbpin.Text + "' WHERE pin_number = '" + Connect.pin + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void btdate_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Customer SET date_of_birth = '" + tbdate.Text + "' WHERE pin_number = '" + Connect.pin + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void btaddr_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Customer SET address = '" + tbaddr.Text + "' WHERE pin_number = '" + Connect.pin + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void btgen_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Customer SET name = '" + comboBox1.Text + "' WHERE pin_number = '" + Connect.pin + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void btuploud_Click(object sender, EventArgs e)
        {

        }
    }
}
