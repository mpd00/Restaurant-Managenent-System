namespace RMS_MPD.Customer
{
    partial class UserControl_Customer_ShoppingList
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
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            this.myListView1 = new System.Windows.Forms.ListView();
            this.Calendar_Order = new System.Windows.Forms.DateTimePicker();
            this.textBox_quantity = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_category = new System.Windows.Forms.TextBox();
            this.textBox_price = new System.Windows.Forms.TextBox();
            this.Calender1 = new System.Windows.Forms.DateTimePicker();
            this.button_plus = new System.Windows.Forms.Button();
            this.button_minus = new System.Windows.Forms.Button();
            this.button_trash = new System.Windows.Forms.Button();
            this.button_ClearShoppingList = new Bunifu.Framework.UI.BunifuFlatButton();
            label3 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.Font = new System.Drawing.Font("Bookman Old Style", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            label3.Location = new System.Drawing.Point(158, 44);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(523, 29);
            label3.TabIndex = 140;
            label3.Text = "Choose a day to see your Shopping List";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = System.Drawing.Color.Transparent;
            label7.Font = new System.Drawing.Font("Bookman Old Style", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            label7.Location = new System.Drawing.Point(931, 327);
            label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(96, 29);
            label7.TabIndex = 162;
            label7.Text = "Photo:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = System.Drawing.Color.Transparent;
            label5.Font = new System.Drawing.Font("Bookman Old Style", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            label5.Location = new System.Drawing.Point(939, 262);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(88, 29);
            label5.TabIndex = 161;
            label5.Text = "Price:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.Transparent;
            label4.Font = new System.Drawing.Font("Bookman Old Style", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            label4.Location = new System.Drawing.Point(933, 193);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(94, 29);
            label4.TabIndex = 160;
            label4.Text = "Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Bookman Old Style", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            label1.Location = new System.Drawing.Point(890, 129);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(137, 29);
            label1.TabIndex = 159;
            label1.Text = "Category:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("Bookman Old Style", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            label2.Location = new System.Drawing.Point(830, 58);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(197, 29);
            label2.TabIndex = 169;
            label2.Text = "Delivery Date:";
            // 
            // myListView1
            // 
            this.myListView1.BackColor = System.Drawing.Color.White;
            this.myListView1.ForeColor = System.Drawing.Color.Black;
            this.myListView1.HideSelection = false;
            this.myListView1.Location = new System.Drawing.Point(65, 150);
            this.myListView1.Margin = new System.Windows.Forms.Padding(4);
            this.myListView1.Name = "myListView1";
            this.myListView1.Size = new System.Drawing.Size(723, 737);
            this.myListView1.TabIndex = 132;
            this.myListView1.UseCompatibleStateImageBehavior = false;
            this.myListView1.SelectedIndexChanged += new System.EventHandler(this.myListView1_SelectedIndexChanged);
            // 
            // Calendar_Order
            // 
            this.Calendar_Order.Checked = false;
            this.Calendar_Order.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calendar_Order.Location = new System.Drawing.Point(216, 99);
            this.Calendar_Order.Name = "Calendar_Order";
            this.Calendar_Order.Size = new System.Drawing.Size(404, 35);
            this.Calendar_Order.TabIndex = 139;
            this.Calendar_Order.TabStop = false;
            this.Calendar_Order.ValueChanged += new System.EventHandler(this.Calendar_Order_onValueChanged);
            // 
            // textBox_quantity
            // 
            this.textBox_quantity.BackColor = System.Drawing.Color.White;
            this.textBox_quantity.Font = new System.Drawing.Font("Century Gothic", 23F, System.Drawing.FontStyle.Bold);
            this.textBox_quantity.Location = new System.Drawing.Point(1213, 737);
            this.textBox_quantity.Multiline = true;
            this.textBox_quantity.Name = "textBox_quantity";
            this.textBox_quantity.ReadOnly = true;
            this.textBox_quantity.Size = new System.Drawing.Size(144, 59);
            this.textBox_quantity.TabIndex = 166;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Location = new System.Drawing.Point(1072, 336);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(468, 355);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 165;
            this.pictureBox1.TabStop = false;
            // 
            // textBox_name
            // 
            this.textBox_name.BackColor = System.Drawing.Color.White;
            this.textBox_name.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.textBox_name.Location = new System.Drawing.Point(1072, 193);
            this.textBox_name.Multiline = true;
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.ReadOnly = true;
            this.textBox_name.Size = new System.Drawing.Size(433, 38);
            this.textBox_name.TabIndex = 164;
            // 
            // textBox_category
            // 
            this.textBox_category.BackColor = System.Drawing.Color.White;
            this.textBox_category.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.textBox_category.Location = new System.Drawing.Point(1072, 129);
            this.textBox_category.Multiline = true;
            this.textBox_category.Name = "textBox_category";
            this.textBox_category.ReadOnly = true;
            this.textBox_category.Size = new System.Drawing.Size(433, 38);
            this.textBox_category.TabIndex = 163;
            // 
            // textBox_price
            // 
            this.textBox_price.BackColor = System.Drawing.Color.White;
            this.textBox_price.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.textBox_price.Location = new System.Drawing.Point(1072, 272);
            this.textBox_price.Multiline = true;
            this.textBox_price.Name = "textBox_price";
            this.textBox_price.ReadOnly = true;
            this.textBox_price.Size = new System.Drawing.Size(433, 38);
            this.textBox_price.TabIndex = 157;
            // 
            // Calender1
            // 
            this.Calender1.Checked = false;
            this.Calender1.Enabled = false;
            this.Calender1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calender1.Location = new System.Drawing.Point(1072, 54);
            this.Calender1.Name = "Calender1";
            this.Calender1.Size = new System.Drawing.Size(409, 35);
            this.Calender1.TabIndex = 170;
            this.Calender1.TabStop = false;
            // 
            // button_plus
            // 
            this.button_plus.BackColor = System.Drawing.Color.Transparent;
            this.button_plus.BackgroundImage = global::RMS_MPD.Properties.Resources.Plus;
            this.button_plus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_plus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_plus.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button_plus.FlatAppearance.BorderSize = 0;
            this.button_plus.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button_plus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_plus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_plus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_plus.Location = new System.Drawing.Point(1381, 737);
            this.button_plus.Name = "button_plus";
            this.button_plus.Size = new System.Drawing.Size(60, 59);
            this.button_plus.TabIndex = 171;
            this.button_plus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_plus.UseVisualStyleBackColor = false;
            this.button_plus.Click += new System.EventHandler(this.button_plus_Click);
            // 
            // button_minus
            // 
            this.button_minus.BackColor = System.Drawing.Color.Transparent;
            this.button_minus.BackgroundImage = global::RMS_MPD.Properties.Resources.minus;
            this.button_minus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_minus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_minus.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button_minus.FlatAppearance.BorderSize = 0;
            this.button_minus.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button_minus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_minus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_minus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_minus.Location = new System.Drawing.Point(1131, 737);
            this.button_minus.Name = "button_minus";
            this.button_minus.Size = new System.Drawing.Size(60, 59);
            this.button_minus.TabIndex = 172;
            this.button_minus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_minus.UseVisualStyleBackColor = false;
            this.button_minus.Click += new System.EventHandler(this.button_minus_Click);
            // 
            // button_trash
            // 
            this.button_trash.BackColor = System.Drawing.Color.Transparent;
            this.button_trash.BackgroundImage = global::RMS_MPD.Properties.Resources.trash;
            this.button_trash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_trash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_trash.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button_trash.FlatAppearance.BorderSize = 0;
            this.button_trash.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button_trash.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_trash.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_trash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_trash.Location = new System.Drawing.Point(1466, 710);
            this.button_trash.Name = "button_trash";
            this.button_trash.Size = new System.Drawing.Size(78, 109);
            this.button_trash.TabIndex = 173;
            this.button_trash.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_trash.UseVisualStyleBackColor = false;
            this.button_trash.Click += new System.EventHandler(this.button_trash_Click);
            // 
            // button_ClearShoppingList
            // 
            this.button_ClearShoppingList.Activecolor = System.Drawing.Color.IndianRed;
            this.button_ClearShoppingList.BackColor = System.Drawing.Color.Maroon;
            this.button_ClearShoppingList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_ClearShoppingList.BorderRadius = 30;
            this.button_ClearShoppingList.ButtonText = "     Clear Shopping List";
            this.button_ClearShoppingList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_ClearShoppingList.Font = new System.Drawing.Font("Century Gothic", 3F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ClearShoppingList.Iconcolor = System.Drawing.Color.Transparent;
            this.button_ClearShoppingList.Iconimage = null;
            this.button_ClearShoppingList.Iconimage_right = null;
            this.button_ClearShoppingList.Iconimage_right_Selected = null;
            this.button_ClearShoppingList.Iconimage_Selected = null;
            this.button_ClearShoppingList.IconZoom = 70D;
            this.button_ClearShoppingList.IsTab = false;
            this.button_ClearShoppingList.Location = new System.Drawing.Point(1160, 847);
            this.button_ClearShoppingList.Margin = new System.Windows.Forms.Padding(4);
            this.button_ClearShoppingList.Name = "button_ClearShoppingList";
            this.button_ClearShoppingList.Normalcolor = System.Drawing.Color.Maroon;
            this.button_ClearShoppingList.OnHovercolor = System.Drawing.Color.Firebrick;
            this.button_ClearShoppingList.OnHoverTextColor = System.Drawing.Color.White;
            this.button_ClearShoppingList.selected = false;
            this.button_ClearShoppingList.Size = new System.Drawing.Size(283, 89);
            this.button_ClearShoppingList.TabIndex = 175;
            this.button_ClearShoppingList.Textcolor = System.Drawing.Color.White;
            this.button_ClearShoppingList.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ClearShoppingList.Click += new System.EventHandler(this.button_ClearShoppingList_Click);
            // 
            // UserControl_Customer_ShoppingList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::RMS_MPD.Properties.Resources.restaurant11;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.button_ClearShoppingList);
            this.Controls.Add(this.button_minus);
            this.Controls.Add(this.button_plus);
            this.Controls.Add(this.Calender1);
            this.Controls.Add(label2);
            this.Controls.Add(this.textBox_quantity);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.textBox_category);
            this.Controls.Add(label7);
            this.Controls.Add(label5);
            this.Controls.Add(label4);
            this.Controls.Add(label1);
            this.Controls.Add(this.textBox_price);
            this.Controls.Add(label3);
            this.Controls.Add(this.Calendar_Order);
            this.Controls.Add(this.myListView1);
            this.Controls.Add(this.button_trash);
            this.DoubleBuffered = true;
            this.Name = "UserControl_Customer_ShoppingList";
            this.Size = new System.Drawing.Size(1586, 1019);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView myListView1;
        private System.Windows.Forms.DateTimePicker Calendar_Order;
        private System.Windows.Forms.TextBox textBox_quantity;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_category;
        private System.Windows.Forms.TextBox textBox_price;
        private System.Windows.Forms.DateTimePicker Calender1;
        private System.Windows.Forms.Button button_plus;
        private System.Windows.Forms.Button button_minus;
        private System.Windows.Forms.Button button_trash;
        private Bunifu.Framework.UI.BunifuFlatButton button_ClearShoppingList;
    }
}
