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
    public partial class UserControl_Customer_ShoppingList : UserControl
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
        string socialid_temp;
        public UserControl_Customer_ShoppingList()
        {
            InitializeComponent();
            
            Calendar_Order.Value = DateTime.Today;
            Calendar_Order.MinDate = DateTime.Now;
            Calendar_Order.MaxDate = DateTime.Now.AddDays(29);
            RefreshData();
        }
        public void RefreshData()
        {
            clearall();
            ShoppingList.FillList();

            ////////////////////
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
            ShoppingList.FillList();
            utility.currentSocialID = socialid_temp;
            List<ShoppingList> temp = new List<ShoppingList>();
            foreach (KeyValuePair<DateTime, List<ShoppingList>> entry in ShoppingList.shoppinglistdict)
            {
                if (entry.Key.ToString("yyyy-MM-dd") == Calendar_Order.Value.ToString("yyyy-MM-dd"))
                {
                    foreach (ShoppingList f in entry.Value)
                    {
                        if (f.SocialID == socialid_temp)
                        {
                            temp.Add(f);
                        }
                    }
                }
            }
            ShoppingList.Fill_ListView(myListView1, temp);
        }
        public void clearall()
        {
            textBox_category.Clear();
            textBox_name.Clear();
            textBox_price.Clear();
            textBox_quantity.Clear();
            Calender1.Value = DateTime.Today;
            pictureBox1.Image = null;
        }
        
        private void myListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShoppingList.FillList();
            foreach (ListViewItem item in myListView1.SelectedItems)
            {
                foreach (KeyValuePair<DateTime, List<ShoppingList>> entry in ShoppingList.shoppinglistdict)
                {
                    if (entry.Key.ToString("yyyy-MM-dd") == Calendar_Order.Value.ToString("yyyy-MM-dd"))
                    {
                        foreach (ShoppingList f in entry.Value)
                        {
                            if (f.Name == item.Text.ToString() && f.SocialID == socialid_temp)
                            {
                                textBox_name.Text = item.Text.ToString();
                                textBox_quantity.Text = f.Quantity;
                                textBox_category.Text = f.Category;
                                textBox_name.Text = f.Name;
                                textBox_price.Text = f.Price;
                                pictureBox1.Image = Food.ConvertBinaryTOImage(f.Photo);
                                Calender1.Value = DateTime.Parse(f.OrderDate);
                            }
                        }
                    }
                }
            }
        }
        private void Calendar_Order_onValueChanged(object sender, EventArgs e)
        {
            ShoppingList.FillList();
            List<ShoppingList> temp = new List<ShoppingList>();
            foreach (KeyValuePair<DateTime, List<ShoppingList>> entry in ShoppingList.shoppinglistdict)
            {
                if (entry.Key.ToString("yyyy-MM-dd") == Calendar_Order.Value.ToString("yyyy-MM-dd"))
                {
                    foreach (ShoppingList f in entry.Value)
                    {
                        if (f.SocialID == socialid_temp)
                        {
                            temp.Add(f);
                        }
                    }
                }
            }
            ShoppingList.Fill_ListView(myListView1, temp);
        }

        private void button_plus_Click(object sender, EventArgs e)
        {
            FoodCalender.FillList();
            bool exists = false;
            foreach (KeyValuePair<DateTime, List<Food>> entry in FoodCalender.datedict)
            {
                if (entry.Key.ToString("yyyy-MM-dd") == Calendar_Order.Value.ToString("yyyy-MM-dd"))
                {
                    foreach (Food f in entry.Value)
                    {
                        if (textBox_name.Text == f.Name)
                        {
                            exists = true;
                        }
                    }
                }
            }
            if (exists)
            {
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

                int quantity = int.Parse(textBox_quantity.Text);
                quantity++;
                textBox_quantity.Text = quantity.ToString();

                ShoppingList f1 = new ShoppingList();
                foreach (KeyValuePair<DateTime, List<ShoppingList>> entry in ShoppingList.shoppinglistdict)
                {
                    if (entry.Key.ToString("yyyy-MM-dd") == Calendar_Order.Value.ToString("yyyy-MM-dd"))
                    {
                        foreach (ShoppingList f in entry.Value)
                        {
                            if (f.Name == textBox_name.Text && f.SocialID == socialid_temp)
                            {
                                f1.SocialID = f.SocialID;
                                f1.Date = f.Date;
                                f1.OrderDate = f.OrderDate;
                                f1.Category = f.Category;
                                f1.Name = f.Name;
                                f1.Price = f.Price;
                                f1.Quantity = f.Quantity;
                                f1.Photo = f.Photo;
                            }
                        }
                    }
                }
                //////////////Update ShoppingList
                var connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\ShoppingListDB.mdf;Integrated Security=True";
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    using (SqlCommand command = connection.CreateCommand())
                    {

                        command.CommandText = "UPDATE ShoppingListTable SET SocialID = @SocialID, Date = @Date, OrderDate = @OrderDate, Category = @Category, Name = @Name" +
                            ", Price = @Price , Quantity = @Quantity , Photo = @Photo Where Name = @Name and OrderDate = @OrderDate and SocialID = @SocialID";

                        command.Parameters.AddWithValue("@SocialID", f1.SocialID);
                        command.Parameters.AddWithValue("@Date", f1.Date);
                        command.Parameters.AddWithValue("@OrderDate", f1.OrderDate);
                        command.Parameters.AddWithValue("@Category", f1.Category);
                        command.Parameters.AddWithValue("@Name", f1.Name);
                        command.Parameters.AddWithValue("@Price", f1.Price);
                        command.Parameters.AddWithValue("@Quantity", quantity);
                        command.Parameters.AddWithValue("@Photo", f1.Photo);

                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                }
                catch
                { }

                if (int.Parse(current_Q) <= 1)  //delete from calender if it is the last one left
                {
                    //////////////////////Delete from Calender
                    var connectionString5 = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\FoodCalenderDB.mdf;Integrated Security=True";
                    try
                    {
                        using (SqlConnection con3 = new SqlConnection(connectionString5))
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
                    //////////////////////////////////////////////
                }
                else                /////////////Update foodcalender
                {
                    Food f2 = new Food();
                    foreach (KeyValuePair<DateTime, List<Food>> entry in FoodCalender.datedict)
                    {
                        if (entry.Key.ToString("yyyy-MM-dd") == Calendar_Order.Value.ToString("yyyy-MM-dd"))
                        {
                            foreach (Food f in entry.Value)
                            {
                                if (f.Name == f1.Name)
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
                            command2.Parameters.AddWithValue("@Quantity", (int.Parse(current_Q) - 1));
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
                }
            }
            else
            {
                MessageBox.Show("Sorry no more left!");
            }
        }

        private void button_minus_Click(object sender, EventArgs e)
        {
            if (textBox_quantity.Text == "1")   //perform trash button action
            {
                int quantity = int.Parse(textBox_quantity.Text);
                //textBox_quantity.Text = quantity.ToString();

                ShoppingList ShList = new ShoppingList();
                ShoppingList.FillList();
                foreach (ListViewItem item in myListView1.SelectedItems)
                {
                    foreach (KeyValuePair<DateTime, List<ShoppingList>> entry in ShoppingList.shoppinglistdict)
                    {
                        if (entry.Key.ToString("yyyy-MM-dd") == Calendar_Order.Value.ToString("yyyy-MM-dd"))
                        {
                            foreach (ShoppingList f in entry.Value)
                            {
                                if (f.Name == item.Text.ToString())
                                {
                                    ShList.SocialID = f.SocialID;
                                    ShList.Date = f.Date;
                                    ShList.OrderDate = f.OrderDate;
                                    ShList.Category = f.Category;
                                    ShList.Name = f.Name;
                                    ShList.Price = f.Price;
                                    ShList.Quantity = f.Quantity;
                                    ShList.Photo = f.Photo;
                                }
                            }
                        }
                    }
                }

                //////////////////////////////////////Read calender's current quantity to the selected object so that we'd add to it in the edit section
                string currentquantity = string.Empty;
                string currentdate = string.Empty;

                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\FoodCalenderDB.mdf;Integrated Security=True");
                string sql = "select * from CalenderFoodTable";
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    string tempdate = dr["Date"].ToString();
                    //DateTime oDate = DateTime.Parse(tempdate);

                    Food food = new Food();
                    food.Category = dr["Category"].ToString();
                    food.Name = dr["Name"].ToString();
                    food.Ingridients = dr["Ingridients"].ToString();
                    food.Price = dr["Price"].ToString();
                    food.Quantity = dr["Quantity"].ToString();
                    food.Photo = (byte[])dr["Photo"];
                    food.PhotoURL = dr["PhotoURL"].ToString();
                    if (food.Name == ShList.Name && tempdate == ShList.OrderDate)
                    {
                        currentquantity = food.Quantity;
                        currentdate = tempdate;
                    }
                }
                con.Close();
                /////////////////////////////////////////////
                ////////////////////////////////////////////if it doesnt exist in the food calender add it on that day with the amount
                bool exists = false;
                foreach (KeyValuePair<DateTime, List<Food>> entry in FoodCalender.datedict)
                {
                    if (entry.Key.ToString("yyyy-MM-dd") == Calendar_Order.Value.ToString("yyyy-MM-dd"))
                    {
                        foreach (Food f in entry.Value)
                        {
                            if (textBox_name.Text == f.Name)
                            {
                                exists = true;
                            }
                        }
                    }
                }
                if (!exists)
                {
                    Food food = new Food();       //match sh with a food object from database to copy its info
                    Food.Food_Initialize();
                    Food.Fill_FoodArray();
                    foreach (Food entry in Food.FoodList)
                    {
                        if (textBox_name.Text == entry.Name)
                        {
                            food.Category = entry.Category;
                            food.Name = entry.Name;
                            food.Ingridients = entry.Ingridients;
                            food.Photo = entry.Photo;
                            food.PhotoURL = entry.PhotoURL;
                            food.Price = entry.Price;
                            food.Quantity = entry.Quantity;
                        }
                    }
                    FoodCalender.AddtoTable(Calendar_Order.Value.ToString("yyyy-MM-dd"), food.Category, food.Name, food.Ingridients, food.Price, textBox_quantity.Text, food.Photo, food.PhotoURL);
                    /////////////////////////////////////////
                }
                else
                {
                    //////////////////////////////////Edit in food calender
                    Food f1 = new Food();       //match sh with a food object from database to copy its info
                    foreach (KeyValuePair<DateTime, List<Food>> entry in FoodCalender.datedict)
                    {
                        if (entry.Key.ToString("yyyy-MM-dd") == Calendar_Order.Value.ToString("yyyy-MM-dd"))
                        {
                            foreach (Food f in entry.Value)
                            {
                                if (f.Name == ShList.Name)
                                {
                                    f1.Category = f.Category;
                                    f1.Name = f.Name;
                                    f1.Ingridients = f.Ingridients;
                                    f1.Photo = f.Photo;
                                    f1.PhotoURL = f.PhotoURL;
                                    f1.Price = f.Price;
                                    f1.Quantity = f.Quantity;
                                }
                            }
                        }
                    }
                    var connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\FoodCalenderDB.mdf;Integrated Security=True";
                    try
                    {
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        using (SqlCommand command = connection.CreateCommand())
                        {

                            command.CommandText = "UPDATE CalenderFoodTable SET Date = @Date, Category = @Category, Name = @Name , Ingridients = @Ingridients" +
                                ", Price = @Price , Quantity = @Quantity , Photo = @Photo, PhotoURL = @PhotoURL Where Name = @Name and Date = @Date";

                            if (f1.Name == ShList.Name && currentdate == ShList.OrderDate)
                            {
                                command.Parameters.AddWithValue("@Date", ShList.OrderDate);
                                command.Parameters.AddWithValue("@Category", f1.Category);
                                command.Parameters.AddWithValue("@Name", f1.Name);
                                command.Parameters.AddWithValue("@Ingridients", f1.Ingridients);
                                command.Parameters.AddWithValue("@Price", f1.Price);
                                command.Parameters.AddWithValue("@Quantity", (int.Parse(textBox_quantity.Text) + int.Parse(currentquantity)).ToString());
                                command.Parameters.AddWithValue("@Photo", f1.Photo);
                                command.Parameters.AddWithValue("@PhotoURL", f1.PhotoURL);
                            }
                            connection.Open();
                            command.ExecuteNonQuery();
                            connection.Close();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("An error occured please retry");
                    }
                    ////////////////////////////////////
                }

                //////////////////////Delete from shoppinglist
                var connectionString2 = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\ShoppingListDB.mdf;Integrated Security=True";
                try
                {
                    try
                    {
                        using (SqlConnection con2 = new SqlConnection(connectionString2))
                        {
                            con2.Open();
                            using (SqlCommand command = new SqlCommand("DELETE FROM ShoppingListTable WHERE OrderDate =  '" + Calendar_Order.Value.ToString("yyyy-MM-dd") + "' and Name = '" + textBox_name.Text + "' and SocialID = '" + socialid_temp + "'", con2))
                            {
                                command.ExecuteNonQuery();
                            }
                            con2.Close();
                        }
                    }
                    catch (SystemException ex)
                    {
                        MessageBox.Show(string.Format("An error occurred: {0}", ex.Message));
                    }

                    //fill list
                    //update listview
                    ShoppingList.FillList();
                    RefreshData();
                }
                catch { }
                //////////////////////////////////////////////
                clearall();
            }
            else
            {
                /////////////////see if exists
                bool exists = false;
                foreach (KeyValuePair<DateTime, List<Food>> entry in FoodCalender.datedict)
                {
                    if (entry.Key.ToString("yyyy-MM-dd") == Calendar_Order.Value.ToString("yyyy-MM-dd"))
                    {
                        foreach (Food f in entry.Value)
                        {
                            if (textBox_name.Text == f.Name)
                            {
                                exists = true;
                            }
                        }
                    }
                }

                if (!exists)    //item doesnt already exist
                {
                    ////////////////////////////////create food in calender
                    Food food = new Food();       //match sh with a food object from database to copy its info
                    Food.Food_Initialize();
                    Food.Fill_FoodArray();
                    foreach (Food entry in Food.FoodList)
                    {
                        if (textBox_name.Text == entry.Name)
                        {
                            food.Category = entry.Category;
                            food.Name = entry.Name;
                            food.Ingridients = entry.Ingridients;
                            food.Photo = entry.Photo;
                            food.PhotoURL = entry.PhotoURL;
                            food.Price = entry.Price;
                            food.Quantity = "0";
                        }
                    }
                    FoodCalender.AddtoTable(Calendar_Order.Value.ToString("yyyy-MM-dd"), food.Category, food.Name, food.Ingridients, food.Price, food.Quantity, food.Photo, food.PhotoURL);
                    /////////////////////////////////////////
                }

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

                int quantity = int.Parse(textBox_quantity.Text);
                quantity--;
                textBox_quantity.Text = quantity.ToString();

                ShoppingList f1 = new ShoppingList();
                foreach (KeyValuePair<DateTime, List<ShoppingList>> entry in ShoppingList.shoppinglistdict)
                {
                    if (entry.Key.ToString("yyyy-MM-dd") == Calendar_Order.Value.ToString("yyyy-MM-dd"))
                    {
                        foreach (ShoppingList f in entry.Value)
                        {
                            if (f.Name == textBox_name.Text && f.SocialID == socialid_temp)
                            {
                                f1.SocialID = f.SocialID;
                                f1.Date = f.Date;
                                f1.OrderDate = f.OrderDate;
                                f1.Category = f.Category;
                                f1.Name = f.Name;
                                f1.Price = f.Price;
                                f1.Quantity = f.Quantity;
                                f1.Photo = f.Photo;
                            }
                        }
                    }
                }
                //////////////Update ShoppingList
                var connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\ShoppingListDB.mdf;Integrated Security=True";
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    using (SqlCommand command = connection.CreateCommand())
                    {

                        command.CommandText = "UPDATE ShoppingListTable SET SocialID = @SocialID, Date = @Date, OrderDate = @OrderDate, Category = @Category, Name = @Name" +
                            ", Price = @Price , Quantity = @Quantity , Photo = @Photo Where Name = @Name and OrderDate = @OrderDate and SocialID = @SocialID";

                        command.Parameters.AddWithValue("@SocialID", f1.SocialID);
                        command.Parameters.AddWithValue("@Date", f1.Date);
                        command.Parameters.AddWithValue("@OrderDate", f1.OrderDate);
                        command.Parameters.AddWithValue("@Category", f1.Category);
                        command.Parameters.AddWithValue("@Name", f1.Name);
                        command.Parameters.AddWithValue("@Price", f1.Price);
                        command.Parameters.AddWithValue("@Quantity", quantity);
                        command.Parameters.AddWithValue("@Photo", f1.Photo);

                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                }
                catch
                { }
                /////////////Update foodcalender
                Food f2 = new Food();
                foreach (KeyValuePair<DateTime, List<Food>> entry in FoodCalender.datedict)
                {
                    if (entry.Key.ToString("yyyy-MM-dd") == Calendar_Order.Value.ToString("yyyy-MM-dd"))
                    {
                        foreach (Food f in entry.Value)
                        {
                            if (f.Name == f1.Name)
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
                        command2.Parameters.AddWithValue("@Quantity", (int.Parse(current_Q) + 1));
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
            }
        }

        private void button_trash_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(textBox_quantity.Text);
            //textBox_quantity.Text = quantity.ToString();

            ShoppingList ShList = new ShoppingList();
            ShoppingList.FillList();
            foreach (ListViewItem item in myListView1.SelectedItems)
            {
                foreach (KeyValuePair<DateTime, List<ShoppingList>> entry in ShoppingList.shoppinglistdict)
                {
                    if (entry.Key.ToString("yyyy-MM-dd") == Calendar_Order.Value.ToString("yyyy-MM-dd"))
                    {
                        foreach (ShoppingList f in entry.Value)
                        {
                            if (f.Name == item.Text.ToString())
                            {
                                ShList.SocialID = f.SocialID;
                                ShList.Date = f.Date;
                                ShList.OrderDate = f.OrderDate;
                                ShList.Category = f.Category;
                                ShList.Name = f.Name;
                                ShList.Price = f.Price;
                                ShList.Quantity = f.Quantity;
                                ShList.Photo = f.Photo;
                            }
                        }
                    }
                }
            }

            //////////////////////////////////////Read calender's current quantity to the selected object so that we'd add to it in the edit section
            string currentquantity = string.Empty;
            string currentdate = string.Empty;

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\FoodCalenderDB.mdf;Integrated Security=True");
            string sql = "select * from CalenderFoodTable";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                string tempdate = dr["Date"].ToString();
                //DateTime oDate = DateTime.Parse(tempdate);

                Food food = new Food();
                food.Category = dr["Category"].ToString();
                food.Name = dr["Name"].ToString();
                food.Ingridients = dr["Ingridients"].ToString();
                food.Price = dr["Price"].ToString();
                food.Quantity = dr["Quantity"].ToString();
                food.Photo = (byte[])dr["Photo"];
                food.PhotoURL = dr["PhotoURL"].ToString();
                if(food.Name == ShList.Name && tempdate == ShList.OrderDate)
                {
                    currentquantity = food.Quantity;
                    currentdate = tempdate;
                }
            }
            con.Close();
            /////////////////////////////////////////////
            ////////////////////////////////////////////if it doesnt exist in the food calender add it on that day with the amount
            bool exists = false;
            foreach (KeyValuePair<DateTime, List<Food>> entry in FoodCalender.datedict)
            {
                if (entry.Key.ToString("yyyy-MM-dd") == Calendar_Order.Value.ToString("yyyy-MM-dd"))
                {
                    foreach(Food f in entry.Value)
                    {
                        if(textBox_name.Text == f.Name)
                        {
                            exists = true;
                        }
                    }
                }
            }
            if (!exists)
            {
                Food food = new Food();       //match sh with a food object from database to copy its info
                Food.Food_Initialize();
                Food.Fill_FoodArray();
                foreach (Food entry in Food.FoodList)
                {
                    if (textBox_name.Text == entry.Name)
                    {
                        food.Category = entry.Category;
                        food.Name = entry.Name;
                        food.Ingridients = entry.Ingridients;
                        food.Photo = entry.Photo;
                        food.PhotoURL = entry.PhotoURL;
                        food.Price = entry.Price;
                        food.Quantity = entry.Quantity;
                    }
                }
                FoodCalender.AddtoTable(Calendar_Order.Value.ToString("yyyy-MM-dd"), food.Category, food.Name, food.Ingridients, food.Price, textBox_quantity.Text, food.Photo, food.PhotoURL);
                /////////////////////////////////////////
            }
            else
            {
                //////////////////////////////////Edit in food calender
                Food f1 = new Food();       //match sh with a food object from database to copy its info
                foreach (KeyValuePair<DateTime, List<Food>> entry in FoodCalender.datedict)
                {
                    if (entry.Key.ToString("yyyy-MM-dd") == Calendar_Order.Value.ToString("yyyy-MM-dd"))
                    {
                        foreach (Food f in entry.Value)
                        {
                            if (f.Name == ShList.Name)
                            {
                                f1.Category = f.Category;
                                f1.Name = f.Name;
                                f1.Ingridients = f.Ingridients;
                                f1.Photo = f.Photo;
                                f1.PhotoURL = f.PhotoURL;
                                f1.Price = f.Price;
                                f1.Quantity = f.Quantity;
                            }
                        }
                    }
                }
                var connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\FoodCalenderDB.mdf;Integrated Security=True";
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    using (SqlCommand command = connection.CreateCommand())
                    {

                        command.CommandText = "UPDATE CalenderFoodTable SET Date = @Date, Category = @Category, Name = @Name , Ingridients = @Ingridients" +
                            ", Price = @Price , Quantity = @Quantity , Photo = @Photo, PhotoURL = @PhotoURL Where Name = @Name and Date = @Date";

                        if (f1.Name == ShList.Name && currentdate == ShList.OrderDate)
                        {
                            command.Parameters.AddWithValue("@Date", ShList.OrderDate);
                            command.Parameters.AddWithValue("@Category", f1.Category);
                            command.Parameters.AddWithValue("@Name", f1.Name);
                            command.Parameters.AddWithValue("@Ingridients", f1.Ingridients);
                            command.Parameters.AddWithValue("@Price", f1.Price);
                            command.Parameters.AddWithValue("@Quantity", (int.Parse(textBox_quantity.Text) + int.Parse(currentquantity)).ToString());
                            command.Parameters.AddWithValue("@Photo", f1.Photo);
                            command.Parameters.AddWithValue("@PhotoURL", f1.PhotoURL);
                        }
                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                }
                catch
                {
                    MessageBox.Show("An error occured please retry");
                }
                ////////////////////////////////////
            }

            //////////////////////Delete from shoppinglist
            var connectionString2 = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\ShoppingListDB.mdf;Integrated Security=True";
            try
            {
                try
                {
                    using (SqlConnection con2 = new SqlConnection(connectionString2))
                    {
                        con2.Open();
                        using (SqlCommand command = new SqlCommand("DELETE FROM ShoppingListTable WHERE OrderDate =  '" + Calendar_Order.Value.ToString("yyyy-MM-dd") + "' and Name = '" + textBox_name.Text + "' and SocialID = '" + socialid_temp + "'", con2))
                        {
                            command.ExecuteNonQuery();
                        }
                        con2.Close();
                    }
                }
                catch (SystemException ex)
                {
                    MessageBox.Show(string.Format("An error occurred: {0}", ex.Message));
                }

                //fill list
                //update listview
                ShoppingList.FillList();
                RefreshData();
            }
            catch {}
            //////////////////////////////////////////////


            clearall();
        }

        private void button_CompletePurchase_Click(object sender, EventArgs e)
        {
            if (!Customer_Dashboard_Main.Instance.PnlContainer.Controls.ContainsKey("UserControl_Customer_CopmletePurchase"))
            {
                UserControl_Customer_CopmletePurchase un = new UserControl_Customer_CopmletePurchase();
                un.Dock = DockStyle.Fill;
                un.RefreshDataCalender();
                Customer_Dashboard_Main.Instance.PnlContainer.Controls.Add(un);
            }
            Customer_Dashboard_Main.Instance.PnlContainer.Controls["UserControl_Customer_CopmletePurchase"].Refresh();
            Customer_Dashboard_Main.Instance.PnlContainer.Controls["UserControl_Customer_CopmletePurchase"].BringToFront();
        }

        private void button_ClearShoppingList_Click(object sender, EventArgs e)
        {
                ShoppingList.FillList();
                foreach (ListViewItem item in myListView1.Items)
                {
            x:;
                try
                {
                    foreach (KeyValuePair<DateTime, List<ShoppingList>> entry in ShoppingList.shoppinglistdict)
                    {
                        if (entry.Key.ToString("yyyy-MM-dd") == Calendar_Order.Value.ToString("yyyy-MM-dd"))
                        {
                            foreach (ShoppingList SHLISTITEM in entry.Value)
                            {
                                if (SHLISTITEM.Name == item.Text.ToString() && SHLISTITEM.SocialID == socialid_temp)
                                {
                                    int quantity = int.Parse(SHLISTITEM.Quantity);
                                    //textBox_quantity.Text = quantity.ToString();

                                    ShoppingList ShList = new ShoppingList();
                                    ShoppingList.FillList();

                                    ShList.SocialID = SHLISTITEM.SocialID;
                                    ShList.Date = SHLISTITEM.Date;
                                    ShList.OrderDate = SHLISTITEM.OrderDate;
                                    ShList.Category = SHLISTITEM.Category;
                                    ShList.Name = SHLISTITEM.Name;
                                    ShList.Price = SHLISTITEM.Price;
                                    ShList.Quantity = SHLISTITEM.Quantity;
                                    ShList.Photo = SHLISTITEM.Photo;


                                    //////////////////////////////////////Read calender's current quantity to the selected object so that we'd add to it in the edit section
                                    string currentquantity = string.Empty;
                                    string currentdate = string.Empty;

                                    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\FoodCalenderDB.mdf;Integrated Security=True");
                                    string sql = "select * from CalenderFoodTable";
                                    con.Open();
                                    SqlCommand cmd = new SqlCommand(sql, con);
                                    SqlDataReader dr = cmd.ExecuteReader();

                                    while (dr.Read())
                                    {
                                        string tempdate = dr["Date"].ToString();
                                        //DateTime oDate = DateTime.Parse(tempdate);

                                        Food food = new Food();
                                        food.Category = dr["Category"].ToString();
                                        food.Name = dr["Name"].ToString();
                                        food.Ingridients = dr["Ingridients"].ToString();
                                        food.Price = dr["Price"].ToString();
                                        food.Quantity = dr["Quantity"].ToString();
                                        food.Photo = (byte[])dr["Photo"];
                                        food.PhotoURL = dr["PhotoURL"].ToString();
                                        if (food.Name == ShList.Name && tempdate == ShList.OrderDate)
                                        {
                                            currentquantity = food.Quantity;
                                            currentdate = tempdate;
                                        }
                                    }
                                    con.Close();
                                    /////////////////////////////////////////////
                                    ////////////////////////////////////////////if it doesnt exist in the food calender add it on that day with the amount
                                    bool exists = false;
                                    foreach (KeyValuePair<DateTime, List<Food>> entry2 in FoodCalender.datedict)
                                    {
                                        if (entry2.Key.ToString("yyyy-MM-dd") == Calendar_Order.Value.ToString("yyyy-MM-dd"))
                                        {
                                            foreach (Food f2 in entry2.Value)
                                            {
                                                if (SHLISTITEM.Name == f2.Name)
                                                {
                                                    exists = true;
                                                }
                                            }
                                        }
                                    }
                                    if (!exists)
                                    {
                                        Food food = new Food();       //match sh with a food object from database to copy its info
                                        Food.Food_Initialize();
                                        Food.Fill_FoodArray();
                                        foreach (Food entry3 in Food.FoodList)
                                        {
                                            if (textBox_name.Text == entry3.Name)
                                            {
                                                food.Category = entry3.Category;
                                                food.Name = entry3.Name;
                                                food.Ingridients = entry3.Ingridients;
                                                food.Photo = entry3.Photo;
                                                food.PhotoURL = entry3.PhotoURL;
                                                food.Price = entry3.Price;
                                                food.Quantity = entry3.Quantity;
                                            }
                                        }
                                        FoodCalender.AddtoTable(Calendar_Order.Value.ToString("yyyy-MM-dd"), food.Category, food.Name, food.Ingridients, food.Price, SHLISTITEM.Quantity, food.Photo, food.PhotoURL);
                                        /////////////////////////////////////////
                                    }
                                    else
                                    {
                                        //////////////////////////////////Edit in food calender
                                        Food f1 = new Food();       //match sh with a food object from database to copy its info
                                        foreach (KeyValuePair<DateTime, List<Food>> entry4 in FoodCalender.datedict)
                                        {
                                            if (entry4.Key.ToString("yyyy-MM-dd") == Calendar_Order.Value.ToString("yyyy-MM-dd"))
                                            {
                                                foreach (Food f2 in entry4.Value)
                                                {
                                                    if (f2.Name == ShList.Name)
                                                    {
                                                        f1.Category = f2.Category;
                                                        f1.Name = f2.Name;
                                                        f1.Ingridients = f2.Ingridients;
                                                        f1.Photo = f2.Photo;
                                                        f1.PhotoURL = f2.PhotoURL;
                                                        f1.Price = f2.Price;
                                                        f1.Quantity = f2.Quantity;
                                                    }
                                                }
                                            }
                                        }
                                        var connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\FoodCalenderDB.mdf;Integrated Security=True";
                                        try
                                        {
                                            using (SqlConnection connection = new SqlConnection(connectionString))
                                            using (SqlCommand command = connection.CreateCommand())
                                            {

                                                command.CommandText = "UPDATE CalenderFoodTable SET Date = @Date, Category = @Category, Name = @Name , Ingridients = @Ingridients" +
                                                    ", Price = @Price , Quantity = @Quantity , Photo = @Photo, PhotoURL = @PhotoURL Where Name = @Name and Date = @Date";

                                                if (f1.Name == ShList.Name && currentdate == ShList.OrderDate)
                                                {
                                                    command.Parameters.AddWithValue("@Date", ShList.OrderDate);
                                                    command.Parameters.AddWithValue("@Category", f1.Category);
                                                    command.Parameters.AddWithValue("@Name", f1.Name);
                                                    command.Parameters.AddWithValue("@Ingridients", f1.Ingridients);
                                                    command.Parameters.AddWithValue("@Price", f1.Price);
                                                    command.Parameters.AddWithValue("@Quantity", (int.Parse(SHLISTITEM.Quantity) + int.Parse(currentquantity)).ToString());
                                                    command.Parameters.AddWithValue("@Photo", f1.Photo);
                                                    command.Parameters.AddWithValue("@PhotoURL", f1.PhotoURL);
                                                }
                                                connection.Open();
                                                command.ExecuteNonQuery();
                                                connection.Close();
                                            }
                                        }
                                        catch
                                        {
                                            MessageBox.Show("An error occured please retry");
                                        }
                                        ////////////////////////////////////
                                    }

                                    //////////////////////Delete from shoppinglist
                                    var connectionString2 = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\ShoppingListDB.mdf;Integrated Security=True";
                                    try
                                    {
                                        try
                                        {
                                            using (SqlConnection con2 = new SqlConnection(connectionString2))
                                            {
                                                con2.Open();
                                                using (SqlCommand command = new SqlCommand("DELETE FROM ShoppingListTable WHERE OrderDate =  '" + Calendar_Order.Value.ToString("yyyy-MM-dd") + "' and Name = '" + SHLISTITEM.Name + "' and SocialID = '" + socialid_temp + "'", con2))
                                                {
                                                    command.ExecuteNonQuery();
                                                }
                                                con2.Close();
                                            }
                                        }
                                        catch (SystemException ex)
                                        {
                                            MessageBox.Show(string.Format("An error occurred: {0}", ex.Message));
                                        }

                                        //fill list
                                        //update listview
                                        ShoppingList.FillList();
                                        RefreshData();
                                    }
                                    catch { }
                                    //////////////////////////////////////////////
                                    clearall();
                                }
                            }
                        }
                    }
                }
                catch
                {
                    goto x;
                }
            }
        }
    }
}
