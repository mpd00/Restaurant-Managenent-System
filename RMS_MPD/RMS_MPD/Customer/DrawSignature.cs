using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RMS_MPD.Customer
{
    public partial class DrawSignature : Form
    {
        Journal log;
        List<Point> allPoints = new List<Point>();
        public Point current = new Point();
        public Point old = new Point();
        public Graphics g;
        public Pen pen;
        public Pen eraser;

        //Parameters that user can change
        Color pen_color;
        decimal pen_width;
        decimal eraser_width;
        SpecialForm Specialform;
        List<SpecialForm> allSpecialForms = new List<SpecialForm>();
        Image Specialform_IMG;

        //Useful to control pen state
        public Boolean pen_state;
        public Boolean eraser_state;
        public Boolean specialForm_enabled;
        public Boolean drawing;

        public DrawSignature()
        {
            InitializeComponent();
            g = panel1.CreateGraphics();

            //Initialisations
            pen_state = false;
            specialForm_enabled = false;
            drawing = false;

            log = new Journal();
            pen_width = 5;
            pen_color = Color.Black;
            pen = new Pen(Color.Black, (int)pen_width);
            pen.SetLineCap(System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.DashCap.Round);
            //////////////////
            pen_state = true;
            eraser_state = false;
            specialForm_enabled = false;
        }


        private void btn_save_Click(object sender, EventArgs e)
        {
            SaveSketch();
        }
        private void btn_clear_Click(object sender, EventArgs e)
        {
            allPoints = new List<Point>();
            allSpecialForms = new List<SpecialForm>();
            panel1.Invalidate();
        }
        private void SaveSketch()
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            Bitmap bitm = new Bitmap(panel1.Width, panel1.Height);
            Graphics bitGraphics = Graphics.FromImage(bitm);

            saveDialog.Filter = "Image (*.PNG)|*.PNG";


            try
            {
                //Draw all point to Graphics
                bitGraphics.DrawLines(pen, allPoints.ToArray());

                //Drawing Images to Graphics
                foreach (var item in allSpecialForms)
                {
                    bitGraphics.DrawImage(item._Image, item._Point);
                }

            utility.Generate_OrderID();
            bitm.Save($@"{Path.GetDirectoryName(Application.ExecutablePath)}\temp\{utility.OrderID}.PNG");

                ///////////////////////////Add them to database
                OrderHistory order = new OrderHistory();
                ShoppingList.FillList();
                foreach (KeyValuePair<DateTime, List<ShoppingList>> entry in ShoppingList.shoppinglistdict)
                {
                    foreach (ShoppingList shoppingList in entry.Value)
                    {
                        if (shoppingList.SocialID == utility.currentSocialID)
                        {
                            order.SocialID = shoppingList.SocialID;
                            order.Date = shoppingList.Date;
                            order.OrderDate = shoppingList.OrderDate;
                            order.Category = shoppingList.Category;
                            order.Name = shoppingList.Name;
                            order.Price = shoppingList.Price;
                            order.Quantity = shoppingList.Quantity;
                            order.Photo = shoppingList.Photo;
                            order.AccountNumber = OrderHistory.Account_Number;
                            order.Signature = Food.ConvertImageTOBinary(Image.FromFile($@"{Path.GetDirectoryName(Application.ExecutablePath)}\temp\{utility.OrderID}.PNG"));
                            order.Receipt = Food.ConvertImageTOBinary(Image.FromFile($@"{Path.GetDirectoryName(Application.ExecutablePath)}\temp\{utility.OrderID}.PNG"));
                            order.PaymentMethod = OrderHistory.Payment_Method;
                            order.Status = "Pending";
                            order.OrderID = utility.OrderID;
                            order.Discounts = OrderHistory.Discount;
                            OrderHistory.OrderHistoryList.Add(order);
                            OrderHistory.AddtoTable(order);
                        }
                    }
                }
            ////////////////////////////
            /////////////////////////////////////Delete entries from database
            var connectionString2 = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\ShoppingListDB.mdf;Integrated Security=True";
            try
            {
                using (SqlConnection con3 = new SqlConnection(connectionString2))
                {
                    con3.Open();
                    using (SqlCommand command = new SqlCommand("DELETE FROM ShoppingListTable WHERE SocialID =  '" + utility.currentSocialID + "'", con3))
                    {
                        command.ExecuteNonQuery();
                    }
                    con3.Close();
                }
            }
            catch (SystemException ex)
            {
                MessageBox.Show(string.Format("An error occurred: {0}", ex.Message));
            }
            ////////////////////////////////////
            

            Form f1 = new Customer.Receipt();
                f1.Show();
                f1.BringToFront();
                this.Hide();

            }
            catch (Exception e)
            {
                MessageBox.Show("Signature cant be empty!");
            }
        }

        private void panel1_MouseHover(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (pen_state) //crayon déjà cliqué
            {
                old = e.Location;
            }

            //About eraser
            if (eraser_state)
            {
                old = e.Location;
            }

            if (specialForm_enabled)
            {
                g.DrawImage(Specialform_IMG, e.Location);
                Specialform = new SpecialForm(Specialform_IMG, e.Location);
                //drawing = true;
            }

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (pen_state) //Pen enable
            {
                if (e.Button == MouseButtons.Left)
                {
                    Cursor.Current = Cursors.Cross;
                    current = e.Location;
                    g.DrawLine(pen, old, current);
                    old = current;

                    //Add the draw point to the list of Points
                    allPoints.Add(current);
                    drawing = true;
                }
            }

            //Eraser enable
            if (eraser_state)
            {
                if (e.Button == MouseButtons.Left)
                {
                    current = e.Location;
                    g.DrawLine(eraser, old, current);
                    old = current;

                    //Remove the eraser point from the list of points
                    allPoints.Remove(current);
                    //drawing = true;
                }
            }

            if (specialForm_enabled)
            {
                if (e.Button == MouseButtons.Left)
                {
                    g.DrawImage(Specialform_IMG, e.Location);

                    //Add the draw point to the list of SpecialForm
                    Specialform = new SpecialForm(Specialform_IMG, e.Location);
                    allSpecialForms.Add(Specialform);


                }
            }

            RefreshInformations();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
        }
        private void RefreshInformations()
        {
            if (((allPoints.Count == 0) & (allSpecialForms.Count == 0)) || (drawing = false))
            {
                label_Info.Text = "Papier vide !";
            }
            else
            {
                label_Info.Text = "Dessin en cours... ";
            }
        }
    }
    class SpecialForm
    {
        Image _image;
        Point _point;

        public Image _Image
        {
            get
            {
                return _image;
            }

            set
            {
                _image = value;
            }
        }

        public Point _Point
        {
            get
            {
                return _point;
            }
            set
            {
                _point = value;
            }
        }

        public SpecialForm(Image img, Point pnt)
        {
            _image = img;
            _point = pnt;
        }
    }
    class Journal
    {
        const string CONNECT_ACTION = "connect";
        const string DISCONNECT_ACTION = "disconnect";
        const string PIC_SAVE_ACTION = "pic_save";
        const string PRINT_ACTION = "print";

        String _separator;
        String _filePath;
        StreamWriter _writer;

        public Journal()
        {
            _separator = " --> ";
            _filePath = @"log.txt";

            //When the file does not exists, we create it and insert inside it the head
            if (!File.Exists(_filePath))
                WriteHead();
        }

        /// <summary>
        /// Insert into the log file a specific action
        /// </summary>
        /// <param name="action">The action that we want to save into the log file</param>
        public void WriteToLogFile(string action)
        {
            String data;

            switch (action)
            {
                case CONNECT_ACTION:
                    data = "Esgis_Paint started.";
                    InsertToLogFile(data);
                    break;
                case DISCONNECT_ACTION:
                    data = "Esgis_Paint closed.";
                    InsertToLogFile(data);
                    Console.WriteLine(" ");
                    break;
                default: //Nothing to do yet
                    break;
            }
        }


        /// <summary>
        /// Insert into the log file a specific action
        /// </summary>
        /// <param name="action"></param>
        /// <param name="path">The path of the file witch is saved or printed </param>
        public void WriteToLogFile(string action, string path)
        {
            String data;

            switch (action)
            {
                case PIC_SAVE_ACTION:
                    data = "Picture " + path + " saved ";
                    InsertToLogFile(data);
                    break;
                case PRINT_ACTION:
                    data = "Picture " + path + " printed ";
                    InsertToLogFile(data);
                    break;
                default:
                    break;
            }
        }

        public void openLogFile()
        {
            System.Diagnostics.Process.Start(_filePath);
        }

        /// <summary>
        /// Write the title of columns on the head of log file
        /// </summary>
        private void WriteHead()
        {
            String head = "DATE      " + " HOUR         " + "ACTION";
            String underline = "----      " + " ----         " + "------";
            try
            {
                using (_writer = new StreamWriter(_filePath, true))
                {
                    _writer.WriteLine(underline);
                    _writer.WriteLine(head);
                    _writer.WriteLine(underline);
                }
            }
            catch (Exception e)
            {
                String error_message = "Failed to write in the log file. Details : " + e;
                System.Windows.Forms.MessageBox.Show(error_message);
            }
        }

        /// <summary>
        /// Insert Line of string to the log file
        /// </summary>
        /// <param name="line"></param>
        private void InsertToLogFile(String line)
        {
            // First, we insert datetime data
            // Secondly, we add the parameter <line>

            DateTime currentTime = DateTime.Now;

            try
            {
                using (_writer = new StreamWriter(_filePath, true))
                {
                    _writer.Write(currentTime.ToString() + _separator);
                    _writer.WriteLine(line);
                }
            }
            catch (Exception e)
            {
                String error_message = "Failed to write in the log file. Details : " + e;
                System.Windows.Forms.MessageBox.Show(error_message, "ERROR !");
            }
        }
    }
}
