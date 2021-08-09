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
using System.Drawing.Imaging;
using System.IO;

namespace RMS_MPD.Customer
{
    public partial class Receipt : Form
    {
        List<ShoppingList> Temp = new List<ShoppingList>();
        public Receipt()
        {
            InitializeComponent();
            label_Total.Text = CalculateTotal() + "$";
            pictureBox1.Image = Image.FromFile($@"{Path.GetDirectoryName(Application.ExecutablePath)}\temp\{utility.OrderID}.PNG");
            RefreshData();
        }
        public void RefreshData()
        {
            listView1.Items.Clear();
            listView1.Groups.Clear();
            OrderHistory.FillList();
            //////////////////////////number of orders with current social id
            List<string> OrderIDS = new List<string>();
            string tt = string.Empty;
            foreach (OrderHistory order in OrderHistory.OrderHistoryList)
            {
                if (order.SocialID == utility.currentSocialID && tt != order.OrderID)
                {
                    OrderIDS.Add(order.OrderID);
                    tt = order.OrderID;
                }
            }
            for (int i = 0; i < OrderIDS.Count; i++)
            {
                listView1.Groups.Add(new ListViewGroup($"{OrderIDS[i]}", HorizontalAlignment.Left));
            }
            ///////////////////////////

            List<OrderHistory> TempOrders = new List<OrderHistory>();
            foreach (OrderHistory order in OrderHistory.OrderHistoryList)
            {

                if (order.SocialID == utility.currentSocialID && order.OrderID == utility.OrderID)
                {
                    ListViewItem item = new ListViewItem(order.Category);
                    item.SubItems.Add(order.Name);
                    item.SubItems.Add(order.Price);
                    item.SubItems.Add(order.Quantity);
                    item.SubItems.Add(order.OrderDate);
                    item.SubItems.Add(order.OrderID);
                    item.SubItems.Add(order.PaymentMethod);
                    item.SubItems.Add(order.Status);
                    listView1.Items.Add(item);
                    TempOrders.Add(order);
                }
            }


            for (int i = 0; i < TempOrders.Count; i++)
            {
                if (TempOrders[i].SocialID == utility.currentSocialID)
                {
                    for (int j = 0; j < OrderIDS.Count; j++)
                    {
                        if (OrderIDS[j] == TempOrders[i].OrderID)
                        {
                            listView1.Items[i].Group = listView1.Groups[j];
                        }
                    }
                }
            }
        }
        public double CalculateTotal()
        {
            OrderHistory.FillList();
            double Total = 0;
            foreach (OrderHistory order in OrderHistory.OrderHistoryList)
            {
                if (order.SocialID == utility.currentSocialID && order.OrderID == utility.OrderID)
                {
                    if (order.Discounts == string.Empty)
                    {
                        Total += double.Parse(order.Price) * double.Parse(order.Quantity);
                    }
                    else
                    {
                        double discount = 1 - Convert.ToDouble((order.Discounts.Replace("%", string.Empty))) * 0.01;
                        Total += double.Parse(order.Price) * double.Parse(order.Quantity) * discount;
                    }
                }
            }
            return Total;
        }

        private void Button_SaveImage_Click(object sender, EventArgs e)
        {
            int width = panel1.Size.Width;
            int height = panel1.Size.Height;
            Bitmap bm = new Bitmap(width, height);
            panel1.DrawToBitmap(bm, new Rectangle(0, 0, width, height));
            try
            {
                SaveFileDialog sf = new SaveFileDialog();
                sf.Filter = "Bitmap Image (.bmp)|*.bmp|Gif Image (.gif)|*.gif|JPEG Image (.jpeg)|*.jpeg|Png Image (.png)|*.png|Tiff Image (.tiff)|*.tiff|Wmf Image (.wmf)|*.wmf";
                sf.ShowDialog();
                var path = sf.FileName;
                bm.Save(path, ImageFormat.Jpeg);
            }
            catch { }
        }

        private void BunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
