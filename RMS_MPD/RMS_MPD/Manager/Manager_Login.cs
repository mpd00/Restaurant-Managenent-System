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

namespace RMS_MPD.Manager
{
    public partial class Manager_Login : Form
    {
        public Manager_Login()
        {
            InitializeComponent();
            this.BringToFront();
            label_Error.Hide();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (!utility.usernamecheck(textBox1.Text))
            {
                label_Error.Show();
                label_Error.Text = "User Name was entered in a wrong format";
            }
            else if (textBox2.Text != "000")
            {
                label_Error.Show();
                label_Error.Text = "Entered password is incorrect please Retry";
            }
            else
            {
                UpdateDB(textBox1.Text);
                utility.ManagerUser = textBox1.Text;
                utility.ManagerPass = textBox2.Text;
                this.Hide();
                Form f1 = new Manager.Manager_Dashboard_Main();
                f1.ShowDialog();
            }

        }

        public static bool Exists_in_DB;
        public int NumberofLogins(string Username)
        {
            int NumberofLogin = 0;
            ///////////////////////Get number of logins
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\ManagersInfo.mdf;Integrated Security=True");
            string sql = "select * from ManagerInfo";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (dr["Username"].ToString() == Username)
                {
                    NumberofLogin = int.Parse(dr["LoginNumber"].ToString());
                    Exists_in_DB = true;
                }
            }
            ///////////////////////
            return NumberofLogin;
        }
        public void UpdateDB(string Username)
        {
            ///////////////////////Update number of login in database

                int NumberofLogin = NumberofLogins(Username);
                NumberofLogin++;
                var connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\ManagersInfo.mdf;Integrated Security=True";
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    using (SqlCommand command = connection.CreateCommand())
                    {

                        command.CommandText = "UPDATE ManagerInfo SET LoginNumber = @LoginNumber Where Username = @Username ";

                        command.Parameters.AddWithValue("@LoginNumber", NumberofLogin);
                        command.Parameters.AddWithValue("@Username", Username);

                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                }
                catch
                { }
            //////////////////////
        }
        public string GeneratePassword(string Username)
        {
            string Password = string.Empty;
            int NumberofLogin = NumberofLogins(Username);

            //////////////////////if doesnt exist create;
            if (!Exists_in_DB)
            {
                SqlConnection con2 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\ManagersInfo.mdf;Integrated Security=True");
                SqlCommand cmd2 = new SqlCommand("insert into ManagerInfo (Username,Password,LoginNumber) values (@Username,@Password,@LoginNumber)", con2);
                cmd2.Parameters.AddWithValue("@Username", Username);
                cmd2.Parameters.AddWithValue("@Password", "");
                cmd2.Parameters.AddWithValue("@LoginNumber", 0);

                con2.Open();
                cmd2.ExecuteNonQuery();
                con2.Close();
            }
            ///////////////////////Set Password
            for (int i = 0; i < NumberofLogin % 10; i++)
            {
                Password += '1';
            }
            foreach (char c in Username)
            {
                if(c == 'a' || c == 'A' || c == 'e' || c == 'E' || c == 'i' || c == 'I' || c == 'o' || c == 'O' || c == 'u' || c == 'U')
                {
                    Password += '0';
                }
            }
            return Password;

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
