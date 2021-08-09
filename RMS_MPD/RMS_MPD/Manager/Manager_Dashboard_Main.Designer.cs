namespace RMS_MPD.Manager
{
    partial class Manager_Dashboard_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manager_Dashboard_Main));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel_menu = new System.Windows.Forms.Panel();
            this.button_Settings = new Bunifu.Framework.UI.BunifuFlatButton();
            this.button_Finances = new Bunifu.Framework.UI.BunifuFlatButton();
            this.button_OrderHistory = new Bunifu.Framework.UI.BunifuFlatButton();
            this.button_ChangeMenu = new Bunifu.Framework.UI.BunifuFlatButton();
            this.button_Orders = new Bunifu.Framework.UI.BunifuFlatButton();
            this.button_menu = new Bunifu.Framework.UI.BunifuImageButton();
            this.button_Home = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_Back = new Bunifu.Framework.UI.BunifuImageButton();
            this.animator1 = new BunifuAnimatorNS.Animator(this.components);
            this.panel = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.userControl_Manager_OrderHistory1 = new RMS_MPD.Manager.UserControl_Manager_OrderHistory();
            this.userControl_Manager_AccountSettings1 = new RMS_MPD.Manager.UserControl_Manager_AccountSettings();
            this.userControl_Manager_Finances1 = new RMS_MPD.Manager.UserControl_Manager_Finances();
            this.userControl_Manager_CMenu1 = new RMS_MPD.Manager.UserControl_Manager_CMenu();
            this.userControl_Manager_Orders1 = new RMS_MPD.Manager.UserControl_Manager_Orders();
            this.userControl_Manager_Home1 = new RMS_MPD.Manager.UserControl_Manager_Home();
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
            this.panel_menu.Controls.Add(this.button_Finances);
            this.panel_menu.Controls.Add(this.button_OrderHistory);
            this.panel_menu.Controls.Add(this.button_ChangeMenu);
            this.panel_menu.Controls.Add(this.button_Orders);
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
            this.button_Settings.Location = new System.Drawing.Point(-8, 872);
            this.button_Settings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Settings.Name = "button_Settings";
            this.button_Settings.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(9)))), ((int)(((byte)(135)))));
            this.button_Settings.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(6)))), ((int)(((byte)(90)))));
            this.button_Settings.OnHoverTextColor = System.Drawing.Color.White;
            this.button_Settings.selected = false;
            this.button_Settings.Size = new System.Drawing.Size(340, 98);
            this.button_Settings.TabIndex = 10;
            this.button_Settings.Textcolor = System.Drawing.Color.White;
            this.button_Settings.TextFont = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Settings.Click += new System.EventHandler(this.button_Settings_Click);
            // 
            // button_Finances
            // 
            this.button_Finances.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(6)))), ((int)(((byte)(90)))));
            this.button_Finances.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(9)))), ((int)(((byte)(135)))));
            this.button_Finances.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Finances.BorderRadius = 0;
            this.button_Finances.ButtonText = "     Finances";
            this.button_Finances.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator1.SetDecoration(this.button_Finances, BunifuAnimatorNS.DecorationType.None);
            this.button_Finances.Iconcolor = System.Drawing.Color.Transparent;
            this.button_Finances.Iconimage = global::RMS_MPD.Properties.Resources.Finance;
            this.button_Finances.Iconimage_right = null;
            this.button_Finances.Iconimage_right_Selected = null;
            this.button_Finances.Iconimage_Selected = null;
            this.button_Finances.IconZoom = 70D;
            this.button_Finances.IsTab = false;
            this.button_Finances.Location = new System.Drawing.Point(-8, 768);
            this.button_Finances.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Finances.Name = "button_Finances";
            this.button_Finances.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(9)))), ((int)(((byte)(135)))));
            this.button_Finances.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(6)))), ((int)(((byte)(90)))));
            this.button_Finances.OnHoverTextColor = System.Drawing.Color.White;
            this.button_Finances.selected = false;
            this.button_Finances.Size = new System.Drawing.Size(340, 98);
            this.button_Finances.TabIndex = 9;
            this.button_Finances.Textcolor = System.Drawing.Color.White;
            this.button_Finances.TextFont = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Finances.Click += new System.EventHandler(this.button_Finances_Click);
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
            this.button_OrderHistory.Location = new System.Drawing.Point(-9, 665);
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
            // button_ChangeMenu
            // 
            this.button_ChangeMenu.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(6)))), ((int)(((byte)(90)))));
            this.button_ChangeMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(9)))), ((int)(((byte)(135)))));
            this.button_ChangeMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_ChangeMenu.BorderRadius = 0;
            this.button_ChangeMenu.ButtonText = "     Change Menu";
            this.button_ChangeMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator1.SetDecoration(this.button_ChangeMenu, BunifuAnimatorNS.DecorationType.None);
            this.button_ChangeMenu.Iconcolor = System.Drawing.Color.Transparent;
            this.button_ChangeMenu.Iconimage = global::RMS_MPD.Properties.Resources.ChangeMenu;
            this.button_ChangeMenu.Iconimage_right = null;
            this.button_ChangeMenu.Iconimage_right_Selected = null;
            this.button_ChangeMenu.Iconimage_Selected = null;
            this.button_ChangeMenu.IconZoom = 70D;
            this.button_ChangeMenu.IsTab = false;
            this.button_ChangeMenu.Location = new System.Drawing.Point(-8, 563);
            this.button_ChangeMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_ChangeMenu.Name = "button_ChangeMenu";
            this.button_ChangeMenu.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(9)))), ((int)(((byte)(135)))));
            this.button_ChangeMenu.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(6)))), ((int)(((byte)(90)))));
            this.button_ChangeMenu.OnHoverTextColor = System.Drawing.Color.White;
            this.button_ChangeMenu.selected = false;
            this.button_ChangeMenu.Size = new System.Drawing.Size(340, 98);
            this.button_ChangeMenu.TabIndex = 7;
            this.button_ChangeMenu.Textcolor = System.Drawing.Color.White;
            this.button_ChangeMenu.TextFont = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ChangeMenu.Click += new System.EventHandler(this.button_ChangeMenu_Click);
            // 
            // button_Orders
            // 
            this.button_Orders.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(6)))), ((int)(((byte)(90)))));
            this.button_Orders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(9)))), ((int)(((byte)(135)))));
            this.button_Orders.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Orders.BorderRadius = 0;
            this.button_Orders.ButtonText = "     Orders";
            this.button_Orders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator1.SetDecoration(this.button_Orders, BunifuAnimatorNS.DecorationType.None);
            this.button_Orders.Iconcolor = System.Drawing.Color.Transparent;
            this.button_Orders.Iconimage = global::RMS_MPD.Properties.Resources.Order;
            this.button_Orders.Iconimage_right = null;
            this.button_Orders.Iconimage_right_Selected = null;
            this.button_Orders.Iconimage_Selected = null;
            this.button_Orders.IconZoom = 70D;
            this.button_Orders.IsTab = false;
            this.button_Orders.Location = new System.Drawing.Point(-9, 460);
            this.button_Orders.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Orders.Name = "button_Orders";
            this.button_Orders.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(9)))), ((int)(((byte)(135)))));
            this.button_Orders.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(6)))), ((int)(((byte)(90)))));
            this.button_Orders.OnHoverTextColor = System.Drawing.Color.White;
            this.button_Orders.selected = false;
            this.button_Orders.Size = new System.Drawing.Size(340, 98);
            this.button_Orders.TabIndex = 6;
            this.button_Orders.Textcolor = System.Drawing.Color.White;
            this.button_Orders.TextFont = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Orders.Click += new System.EventHandler(this.button_Order_Click);
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
            this.panel.Controls.Add(this.userControl_Manager_OrderHistory1);
            this.panel.Controls.Add(this.userControl_Manager_AccountSettings1);
            this.panel.Controls.Add(this.userControl_Manager_Finances1);
            this.panel.Controls.Add(this.userControl_Manager_CMenu1);
            this.panel.Controls.Add(this.userControl_Manager_Orders1);
            this.panel.Controls.Add(this.userControl_Manager_Home1);
            this.animator1.SetDecoration(this.panel, BunifuAnimatorNS.DecorationType.None);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(334, 61);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1586, 1019);
            this.panel.TabIndex = 2;
            this.panel.AutoSize = true;
            this.panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            // 
            // userControl_Manager_OrderHistory1
            // 
            this.userControl_Manager_OrderHistory1.BackColor = System.Drawing.Color.White;
            this.animator1.SetDecoration(this.userControl_Manager_OrderHistory1, BunifuAnimatorNS.DecorationType.None);
            this.userControl_Manager_OrderHistory1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl_Manager_OrderHistory1.Location = new System.Drawing.Point(0, 0);
            this.userControl_Manager_OrderHistory1.Name = "userControl_Manager_OrderHistory1";
            this.userControl_Manager_OrderHistory1.Size = new System.Drawing.Size(1586, 1019);
            this.userControl_Manager_OrderHistory1.TabIndex = 5;
            // 
            // userControl_Manager_AccountSettings1
            // 
            this.userControl_Manager_AccountSettings1.BackColor = System.Drawing.Color.White;
            this.animator1.SetDecoration(this.userControl_Manager_AccountSettings1, BunifuAnimatorNS.DecorationType.None);
            this.userControl_Manager_AccountSettings1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl_Manager_AccountSettings1.Location = new System.Drawing.Point(0, 0);
            this.userControl_Manager_AccountSettings1.Name = "userControl_Manager_AccountSettings1";
            this.userControl_Manager_AccountSettings1.Size = new System.Drawing.Size(1586, 1019);
            this.userControl_Manager_AccountSettings1.TabIndex = 4;
            // 
            // userControl_Manager_Finances1
            // 
            this.userControl_Manager_Finances1.BackColor = System.Drawing.Color.White;
            this.animator1.SetDecoration(this.userControl_Manager_Finances1, BunifuAnimatorNS.DecorationType.None);
            this.userControl_Manager_Finances1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl_Manager_Finances1.Location = new System.Drawing.Point(0, 0);
            this.userControl_Manager_Finances1.Name = "userControl_Manager_Finances1";
            this.userControl_Manager_Finances1.Size = new System.Drawing.Size(1586, 1019);
            this.userControl_Manager_Finances1.TabIndex = 3;
            // 
            // userControl_Manager_CMenu1
            // 
            this.userControl_Manager_CMenu1.BackColor = System.Drawing.Color.White;
            this.animator1.SetDecoration(this.userControl_Manager_CMenu1, BunifuAnimatorNS.DecorationType.None);
            this.userControl_Manager_CMenu1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl_Manager_CMenu1.Location = new System.Drawing.Point(0, 0);
            this.userControl_Manager_CMenu1.Name = "userControl_Manager_CMenu1";
            this.userControl_Manager_CMenu1.Size = new System.Drawing.Size(1586, 1019);
            this.userControl_Manager_CMenu1.TabIndex = 2;
            // 
            // userControl_Manager_Orders1
            // 
            this.userControl_Manager_Orders1.BackColor = System.Drawing.Color.White;
            this.animator1.SetDecoration(this.userControl_Manager_Orders1, BunifuAnimatorNS.DecorationType.None);
            this.userControl_Manager_Orders1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl_Manager_Orders1.Location = new System.Drawing.Point(0, 0);
            this.userControl_Manager_Orders1.Name = "userControl_Manager_Orders1";
            this.userControl_Manager_Orders1.Size = new System.Drawing.Size(1586, 1019);
            this.userControl_Manager_Orders1.TabIndex = 1;
            // 
            // userControl_Manager_Home1
            // 
            this.userControl_Manager_Home1.BackColor = System.Drawing.Color.White;
            this.animator1.SetDecoration(this.userControl_Manager_Home1, BunifuAnimatorNS.DecorationType.None);
            this.userControl_Manager_Home1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl_Manager_Home1.Location = new System.Drawing.Point(0, 0);
            this.userControl_Manager_Home1.Name = "userControl_Manager_Home1";
            this.userControl_Manager_Home1.Size = new System.Drawing.Size(1586, 1019);
            this.userControl_Manager_Home1.TabIndex = 0;
            // 
            // Manager_Dashboard_Main
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
            this.Name = "Manager_Dashboard_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer_Dashboard_Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Customer_Dashboard_Main_FormClosing);
            this.panel_menu.ResumeLayout(false);
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
        private Bunifu.Framework.UI.BunifuFlatButton button_ChangeMenu;
        private Bunifu.Framework.UI.BunifuFlatButton button_Orders;
        private Bunifu.Framework.UI.BunifuFlatButton button_Finances;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel;
        private Bunifu.Framework.UI.BunifuFlatButton button_Settings;
        private UserControl_Manager_Home userControl_Manager_Home1;
        private UserControl_Manager_AccountSettings userControl_Manager_AccountSettings1;
        private UserControl_Manager_Finances userControl_Manager_Finances1;
        private UserControl_Manager_CMenu userControl_Manager_CMenu1;
        private UserControl_Manager_Orders userControl_Manager_Orders1;
        private UserControl_Manager_OrderHistory userControl_Manager_OrderHistory1;
    }
}