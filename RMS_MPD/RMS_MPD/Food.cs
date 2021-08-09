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

namespace RMS_MPD
{
    class Food
    {
        public static List<Food> FoodList = new List<Food>();

    public static void Fill_FoodArray()
        {
            FoodList.Clear();
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\FoodDB.mdf;Integrated Security=True");
            string sql = "select * from foodMenuTable";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Food food = new Food();
                food.Category = dr["Category"].ToString();
                food.Name = dr["Name"].ToString();
                food.Ingridients = dr["Ingridients"].ToString();
                food.Price = dr["Price"].ToString();
                food.Quantity = dr["Quantity"].ToString();
                food.Photo = (byte[])dr["Photo"];
                food.PhotoURL = dr["PhotoURL"].ToString();

                FoodList.Add(food);
            }
            con.Close();
        }
        public static void Food_Initialize()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\FoodDB.mdf;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into foodMenuTable (Category,Name,Ingridients,Price,Quantity,Photo,PhotoURL) values (@Category,@Name,@Ingridients,@Price,@Quantity,@Photo,@PhotoURL)", con);
            cmd.Parameters.AddWithValue("@Category", "Beverages");
            cmd.Parameters.AddWithValue("@Name", "Coka");
            cmd.Parameters.AddWithValue("@Ingridients", "Stuff");
            cmd.Parameters.AddWithValue("@Price", 10);
            cmd.Parameters.AddWithValue("@Quantity", 0);
            cmd.Parameters.AddWithValue("@Photo", Food.ConvertImageTOBinary(Image.FromFile("beverage.PNG")));
            cmd.Parameters.AddWithValue("@PhotoURL", "");
            cmd.ExecuteNonQuery();

        }
        public static void Clear_Table()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\FoodDB.mdf;Integrated Security=True");
            con.Open();
            string sql = @"DELETE FROM foodMenuTable";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public static void Fill_ListView(ListView myListView , List<Food> List)
        {
            //System.Threading.SynchronizationContext.Current.Post(o => myImageList1.Images.Clear(), null);
            myListView.Items.Clear();
            //Take imagelist for store images to use in listview.
            ImageList myImageList1 = new ImageList();
            //set the image size of which size images will be displayed in the listview.
            myImageList1.ImageSize = new Size(194, 194);

            //Now add the images into the imageList..

            for (int i = 0; i <List.Count; i++)
            {
                myImageList1.Images.Add(Food.ConvertBinaryTOImage(List[i].Photo));

            }

            myListView.LargeImageList = myImageList1;

            for (int i = 0; i < List.Count; i++)
            {
                myListView.Items.Add($"{List[i].Name}", i);
            }

            ListViewGroup Burgers = new ListViewGroup("Burgers", HorizontalAlignment.Left);
            ListViewGroup Pizza = new ListViewGroup("Pizza", HorizontalAlignment.Left);
            ListViewGroup Chicken = new ListViewGroup("Chicken", HorizontalAlignment.Left);
            ListViewGroup Soups = new ListViewGroup("Soups", HorizontalAlignment.Left);
            ListViewGroup Salads = new ListViewGroup("Salads", HorizontalAlignment.Left);
            ListViewGroup Beverages = new ListViewGroup("Beverages", HorizontalAlignment.Left);
            ListViewGroup Desserts = new ListViewGroup("Desserts", HorizontalAlignment.Left);
            ListViewGroup Indian = new ListViewGroup("Indian", HorizontalAlignment.Left);
            ListViewGroup Persian = new ListViewGroup("Persian", HorizontalAlignment.Left);


            myListView.Groups.AddRange(new ListViewGroup[] { Burgers, Pizza, Chicken, Soups, Salads, Beverages, Desserts, Indian, Persian });

            for (int i = 0; i < List.Count; i++)
            {
                switch (List[i].Category)
                {
                    case "Burgers":
                        myListView.Items[i].Group = myListView.Groups[0];
                        break;
                    case "Pizza":
                        myListView.Items[i].Group = myListView.Groups[1];
                        break;
                    case "Chicken":
                        myListView.Items[i].Group = myListView.Groups[2];
                        break;
                    case "Soups":
                        myListView.Items[i].Group = myListView.Groups[3];
                        break;
                    case "Salads":
                        myListView.Items[i].Group = myListView.Groups[4];
                        break;
                    case "Beverages":
                        myListView.Items[i].Group = myListView.Groups[5];
                        break;
                    case "Desserts":
                        myListView.Items[i].Group = myListView.Groups[6];
                        break;
                    case "Indian":
                        myListView.Items[i].Group = myListView.Groups[7];
                        break;
                    case "Persian":
                        myListView.Items[i].Group = myListView.Groups[8];
                        break;
                }
            }
        }
        public static byte[] ConvertImageTOBinary(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }
        public static Image ConvertBinaryTOImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }
        }

        public string Category;
        public string Name;
        public string Ingridients;
        public string Price;
        public string Quantity;
        public byte[] Photo;
        public string PhotoURL;
        public Food(string Category, string Name, string Ingridients, string Price, string Quantity, byte[] Photo, string PhotoURL)
        {
            this.Category = Category;
            this.Name = Name;
            this.Ingridients = Ingridients;
            this.Price = Price;
            this.Quantity = Quantity;
            this.Photo = Photo;
            this.PhotoURL = PhotoURL;
        }
        public Food()
        {

        }

    }
}
