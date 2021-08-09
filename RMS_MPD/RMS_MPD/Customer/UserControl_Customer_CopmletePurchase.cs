using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;


namespace RMS_MPD.Customer
{
    public partial class UserControl_Customer_CopmletePurchase : UserControl
    {
        #region Movement
        public void MoveRight()
        {
            foreach (Control control in this.Controls)
            {
                if(control.Name != "listView1")
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

        string paymnetM = "Cash";
        public UserControl_Customer_CopmletePurchase()
        {
            InitializeComponent();
            Calendar_Order.Value = DateTime.Today;
            Calendar_Order.MinDate = DateTime.Now;
            Calendar_Order.MaxDate = DateTime.Now.AddDays(29);
            CalculateTotal();
            Calendar_Order.Enabled = false;
            radioButton2.Checked = true;
            RefreshDataAll();
            textBox1.Enabled = false;
        }

        private void Calendar_Order_onValueChanged(object sender, EventArgs e)
        {
            RefreshDataCalender();
        }
        public void CalculateTotal()
        {
            double Total = 0;
            ShoppingList.FillList();
            foreach (KeyValuePair<DateTime, List<ShoppingList>> entry in ShoppingList.shoppinglistdict)
            {
                foreach (ShoppingList shoppingList in entry.Value)
                {
                    if (shoppingList.SocialID == utility.currentSocialID)
                    {
                        Total += double.Parse(shoppingList.Price) * double.Parse(shoppingList.Quantity);
                    }
                }
            }
            textBox_price.Text = Total.ToString();
        }
        public void RefreshDataCalender()
        {
            listView1.Items.Clear();
            ShoppingList.FillList();
            foreach (KeyValuePair<DateTime, List<ShoppingList>> entry in ShoppingList.shoppinglistdict)
            {
                if (Calendar_Order.Value.ToString("yyyy-MM-dd") == entry.Key.ToString("yyyy-MM-dd"))
                {
                    foreach (ShoppingList shoppingList in entry.Value)
                    {
                        if (shoppingList.SocialID == utility.currentSocialID)
                        {
                            ListViewItem item = new ListViewItem(shoppingList.Category);
                            item.SubItems.Add(shoppingList.Name);
                            item.SubItems.Add(shoppingList.Price);
                            item.SubItems.Add(shoppingList.Quantity);
                            item.SubItems.Add(shoppingList.OrderDate);
                            listView1.Items.Add(item);
                        }
                    }
                }
            }
        }
        public void RefreshDataAll()
        {
            listView1.Items.Clear();
            ShoppingList.FillList();
            foreach (KeyValuePair<DateTime, List<ShoppingList>> entry in ShoppingList.shoppinglistdict)
            {
                foreach (ShoppingList shoppingList in entry.Value)
                {
                    if (shoppingList.SocialID == utility.currentSocialID)
                    {
                        ListViewItem item = new ListViewItem(shoppingList.Category);
                        item.SubItems.Add(shoppingList.Name);
                        item.SubItems.Add(shoppingList.Price);
                        item.SubItems.Add(shoppingList.Quantity);
                        item.SubItems.Add(shoppingList.OrderDate);
                        listView1.Items.Add(item);
                    }
                }
            }
        }
        public void FirstEnterance()
        {
            CalculateTotal();
            if (radioButton1.Checked)
            {
                RefreshDataCalender();
            }
            if (radioButton2.Checked)
            {
                RefreshDataAll();
            }
        }
        private void button_back_Click(object sender, EventArgs e)
        {
            if (!Customer_Dashboard_Main.Instance.PnlContainer.Controls.ContainsKey("UserControl_Customer_ShoppingList"))
            {
                UserControl_Customer_ShoppingList un = new UserControl_Customer_ShoppingList();
                un.Dock = DockStyle.Fill;
                un.RefreshData();
                Customer_Dashboard_Main.Instance.PnlContainer.Controls.Add(un);
            }
            Customer_Dashboard_Main.Instance.PnlContainer.Controls["UserControl_Customer_ShoppingList"].BringToFront();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Calendar_Order.Enabled = false;
            RefreshDataAll();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Calendar_Order.Enabled = true;
            RefreshDataCalender();
        }

        private void Button_CompletePurchase_Click(object sender, EventArgs e)
        {
            if (double.Parse(textBox_price.Text) == 0)
            {
                MessageBox.Show("Your Shopping List is empty!");
                goto x;
            }
            if (paymnetM == "Online")
            {
                if(textBox1.Text == string.Empty)
                {
                    MessageBox.Show("Enter your account number please!");
                    goto x;
                }
                else
                {
                    try
                    {
                        double.Parse(textBox1.Text);
                        MessageBox.Show($"{textBox_price.Text}$ will be paid from your account!");
                    }
                    catch
                    {
                        MessageBox.Show("Account Number was entered in a wrong format Retry!");
                        textBox1.Clear();
                        goto x;
                    }
                }
            }
            else
            {
                MessageBox.Show($"{textBox_price.Text}$ will be paid by cash later!");
            }

            OrderHistory.Account_Number = textBox1.Text;
            OrderHistory.Payment_Method = paymnetM;

            listView1.Items.Clear();
            label_discount.Visible = false;
            textBox_discount.Clear();
            textBox1.Clear();

            Form form1 = new Customer.DrawSignature();
            form1.Show();
            form1.BringToFront();
        x:;
        }

        private void BunifuFlatButton1_Click(object sender, EventArgs e)
        {
            paymnetM = "Cash";
            textBox1.Enabled = false;
        }

        private void Button_paypal_Click(object sender, EventArgs e)
        {
            paymnetM = "Online";
            textBox1.Enabled = true;
            MessageBox.Show("Enter your Account Number");
        }

        private void Button_MansterCard_Click(object sender, EventArgs e)
        {
            paymnetM = "Online";
            textBox1.Enabled = true;
            MessageBox.Show("Enter your Account Number");

        }

        private void Button_Bitcoin_Click(object sender, EventArgs e)
        {
            paymnetM = "Online";
            textBox1.Enabled = true;
            MessageBox.Show("Enter your Account Number");
        }

        private void Button_ApplyDiscount_Click(object sender, EventArgs e)
        {
            //////////////////////////number of orders with current social id
            OrderHistory.FillList();
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
            /////////////////////////////
            if (textBox_discount.Text == "Welcome_First_MPD" && OrderIDS.Count == 0 && textBox_discount.Text != string.Empty)
            {
                MessageBox.Show("5% Discount was applied on your first order");
                label_discount.Text = "5%";
                label_discount.Visible = true;
                OrderHistory.Discount = "5%";
                textBox_price.Text = (Convert.ToDouble(textBox_price.Text) * 0.95).ToString();
            }
            if (textBox_discount.Text == "Welcome_Second_MPD" && OrderIDS.Count == 1 && textBox_discount.Text != string.Empty)
            {
                MessageBox.Show("10% Discount was applied on your second order");
                label_discount.Text = "10%";
                label_discount.Visible = true;
                OrderHistory.Discount = "10%";
                textBox_price.Text = (Convert.ToDouble(textBox_price.Text) * 0.90).ToString();
            }

        }
    }
}
