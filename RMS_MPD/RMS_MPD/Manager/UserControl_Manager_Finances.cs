using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RMS_MPD.Manager
{
    public partial class UserControl_Manager_Finances : UserControl
    {
        #region Movement
        public void MoveRight()
        {
            foreach (Control control in this.Controls)
            {
                int tempx = control.Location.X;
                int tempy = control.Location.Y;
                int tempw = control.Size.Width;
                int temph = control.Size.Height;
                control.Location = new Point(tempx+15, tempy);
                control.Size = new Size(tempw + 230 , temph);
            }
        }
        public void MoveLeft()
        {
            foreach (Control control in this.Controls)
            {
                int tempx = control.Location.X;
                int tempy = control.Location.Y;
                int tempw = control.Size.Width;
                int temph = control.Size.Height;
                control.Location = new Point(tempx-15, tempy);
                control.Size = new Size(tempw - 230, temph);
            }
        }
        #endregion

        Bunifu.DataViz.WinForms.DataPoint datapoint1;
        public UserControl_Manager_Finances()
        {
            InitializeComponent();
            RefreshData();
        }
        public void RefreshData()
        {
            datapoint1 = new Bunifu.DataViz.WinForms.DataPoint(Bunifu.DataViz.WinForms.BunifuDataViz._type.Bunifu_line);
            Bunifu.DataViz.WinForms.Canvas canvas = new Bunifu.DataViz.WinForms.Canvas();

            OrderHistory.FillList();
            List<string> dates = new List<string>();
            List<double> totals = new List<double>();

            OrderHistory.OrderHistoryList = OrderHistory.OrderHistoryList.OrderBy(z => z.OrderDate).ToList();

            string t = string.Empty;
            foreach (OrderHistory orderHistory in OrderHistory.OrderHistoryList)
            {
                if (orderHistory.OrderDate != t)
                {
                    dates.Add(orderHistory.OrderDate);
                    t = orderHistory.OrderDate;
                }
            }

            for (int i = 0; i < dates.Count; i++)
            {
                double Total = 0;
                foreach (OrderHistory order in OrderHistory.OrderHistoryList)
                {
                    if (order.OrderDate == dates[i] && order.Status == "Pending")
                    {
                        //double discount = 1 - Convert.ToDouble((order.Discounts.Replace("%", string.Empty))) * 0.01;
                        //Total += double.Parse(order.Price) * double.Parse(order.Quantity) * discount;
                    }
                }
                totals.Add(Total);
            }

            bool used = false;
            DateTime x = DateTime.Today.AddDays(-10);
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < dates.Count; j++)
                {
                    if (x.ToString("yyyy-MM-dd") == dates[j])
                    {
                        datapoint1.addLabely(x.ToString("MM-dd"), totals[j]);
                        used = true;
                    }
                }
                if (used == false)
                {
                    datapoint1.addLabely($"{x.ToString("MM-dd")}", 0);
                }
                x = x.AddDays(1);
                used = false;
            }

            canvas.addData(datapoint1);
            bunifuDataViz1.Render(canvas);
        }
    }
}
