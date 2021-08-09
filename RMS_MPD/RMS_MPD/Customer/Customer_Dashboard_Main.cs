using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace RMS_MPD.Customer
{
    public partial class Customer_Dashboard_Main : Form
    {
        public Customer_Dashboard_Main()
        {
            InitializeComponent();
            _obj = this;
            this.userControl_Home1.BringToFront();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.WindowState = FormWindowState.Maximized;
        }

        private void button_menu_Click(object sender, EventArgs e)
        {
            if (panel_menu.Width == 75)
            {
                panel_menu.Visible = false;
                panel_menu.Width = 307;
                animator1.ShowSync(panel_menu);
                //////////////////////find which control is front then move its objects
                string temp = string.Empty;
                foreach (Control control in panel.Controls)
                {
                    //if (IsControlAtFront(control))
                    //{
                        temp = control.Name;
                    //}
                    switch (temp)
                    {
                        case "userControl_Home1":
                            userControl_Home1.MoveLeft();
                            break;
                        case "userControl_Order1":
                            userControl_Order1.MoveLeft();
                            break;
                        case "userControl_AccountSettings1":
                            userControl_AccountSettings1.MoveLeft();
                            break;
                        case "userControl_OrderHistory1":
                            userControl_OrderHistory1.MoveLeft();
                            break;
                        case "userControl_ShoppingList1":
                            userControl_ShoppingList1.MoveLeft();
                            break;
                        case "userControl_CopmletePurchase1":
                            userControl_CopmletePurchase1.MoveLeft();
                            break;
                    }
                }
                ////////////////////////////////
            }
            else
            {
                panel_menu.Visible = false;
                panel_menu.Width = 75;
                animator1.ShowSync(panel_menu);
                //////////////////////find which control is front then move its objects
                string temp = string.Empty;
                foreach (Control control in panel.Controls)
                {
                    //if (IsControlAtFront(control))
                    //{
                        temp = control.Name;
                    //}
                    switch (temp)
                    {
                        case "userControl_Home1":
                            userControl_Home1.MoveRight();
                            break;
                        case "userControl_Order1":
                            userControl_Order1.MoveRight();
                            break;
                        case "userControl_AccountSettings1":
                            userControl_AccountSettings1.MoveRight();
                            break;
                        case "userControl_OrderHistory1":
                            userControl_OrderHistory1.MoveRight();
                            break;
                        case "userControl_ShoppingList1":
                            userControl_ShoppingList1.MoveRight();
                            break;
                        case "userControl_CopmletePurchase1":
                            userControl_CopmletePurchase1.MoveRight();
                            break;
                    }
                }
                ////////////////////////////////
            }
            
        }
        private bool IsControlAtFront(Control control)
        {
            return control.Parent.Controls.GetChildIndex(control) == 0;
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f1 = new MenuMain();
            f1.ShowDialog();
        }

        private void button_Home_Click(object sender, EventArgs e)
        {
            this.userControl_Home1.RefreshData();
            this.userControl_Home1.Visible = true;
            this.userControl_Home1.BringToFront();
        }

        private void button_Order_Click(object sender, EventArgs e)
        {
            this.userControl_Order1.RefreshData();
            this.userControl_Order1.Visible = true;
            this.userControl_Order1.BringToFront();
        }

        private void Customer_Dashboard_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (var process in Process.GetProcessesByName("RMS_MPD"))
            {
                process.Kill();
            }
            foreach (var process in Process.GetProcessesByName("Customer_Signup"))
            {
                process.Kill();
            }
        }

        private void button_ShoppingList_Click(object sender, EventArgs e)
        {
            this.userControl_ShoppingList1.RefreshData();
            this.userControl_ShoppingList1.BringToFront();
        }
        private void button_CompletePurchase_Click(object sender, EventArgs e)
        {
            this.userControl_CopmletePurchase1.Visible = true;
            this.userControl_CopmletePurchase1.BringToFront();
            this.userControl_CopmletePurchase1.FirstEnterance();
        }

        private void button_OrderHistory_Click(object sender, EventArgs e)
        {
            this.userControl_OrderHistory1.RefreshData();
            this.userControl_OrderHistory1.BringToFront();
        }

        private void button_Settings_Click(object sender, EventArgs e)
        {
            this.userControl_AccountSettings1.BringToFront();
        }
        static Customer_Dashboard_Main _obj;
        public static Customer_Dashboard_Main Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new Customer_Dashboard_Main();
                }
                return _obj;
            }
        }
        public Panel PnlContainer
        {
            get
            {
                return panel;
            }
            set
            {
                panel = value;
            }
        }
/*        private void Customer_Dashboard_Main_Load(object sender, EventArgs e)
        {
            _obj = this;

        }*/


    }
}
