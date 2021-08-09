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
    public partial class Customer_Signup : Form
    {
        public Customer_Signup()
        {
            InitializeComponent();
        }

        private void customersInfoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersInfoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.customersInfoDataSet);
        }

        private void Customer_Signup_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'customersInfoDataSet.CustomersInfo' table. You can move, or remove it, as needed.
            this.customersInfoTableAdapter.Fill(this.customersInfoDataSet.CustomersInfo);

        }

        private void button_Signup_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection("Data Source=NiluNilesh;Integrated Security=True");  
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\CustomersInfo.mdf;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("sp_insert", con);
            if (fullnameTextBox.Text == string.Empty || socialIDTextBox.Text == string.Empty || emailTextBox.Text == string.Empty
                || phoneNumberTextBox.Text == string.Empty || passwordTextBox.Text == string.Empty || confirmpasswordTextBox.Text == string.Empty)
            {
                label_Error.Show();
                label_Error.Text = "All fields should be filled.";
            }
            else if (!utility.Is_ID_Ok(socialIDTextBox.Text))
            {
                label_Error.Show();
                label_Error.Text = "Social ID was entered in a wrong format";
            }
            else if (!utility.emailcheck(emailTextBox.Text))
            {
                label_Error.Show();
                label_Error.Text = "Email was entered in a wrong format";
            }
            else if (!utility.phonecheck(phoneNumberTextBox.Text))
            {
                label_Error.Show();
                label_Error.Text = "Phone Number was entered in a wrong format";
            }
            else if (passwordTextBox.Text != confirmpasswordTextBox.Text)
            {
                label_Error.Show();
                label_Error.Text = "Passwords don't match!";
            }
            else
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Fullname", fullnameTextBox.Text);
                cmd.Parameters.AddWithValue("@SocialID", socialIDTextBox.Text);
                cmd.Parameters.AddWithValue("@Email", emailTextBox.Text);
                cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumberTextBox.Text);
                cmd.Parameters.AddWithValue("@Password", passwordTextBox.Text);
                con.Open();
                int i = cmd.ExecuteNonQuery();
                con.Close();
                if (i != 0)
                {
                    MessageBox.Show("Account created successfully.");
                }
                //this.customersInfoTableAdapter.Fill(this.CustomersInfoDataSet.CustomersInfo);
                this.Hide();
                Form f1 = new Customer.Customer_Login();
                f1.BringToFront();
                f1.ShowDialog();
           }

        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f2 = new Customer.Customer_Login();
            f2.ShowDialog();
            f2.BringToFront();
        }

        private void Customer_Signup_FormClosing(object sender, FormClosingEventArgs e)
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
