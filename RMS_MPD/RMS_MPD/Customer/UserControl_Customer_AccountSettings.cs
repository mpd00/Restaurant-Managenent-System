using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RMS_MPD.Customer
{
    public partial class UserControl_Customer_AccountSettings : UserControl
    {
        #region Movement
        public void MoveRight()
        {
            foreach (Control control in this.Controls)
            {
                int tempx = control.Location.X;
                int tempy = control.Location.Y;
                control.Location = new Point(tempx + 160, tempy);
            }
        }
        public void MoveLeft()
        {
            foreach (Control control in this.Controls)
            {
                int tempx = control.Location.X;
                int tempy = control.Location.Y;
                control.Location = new Point(tempx - 160, tempy);
            }
        }
        #endregion

        public UserControl_Customer_AccountSettings()
        {
            InitializeComponent();
        }

        private void button_editinfo_Click(object sender, EventArgs e)
        {

            string Fullname = fullnameTextBox.Text;
            string SocialID = socialIDTextBox.Text;
            string Email = emailTextBox.Text;
            string PhoneNumber = phoneNumberTextBox.Text;
            string Password = passwordTextBox.Text;

            var connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\CustomersInfo.mdf;Integrated Security=True";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = connection.CreateCommand())
                {

                    command.CommandText = "UPDATE CustomersInfo SET Fullname = @Fullname, SocialID = @SocialID , Email = @Email" +
                        ", PhoneNumber = @PhoneNumber , Password = @Password Where Fullname = @Fullname ";

                    command.Parameters.AddWithValue("@Fullname", Fullname);
                    command.Parameters.AddWithValue("@SocialID", SocialID);
                    command.Parameters.AddWithValue("@Email", Email);
                    command.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
                    command.Parameters.AddWithValue("@Password", Password);

                    connection.Open();

                    command.ExecuteNonQuery();

                    connection.Close();
                }
                MessageBox.Show("Information updated successfully.");
            }
            catch
            {
                MessageBox.Show("An error occured please retry");
            }
        }

        private void UserControl_Customer_AccountSettings_Load(object sender, EventArgs e)
        {
            List<Customer> listid = new List<Customer>();
            string currentuser = utility.currentemail;
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\CustomersInfo.mdf;Integrated Security=True");
            string sql = "select * from CustomersInfo";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Customer custo = new Customer();
                custo.Fullname = dr["Fullname"].ToString();
                custo.SocialID = dr["SocialID"].ToString();
                custo.Email = dr["Email"].ToString();
                custo.PhoneNumber = dr["PhoneNumber"].ToString();
                custo.Password = dr["Password"].ToString();

                listid.Add(custo);
            }

            for (int i = 0; i < listid.Count; i++)
            {
                if (listid[i].Email == currentuser)
                {
                    this.fullnameTextBox.Text = listid[i].Fullname.ToString();
                    this.socialIDTextBox.Text = listid[i].SocialID.ToString();
                    this.emailTextBox.Text = listid[i].Email.ToString();
                    this.phoneNumberTextBox.Text = listid[i].PhoneNumber.ToString();
                    this.passwordTextBox.Text = listid[i].Password.ToString();
                }
            }
        }
        public class Customer
        {
            private string fullname;
            public string Fullname
            {
                get { return fullname; }
                set { fullname = value; }
            }
            private string socialID;
            public string SocialID
            {
                get { return socialID; }
                set { socialID = value; }
            }
            private string email;
            public string Email
            {
                get { return email; }
                set { email = value; }
            }
            private string phoneNumber;
            public string PhoneNumber
            {
                get { return phoneNumber; }
                set { phoneNumber = value; }
            }
            private string password;
            public string Password
            {
                get { return password; }
                set { password = value; }
            }
        }
        }
}
