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

namespace RMS_MPD.Manager
{
    public partial class Manager_Dashboard_Main : Form
    {
        public Manager_Dashboard_Main()
        {
            InitializeComponent();
            this.userControl_Manager_Home1.BringToFront();
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
                        case "userControl_Manager_Home1":
                            userControl_Manager_Home1.MoveLeft();
                            break;
                        case "userControl_Manager_AccountSettings1":
                            userControl_Manager_AccountSettings1.MoveLeft();
                            break;
                        case "userControl_Manager_Finances1":
                            userControl_Manager_Finances1.MoveLeft();
                            break;
                        case "userControl_Manager_CMenu1":
                            userControl_Manager_CMenu1.MoveLeft();
                            break;
                        case "userControl_Manager_Orders1":
                            userControl_Manager_Orders1.MoveLeft();
                            break;
                        case "userControl_Manager_OrderHistory1":
                            userControl_Manager_OrderHistory1.MoveLeft();
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
                        case "userControl_Manager_Home1":
                            userControl_Manager_Home1.MoveRight();
                            break;
                        case "userControl_Manager_AccountSettings1":
                            userControl_Manager_AccountSettings1.MoveRight();
                            break;
                        case "userControl_Manager_Finances1":
                            userControl_Manager_Finances1.MoveRight();
                            break;
                        case "userControl_Manager_CMenu1":
                            userControl_Manager_CMenu1.MoveRight();
                            break;
                        case "userControl_Manager_Orders1":
                            userControl_Manager_Orders1.MoveRight();
                            break;
                        case "userControl_Manager_OrderHistory1":
                            userControl_Manager_OrderHistory1.MoveRight();
                            break;
                    }
                }
                ////////////////////////////////
            }
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f1 = new MenuMain();
            f1.ShowDialog();
        }

        private void button_Home_Click(object sender, EventArgs e)
        {
            this.userControl_Manager_Home1.BringToFront();
            this.userControl_Manager_Home1.RefreshData();
        }

        private void button_Order_Click(object sender, EventArgs e)
        {
            this.userControl_Manager_Orders1.BringToFront();
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


        private void button_OrderHistory_Click(object sender, EventArgs e)
        {
            this.userControl_Manager_OrderHistory1.BringToFront();
        }

        private void button_Settings_Click(object sender, EventArgs e)
        {
            this.userControl_Manager_AccountSettings1.BringToFront();
        }

        private void button_ChangeMenu_Click(object sender, EventArgs e)
        {
            this.userControl_Manager_CMenu1.BringToFront();
        }

        private void button_Finances_Click(object sender, EventArgs e)
        {
            this.userControl_Manager_Finances1.BringToFront();
            this.userControl_Manager_Finances1.RefreshData();
        }
    }
}
