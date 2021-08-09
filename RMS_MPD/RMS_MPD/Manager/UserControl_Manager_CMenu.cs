using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using RestRequest;
using System.Data.SqlClient;
using System.IO;


namespace RMS_MPD.Manager
{
    public partial class UserControl_Manager_CMenu : UserControl
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
        public void clearfields()
        {
            comboBox_Category.Text = null;
            comboBox_Name.Items.Clear();
            comboBox_Name.ResetText();
            textBox_price.Clear();
            textBox_recepie.Clear();
            image = Blankimage;
            ImageURL = null;
        }

        public UserControl_Manager_CMenu()
        {
            InitializeComponent();

            //Food.Clear_Table();
            //Food.Food_Initialize();

            Food.Fill_FoodArray();

            Food.Fill_ListView(myListView, Food.FoodList);
            clearfields();
        }

        

        //When user will select the "Large Icon" RadioButton, then it will display items into Large Icon view...
        private void rbLargeIcon_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLargeIcon.Checked == true)
            {
                myListView.View = View.LargeIcon;
            }
        }

        //When user will select the "Tile" RadioButton, then it will display items into Tile view...
        private void rbTile_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTile.Checked == true)
            {
                myListView.View = View.Tile;
            }
        }


        //Finally it will display the selected item message box when user will select a particular item from the ListView...
        private void myListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in myListView.SelectedItems)
            {
                string name = item.Text.ToString();
                foreach(Food food in Food.FoodList)
                {
                    if(food.Name == name)
                    {
                        comboBox_Category.SelectedItem = food.Category;
                        textBox_price.Text = food.Price;
                        textBox_recepie.Text = food.Ingridients;
                        comboBox_Name.Text = food.Name;
/*                        
                        DateTime oDate = DateTime.Parse(food.PhotoURL);
                        Calendar_Order.Value = oDate;*/
                    }
                }
                //MessageBox.Show(item.Text.ToString());
            }
        }





        private static List<string> recipeList = new List<string>();

        private static async Task GetRecipes(string recipe)
        {
            //This is how I have set up calls to the RestApp
            //PARAMS: string method, string query
            Response response = await RestApp.Request("GET", recipe);

            //serialize the response to a string
            string jsonResponse = await response.Content.ReadAsStringAsync();

            //Create a JObject from the string jsonResponse
            JObject recipes = JObject.Parse(jsonResponse);

            //Create a JArray from a key element in the JSON(hits)
            //hits is a JSON Array of objects hence, the need to convert the JObject into an Array
            JArray recipeArr = JArray.Parse(recipes["hits"].ToString());


            //Loop through all of the objects found in recipes["hits"]
            for (var i = 0; i < recipeArr.Count(); ++i)
            {
                //Due to our set toLimit in the RestRequest application we will at maximum only get 25 recipes back.
                recipeList.Add(recipeArr[i]["recipe"]["label"].ToString());
            }
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\FoodDB.mdf;Integrated Security=True");
        string ImageURL = null;
        Image image ;
        Image Blankimage;

        private void button_Browse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    ImageURL = ofd.FileName;
                    image = Image.FromFile(ofd.FileName);
                    //pictureBox1.Image = Image.FromFile(ofd.FileName);
                }
            }
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            bool ok = true;
            try
            {
                double x = Double.Parse(textBox_price.Text);
                if(x <= 0)
                {
                    ok = false;
                    throw new IndexOutOfRangeException();
                }
            }
            catch
            {
                MessageBox.Show("Price isn't in a correct format! Retry!");
                textBox_price.Clear();
                ok = false;
            }
            if (ok)
            {
                //string theDate = Calendar_Order.Value.ToString("yyyy-MM-dd");
                Image img = image;
                byte[] arr = Food.ConvertImageTOBinary(Image.FromFile("burgers.PNG"));

                if (image != Blankimage)
                {
                    ImageConverter convertor = new ImageConverter();
                    arr = Food.ConvertImageTOBinary(img);
                }
                else
                {
                    switch (comboBox_Category.Text)
                    {
                        case "Burgers":
                            arr = Food.ConvertImageTOBinary(Image.FromFile("burgers.PNG"));
                            break;
                        case "Pizza":
                            arr = Food.ConvertImageTOBinary(Image.FromFile("pizza.PNG"));
                            break;
                        case "Chicken":
                            arr = Food.ConvertImageTOBinary(Image.FromFile("chicken.PNG"));
                            break;
                        case "Soups":
                            arr = Food.ConvertImageTOBinary(Image.FromFile("soup.PNG"));
                            break;
                        case "Salads":
                            arr = Food.ConvertImageTOBinary(Image.FromFile("salad.PNG"));
                            break;
                        case "Beverages":
                            arr = Food.ConvertImageTOBinary(Image.FromFile("beverage.PNG"));
                            break;
                        case "Desserts":
                            arr = Food.ConvertImageTOBinary(Image.FromFile("dessert.PNG"));
                            break;
                        case "Indian":
                            arr = Food.ConvertImageTOBinary(Image.FromFile("indian.PNG"));
                            break;
                        case "Persian":
                            arr = Food.ConvertImageTOBinary(Image.FromFile("persian.PNG"));
                            break;
                    }
                }

                bool flag_used = false;     //if the item has been assigned before

                foreach (Food fod in Food.FoodList)
                {
                    if (comboBox_Name.Text == fod.Name)
                    {
                        flag_used = true;
                    }
                }

                if (!flag_used)     //This means new entry
                {
                    Food food = new Food(comboBox_Category.Text, comboBox_Name.Text, textBox_recepie.Text, textBox_price.Text, "0", arr, ImageURL);

                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into foodMenuTable (Category,Name,Ingridients,Price,Quantity,Photo,PhotoURL) values (@Category,@Name,@Ingridients,@Price,@Quantity,@Photo,@PhotoURL)", con);
                    cmd.Parameters.AddWithValue("@Category", food.Category);
                    cmd.Parameters.AddWithValue("@Name", food.Name);
                    cmd.Parameters.AddWithValue("@Ingridients", food.Ingridients);
                    cmd.Parameters.AddWithValue("@Price", food.Price);
                    cmd.Parameters.AddWithValue("@Quantity", 0);
                    cmd.Parameters.AddWithValue("@Photo", food.Photo);
                    cmd.Parameters.AddWithValue("@PhotoURL", "");
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product Saved!");

                    /*                SqlCommand updateDatagrid = new SqlCommand("select * from foodMenuTable", con);
                                    DataTable dt = new DataTable();
                                    dt.Load(updateDatagrid.ExecuteReader());
                                    dataGridView1.DataSource = dt;*/

                    con.Close();
                    Food.Fill_FoodArray();
                    Food.Fill_ListView(myListView, Food.FoodList);
                    image = Blankimage;
                    ImageURL = null;
                }
                else    //This means editing an existing item;
                {
                    Food food = new Food(comboBox_Category.Text, comboBox_Name.Text, textBox_recepie.Text, textBox_price.Text, "0", arr, ImageURL);
                    var connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\FoodDB.mdf;Integrated Security=True";
                    try
                    {
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        using (SqlCommand command = connection.CreateCommand())
                        {

                            command.CommandText = "UPDATE foodMenuTable SET Category = @Category, Name = @Name , Ingridients = @Ingridients" +
                                ", Price = @Price , Quantity = @Quantity , Photo = @Photo, PhotoURL = @PhotoURL Where Name = @Name ";

                            command.Parameters.AddWithValue("@Category", food.Category);
                            command.Parameters.AddWithValue("@Name", food.Name);
                            command.Parameters.AddWithValue("@Ingridients", food.Ingridients);
                            command.Parameters.AddWithValue("@Price", food.Price);
                            command.Parameters.AddWithValue("@Quantity", 0);
                            command.Parameters.AddWithValue("@Photo", food.Photo);
                            command.Parameters.AddWithValue("@PhotoURL", "");

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

                    Food.Fill_FoodArray();
                    Food.Fill_ListView(myListView, Food.FoodList);
                    image = Blankimage;
                    ImageURL = null;
                    clearfields();
                }
            }
        }

        private void foodMenuTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.foodMenuTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.foodDBDataSet);

        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            clearfields();
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            ////////////////////////////////////////////delete from menu
            var connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\FoodDB.mdf;Integrated Security=True";
            try
            {
                using (SqlConnection con2 = new SqlConnection(connectionString))
                {
                    con2.Open();
                    using (SqlCommand command = new SqlCommand("DELETE FROM " + "foodMenuTable" + " WHERE " + "Name" + " = '" + comboBox_Name.Text+ "'", con2))
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
            Food.Fill_FoodArray();
            Food.Fill_ListView(myListView, Food.FoodList);
            image = Blankimage;
            ImageURL = null;
            /////////////////////////////////////
            /////////////////////////////////////delete from shoppinglist
            var connectionString2 = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\ShoppingListDB.mdf;Integrated Security=True";
            try
            {
                using (SqlConnection con2 = new SqlConnection(connectionString2))
                {
                    con2.Open();
                    using (SqlCommand command = new SqlCommand("DELETE FROM ShoppingListTable WHERE Name = '" + comboBox_Name.Text + "'", con2))
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
            var connectionString5 = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\FoodCalenderDB.mdf;Integrated Security=True";
            try
            {
                using (SqlConnection con2 = new SqlConnection(connectionString5))
                {
                    con2.Open();
                    using (SqlCommand command = new SqlCommand("DELETE FROM CalenderFoodTable WHERE Name = '" + comboBox_Name.Text + "'", con2))
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
        }

        private void label_Suggest_Click(object sender, EventArgs e)
        {
            if (utility.CheckForInternetConnection())
            {
                comboBox_Name.Items.Clear();
                if (comboBox_Category.Text != string.Empty)
                {
                    recipeList.Clear();
                    comboBox_Name.ForeColor = Color.Gray;
                    comboBox_Name.Text = "Please Wait.....";
                    GetRecipes(comboBox_Category.Text).Wait();
                    comboBox_Name.ForeColor = Color.Black;
                    comboBox_Name.Text = "Choose!";

                    foreach (var rec in recipeList)
                    {
                        comboBox_Name.Items.Add(rec);
                    }
                }
            }
            else
            {
                MessageBox.Show("Name suggestion requires internet connection!");
            }
        }
    }
}
