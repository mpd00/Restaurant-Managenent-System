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
    class ShoppingList
    {
        public static Dictionary<DateTime, List<ShoppingList>> shoppinglistdict = new Dictionary<DateTime, List<ShoppingList>>();
        public static void IntializeShoppingListDictionary()
        {
            if (shoppinglistdict.Count == 0)
            {
                DateTime x = DateTime.Today;
                for (int i = 0; i < 30; i++)
                {
                    shoppinglistdict.Add(x, new List<ShoppingList>());
                    x = x.AddDays(1);
                }
            }
        }


        //public static List<ShoppingList> ShoppingL_List = new List<ShoppingList>();
        public string SocialID;
        public string Date;
        public string OrderDate;
        public string Category;
        public string Name;
        public string Price;
        public string Quantity;
        public byte[] Photo;
        public ShoppingList(string SocialID, string Date, string OrderDate, string Category, string Name, string Price, string Quantity, byte[] Photo)
        {
            this.SocialID = SocialID;
            this.Date = Date;
            this.OrderDate = OrderDate;
            this.Category = Category;
            this.Name = Name;
            this.Price = Price;
            this.Quantity = Quantity;
            this.Photo = Photo;
        }
        public ShoppingList()
        {
            
        }
        public static void FillList()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\ShoppingListDB.mdf;Integrated Security=True");
            string sql = "select * from ShoppingListTable";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();

            shoppinglistdict.Clear();
            IntializeShoppingListDictionary();

            while (dr.Read())
            {
                ShoppingList shoppingList = new ShoppingList();
                foreach (KeyValuePair<DateTime, List<ShoppingList>> entry in shoppinglistdict)
                {
                    if(dr["OrderDate"].ToString() == entry.Key.ToString("yyyy-MM-dd"))
                    {
                        shoppingList.SocialID = dr["SocialID"].ToString();
                        shoppingList.Date = dr["Date"].ToString();
                        shoppingList.OrderDate = dr["OrderDate"].ToString();
                        shoppingList.Category = dr["Category"].ToString();
                        shoppingList.Name = dr["Name"].ToString();
                        shoppingList.Price = dr["Price"].ToString();
                        shoppingList.Quantity = dr["Quantity"].ToString();
                        shoppingList.Photo = (byte[])dr["Photo"];

                        entry.Value.Add(shoppingList);
                    }
                }
            }
            con.Close();
        }
        public static void Fill_ListView(ListView myListView, List<ShoppingList> List)
        {
            //System.Threading.SynchronizationContext.Current.Post(o => myImageList1.Images.Clear(), null);
            myListView.Items.Clear();
            //Take imagelist for store images to use in listview.
            ImageList myImageList1 = new ImageList();
            //set the image size of which size images will be displayed in the listview.
            myImageList1.ImageSize = new Size(194, 194);

            //Now add the images into the imageList..

            for (int i = 0; i < List.Count; i++)
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
    }
}
