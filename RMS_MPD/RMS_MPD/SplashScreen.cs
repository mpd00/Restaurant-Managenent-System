using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RMS_MPD
{
    public partial class SplashScreen : Form
    {
/*        List<Color> Colors = new List<Color>();
        List<Color> Colors_Button = new List<Color>();
        int currentcolor = 0;
        int a = 0;
        int b = 0;
*/
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 3;
            if (panel2.Width >= 770)
            {
                timer1.Stop();
                Form f1 = new MenuMain();
                f1.Show();
                this.Hide();
            }
        }
    }
/*
            for (int i = 20; i <= 224; i += 18)
            {
                Colors.Add(Color.FromArgb(i, 9, 104));
            }
            for (int i = 224; i >= 20; i -= 18)
            {
                Colors.Add(Color.FromArgb(i, 9, 104));
            }
            for (int i = 20; i <= 224; i += 18)
            {
                Colors.Add(Color.FromArgb(i, 9, 104));
            }
            for (int i = 224; i >= 20; i -= 18)
            {
                Colors.Add(Color.FromArgb(i, 9, 104));
            }
            for (int i = 20; i <= 224; i += 18)
            {
                Colors.Add(Color.FromArgb(i, 9, 104));
            }
            for (int i = 224; i >= 20; i -= 18)
            {
                Colors.Add(Color.FromArgb(i, 9, 104));
            }
            ///////////////////
            for (int i = 224; i >= 20; i -= 18)
            {
                Colors_Button.Add(Color.FromArgb(i, 9, 104));
            }
            for (int i = 20; i <= 224; i += 18)
            {
                Colors_Button.Add(Color.FromArgb(i, 9, 104));
            }
            for (int i = 224; i >= 20; i -= 18)
            {
                Colors_Button.Add(Color.FromArgb(i, 9, 104));
            }
            for (int i = 20; i <= 224; i += 18)
            {
                Colors_Button.Add(Color.FromArgb(i, 9, 104));
            }
            for (int i = 224; i >= 20; i -= 18)
            {
                Colors_Button.Add(Color.FromArgb(i, 9, 104));
            }
            for (int i = 20; i <= 224; i += 18)
            {
                Colors_Button.Add(Color.FromArgb(i, 9, 104));
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            if(currentcolor < Colors.Count - 1)
            {
                this.BackColor = Bunifu.Framework.UI.BunifuColorTransition.getColorScale(a,Colors[currentcolor] , Colors[currentcolor+1]);
                this.button_Manager.ForeColor = Bunifu.Framework.UI.BunifuColorTransition.getColorScale(b, Colors_Button[currentcolor], Colors_Button[currentcolor + 1]);
                this.button_Customer.ForeColor = Bunifu.Framework.UI.BunifuColorTransition.getColorScale(b, Colors_Button[currentcolor], Colors_Button[currentcolor + 1]);
                this.button3.ForeColor = Bunifu.Framework.UI.BunifuColorTransition.getColorScale(b, Colors_Button[currentcolor], Colors_Button[currentcolor + 1]);
                if (a < 100)
                {
                    a++;
                }
                else
                {
                    a = 0;
                    currentcolor++;
                }
                if (b < 100)
                {
                    a++;
                }
                else
                {
                    b = 0;
                    currentcolor++;
                }
                timer1.Enabled = true;
            }
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Customer_Click_1(object sender, EventArgs e)
        {
            Form f1 = new Customer.Customer_Login();
            f1.ShowDialog();
            this.Close();
        }
    }*/
}
