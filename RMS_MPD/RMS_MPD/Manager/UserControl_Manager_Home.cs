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
    public partial class UserControl_Manager_Home : UserControl
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
        Food food = new Food(); //remember to empty parametera after done
        public UserControl_Manager_Home()
        {
            InitializeComponent();
            Food.Fill_ListView(myListView1, Food.FoodList);
            Calendar_Order.Value = DateTime.Today;
            Calendar_Order.MinDate = DateTime.Now;
            Calendar_Order.MaxDate = DateTime.Now.AddDays(29);
            FoodCalender.IntializeCalenderDictionary();
        }

        string selectedname_listview1;
        private void myListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in myListView1.SelectedItems)
            {
                selectedname_listview1 = item.Text.ToString();
                string name = item.Text.ToString();
                foreach (Food fod in Food.FoodList)
                {
                    if (fod.Name == name)
                    {
                        //MessageBox.Show(item.Text.ToString());
                        food.Category = fod.Category;
                        food.Name = fod.Name;
                        food.Ingridients = fod.Ingridients;
                        food.Photo = fod.Photo;
                        food.PhotoURL = fod.PhotoURL;
                        food.Price = fod.Price;
                        food.Quantity = fod.Quantity;
                        //MessageBox.Show("Info saved to temp Food");
                    }
                }
            }
        }



        private void button_add_Click(object sender, EventArgs e)
        {
            bool flag = true;
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\FoodCalenderDB.mdf;Integrated Security=True");
            string sql = "select * from CalenderFoodTable";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string tempdate = dr["Date"].ToString();
                Food food = new Food();
                food.Category = dr["Category"].ToString();
                food.Name = dr["Name"].ToString();
                food.Ingridients = dr["Ingridients"].ToString();
                food.Price = dr["Price"].ToString();
                food.Quantity = dr["Quantity"].ToString();
                food.Photo = (byte[])dr["Photo"];
                food.PhotoURL = dr["PhotoURL"].ToString();

                if(selectedname_listview1 == food.Name && tempdate == Calendar_Order.Value.ToString("yyyy-MM-dd"))
                {
                    MessageBox.Show("Item already exists on this day.\nUse Edit button to add more.");
                    flag = false;
                }
            }
            con.Close();

            ////////////////////////////////
            try
            {
                int x = int.Parse(textBox_quantity.Text);
                if (x == 0)
                {
                    MessageBox.Show("Quantity cant be 0!");
                    textBox_quantity.Clear();
                    flag = false;
                }
            }
            catch
            {
                MessageBox.Show("Quantity was entered in a wrong format!");
                flag = false;
                textBox_quantity.Clear();
            }
            if (flag) {
                FoodCalender.AddtoTable(Calendar_Order.Value.ToString("yyyy-MM-dd"), food.Category, food.Name, food.Ingridients, food.Price, textBox_quantity.Text, food.Photo, food.PhotoURL);

                /*            //Update data grid table
                            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\FoodCalenderDB.mdf;Integrated Security=True");
                            con.Open();
                            SqlCommand updateDatagrid = new SqlCommand("select * from CalenderFoodTable", con);
                            DataTable dt = new DataTable();
                            dt.Load(updateDatagrid.ExecuteReader());
                            dataGridView1.DataSource = dt;
                            con.Close();
                            //////////////////////*/
                //update mylistview2
                FoodCalender.FillList();
                foreach (KeyValuePair<DateTime, List<Food>> entry in FoodCalender.datedict)
                {
                    if (entry.Key.ToString("yyyy-MM-dd") == Calendar_Order.Value.ToString("yyyy-MM-dd"))
                    {
                        Food.Fill_ListView(myListView2, entry.Value);

                    }
                }
                ///////////////////////////////

                textBox_quantity.Clear();
            }
        }

        private void button_update_grid_Click(object sender, EventArgs e)
        {
            FoodCalender.FillList();
            foreach (KeyValuePair<DateTime, List<Food>> entry in FoodCalender.datedict)
            {
                if (entry.Key.ToString("yyyy-MM-dd") == Calendar_Order.Value.ToString("yyyy-MM-dd"))
                {
                    Food.Fill_ListView(myListView2, entry.Value);

                }
            }
        }

        string listview2_selected_name;
        private void myListView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in myListView2.SelectedItems)
            {
                //MessageBox.Show("vv");
                FoodCalender.FillList();
                foreach (KeyValuePair<DateTime, List<Food>> entry in FoodCalender.datedict)
                {
                    if (entry.Key.ToString("yyyy-MM-dd") == Calendar_Order.Value.ToString("yyyy-MM-dd"))
                    {
                        foreach(Food f in entry.Value)
                        {
                            if(f.Name == item.Text.ToString())
                            {
                                textBox_recieved_quantity.Text = f.Quantity;
                                listview2_selected_name = item.Text.ToString();
                            }
                        }
                    }
                }
            }

        }

        private void Calendar_Order_onValueChanged(object sender, EventArgs e)
        {
            FoodCalender.FillList();
            foreach (KeyValuePair<DateTime, List<Food>> entry in FoodCalender.datedict)
            {
                if (entry.Key.ToString("yyyy-MM-dd") == Calendar_Order.Value.ToString("yyyy-MM-dd"))
                {
                    Food.Fill_ListView(myListView2, entry.Value);

                }
            }
            textBox_recieved_quantity.Clear();
        }

        private void button_Edit_Click(object sender, EventArgs e)
        {
            bool flag = true;
            try
            {
                int x = int.Parse(textBox_recieved_quantity.Text);
                if (x == 0)
                {
                    MessageBox.Show("Quantity cant be 0!");
                    textBox_quantity.Clear();
                    flag = false;
                }
            }
            catch
            {
                MessageBox.Show("Quantity was entered in a wrong format!");
                flag = false;
                textBox_quantity.Clear();
            }
            if (flag)
            {
                Food f1 = new Food();
                foreach (KeyValuePair<DateTime, List<Food>> entry in FoodCalender.datedict)
                {
                    if (entry.Key.ToString("yyyy-MM-dd") == Calendar_Order.Value.ToString("yyyy-MM-dd"))
                    {
                        foreach (Food f in entry.Value)
                        {
                            if (f.Name == listview2_selected_name)
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

                        command.Parameters.AddWithValue("@Date", Calendar_Order.Value.ToString("yyyy-MM-dd"));
                        command.Parameters.AddWithValue("@Category", f1.Category);
                        command.Parameters.AddWithValue("@Name", f1.Name);
                        command.Parameters.AddWithValue("@Ingridients", f1.Ingridients);
                        command.Parameters.AddWithValue("@Price", f1.Price);
                        command.Parameters.AddWithValue("@Quantity", textBox_recieved_quantity.Text);
                        command.Parameters.AddWithValue("@Photo", f1.Photo);
                        command.Parameters.AddWithValue("@PhotoURL", f1.PhotoURL);

                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                    MessageBox.Show("Quantity updated successfully.");
                }
                catch
                {
                    MessageBox.Show("An error occured please retry");
                }
            }
            RefreshData();
        }
        public void RefreshData()
        {
            FoodCalender.FillList();
            Food.Fill_FoodArray();
            Food.Fill_ListView(myListView1, Food.FoodList);
            foreach (KeyValuePair<DateTime, List<Food>> entry in FoodCalender.datedict)
            {
                if (entry.Key.ToString("yyyy-MM-dd") == Calendar_Order.Value.ToString("yyyy-MM-dd"))
                {
                    Food.Fill_ListView(myListView2, entry.Value);

                }
            }
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            /////////////////////////////////////delete from shoppinglist
            var connectionString2 = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\ShoppingListDB.mdf;Integrated Security=True";
            try
            {
                using (SqlConnection con2 = new SqlConnection(connectionString2))
                {
                    con2.Open();
                    using (SqlCommand command = new SqlCommand("DELETE FROM ShoppingListTable WHERE OrderDate =  '" + Calendar_Order.Value.ToString("yyyy-MM-dd") + "' and Name = '" + listview2_selected_name + "'", con2))
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
            
            /////////////////////////////////////////delete from food calender
            var connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\FoodCalenderDB.mdf;Integrated Security=True";
            try
            {
                using (SqlConnection con2 = new SqlConnection(connectionString))
                {
                    con2.Open();
                    using (SqlCommand command = new SqlCommand("DELETE FROM CalenderFoodTable WHERE Date =  '" + Calendar_Order.Value.ToString("yyyy-MM-dd") + "' and Name = '" + listview2_selected_name + "'", con2))
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

            RefreshData();
        }
    }
}
