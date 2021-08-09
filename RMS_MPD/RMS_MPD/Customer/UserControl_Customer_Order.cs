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
    public partial class UserControl_Customer_Order : UserControl
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
        public UserControl_Customer_Order()
        {
            InitializeComponent();
            Calendar_Order.Value = DateTime.Today;
            Calendar_Order.MinDate = DateTime.Now;
            Calendar_Order.MaxDate = DateTime.Now.AddDays(29);

            RefreshData();
        }

        string listview1_selected_name;
        private void myListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in myListView1.SelectedItems)
            {
                //MessageBox.Show("vv");
                FoodCalender.FillList();
                foreach (KeyValuePair<DateTime, List<Food>> entry in FoodCalender.datedict)
                {
                    if (entry.Key.ToString("yyyy-MM-dd") == Calendar_Order.Value.ToString("yyyy-MM-dd"))
                    {
                        foreach (Food f in entry.Value)
                        {
                            if (f.Name == item.Text.ToString())
                            {
                                listview1_selected_name = item.Text.ToString();
                                textBox_recieved_quantity.Text = f.Quantity;
                                textBox_category.Text = f.Category;
                                textBox_name.Text = f.Name;
                                textBox_recepie.Text = f.Ingridients;
                                textBox_price.Text = (Convert.ToDouble(f.Price) * 1.24).ToString();
                                pictureBox1.Image = Food.ConvertBinaryTOImage(f.Photo);
                            }
                        }
                    }
                }
            }
        }
        public void RefreshData()
        {
            
            FoodCalender.FillList();
            foreach (KeyValuePair<DateTime, List<Food>> entry in FoodCalender.datedict)
            {
                if (entry.Key.ToString("yyyy-MM-dd") == Calendar_Order.Value.ToString("yyyy-MM-dd"))
                {
                    Food.Fill_ListView(myListView1, entry.Value);
                }
            }
            textBox_category.Clear();
            textBox_name.Clear();
            textBox_price.Clear();
            textBox_quantity.Clear();
            textBox_recepie.Clear();
            textBox_recieved_quantity.Clear();
            pictureBox1.Image = null;
        }

        private void Calendar_Order_onValueChanged(object sender, EventArgs e)
        {
            FoodCalender.FillList();
            foreach (KeyValuePair<DateTime, List<Food>> entry in FoodCalender.datedict)
            {
                if (entry.Key.ToString("yyyy-MM-dd") == Calendar_Order.Value.ToString("yyyy-MM-dd"))
                {
                    Food.Fill_ListView(myListView1, entry.Value);

                }
            }
            textBox_recieved_quantity.Clear();
        }

        string socialid_temp;
        private void button_add_shoppinglist_Click(object sender, EventArgs e)
        {
            try
            {
                bool flag_used = false;
                ////////////////////Assining social id
                List<Customer2> listid = new List<Customer2>();
                string currentuser = utility.currentemail;
                SqlConnection con2 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\CustomersInfo.mdf;Integrated Security=True");
                string sql = "select * from CustomersInfo";
                con2.Open();
                SqlCommand cmd2 = new SqlCommand(sql, con2);
                SqlDataReader dr = cmd2.ExecuteReader();
                while (dr.Read())
                {
                    Customer2 custo = new Customer2();
                    custo.Fullname = dr["Fullname"].ToString();
                    custo.SocialID = dr["SocialID"].ToString();
                    custo.Email = dr["Email"].ToString();
                    custo.PhoneNumber = dr["PhoneNumber"].ToString();
                    custo.Password = dr["Password"].ToString();
                    listid.Add(custo);
                }
                con2.Close();
                for (int i = 0; i < listid.Count; i++)
                {
                    if (listid[i].Email == currentuser)
                    {
                        socialid_temp = listid[i].SocialID.ToString();
                    }
                }
                ////////////////////
                utility.currentSocialID = socialid_temp;
                ShoppingList.IntializeShoppingListDictionary();
                ShoppingList.FillList();
                foreach (KeyValuePair<DateTime, List<ShoppingList>> entry in ShoppingList.shoppinglistdict)
                {
                    if (Calendar_Order.Value.ToString("yyyy-MM-dd") == entry.Key.ToString("yyyy-MM-dd"))
                    {
                        foreach (ShoppingList shoppingList in entry.Value)
                        {
                            if (shoppingList.Name == textBox_name.Text && shoppingList.SocialID == socialid_temp)
                            {
                                flag_used = true;
                            }
                        }
                    }
                }

                if (flag_used)  //This means item has already been added on the current date
                {
                    MessageBox.Show("Item already exists on your Shopping List on the current date.\nTo edit it, go to your Shopping List");
                    textBox_category.Clear();
                    textBox_name.Clear();
                    textBox_price.Clear();
                    textBox_quantity.Clear();
                    textBox_recepie.Clear();
                    textBox_recieved_quantity.Clear();
                    pictureBox1.Image = null;
                }
                else    //This means its mew entry
                {
                    if (int.Parse(textBox_recieved_quantity.Text) < int.Parse(textBox_quantity.Text))   //When entered quantity is more than whats left
                    {
                        MessageBox.Show("The entered quantity is more tham whats left!");
                        textBox_quantity.Clear();
                    }
                    else if (int.Parse(textBox_recieved_quantity.Text) == int.Parse(textBox_quantity.Text))  //When its equal (Also delete the entry from calender)
                    {
                        SqlConnection con4 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\ShoppingListDB.mdf;Integrated Security=True");
                        SqlCommand cmd4 = new SqlCommand("insert into ShoppingListTable (SocialID,Date,OrderDate,Category,Name,Price,Quantity,Photo) values (@SocialID,@Date,@OrderDate,@Category,@Name,@Price,@Quantity,@Photo)", con4);
                        cmd4.Parameters.AddWithValue("@SocialID", socialid_temp);
                        cmd4.Parameters.AddWithValue("@Date", DateTime.Now.ToString());
                        cmd4.Parameters.AddWithValue("@OrderDate", Calendar_Order.Value.ToString("yyyy-MM-dd"));
                        cmd4.Parameters.AddWithValue("@Category", textBox_category.Text);
                        cmd4.Parameters.AddWithValue("@Name", textBox_name.Text);
                        cmd4.Parameters.AddWithValue("@Price", textBox_price.Text);
                        cmd4.Parameters.AddWithValue("@Quantity", textBox_quantity.Text);
                        cmd4.Parameters.AddWithValue("@Photo", Food.ConvertImageTOBinary(pictureBox1.Image));
                        con4.Open();
                        cmd4.ExecuteNonQuery();
                        con4.Close();

                        //////////////////////Delete from shoppinglist
                        var connectionString2 = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\FoodCalenderDB.mdf;Integrated Security=True";
                        try
                        {
                            try
                            {
                                using (SqlConnection con3 = new SqlConnection(connectionString2))
                                {
                                    con3.Open();
                                    using (SqlCommand command = new SqlCommand("DELETE FROM CalenderFoodTable WHERE Date =  '" + Calendar_Order.Value.ToString("yyyy-MM-dd") + "' and Name = '" + textBox_name.Text + "'", con3))
                                    {
                                        command.ExecuteNonQuery();
                                    }
                                    con3.Close();
                                }
                            }
                            catch (SystemException ex)
                            {
                                MessageBox.Show(string.Format("An error occurred: {0}", ex.Message));
                            }

                            //fill list
                            //update listview
                            FoodCalender.FillList();
                            foreach (KeyValuePair<DateTime, List<Food>> entry in FoodCalender.datedict)
                            {
                                if (entry.Key.ToString("yyyy-MM-dd") == Calendar_Order.Value.ToString("yyyy-MM-dd"))
                                {
                                    Food.Fill_ListView(myListView1, entry.Value);
                                }
                            }
                        }
                        catch { }
                        //////////////////////////////////////////////
                        textBox_category.Clear();
                        textBox_name.Clear();
                        textBox_price.Clear();
                        textBox_quantity.Clear();
                        textBox_recepie.Clear();
                        textBox_recieved_quantity.Clear();
                        pictureBox1.Image = null;
                    }

                    else                    //When its less (Change the amount in calender)
                    {
                        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\ShoppingListDB.mdf;Integrated Security=True");
                        SqlCommand cmd = new SqlCommand("insert into ShoppingListTable (SocialID,Date,OrderDate,Category,Name,Price,Quantity,Photo) values (@SocialID,@Date,@OrderDate,@Category,@Name,@Price,@Quantity,@Photo)", con);
                        cmd.Parameters.AddWithValue("@SocialID", socialid_temp);
                        cmd.Parameters.AddWithValue("@Date", DateTime.Now.ToString());
                        cmd.Parameters.AddWithValue("@OrderDate", Calendar_Order.Value.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@Category", textBox_category.Text);
                        cmd.Parameters.AddWithValue("@Name", textBox_name.Text);
                        cmd.Parameters.AddWithValue("@Price", textBox_price.Text);
                        cmd.Parameters.AddWithValue("@Quantity", textBox_quantity.Text);
                        cmd.Parameters.AddWithValue("@Photo", Food.ConvertImageTOBinary(pictureBox1.Image));
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();

                        /////////////Update foodcalender
                        Food f2 = new Food();
                        foreach (KeyValuePair<DateTime, List<Food>> entry in FoodCalender.datedict)
                        {
                            if (entry.Key.ToString("yyyy-MM-dd") == Calendar_Order.Value.ToString("yyyy-MM-dd"))
                            {
                                foreach (Food f in entry.Value)
                                {
                                    if (f.Name == textBox_name.Text)
                                    {
                                        f2.Category = textBox_category.Text;
                                        f2.Name = textBox_name.Text;
                                        f2.Ingridients = f.Ingridients;
                                        f2.Photo = Food.ConvertImageTOBinary(pictureBox1.Image);
                                        f2.PhotoURL = "";
                                        f2.Price = textBox_price.Text;
                                        f2.Quantity = textBox_quantity.Text;
                                    }
                                }
                            }
                        }
                        //////////////////read current quantity in calender
                        string current_Q = string.Empty;
                        FoodCalender.FillList();
                        foreach (KeyValuePair<DateTime, List<Food>> entry in FoodCalender.datedict)
                        {
                            if (entry.Key.ToString("yyyy-MM-dd") == Calendar_Order.Value.ToString("yyyy-MM-dd"))
                            {
                                foreach (Food f in entry.Value)
                                {
                                    if (f.Name == textBox_name.Text)
                                    {
                                        current_Q = f.Quantity;
                                    }
                                }
                            }
                        }
                        ///////////////

                        var connectionString2 = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\FoodCalenderDB.mdf;Integrated Security=True";
                        try
                        {
                            using (SqlConnection connection = new SqlConnection(connectionString2))
                            using (SqlCommand command2 = connection.CreateCommand())
                            {

                                command2.CommandText = "UPDATE CalenderFoodTable SET Date = @Date, Category = @Category, Name = @Name , Ingridients = @Ingridients" +
                                    ", Price = @Price , Quantity = @Quantity , Photo = @Photo, PhotoURL = @PhotoURL Where Name = @Name and Date = @Date";

                                command2.Parameters.AddWithValue("@Date", Calendar_Order.Value.ToString("yyyy-MM-dd"));
                                command2.Parameters.AddWithValue("@Category", f2.Category);
                                command2.Parameters.AddWithValue("@Name", f2.Name);
                                command2.Parameters.AddWithValue("@Ingridients", f2.Ingridients);
                                command2.Parameters.AddWithValue("@Price", f2.Price);
                                command2.Parameters.AddWithValue("@Quantity", int.Parse(current_Q) - int.Parse(textBox_quantity.Text));
                                command2.Parameters.AddWithValue("@Photo", f2.Photo);
                                command2.Parameters.AddWithValue("@PhotoURL", f2.PhotoURL);

                                connection.Open();
                                command2.ExecuteNonQuery();
                                connection.Close();
                            }
                        }
                        catch
                        { }
                        ////////////////////////////
                        RefreshData();
                        textBox_category.Clear();
                        textBox_name.Clear();
                        textBox_price.Clear();
                        textBox_quantity.Clear();
                        textBox_recepie.Clear();
                        textBox_recieved_quantity.Clear();
                        pictureBox1.Image = null;
                    }
                }
                RefreshData();
            }
            catch { MessageBox.Show("An error occured Retry"); }
        }
    }
}