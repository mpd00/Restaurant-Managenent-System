namespace RMS_MPD.Customer
{
    partial class UserControl_Customer_Order
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label8;
            this.myListView1 = new System.Windows.Forms.ListView();
            this.Calendar_Order = new System.Windows.Forms.DateTimePicker();
            this.textBox_recieved_quantity = new System.Windows.Forms.TextBox();
            this.textBox_price = new System.Windows.Forms.TextBox();
            this.textBox_recepie = new System.Windows.Forms.TextBox();
            this.textBox_category = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_add_shoppinglist = new Bunifu.Framework.UI.BunifuFlatButton();
            this.textBox_quantity = new System.Windows.Forms.TextBox();
            this.shoppingListTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shoppingListDBDataSet = new RMS_MPD.ShoppingListDBDataSet();
            this.shoppingListTableTableAdapter = new RMS_MPD.ShoppingListDBDataSetTableAdapters.ShoppingListTableTableAdapter();
            this.shoppingListTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoppingListTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoppingListDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoppingListTableBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.Font = new System.Drawing.Font("Bookman Old Style", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.ForeColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(138, 32);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(474, 29);
            label3.TabIndex = 138;
            label3.Text = "Choose a day to see available menu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(157, 894);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(123, 24);
            label2.TabIndex = 139;
            label2.Text = "Items Left:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = System.Drawing.Color.Transparent;
            label7.Font = new System.Drawing.Font("Bookman Old Style", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label7.ForeColor = System.Drawing.Color.White;
            label7.Location = new System.Drawing.Point(895, 433);
            label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(96, 29);
            label7.TabIndex = 149;
            label7.Text = "Photo:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = System.Drawing.Color.Transparent;
            label5.Font = new System.Drawing.Font("Bookman Old Style", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.ForeColor = System.Drawing.Color.White;
            label5.Location = new System.Drawing.Point(903, 368);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(88, 29);
            label5.TabIndex = 148;
            label5.Text = "Price:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.Transparent;
            label4.Font = new System.Drawing.Font("Bookman Old Style", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.ForeColor = System.Drawing.Color.White;
            label4.Location = new System.Drawing.Point(897, 96);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(94, 29);
            label4.TabIndex = 147;
            label4.Text = "Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Bookman Old Style", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(854, 32);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(137, 29);
            label1.TabIndex = 146;
            label1.Text = "Category:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = System.Drawing.Color.Transparent;
            label6.Font = new System.Drawing.Font("Bookman Old Style", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label6.ForeColor = System.Drawing.Color.White;
            label6.Location = new System.Drawing.Point(827, 152);
            label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(164, 29);
            label6.TabIndex = 145;
            label6.Text = "Ingridients:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = System.Drawing.Color.Transparent;
            label8.Font = new System.Drawing.Font("Bookman Old Style", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label8.ForeColor = System.Drawing.Color.White;
            label8.Location = new System.Drawing.Point(854, 827);
            label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(137, 29);
            label8.TabIndex = 155;
            label8.Text = "Quantity:";
            // 
            // myListView1
            // 
            this.myListView1.BackColor = System.Drawing.Color.White;
            this.myListView1.ForeColor = System.Drawing.Color.Black;
            this.myListView1.HideSelection = false;
            this.myListView1.Location = new System.Drawing.Point(44, 155);
            this.myListView1.Margin = new System.Windows.Forms.Padding(4);
            this.myListView1.Name = "myListView1";
            this.myListView1.Size = new System.Drawing.Size(663, 682);
            this.myListView1.TabIndex = 131;
            this.myListView1.UseCompatibleStateImageBehavior = false;
            this.myListView1.SelectedIndexChanged += new System.EventHandler(this.myListView1_SelectedIndexChanged);
            // 
            // Calendar_Order
            // 
            this.Calendar_Order.Checked = false;
            this.Calendar_Order.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calendar_Order.Location = new System.Drawing.Point(161, 85);
            this.Calendar_Order.Name = "Calendar_Order";
            this.Calendar_Order.Size = new System.Drawing.Size(404, 35);
            this.Calendar_Order.TabIndex = 137;
            this.Calendar_Order.TabStop = false;
            this.Calendar_Order.ValueChanged += new System.EventHandler(this.Calendar_Order_onValueChanged);
            // 
            // textBox_recieved_quantity
            // 
            this.textBox_recieved_quantity.BackColor = System.Drawing.Color.White;
            this.textBox_recieved_quantity.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.textBox_recieved_quantity.Location = new System.Drawing.Point(312, 888);
            this.textBox_recieved_quantity.Multiline = true;
            this.textBox_recieved_quantity.Name = "textBox_recieved_quantity";
            this.textBox_recieved_quantity.Size = new System.Drawing.Size(214, 38);
            this.textBox_recieved_quantity.TabIndex = 140;
            // 
            // textBox_price
            // 
            this.textBox_price.BackColor = System.Drawing.Color.White;
            this.textBox_price.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.textBox_price.Location = new System.Drawing.Point(1036, 378);
            this.textBox_price.Multiline = true;
            this.textBox_price.Name = "textBox_price";
            this.textBox_price.ReadOnly = true;
            this.textBox_price.Size = new System.Drawing.Size(433, 38);
            this.textBox_price.TabIndex = 144;
            // 
            // textBox_recepie
            // 
            this.textBox_recepie.BackColor = System.Drawing.Color.White;
            this.textBox_recepie.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.textBox_recepie.Location = new System.Drawing.Point(1036, 160);
            this.textBox_recepie.Multiline = true;
            this.textBox_recepie.Name = "textBox_recepie";
            this.textBox_recepie.ReadOnly = true;
            this.textBox_recepie.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox_recepie.Size = new System.Drawing.Size(529, 192);
            this.textBox_recepie.TabIndex = 143;
            // 
            // textBox_category
            // 
            this.textBox_category.BackColor = System.Drawing.Color.White;
            this.textBox_category.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.textBox_category.Location = new System.Drawing.Point(1036, 32);
            this.textBox_category.Multiline = true;
            this.textBox_category.Name = "textBox_category";
            this.textBox_category.ReadOnly = true;
            this.textBox_category.Size = new System.Drawing.Size(433, 38);
            this.textBox_category.TabIndex = 150;
            // 
            // textBox_name
            // 
            this.textBox_name.BackColor = System.Drawing.Color.White;
            this.textBox_name.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.textBox_name.Location = new System.Drawing.Point(1036, 96);
            this.textBox_name.Multiline = true;
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.ReadOnly = true;
            this.textBox_name.Size = new System.Drawing.Size(433, 38);
            this.textBox_name.TabIndex = 151;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Location = new System.Drawing.Point(1036, 442);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(468, 355);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 152;
            this.pictureBox1.TabStop = false;
            // 
            // button_add_shoppinglist
            // 
            this.button_add_shoppinglist.Activecolor = System.Drawing.Color.IndianRed;
            this.button_add_shoppinglist.BackColor = System.Drawing.Color.LightSalmon;
            this.button_add_shoppinglist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_add_shoppinglist.BorderRadius = 30;
            this.button_add_shoppinglist.ButtonText = "              Add to Shopping List";
            this.button_add_shoppinglist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_add_shoppinglist.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add_shoppinglist.Iconcolor = System.Drawing.Color.Transparent;
            this.button_add_shoppinglist.Iconimage = null;
            this.button_add_shoppinglist.Iconimage_right = null;
            this.button_add_shoppinglist.Iconimage_right_Selected = null;
            this.button_add_shoppinglist.Iconimage_Selected = null;
            this.button_add_shoppinglist.IconZoom = 110D;
            this.button_add_shoppinglist.IsTab = false;
            this.button_add_shoppinglist.Location = new System.Drawing.Point(1086, 896);
            this.button_add_shoppinglist.Margin = new System.Windows.Forms.Padding(5);
            this.button_add_shoppinglist.Name = "button_add_shoppinglist";
            this.button_add_shoppinglist.Normalcolor = System.Drawing.Color.LightSalmon;
            this.button_add_shoppinglist.OnHovercolor = System.Drawing.Color.Tomato;
            this.button_add_shoppinglist.OnHoverTextColor = System.Drawing.Color.DarkGray;
            this.button_add_shoppinglist.selected = false;
            this.button_add_shoppinglist.Size = new System.Drawing.Size(347, 64);
            this.button_add_shoppinglist.TabIndex = 153;
            this.button_add_shoppinglist.Textcolor = System.Drawing.Color.Black;
            this.button_add_shoppinglist.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add_shoppinglist.Click += new System.EventHandler(this.button_add_shoppinglist_Click);
            // 
            // textBox_quantity
            // 
            this.textBox_quantity.BackColor = System.Drawing.Color.White;
            this.textBox_quantity.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.textBox_quantity.Location = new System.Drawing.Point(1036, 823);
            this.textBox_quantity.Multiline = true;
            this.textBox_quantity.Name = "textBox_quantity";
            this.textBox_quantity.Size = new System.Drawing.Size(179, 38);
            this.textBox_quantity.TabIndex = 154;
            // 
            // shoppingListTableBindingSource
            // 
            this.shoppingListTableBindingSource.DataMember = "ShoppingListTable";
            this.shoppingListTableBindingSource.DataSource = this.shoppingListDBDataSet;
            // 
            // shoppingListDBDataSet
            // 
            this.shoppingListDBDataSet.DataSetName = "ShoppingListDBDataSet";
            this.shoppingListDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // shoppingListTableTableAdapter
            // 
            this.shoppingListTableTableAdapter.ClearBeforeFill = true;
            // 
            // shoppingListTableBindingSource1
            // 
            this.shoppingListTableBindingSource1.DataMember = "ShoppingListTable";
            this.shoppingListTableBindingSource1.DataSource = this.shoppingListDBDataSet;
            // 
            // UserControl_Customer_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::RMS_MPD.Properties.Resources.restaurant10;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(label8);
            this.Controls.Add(this.textBox_quantity);
            this.Controls.Add(this.button_add_shoppinglist);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.textBox_category);
            this.Controls.Add(label7);
            this.Controls.Add(label5);
            this.Controls.Add(label4);
            this.Controls.Add(label1);
            this.Controls.Add(label6);
            this.Controls.Add(this.textBox_price);
            this.Controls.Add(this.textBox_recepie);
            this.Controls.Add(this.textBox_recieved_quantity);
            this.Controls.Add(label2);
            this.Controls.Add(label3);
            this.Controls.Add(this.Calendar_Order);
            this.Controls.Add(this.myListView1);
            this.DoubleBuffered = true;
            this.Name = "UserControl_Customer_Order";
            this.Size = new System.Drawing.Size(1586, 1019);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoppingListTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoppingListDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoppingListTableBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView myListView1;
        private System.Windows.Forms.DateTimePicker Calendar_Order;
        private System.Windows.Forms.TextBox textBox_recieved_quantity;
        private System.Windows.Forms.TextBox textBox_price;
        private System.Windows.Forms.TextBox textBox_recepie;
        private System.Windows.Forms.TextBox textBox_category;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuFlatButton button_add_shoppinglist;
        private System.Windows.Forms.TextBox textBox_quantity;
        private System.Windows.Forms.BindingSource shoppingListTableBindingSource;
        private ShoppingListDBDataSet shoppingListDBDataSet;
        private ShoppingListDBDataSetTableAdapters.ShoppingListTableTableAdapter shoppingListTableTableAdapter;
        private System.Windows.Forms.BindingSource shoppingListTableBindingSource1;
    }
}
