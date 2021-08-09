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

namespace RMS_MPD
{
    public partial class MenuMain : Form
    {
        public MenuMain()
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.WindowState = FormWindowState.Maximized;
            this.BringToFront();
        }

        private void button_Customer_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f1 = new Customer.Customer_Login();
            f1.ShowDialog();
        }
        private void button_Manager_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f2 = new Manager.Manager_Login();
            f2.ShowDialog();
        }
        private void button_Exit_Click(object sender, EventArgs e)
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

        private void Button_telegram_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://t.me/mpd00");
        }

        private void Button_github_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/mpd00");
        }
    }
}
