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
    class FoodCalender
    {
        public static Dictionary<DateTime, List<Food>> datedict = new Dictionary<DateTime, List<Food>>();
        public static void IntializeCalenderDictionary()
        {
            if (datedict.Count == 0)
            {
                DateTime x = DateTime.Today;
                for (int i = 0; i < 30; i++)
                {
                    datedict.Add(x, new List<Food>());
                    x = x.AddDays(1);
                }
            }
        }
        public static void AddtoTable(string Date, string Category, string Name, string Ingridients, string Price, string  Quantity, byte[] Photo, string PhotoURL)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\FoodCalenderDB.mdf;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("insert into CalenderFoodTable (Date,Category,Name,Ingridients,Price,Quantity,Photo,PhotoURL) values (@Date,@Category,@Name,@Ingridients,@Price,@Quantity,@Photo,@PhotoURL)", con);
            cmd.Parameters.AddWithValue("@Date", Date);
            cmd.Parameters.AddWithValue("@Category", Category);
            cmd.Parameters.AddWithValue("@Name", Name);
            cmd.Parameters.AddWithValue("@Ingridients", Ingridients);
            cmd.Parameters.AddWithValue("@Price", Price);
            cmd.Parameters.AddWithValue("@Quantity", Quantity);
            cmd.Parameters.AddWithValue("@Photo", Photo);
            cmd.Parameters.AddWithValue("@PhotoURL", PhotoURL);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public static void FillList()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\FoodCalenderDB.mdf;Integrated Security=True");
            string sql = "select * from CalenderFoodTable";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();

            datedict.Clear();
            IntializeCalenderDictionary();

            while (dr.Read())
            {
                string tempdate = dr["Date"].ToString();
                DateTime oDate = DateTime.Parse(tempdate);

                Food food = new Food();
                food.Category = dr["Category"].ToString();
                food.Name = dr["Name"].ToString();
                food.Ingridients = dr["Ingridients"].ToString();
                food.Price = dr["Price"].ToString();
                food.Quantity = dr["Quantity"].ToString();
                food.Photo = (byte[])dr["Photo"];
                food.PhotoURL = dr["PhotoURL"].ToString();


                foreach (KeyValuePair<DateTime, List<Food>> entry in datedict)
                {
                    if(entry.Key == oDate)
                    {
                        entry.Value.Add(food);
                    }
                }
            }
            con.Close();
        }


    }
}
