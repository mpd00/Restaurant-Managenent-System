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
using System.IO;

namespace RMS_MPD.Customer
{
    public partial class UserControl_Customer_Home : UserControl
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

        public UserControl_Customer_Home()
        {
            InitializeComponent();
            RefreshData();
            try
            {
                axAcroPDF1.src = $@"{Path.GetDirectoryName(Application.ExecutablePath)}\Guide.pdf";
            }
            catch { }
        }
        public void RefreshData()
        {
            /////////////////////////to find the name
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
                    label_name.Text = listid[i].Fullname;
                }
            }
            ////////////////////////////////////////
            /////////////////////////
            OrderHistory.FillList();
            List<string> OrderIDS = new List<string>();
            foreach (OrderHistory order in OrderHistory.OrderHistoryList)
            {
                if (order.SocialID == utility.currentSocialID)
                {
                    OrderIDS.Add(order.OrderID);
                }
            }
            textBox_LoginNumber.Text = OrderIDS.Count.ToString();
            ///////////////////////
        }

        private void Label4_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(label4.Text);
            MessageBox.Show("Discount Code copied to clipboard paste it in the discount section and apply!");
        }

        private void Label5_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(label5.Text);
            MessageBox.Show("Discount Code copied to clipboard paste it in the discount section and apply!");
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
