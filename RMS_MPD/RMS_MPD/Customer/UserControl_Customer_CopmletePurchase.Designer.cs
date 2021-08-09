namespace RMS_MPD.Customer
{
    partial class UserControl_Customer_CopmletePurchase
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            this.Calendar_Order = new System.Windows.Forms.DateTimePicker();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.button_paypal = new System.Windows.Forms.Button();
            this.textBox_discount = new System.Windows.Forms.TextBox();
            this.button_ApplyDiscount = new Bunifu.Framework.UI.BunifuFlatButton();
            this.textBox_price = new System.Windows.Forms.TextBox();
            this.button_MansterCard = new System.Windows.Forms.Button();
            this.button_Bitcoin = new System.Windows.Forms.Button();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_CompletePurchase = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label_discount = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Bookman Old Style", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(1125, 494);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(404, 29);
            label1.TabIndex = 178;
            label1.Text = "Choose Your Payment Method";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("Bookman Old Style", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(1137, 234);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(350, 29);
            label2.TabIndex = 183;
            label2.Text = "Enter your discount code:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.Font = new System.Drawing.Font("Bookman Old Style", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.ForeColor = System.Drawing.Color.Navy;
            label3.Location = new System.Drawing.Point(1180, 68);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(244, 38);
            label3.TabIndex = 176;
            label3.Text = "Your Total is:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.Transparent;
            label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            label4.ForeColor = System.Drawing.Color.Navy;
            label4.Location = new System.Drawing.Point(1240, 770);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(184, 23);
            label4.TabIndex = 189;
            label4.Text = "Account Number:";
            // 
            // Calendar_Order
            // 
            this.Calendar_Order.Checked = false;
            this.Calendar_Order.Enabled = false;
            this.Calendar_Order.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calendar_Order.Location = new System.Drawing.Point(85, 49);
            this.Calendar_Order.Name = "Calendar_Order";
            this.Calendar_Order.Size = new System.Drawing.Size(404, 35);
            this.Calendar_Order.TabIndex = 140;
            this.Calendar_Order.TabStop = false;
            this.Calendar_Order.ValueChanged += new System.EventHandler(this.Calendar_Order_onValueChanged);
            // 
            // listView1
            // 
            this.listView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(23, 129);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(991, 798);
            this.listView1.TabIndex = 173;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Category";
            this.columnHeader1.Width = 192;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 233;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Price";
            this.columnHeader8.Width = 188;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Quantity";
            this.columnHeader9.Width = 181;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Delivery Date";
            this.columnHeader10.Width = 192;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.radioButton1.ForeColor = System.Drawing.Color.White;
            this.radioButton1.Location = new System.Drawing.Point(543, 49);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(238, 32);
            this.radioButton1.TabIndex = 174;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Choose from Calendar";
            this.radioButton1.UseVisualStyleBackColor = false;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.Transparent;
            this.radioButton2.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.radioButton2.ForeColor = System.Drawing.Color.White;
            this.radioButton2.Location = new System.Drawing.Point(818, 49);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(114, 32);
            this.radioButton2.TabIndex = 175;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "All dates";
            this.radioButton2.UseVisualStyleBackColor = false;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // button_paypal
            // 
            this.button_paypal.BackColor = System.Drawing.Color.Transparent;
            this.button_paypal.BackgroundImage = global::RMS_MPD.Properties.Resources.PayPal;
            this.button_paypal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_paypal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_paypal.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button_paypal.FlatAppearance.BorderSize = 0;
            this.button_paypal.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button_paypal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_paypal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_paypal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_paypal.Location = new System.Drawing.Point(1174, 566);
            this.button_paypal.Name = "button_paypal";
            this.button_paypal.Size = new System.Drawing.Size(74, 84);
            this.button_paypal.TabIndex = 181;
            this.button_paypal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_paypal.UseVisualStyleBackColor = false;
            this.button_paypal.Click += new System.EventHandler(this.Button_paypal_Click);
            // 
            // textBox_discount
            // 
            this.textBox_discount.BackColor = System.Drawing.Color.White;
            this.textBox_discount.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.textBox_discount.Location = new System.Drawing.Point(1167, 306);
            this.textBox_discount.Multiline = true;
            this.textBox_discount.Name = "textBox_discount";
            this.textBox_discount.Size = new System.Drawing.Size(302, 38);
            this.textBox_discount.TabIndex = 182;
            // 
            // button_ApplyDiscount
            // 
            this.button_ApplyDiscount.Activecolor = System.Drawing.Color.DarkSlateBlue;
            this.button_ApplyDiscount.BackColor = System.Drawing.Color.Navy;
            this.button_ApplyDiscount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_ApplyDiscount.BorderRadius = 30;
            this.button_ApplyDiscount.ButtonText = "      Apply Discount";
            this.button_ApplyDiscount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_ApplyDiscount.Font = new System.Drawing.Font("Century Gothic", 3F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ApplyDiscount.Iconcolor = System.Drawing.Color.Transparent;
            this.button_ApplyDiscount.Iconimage = global::RMS_MPD.Properties.Resources.percent;
            this.button_ApplyDiscount.Iconimage_right = null;
            this.button_ApplyDiscount.Iconimage_right_Selected = null;
            this.button_ApplyDiscount.Iconimage_Selected = null;
            this.button_ApplyDiscount.IconZoom = 140D;
            this.button_ApplyDiscount.IsTab = false;
            this.button_ApplyDiscount.Location = new System.Drawing.Point(1187, 388);
            this.button_ApplyDiscount.Margin = new System.Windows.Forms.Padding(4);
            this.button_ApplyDiscount.Name = "button_ApplyDiscount";
            this.button_ApplyDiscount.Normalcolor = System.Drawing.Color.Navy;
            this.button_ApplyDiscount.OnHovercolor = System.Drawing.Color.MediumBlue;
            this.button_ApplyDiscount.OnHoverTextColor = System.Drawing.Color.White;
            this.button_ApplyDiscount.selected = false;
            this.button_ApplyDiscount.Size = new System.Drawing.Size(255, 53);
            this.button_ApplyDiscount.TabIndex = 184;
            this.button_ApplyDiscount.Textcolor = System.Drawing.Color.White;
            this.button_ApplyDiscount.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ApplyDiscount.Click += new System.EventHandler(this.Button_ApplyDiscount_Click);
            // 
            // textBox_price
            // 
            this.textBox_price.BackColor = System.Drawing.Color.White;
            this.textBox_price.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.textBox_price.Location = new System.Drawing.Point(1242, 128);
            this.textBox_price.Multiline = true;
            this.textBox_price.Name = "textBox_price";
            this.textBox_price.ReadOnly = true;
            this.textBox_price.Size = new System.Drawing.Size(137, 38);
            this.textBox_price.TabIndex = 177;
            // 
            // button_MansterCard
            // 
            this.button_MansterCard.BackColor = System.Drawing.Color.Transparent;
            this.button_MansterCard.BackgroundImage = global::RMS_MPD.Properties.Resources.MasterCard;
            this.button_MansterCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_MansterCard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_MansterCard.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button_MansterCard.FlatAppearance.BorderSize = 0;
            this.button_MansterCard.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button_MansterCard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_MansterCard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_MansterCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_MansterCard.Location = new System.Drawing.Point(1296, 566);
            this.button_MansterCard.Name = "button_MansterCard";
            this.button_MansterCard.Size = new System.Drawing.Size(74, 84);
            this.button_MansterCard.TabIndex = 185;
            this.button_MansterCard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_MansterCard.UseVisualStyleBackColor = false;
            this.button_MansterCard.Click += new System.EventHandler(this.Button_MansterCard_Click);
            // 
            // button_Bitcoin
            // 
            this.button_Bitcoin.BackColor = System.Drawing.Color.Transparent;
            this.button_Bitcoin.BackgroundImage = global::RMS_MPD.Properties.Resources.Bitcoin;
            this.button_Bitcoin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Bitcoin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Bitcoin.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button_Bitcoin.FlatAppearance.BorderSize = 0;
            this.button_Bitcoin.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button_Bitcoin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_Bitcoin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_Bitcoin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Bitcoin.Location = new System.Drawing.Point(1418, 566);
            this.button_Bitcoin.Name = "button_Bitcoin";
            this.button_Bitcoin.Size = new System.Drawing.Size(74, 84);
            this.button_Bitcoin.TabIndex = 186;
            this.button_Bitcoin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_Bitcoin.UseVisualStyleBackColor = false;
            this.button_Bitcoin.Click += new System.EventHandler(this.Button_Bitcoin_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.LimeGreen;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.DarkGreen;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 30;
            this.bunifuFlatButton1.ButtonText = "           Pay in Cash";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.Font = new System.Drawing.Font("Century Gothic", 3F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = null;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconZoom = 70D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(1207, 677);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.DarkGreen;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.Green;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(245, 53);
            this.bunifuFlatButton1.TabIndex = 187;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.BunifuFlatButton1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.textBox1.Location = new System.Drawing.Point(1154, 810);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(345, 38);
            this.textBox1.TabIndex = 188;
            // 
            // button_CompletePurchase
            // 
            this.button_CompletePurchase.Activecolor = System.Drawing.Color.IndianRed;
            this.button_CompletePurchase.BackColor = System.Drawing.Color.Firebrick;
            this.button_CompletePurchase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_CompletePurchase.BorderRadius = 30;
            this.button_CompletePurchase.ButtonText = "         Finish Payment";
            this.button_CompletePurchase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_CompletePurchase.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_CompletePurchase.Iconcolor = System.Drawing.Color.Transparent;
            this.button_CompletePurchase.Iconimage = global::RMS_MPD.Properties.Resources.ShoppingCard;
            this.button_CompletePurchase.Iconimage_right = null;
            this.button_CompletePurchase.Iconimage_right_Selected = null;
            this.button_CompletePurchase.Iconimage_Selected = null;
            this.button_CompletePurchase.IconZoom = 70D;
            this.button_CompletePurchase.IsTab = false;
            this.button_CompletePurchase.Location = new System.Drawing.Point(1190, 879);
            this.button_CompletePurchase.Margin = new System.Windows.Forms.Padding(5);
            this.button_CompletePurchase.Name = "button_CompletePurchase";
            this.button_CompletePurchase.Normalcolor = System.Drawing.Color.Firebrick;
            this.button_CompletePurchase.OnHovercolor = System.Drawing.Color.Tomato;
            this.button_CompletePurchase.OnHoverTextColor = System.Drawing.Color.White;
            this.button_CompletePurchase.selected = false;
            this.button_CompletePurchase.Size = new System.Drawing.Size(297, 64);
            this.button_CompletePurchase.TabIndex = 190;
            this.button_CompletePurchase.Textcolor = System.Drawing.Color.White;
            this.button_CompletePurchase.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_CompletePurchase.Click += new System.EventHandler(this.Button_CompletePurchase_Click);
            // 
            // label_discount
            // 
            this.label_discount.AutoSize = true;
            this.label_discount.BackColor = System.Drawing.Color.Transparent;
            this.label_discount.Font = new System.Drawing.Font("Bookman Old Style", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_discount.ForeColor = System.Drawing.Color.Red;
            this.label_discount.Location = new System.Drawing.Point(1413, 132);
            this.label_discount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_discount.Name = "label_discount";
            this.label_discount.Size = new System.Drawing.Size(28, 29);
            this.label_discount.TabIndex = 191;
            this.label_discount.Text = "a";
            this.label_discount.Visible = false;
            // 
            // UserControl_Customer_CopmletePurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::RMS_MPD.Properties.Resources.restaurant12;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.label_discount);
            this.Controls.Add(this.button_CompletePurchase);
            this.Controls.Add(label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.button_Bitcoin);
            this.Controls.Add(this.button_MansterCard);
            this.Controls.Add(this.button_ApplyDiscount);
            this.Controls.Add(label2);
            this.Controls.Add(this.textBox_discount);
            this.Controls.Add(this.button_paypal);
            this.Controls.Add(label1);
            this.Controls.Add(this.textBox_price);
            this.Controls.Add(label3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.Calendar_Order);
            this.DoubleBuffered = true;
            this.Name = "UserControl_Customer_CopmletePurchase";
            this.Size = new System.Drawing.Size(1586, 1019);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker Calendar_Order;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button button_paypal;
        private System.Windows.Forms.TextBox textBox_discount;
        private Bunifu.Framework.UI.BunifuFlatButton button_ApplyDiscount;
        private System.Windows.Forms.TextBox textBox_price;
        private System.Windows.Forms.Button button_MansterCard;
        private System.Windows.Forms.Button button_Bitcoin;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.TextBox textBox1;
        private Bunifu.Framework.UI.BunifuFlatButton button_CompletePurchase;
        private System.Windows.Forms.Label label_discount;
    }
}
