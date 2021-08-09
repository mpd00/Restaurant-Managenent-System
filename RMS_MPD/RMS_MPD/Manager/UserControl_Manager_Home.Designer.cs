namespace RMS_MPD.Manager
{
    partial class UserControl_Manager_Home
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
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_Manager_Home));
            this.myListView1 = new System.Windows.Forms.ListView();
            this.myListView2 = new System.Windows.Forms.ListView();
            this.foodCalenderDBDataSet = new RMS_MPD.FoodCalenderDBDataSet();
            this.calenderFoodTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.calenderFoodTableTableAdapter = new RMS_MPD.FoodCalenderDBDataSetTableAdapters.CalenderFoodTableTableAdapter();
            this.tableAdapterManager = new RMS_MPD.FoodCalenderDBDataSetTableAdapters.TableAdapterManager();
            this.textBox_quantity = new System.Windows.Forms.TextBox();
            this.textBox_recieved_quantity = new System.Windows.Forms.TextBox();
            this.button_add = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Calendar_Order = new System.Windows.Forms.DateTimePicker();
            this.calenderFoodTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button_Edit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.button_Delete = new Bunifu.Framework.UI.BunifuFlatButton();
            label8 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.foodCalenderDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calenderFoodTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calenderFoodTableBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = System.Drawing.Color.Transparent;
            label8.Font = new System.Drawing.Font("Bookman Old Style", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label8.ForeColor = System.Drawing.Color.White;
            label8.Location = new System.Drawing.Point(227, 19);
            label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(256, 29);
            label8.TabIndex = 130;
            label8.Text = "Restaurant\'s Menu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(81, 796);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(174, 24);
            label1.TabIndex = 131;
            label1.Text = "Enter Quantity:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(1048, 789);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(109, 24);
            label2.TabIndex = 132;
            label2.Text = "Quantity:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.Font = new System.Drawing.Font("Bookman Old Style", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.ForeColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(1004, 19);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(474, 29);
            label3.TabIndex = 136;
            label3.Text = "Choose a day to see available menu";
            // 
            // myListView1
            // 
            this.myListView1.BackColor = System.Drawing.Color.White;
            this.myListView1.ForeColor = System.Drawing.Color.Black;
            this.myListView1.HideSelection = false;
            this.myListView1.Location = new System.Drawing.Point(31, 72);
            this.myListView1.Margin = new System.Windows.Forms.Padding(4);
            this.myListView1.Name = "myListView1";
            this.myListView1.Size = new System.Drawing.Size(663, 669);
            this.myListView1.TabIndex = 116;
            this.myListView1.UseCompatibleStateImageBehavior = false;
            this.myListView1.SelectedIndexChanged += new System.EventHandler(this.myListView1_SelectedIndexChanged);
            // 
            // myListView2
            // 
            this.myListView2.BackColor = System.Drawing.Color.White;
            this.myListView2.ForeColor = System.Drawing.Color.Black;
            this.myListView2.HideSelection = false;
            this.myListView2.Location = new System.Drawing.Point(914, 138);
            this.myListView2.Margin = new System.Windows.Forms.Padding(4);
            this.myListView2.Name = "myListView2";
            this.myListView2.Size = new System.Drawing.Size(643, 603);
            this.myListView2.TabIndex = 117;
            this.myListView2.UseCompatibleStateImageBehavior = false;
            this.myListView2.SelectedIndexChanged += new System.EventHandler(this.myListView2_SelectedIndexChanged);
            // 
            // foodCalenderDBDataSet
            // 
            this.foodCalenderDBDataSet.DataSetName = "FoodCalenderDBDataSet";
            this.foodCalenderDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // calenderFoodTableBindingSource
            // 
            this.calenderFoodTableBindingSource.DataMember = "CalenderFoodTable";
            this.calenderFoodTableBindingSource.DataSource = this.foodCalenderDBDataSet;
            // 
            // calenderFoodTableTableAdapter
            // 
            this.calenderFoodTableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CalenderFoodTableTableAdapter = this.calenderFoodTableTableAdapter;
            this.tableAdapterManager.UpdateOrder = RMS_MPD.FoodCalenderDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // textBox_quantity
            // 
            this.textBox_quantity.BackColor = System.Drawing.Color.White;
            this.textBox_quantity.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.textBox_quantity.Location = new System.Drawing.Point(268, 789);
            this.textBox_quantity.Multiline = true;
            this.textBox_quantity.Name = "textBox_quantity";
            this.textBox_quantity.Size = new System.Drawing.Size(240, 38);
            this.textBox_quantity.TabIndex = 129;
            // 
            // textBox_recieved_quantity
            // 
            this.textBox_recieved_quantity.BackColor = System.Drawing.Color.White;
            this.textBox_recieved_quantity.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.textBox_recieved_quantity.Location = new System.Drawing.Point(1202, 781);
            this.textBox_recieved_quantity.Multiline = true;
            this.textBox_recieved_quantity.Name = "textBox_recieved_quantity";
            this.textBox_recieved_quantity.Size = new System.Drawing.Size(214, 38);
            this.textBox_recieved_quantity.TabIndex = 133;
            // 
            // button_add
            // 
            this.button_add.Activecolor = System.Drawing.Color.IndianRed;
            this.button_add.BackColor = System.Drawing.Color.LightSalmon;
            this.button_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_add.BorderRadius = 30;
            this.button_add.ButtonText = "             Add";
            this.button_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_add.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add.Iconcolor = System.Drawing.Color.Transparent;
            this.button_add.Iconimage = null;
            this.button_add.Iconimage_right = null;
            this.button_add.Iconimage_right_Selected = null;
            this.button_add.Iconimage_Selected = null;
            this.button_add.IconZoom = 110D;
            this.button_add.IsTab = false;
            this.button_add.Location = new System.Drawing.Point(232, 866);
            this.button_add.Margin = new System.Windows.Forms.Padding(5);
            this.button_add.Name = "button_add";
            this.button_add.Normalcolor = System.Drawing.Color.LightSalmon;
            this.button_add.OnHovercolor = System.Drawing.Color.Tomato;
            this.button_add.OnHoverTextColor = System.Drawing.Color.DarkGray;
            this.button_add.selected = false;
            this.button_add.Size = new System.Drawing.Size(212, 87);
            this.button_add.TabIndex = 134;
            this.button_add.Textcolor = System.Drawing.Color.Black;
            this.button_add.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // Calendar_Order
            // 
            this.Calendar_Order.Checked = false;
            this.Calendar_Order.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calendar_Order.Location = new System.Drawing.Point(1027, 72);
            this.Calendar_Order.Name = "Calendar_Order";
            this.Calendar_Order.Size = new System.Drawing.Size(404, 35);
            this.Calendar_Order.TabIndex = 135;
            this.Calendar_Order.TabStop = false;
            this.Calendar_Order.ValueChanged += new System.EventHandler(this.Calendar_Order_onValueChanged);
            // 
            // calenderFoodTableBindingSource1
            // 
            this.calenderFoodTableBindingSource1.DataMember = "CalenderFoodTable";
            this.calenderFoodTableBindingSource1.DataSource = this.foodCalenderDBDataSet;
            // 
            // button_Edit
            // 
            this.button_Edit.Activecolor = System.Drawing.Color.IndianRed;
            this.button_Edit.BackColor = System.Drawing.Color.LightSalmon;
            this.button_Edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Edit.BorderRadius = 30;
            this.button_Edit.ButtonText = "             Edit";
            this.button_Edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Edit.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Edit.Iconcolor = System.Drawing.Color.Transparent;
            this.button_Edit.Iconimage = null;
            this.button_Edit.Iconimage_right = null;
            this.button_Edit.Iconimage_right_Selected = null;
            this.button_Edit.Iconimage_Selected = null;
            this.button_Edit.IconZoom = 110D;
            this.button_Edit.IsTab = false;
            this.button_Edit.Location = new System.Drawing.Point(1008, 866);
            this.button_Edit.Margin = new System.Windows.Forms.Padding(5);
            this.button_Edit.Name = "button_Edit";
            this.button_Edit.Normalcolor = System.Drawing.Color.LightSalmon;
            this.button_Edit.OnHovercolor = System.Drawing.Color.Tomato;
            this.button_Edit.OnHoverTextColor = System.Drawing.Color.DarkGray;
            this.button_Edit.selected = false;
            this.button_Edit.Size = new System.Drawing.Size(212, 87);
            this.button_Edit.TabIndex = 137;
            this.button_Edit.Textcolor = System.Drawing.Color.Black;
            this.button_Edit.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Edit.Click += new System.EventHandler(this.button_Edit_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.Activecolor = System.Drawing.Color.IndianRed;
            this.button_Delete.BackColor = System.Drawing.Color.LightSalmon;
            this.button_Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Delete.BorderRadius = 30;
            this.button_Delete.ButtonText = "           Delete";
            this.button_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Delete.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Delete.Iconcolor = System.Drawing.Color.Transparent;
            this.button_Delete.Iconimage = null;
            this.button_Delete.Iconimage_right = null;
            this.button_Delete.Iconimage_right_Selected = null;
            this.button_Delete.Iconimage_Selected = null;
            this.button_Delete.IconZoom = 110D;
            this.button_Delete.IsTab = false;
            this.button_Delete.Location = new System.Drawing.Point(1258, 866);
            this.button_Delete.Margin = new System.Windows.Forms.Padding(5);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Normalcolor = System.Drawing.Color.LightSalmon;
            this.button_Delete.OnHovercolor = System.Drawing.Color.Tomato;
            this.button_Delete.OnHoverTextColor = System.Drawing.Color.DarkGray;
            this.button_Delete.selected = false;
            this.button_Delete.Size = new System.Drawing.Size(212, 87);
            this.button_Delete.TabIndex = 138;
            this.button_Delete.Textcolor = System.Drawing.Color.Black;
            this.button_Delete.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // UserControl_Manager_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Edit);
            this.Controls.Add(label3);
            this.Controls.Add(this.Calendar_Order);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.textBox_recieved_quantity);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(label8);
            this.Controls.Add(this.textBox_quantity);
            this.Controls.Add(this.myListView2);
            this.Controls.Add(this.myListView1);
            this.DoubleBuffered = true;
            this.Name = "UserControl_Manager_Home";
            this.Size = new System.Drawing.Size(1586, 1022);
            ((System.ComponentModel.ISupportInitialize)(this.foodCalenderDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calenderFoodTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calenderFoodTableBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView myListView1;
        private System.Windows.Forms.ListView myListView2;
        private FoodCalenderDBDataSet foodCalenderDBDataSet;
        private System.Windows.Forms.BindingSource calenderFoodTableBindingSource;
        private FoodCalenderDBDataSetTableAdapters.CalenderFoodTableTableAdapter calenderFoodTableTableAdapter;
        private FoodCalenderDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox textBox_quantity;
        private System.Windows.Forms.TextBox textBox_recieved_quantity;
        private Bunifu.Framework.UI.BunifuFlatButton button_add;
        private System.Windows.Forms.DateTimePicker Calendar_Order;
        private System.Windows.Forms.BindingSource calenderFoodTableBindingSource1;
        private Bunifu.Framework.UI.BunifuFlatButton button_Edit;
        private Bunifu.Framework.UI.BunifuFlatButton button_Delete;
    }
}
