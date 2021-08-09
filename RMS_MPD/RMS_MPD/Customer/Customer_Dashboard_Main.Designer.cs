namespace RMS_MPD.Customer
{
    partial class Customer_Dashboard_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer_Dashboard_Main));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel_menu = new System.Windows.Forms.Panel();
            this.button_Settings = new Bunifu.Framework.UI.BunifuFlatButton();
            this.button_OrderHistory = new Bunifu.Framework.UI.BunifuFlatButton();
            this.button_ShoppingList = new Bunifu.Framework.UI.BunifuFlatButton();
            this.button_CompletePurchase = new Bunifu.Framework.UI.BunifuFlatButton();
            this.button_Order = new Bunifu.Framework.UI.BunifuFlatButton();
            this.button_menu = new Bunifu.Framework.UI.BunifuImageButton();
            this.button_Home = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_Back = new Bunifu.Framework.UI.BunifuImageButton();
            this.animator1 = new BunifuAnimatorNS.Animator(this.components);
            this.panel = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.userControl_AccountSettings1 = new RMS_MPD.Customer.UserControl_Customer_AccountSettings();
            this.userControl_OrderHistory1 = new RMS_MPD.Customer.UserControl_Customer_OrderHistory();
            this.userControl_ShoppingList1 = new RMS_MPD.Customer.UserControl_Customer_ShoppingList();
            this.userControl_Home1 = new RMS_MPD.Customer.UserControl_Customer_Home();
            this.userControl_Order1 = new RMS_MPD.Customer.UserControl_Customer_Order();
            this.userControl_CopmletePurchase1 = new RMS_MPD.Customer.UserControl_Customer_CopmletePurchase();
            this.panel_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.button_menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.button_Back)).BeginInit();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel_menu
            // 
            this.panel_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(9)))), ((int)(((byte)(135)))));
            this.panel_menu.Controls.Add(this.button_Settings);
            this.panel_menu.Controls.Add(this.button_OrderHistory);
            this.panel_menu.Controls.Add(this.button_ShoppingList);
            this.panel_menu.Controls.Add(this.button_CompletePurchase);
            this.panel_menu.Controls.Add(this.button_Order);
            this.panel_menu.Controls.Add(this.button_menu);
            this.panel_menu.Controls.Add(this.button_Home);
            this.panel_menu.Controls.Add(this.pictureBox1);
            this.animator1.SetDecoration(this.panel_menu, BunifuAnimatorNS.DecorationType.None);
            this.panel_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_menu.Location = new System.Drawing.Point(0, 0);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(334, 1080);
            this.panel_menu.TabIndex = 0;
            // 
            // button_Settings
            // 
            this.button_Settings.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(6)))), ((int)(((byte)(90)))));
            this.button_Settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(9)))), ((int)(((byte)(135)))));
            this.button_Settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Settings.BorderRadius = 0;
            this.button_Settings.ButtonText = "     Account Settings";
            this.button_Settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator1.SetDecoration(this.button_Settings, BunifuAnimatorNS.DecorationType.None);
            this.button_Settings.Iconcolor = System.Drawing.Color.Transparent;
            this.button_Settings.Iconimage = global::RMS_MPD.Properties.Resources.Settings;
            this.button_Settings.Iconimage_right = null;
            this.button_Settings.Iconimage_right_Selected = null;
            this.button_Settings.Iconimage_Selected = null;
            this.button_Settings.IconZoom = 70D;
            this.button_Settings.IsTab = false;
            this.button_Settings.Location = new System.Drawing.Point(-8, 866);
            this.button_Settings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Settings.Name = "button_Settings";
            this.button_Settings.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(9)))), ((int)(((byte)(135)))));
            this.button_Settings.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(6)))), ((int)(((byte)(90)))));
            this.button_Settings.OnHoverTextColor = System.Drawing.Color.White;
            this.button_Settings.selected = false;
            this.button_Settings.Size = new System.Drawing.Size(340, 98);
            this.button_Settings.TabIndex = 9;
            this.button_Settings.Textcolor = System.Drawing.Color.White;
            this.button_Settings.TextFont = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Settings.Click += new System.EventHandler(this.button_Settings_Click);
            // 
            // button_OrderHistory
            // 
            this.button_OrderHistory.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(6)))), ((int)(((byte)(90)))));
            this.button_OrderHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(9)))), ((int)(((byte)(135)))));
            this.button_OrderHistory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_OrderHistory.BorderRadius = 0;
            this.button_OrderHistory.ButtonText = "     Orders History";
            this.button_OrderHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator1.SetDecoration(this.button_OrderHistory, BunifuAnimatorNS.DecorationType.None);
            this.button_OrderHistory.Iconcolor = System.Drawing.Color.Transparent;
            this.button_OrderHistory.Iconimage = global::RMS_MPD.Properties.Resources.OrderHistory;
            this.button_OrderHistory.Iconimage_right = null;
            this.button_OrderHistory.Iconimage_right_Selected = null;
            this.button_OrderHistory.Iconimage_Selected = null;
            this.button_OrderHistory.IconZoom = 70D;
            this.button_OrderHistory.IsTab = false;
            this.button_OrderHistory.Location = new System.Drawing.Point(-9, 763);
            this.button_OrderHistory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_OrderHistory.Name = "button_OrderHistory";
            this.button_OrderHistory.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(9)))), ((int)(((byte)(135)))));
            this.button_OrderHistory.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(6)))), ((int)(((byte)(90)))));
            this.button_OrderHistory.OnHoverTextColor = System.Drawing.Color.White;
            this.button_OrderHistory.selected = false;
            this.button_OrderHistory.Size = new System.Drawing.Size(340, 98);
            this.button_OrderHistory.TabIndex = 8;
            this.button_OrderHistory.Textcolor = System.Drawing.Color.White;
            this.button_OrderHistory.TextFont = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_OrderHistory.Click += new System.EventHandler(this.button_OrderHistory_Click);
            // 
            // button_ShoppingList
            // 
            this.button_ShoppingList.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(6)))), ((int)(((byte)(90)))));
            this.button_ShoppingList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(9)))), ((int)(((byte)(135)))));
            this.button_ShoppingList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_ShoppingList.BorderRadius = 0;
            this.button_ShoppingList.ButtonText = "     Shopping List";
            this.button_ShoppingList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator1.SetDecoration(this.button_ShoppingList, BunifuAnimatorNS.DecorationType.None);
            this.button_ShoppingList.Iconcolor = System.Drawing.Color.Transparent;
            this.button_ShoppingList.Iconimage = global::RMS_MPD.Properties.Resources.ShoppingCard;
            this.button_ShoppingList.Iconimage_right = null;
            this.button_ShoppingList.Iconimage_right_Selected = null;
            this.button_ShoppingList.Iconimage_Selected = null;
            this.button_ShoppingList.IconZoom = 70D;
            this.button_ShoppingList.IsTab = false;
            this.button_ShoppingList.Location = new System.Drawing.Point(-8, 563);
            this.button_ShoppingList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_ShoppingList.Name = "button_ShoppingList";
            this.button_ShoppingList.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(9)))), ((int)(((byte)(135)))));
            this.button_ShoppingList.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(6)))), ((int)(((byte)(90)))));
            this.button_ShoppingList.OnHoverTextColor = System.Drawing.Color.White;
            this.button_ShoppingList.selected = false;
            this.button_ShoppingList.Size = new System.Drawing.Size(340, 98);
            this.button_ShoppingList.TabIndex = 7;
            this.button_ShoppingList.Textcolor = System.Drawing.Color.White;
            this.button_ShoppingList.TextFont = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ShoppingList.Click += new System.EventHandler(this.button_ShoppingList_Click);
            // 
            // button_CompletePurchase
            // 
            this.button_CompletePurchase.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(6)))), ((int)(((byte)(90)))));
            this.button_CompletePurchase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(9)))), ((int)(((byte)(135)))));
            this.button_CompletePurchase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_CompletePurchase.BorderRadius = 0;
            this.button_CompletePurchase.ButtonText = "     Payment";
            this.button_CompletePurchase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator1.SetDecoration(this.button_CompletePurchase, BunifuAnimatorNS.DecorationType.None);
            this.button_CompletePurchase.Iconcolor = System.Drawing.Color.Transparent;
            this.button_CompletePurchase.Iconimage = global::RMS_MPD.Properties.Resources.CompletePurchase;
            this.button_CompletePurchase.Iconimage_right = null;
            this.button_CompletePurchase.Iconimage_right_Selected = null;
            this.button_CompletePurchase.Iconimage_Selected = null;
            this.button_CompletePurchase.IconZoom = 70D;
            this.button_CompletePurchase.IsTab = false;
            this.button_CompletePurchase.Location = new System.Drawing.Point(-8, 665);
            this.button_CompletePurchase.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_CompletePurchase.Name = "button_CompletePurchase";
            this.button_CompletePurchase.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(9)))), ((int)(((byte)(135)))));
            this.button_CompletePurchase.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(6)))), ((int)(((byte)(90)))));
            this.button_CompletePurchase.OnHoverTextColor = System.Drawing.Color.White;
            this.button_CompletePurchase.selected = false;
            this.button_CompletePurchase.Size = new System.Drawing.Size(340, 98);
            this.button_CompletePurchase.TabIndex = 12;
            this.button_CompletePurchase.Textcolor = System.Drawing.Color.White;
            this.button_CompletePurchase.TextFont = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_CompletePurchase.Click += new System.EventHandler(this.button_CompletePurchase_Click);
            // 
            // button_Order
            // 
            this.button_Order.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(6)))), ((int)(((byte)(90)))));
            this.button_Order.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(9)))), ((int)(((byte)(135)))));
            this.button_Order.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Order.BorderRadius = 0;
            this.button_Order.ButtonText = "     Order";
            this.button_Order.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator1.SetDecoration(this.button_Order, BunifuAnimatorNS.DecorationType.None);
            this.button_Order.Iconcolor = System.Drawing.Color.Transparent;
            this.button_Order.Iconimage = global::RMS_MPD.Properties.Resources.Order;
            this.button_Order.Iconimage_right = null;
            this.button_Order.Iconimage_right_Selected = null;
            this.button_Order.Iconimage_Selected = null;
            this.button_Order.IconZoom = 70D;
            this.button_Order.IsTab = false;
            this.button_Order.Location = new System.Drawing.Point(-9, 460);
            this.button_Order.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Order.Name = "button_Order";
            this.button_Order.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(9)))), ((int)(((byte)(135)))));
            this.button_Order.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(6)))), ((int)(((byte)(90)))));
            this.button_Order.OnHoverTextColor = System.Drawing.Color.White;
            this.button_Order.selected = false;
            this.button_Order.Size = new System.Drawing.Size(340, 98);
            this.button_Order.TabIndex = 6;
            this.button_Order.Textcolor = System.Drawing.Color.White;
            this.button_Order.TextFont = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Order.Click += new System.EventHandler(this.button_Order_Click);
            // 
            // button_menu
            // 
            this.button_menu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_menu.BackColor = System.Drawing.Color.Transparent;
            this.animator1.SetDecoration(this.button_menu, BunifuAnimatorNS.DecorationType.None);
            this.button_menu.Image = global::RMS_MPD.Properties.Resources.BarsMenu;
            this.button_menu.ImageActive = null;
            this.button_menu.Location = new System.Drawing.Point(270, 10);
            this.button_menu.Name = "button_menu";
            this.button_menu.Size = new System.Drawing.Size(52, 51);
            this.button_menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.button_menu.TabIndex = 5;
            this.button_menu.TabStop = false;
            this.button_menu.Zoom = 10;
            this.button_menu.Click += new System.EventHandler(this.button_menu_Click);
            // 
            // button_Home
            // 
            this.button_Home.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(6)))), ((int)(((byte)(90)))));
            this.button_Home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(9)))), ((int)(((byte)(135)))));
            this.button_Home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Home.BorderRadius = 0;
            this.button_Home.ButtonText = "     Home";
            this.button_Home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator1.SetDecoration(this.button_Home, BunifuAnimatorNS.DecorationType.None);
            this.button_Home.Iconcolor = System.Drawing.Color.Transparent;
            this.button_Home.Iconimage = global::RMS_MPD.Properties.Resources.Home;
            this.button_Home.Iconimage_right = null;
            this.button_Home.Iconimage_right_Selected = null;
            this.button_Home.Iconimage_Selected = null;
            this.button_Home.IconZoom = 70D;
            this.button_Home.IsTab = false;
            this.button_Home.Location = new System.Drawing.Point(-8, 358);
            this.button_Home.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Home.Name = "button_Home";
            this.button_Home.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(9)))), ((int)(((byte)(135)))));
            this.button_Home.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(6)))), ((int)(((byte)(90)))));
            this.button_Home.OnHoverTextColor = System.Drawing.Color.White;
            this.button_Home.selected = false;
            this.button_Home.Size = new System.Drawing.Size(340, 98);
            this.button_Home.TabIndex = 4;
            this.button_Home.Textcolor = System.Drawing.Color.White;
            this.button_Home.TextFont = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Home.Click += new System.EventHandler(this.button_Home_Click);
            // 
            // pictureBox1
            // 
            this.animator1.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Image = global::RMS_MPD.Properties.Resources.menupic;
            this.pictureBox1.Size = new System.Drawing.Size(334, 358);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(6)))), ((int)(((byte)(90)))));
            this.panel2.Controls.Add(this.button_Back);
            this.animator1.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(334, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1586, 61);
            this.panel2.TabIndex = 1;
            // 
            // button_Back
            // 
            this.button_Back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Back.BackColor = System.Drawing.Color.Transparent;
            this.animator1.SetDecoration(this.button_Back, BunifuAnimatorNS.DecorationType.None);
            this.button_Back.Image = global::RMS_MPD.Properties.Resources.Exit;
            this.button_Back.ImageActive = null;
            this.button_Back.Location = new System.Drawing.Point(1511, 0);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(82, 65);
            this.button_Back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.button_Back.TabIndex = 6;
            this.button_Back.TabStop = false;
            this.button_Back.Zoom = 4;
            this.button_Back.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // animator1
            // 
            this.animator1.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.animator1.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 1F;
            this.animator1.DefaultAnimation = animation2;
            // 
            // panel
            // 
            this.panel.Controls.Add(this.userControl_Order1);
            this.panel.Controls.Add(this.userControl_AccountSettings1);
            this.panel.Controls.Add(this.userControl_OrderHistory1);
            this.panel.Controls.Add(this.userControl_ShoppingList1);
            this.panel.Controls.Add(this.userControl_Home1);
            this.panel.Controls.Add(this.userControl_CopmletePurchase1);
            this.animator1.SetDecoration(this.panel, BunifuAnimatorNS.DecorationType.None);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(334, 61);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1586, 1019);
            this.panel.TabIndex = 2;
            // 
            // userControl_AccountSettings1
            // 
            this.userControl_AccountSettings1.BackColor = System.Drawing.Color.White;
            this.animator1.SetDecoration(this.userControl_AccountSettings1, BunifuAnimatorNS.DecorationType.None);
            this.userControl_AccountSettings1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl_AccountSettings1.Location = new System.Drawing.Point(0, 0);
            this.userControl_AccountSettings1.Name = "userControl_AccountSettings1";
            this.userControl_AccountSettings1.Size = new System.Drawing.Size(1586, 1019);
            this.userControl_AccountSettings1.TabIndex = 4;
            // 
            // userControl_OrderHistory1
            // 
            this.userControl_OrderHistory1.BackColor = System.Drawing.Color.White;
            this.animator1.SetDecoration(this.userControl_OrderHistory1, BunifuAnimatorNS.DecorationType.None);
            this.userControl_OrderHistory1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl_OrderHistory1.Location = new System.Drawing.Point(0, 0);
            this.userControl_OrderHistory1.Name = "userControl_OrderHistory1";
            this.userControl_OrderHistory1.Size = new System.Drawing.Size(1586, 1019);
            this.userControl_OrderHistory1.TabIndex = 3;
            // 
            // userControl_ShoppingList1
            // 
            this.userControl_ShoppingList1.BackColor = System.Drawing.Color.White;
            this.animator1.SetDecoration(this.userControl_ShoppingList1, BunifuAnimatorNS.DecorationType.None);
            this.userControl_ShoppingList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl_ShoppingList1.Location = new System.Drawing.Point(0, 0);
            this.userControl_ShoppingList1.Name = "userControl_ShoppingList1";
            this.userControl_ShoppingList1.Size = new System.Drawing.Size(1586, 1019);
            this.userControl_ShoppingList1.TabIndex = 2;
            // 
            // userControl_CopmletePurchase1
            // 
            this.userControl_CopmletePurchase1.BackColor = System.Drawing.Color.White;
            this.animator1.SetDecoration(this.userControl_CopmletePurchase1, BunifuAnimatorNS.DecorationType.None);
            this.userControl_CopmletePurchase1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl_CopmletePurchase1.Location = new System.Drawing.Point(0, 0);
            this.userControl_CopmletePurchase1.Name = "userControl_CopmletePurchase1";
            this.userControl_CopmletePurchase1.Size = new System.Drawing.Size(1586, 1019);
            this.userControl_CopmletePurchase1.TabIndex = 12;
            // 
            // userControl_Home1
            // 
            this.userControl_Home1.BackColor = System.Drawing.Color.White;
            this.animator1.SetDecoration(this.userControl_Home1, BunifuAnimatorNS.DecorationType.None);
            this.userControl_Home1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl_Home1.Location = new System.Drawing.Point(0, 0);
            this.userControl_Home1.Name = "userControl_Home1";
            this.userControl_Home1.Size = new System.Drawing.Size(1586, 1019);
            this.userControl_Home1.TabIndex = 0;
            // 
            // userControl_Order1
            // 
            this.userControl_Order1.BackColor = System.Drawing.Color.White;
            this.animator1.SetDecoration(this.userControl_Order1, BunifuAnimatorNS.DecorationType.None);
            this.userControl_Order1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl_Order1.Location = new System.Drawing.Point(0, 0);
            this.userControl_Order1.Name = "userControl_Order1";
            this.userControl_Order1.Size = new System.Drawing.Size(1586, 1019);
            this.userControl_Order1.TabIndex = 1;
            // 
            // Customer_Dashboard_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel_menu);
            this.animator1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Customer_Dashboard_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer_Dashboard_Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Customer_Dashboard_Main_FormClosing);
            this.panel_menu.ResumeLayout(false);
            //this.Load += new System.EventHandler(this.Customer_Dashboard_Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.button_menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.button_Back)).EndInit();
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.Panel panel2;
        private BunifuAnimatorNS.Animator animator1;
        private Bunifu.Framework.UI.BunifuFlatButton button_Home;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuImageButton button_menu;
        private Bunifu.Framework.UI.BunifuImageButton button_Back;
        private Bunifu.Framework.UI.BunifuFlatButton button_OrderHistory;
        private Bunifu.Framework.UI.BunifuFlatButton button_ShoppingList;
        private Bunifu.Framework.UI.BunifuFlatButton button_CompletePurchase;
        private Bunifu.Framework.UI.BunifuFlatButton button_Order;
        private Bunifu.Framework.UI.BunifuFlatButton button_Settings;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel;
        private UserControl_Customer_Home userControl_Home1;
        private UserControl_Customer_Order userControl_Order1;
        private UserControl_Customer_AccountSettings userControl_AccountSettings1;
        private UserControl_Customer_OrderHistory userControl_OrderHistory1;
        private UserControl_Customer_ShoppingList userControl_ShoppingList1;
        private UserControl_Customer_CopmletePurchase userControl_CopmletePurchase1;
    }
}