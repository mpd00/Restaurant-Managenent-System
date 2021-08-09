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
    public partial class UserControl_Customer_OrderHistory : UserControl
    {
        #region Movement
        public void MoveRight()
        {
            foreach (Control control in this.Controls)
            {
                if (control.Name != "listView1" && control.Name != "listView2")
                {
                    int tempx = control.Location.X;
                    int tempy = control.Location.Y;
                    control.Location = new Point(tempx + 160, tempy);
                }
            }
        }
        public void MoveLeft()
        {
            foreach (Control control in this.Controls)
            {
                if (control.Name != "listView1" && control.Name != "listView2")
                {
                    int tempx = control.Location.X;
                    int tempy = control.Location.Y;
                    control.Location = new Point(tempx - 160, tempy);
                }
            }
        }
        #endregion
        public UserControl_Customer_OrderHistory()
        {
            InitializeComponent();
            RefreshData();
        }
        public void RefreshData()
        {
            listView1.Items.Clear();
            listView1.Groups.Clear();
            listView2.Items.Clear();
            listView2.Groups.Clear();
            OrderHistory.FillList();
            //////////////////////////number of orders with current social id
            List<string> OrderIDS = new List<string>();
            string tt = string.Empty;
            foreach (OrderHistory order in OrderHistory.OrderHistoryList)
            {
                if(order.SocialID == utility.currentSocialID && tt != order.OrderID)
                {
                    OrderIDS.Add(order.OrderID);
                    tt = order.OrderID;
                }
            }
            for (int i = 0; i < OrderIDS.Count; i++)
            {
                 listView1.Groups.Add(new ListViewGroup($"{OrderIDS[i]}", HorizontalAlignment.Left));
                listView2.Groups.Add(new ListViewGroup($"{OrderIDS[i]}", HorizontalAlignment.Left));
            }
            ///////////////////////////
            ///////////////////////////Calculating total for each order ID
            for (int i = 0; i < OrderIDS.Count; i++)
            {
                double Total = 0;
                foreach (OrderHistory order in OrderHistory.OrderHistoryList)
                {
                    if (order.SocialID == utility.currentSocialID && order.OrderID == OrderIDS[i])
                    {
                        if(order.Discounts == string.Empty)
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
                listView2.Items.Add(new ListViewItem(Total.ToString()));
            }
            for (int j = 0; j < OrderIDS.Count; j++)
            {
                    listView2.Items[j].Group = listView2.Groups[j];
            }
            /////////////////////////

            List<OrderHistory> TempOrders = new List<OrderHistory>();
            foreach (OrderHistory order in OrderHistory.OrderHistoryList)
            {

                if (order.SocialID == utility.currentSocialID)
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


            for(int i = 0; i < TempOrders.Count; i++)
            {
                if(TempOrders[i].SocialID == utility.currentSocialID)
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

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            string OrderID = textBox1.Text;
            OrderHistory.FillList();

            double Total = 0;
            foreach (OrderHistory order in OrderHistory.OrderHistoryList)
            {
                if (order.OrderID == OrderID)
                {
                    Total += double.Parse(order.Price) * double.Parse(order.Quantity);
                }
            }

            int c = 0;
            foreach (OrderHistory order in OrderHistory.OrderHistoryList)
            {
                if (order.OrderID == OrderID && c == 0)
                {
                    if (order.Status == "Canceled by Manager")
                    {
                        MessageBox.Show("Sorry your order has been canceled by restaurant manager");
                        c++;
                        goto z;
                    }
                    else if (order.Status == "Canceled by User")
                    {
                        MessageBox.Show("This order has been canceled before");
                        c++;
                        goto z;
                    }
                    else
                    {
                        if (order.PaymentMethod == "Online")
                        {
                            MessageBox.Show($"Your order has been canceled.\n{0.9 * Total} was successfully returned to your account with" +
                                $" Account Number of {order.AccountNumber}.\n{0.1 * Total} was deducted due to tax fee of your order.");
                        }
                        if (order.PaymentMethod == "Cash")
                        {
                            MessageBox.Show($"Your order has been canceled.\nPlease pay {0.1 * Total} tax fee of your order online.");
                        }
                    }
                    c++;
                }
                else
                {
                    continue;
                }
            }
            ////////////////update database
            var connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\OrderHistory.mdf;Integrated Security=True";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = connection.CreateCommand())
                {

                    command.CommandText = "UPDATE OrderHistoryTable SET Status = @Status Where OrderID = @OrderID ";

                    command.Parameters.AddWithValue("@Status", "Canceled by User");
                    command.Parameters.AddWithValue("@OrderID", OrderID);


                    connection.Open();

                    command.ExecuteNonQuery();

                    connection.Close();
                }
            }
            catch
            {
                MessageBox.Show("An error occured please retry");
            }
        /////////////////////
        z:;
            textBox1.Clear();
            RefreshData();
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(ListViewItem item in listView1.SelectedItems)
            {
                textBox1.Text = item.Group.Header.ToString();
            }
        }

        private void ListView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView2.SelectedItems)
            {
                textBox1.Text = item.Group.Header.ToString();
            }
        }
    }
}
