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
    public partial class UserControl_Manager_Orders : UserControl
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
        public UserControl_Manager_Orders()
        {
            InitializeComponent();
            RefreshDataAll();
        }
        public void RefreshDataAll()
        {
            listView1.Items.Clear();
            ShoppingList.FillList();
            foreach (KeyValuePair<DateTime, List<ShoppingList>> entry in ShoppingList.shoppinglistdict)
            {
                foreach (ShoppingList shoppingList in entry.Value)
                {
                        ListViewItem item = new ListViewItem(shoppingList.SocialID);
                        item.SubItems.Add(shoppingList.Category);
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
