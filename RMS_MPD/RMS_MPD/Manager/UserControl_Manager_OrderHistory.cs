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
    public partial class UserControl_Manager_OrderHistory : UserControl
    {
        #region Movement
        public void MoveRight()
        {
            foreach (Control control in this.Controls)
            {
                if (control.Name != "listView1")
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
                if (control.Name != "listView1")
                {
                    int tempx = control.Location.X;
                    int tempy = control.Location.Y;
                    control.Location = new Point(tempx - 160, tempy);
                }
            }
        }
        #endregion
        public UserControl_Manager_OrderHistory()
        {
            InitializeComponent();
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
                if (tt != order.OrderID)
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
                ListViewItem item = new ListViewItem(order.SocialID);
                //item.SubItems.Add(order.Category);
                item.SubItems.Add(order.Name);
                item.SubItems.Add(order.Price);
                item.SubItems.Add(order.Quantity);
                item.SubItems.Add(order.OrderDate);
                item.SubItems.Add(order.OrderID);
                item.SubItems.Add(order.PaymentMethod);
                item.SubItems.Add(order.Status);
                item.SubItems.Add(order.Discounts);
                try
                {
                    item.SubItems.Add($"{24 - int.Parse(order.Discounts.Replace("%", string.Empty))}");
                }
                catch { }
                listView1.Items.Add(item);
                TempOrders.Add(order);
            }

            for (int i = 0; i < TempOrders.Count; i++)
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
        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                textBox1.Text = item.Group.Header.ToString();
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
                    MessageBox.Show($"All {Total} will be paid back to user");
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

                    command.Parameters.AddWithValue("@Status", "Canceled by Manager");
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

            textBox1.Clear();
            RefreshData();
        }
    }
}
