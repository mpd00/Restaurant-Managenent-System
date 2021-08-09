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
using System.Diagnostics;

namespace RMS_MPD.Customer
{
    public partial class Customer_Login : Form
    {
        public Customer_Login()
        {
            InitializeComponent();
            this.BringToFront();
        }
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\CustomersInfo.mdf;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From CustomersInfo Where Email='" + textBox1.Text +
                "' and Password= '" + textBox2.Text + "'", con);
            DataTable dt = new DataTable();
            utility.currentemail = textBox1.Text;
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                MessageBox.Show("Login Successful!");
                this.Hide();
                Form f1 = new Customer.Customer_Dashboard_Main();
                f1.ShowDialog();

            }
            else
            {
                label_Error.Show();
                label_Error.Text = "This account doesn't exist";
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form f1 = new Customer.Customer_Signup();
            f1.ShowDialog();
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f2 = new MenuMain();
            f2.ShowDialog();
        }

        private void Customer_Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (var process in Process.GetProcessesByName("RMS_MPD"))
            {
                process.Kill();
            }
            foreach (var process in Process.GetProcessesByName("Customer_Signup"))
            {
                process.Kill();
            }
        }
    }
}
