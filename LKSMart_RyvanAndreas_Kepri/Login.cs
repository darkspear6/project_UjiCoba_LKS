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
    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection(Connect.connection);
        public Login()
        {
            InitializeComponent();
        }

        private void btlogin_Click(object sender, EventArgs e)
        {
            if (tbemail.Text == null || tbpin.Text == null)
            {
                MessageBox.Show("Silakan isi email atau nomor dan pin");
            } 
            else
            {
                string query = "SELECT * FROM Customer WHERE email = '"+tbemail.Text+"' OR phone_number = '"+tbemail.Text+"' AND pin_number ='"+tbpin.Text+"' ";
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                Connect.email = tbemail.Text;
                Connect.pin = tbpin.Text;
                Connect.nama = dt.Rows[0]["name"].ToString();
                MainForm MF = new MainForm();
                MF.Show();
                this.Hide();
                
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
