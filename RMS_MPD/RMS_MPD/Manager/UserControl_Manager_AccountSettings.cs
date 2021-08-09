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

namespace RMS_MPD.Manager
{
    public partial class UserControl_Manager_AccountSettings : UserControl
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
        public UserControl_Manager_AccountSettings()
        {
            InitializeComponent();
            textBox_Username.Text = utility.ManagerUser;
            textBox_Password.Text = utility.ManagerPass;
            LoginNumber();
            RestaurantInfo();
        }

        public int RestaurantCounter()
        {
            int counter = 0;
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\ManagersInfo.mdf;Integrated Security=True");
            string sql = "select * from RestaurantInfo";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                counter++;
            }
            ///////////////////////
            return counter;
        }
        public void RestaurantInfo()
        {
            if (RestaurantCounter() != 0)
            {
                SqlConnection con2 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\ManagersInfo.mdf;Integrated Security=True");
                string sql2 = "select * from RestaurantInfo";
                con2.Open();
                SqlCommand cmd2 = new SqlCommand(sql2, con2);
                SqlDataReader dr2 = cmd2.ExecuteReader();
                while (dr2.Read())
                {
                    fullnameTextBox.Text = dr2["RestaurantName"].ToString();
                    socialIDTextBox.Text = dr2["RestaurantAddress"].ToString();
                    emailTextBox.Text = dr2["RestaurantDistrict"].ToString();
                    phoneNumberTextBox.Text = dr2["RestaurantType"].ToString();
                    passwordTextBox.Text = dr2["ManagerName"].ToString();
                }
            }
            else
            {
                label_Error.Visible = true;
            }
        }
        public void LoginNumber()
        {
            string Username = utility.ManagerUser;
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
                }
            }
            ///////////////////////
            //NumberofLogin++;
            textBox_LoginNumber.Text = NumberofLogin.ToString();
        }

        private void Button_editinfo_Click(object sender, EventArgs e)
        {
            label_Error.Visible = false;
            if (RestaurantCounter() == 0)   //Create one
            {
                SqlConnection con2 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\ManagersInfo.mdf;Integrated Security=True");
                SqlCommand cmd2 = new SqlCommand("insert into RestaurantInfo (RestaurantName,RestaurantAddress,RestaurantDistrict,RestaurantType,ManagerName)" +
                    " values (@RestaurantName,@RestaurantAddress,@RestaurantDistrict,@RestaurantType,@ManagerName)", con2);

                cmd2.Parameters.AddWithValue("@RestaurantName", fullnameTextBox.Text);
                cmd2.Parameters.AddWithValue("@RestaurantAddress", socialIDTextBox.Text);
                cmd2.Parameters.AddWithValue("@RestaurantDistrict", emailTextBox.Text);
                cmd2.Parameters.AddWithValue("@RestaurantType", phoneNumberTextBox.Text);
                cmd2.Parameters.AddWithValue("@ManagerName", passwordTextBox.Text);

                con2.Open();
                cmd2.ExecuteNonQuery();
                con2.Close();
            }
            else   //Update existing
            {
                var connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\ManagersInfo.mdf;Integrated Security=True";
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    using (SqlCommand command = connection.CreateCommand())
                    {

                        command.CommandText = "UPDATE RestaurantInfo SET RestaurantName = @RestaurantName , RestaurantAddress = @RestaurantAddress ," +
                            "RestaurantDistrict = @RestaurantDistrict , RestaurantType = @RestaurantType , ManagerName = @ManagerName ";

                        command.Parameters.AddWithValue("@RestaurantName", fullnameTextBox.Text);
                        command.Parameters.AddWithValue("@RestaurantAddress", socialIDTextBox.Text);
                        command.Parameters.AddWithValue("@RestaurantDistrict", emailTextBox.Text);
                        command.Parameters.AddWithValue("@RestaurantType", phoneNumberTextBox.Text);
                        command.Parameters.AddWithValue("@ManagerName", passwordTextBox.Text);


                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                }
                catch
                { }
            }
            MessageBox.Show("Restaurant information added successfully");
        }
    }
}
