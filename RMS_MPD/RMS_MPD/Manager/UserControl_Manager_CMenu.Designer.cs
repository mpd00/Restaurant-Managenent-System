namespace RMS_MPD.Manager
{
    partial class UserControl_Manager_CMenu
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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label_Suggest;
            this.rbTile = new System.Windows.Forms.RadioButton();
            this.rbLargeIcon = new System.Windows.Forms.RadioButton();
            this.myListView = new System.Windows.Forms.ListView();
            this.comboBox_Category = new System.Windows.Forms.ComboBox();
            this.comboBox_Name = new System.Windows.Forms.ComboBox();
            this.textBox_recepie = new System.Windows.Forms.TextBox();
            this.textBox_price = new System.Windows.Forms.TextBox();
            this.foodDBDataSet = new RMS_MPD.FoodDBDataSet();
            this.foodMenuTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.foodMenuTableTableAdapter = new RMS_MPD.FoodDBDataSetTableAdapters.FoodMenuTableTableAdapter();
            this.foodMenuTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new RMS_MPD.FoodDBDataSetTableAdapters.TableAdapterManager();
            this.bunifuFlatButton_Browse = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label_Suggest = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.foodDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodMenuTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodMenuTableBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("Bookman Old Style", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(788, 268);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(164, 29);
            label2.TabIndex = 93;
            label2.Text = "Ingridients:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.Font = new System.Drawing.Font("Bookman Old Style", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.ForeColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(815, 61);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(137, 29);
            label3.TabIndex = 94;
            label3.Text = "Category:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.Transparent;
            label4.Font = new System.Drawing.Font("Bookman Old Style", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.ForeColor = System.Drawing.Color.White;
            label4.Location = new System.Drawing.Point(858, 181);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(94, 29);
            label4.TabIndex = 95;
            label4.Text = "Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = System.Drawing.Color.Transparent;
            label5.Font = new System.Drawing.Font("Bookman Old Style", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.ForeColor = System.Drawing.Color.White;
            label5.Location = new System.Drawing.Point(880, 648);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(88, 29);
            label5.TabIndex = 96;
            label5.Text = "Price:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = System.Drawing.Color.Transparent;
            label7.Font = new System.Drawing.Font("Bookman Old Style", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label7.ForeColor = System.Drawing.Color.White;
            label7.Location = new System.Drawing.Point(815, 554);
            label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(153, 29);
            label7.TabIndex = 101;
            label7.Text = "Add photo:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = System.Drawing.Color.Transparent;
            label8.Font = new System.Drawing.Font("Bookman Old Style", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label8.ForeColor = System.Drawing.Color.White;
            label8.Location = new System.Drawing.Point(148, 49);
            label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(354, 29);
            label8.TabIndex = 105;
            label8.Text = "This is your current menu";
            // 
            // label_Suggest
            // 
            label_Suggest.AutoSize = true;
            label_Suggest.BackColor = System.Drawing.Color.Transparent;
            label_Suggest.Cursor = System.Windows.Forms.Cursors.Hand;
            label_Suggest.Font = new System.Drawing.Font("Bodoni MT", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label_Suggest.ForeColor = System.Drawing.Color.Red;
            label_Suggest.Location = new System.Drawing.Point(1508, 173);
            label_Suggest.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label_Suggest.Name = "label_Suggest";
            label_Suggest.Size = new System.Drawing.Size(68, 44);
            label_Suggest.TabIndex = 113;
            label_Suggest.Text = "Suggest\r\n Name";
            label_Suggest.Click += new System.EventHandler(this.label_Suggest_Click);
            // 
            // rbTile
            // 
            this.rbTile.AutoSize = true;
            this.rbTile.BackColor = System.Drawing.Color.Transparent;
            this.rbTile.ForeColor = System.Drawing.Color.White;
            this.rbTile.Location = new System.Drawing.Point(657, 155);
            this.rbTile.Margin = new System.Windows.Forms.Padding(4);
            this.rbTile.Name = "rbTile";
            this.rbTile.Size = new System.Drawing.Size(52, 21);
            this.rbTile.TabIndex = 9;
            this.rbTile.Text = "Tile";
            this.rbTile.UseVisualStyleBackColor = false;
            this.rbTile.CheckedChanged += new System.EventHandler(this.rbTile_CheckedChanged);
            // 
            // rbLargeIcon
            // 
            this.rbLargeIcon.AutoSize = true;
            this.rbLargeIcon.BackColor = System.Drawing.Color.Transparent;
            this.rbLargeIcon.Checked = true;
            this.rbLargeIcon.ForeColor = System.Drawing.Color.White;
            this.rbLargeIcon.Location = new System.Drawing.Point(656, 114);
            this.rbLargeIcon.Margin = new System.Windows.Forms.Padding(4);
            this.rbLargeIcon.Name = "rbLargeIcon";
            this.rbLargeIcon.Size = new System.Drawing.Size(103, 21);
            this.rbLargeIcon.TabIndex = 6;
            this.rbLargeIcon.TabStop = true;
            this.rbLargeIcon.Text = "Large Icons";
            this.rbLargeIcon.UseVisualStyleBackColor = false;
            this.rbLargeIcon.CheckedChanged += new System.EventHandler(this.rbLargeIcon_CheckedChanged);
            // 
            // myListView
            // 
            this.myListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(112)))), ((int)(((byte)(56)))));
            this.myListView.ForeColor = System.Drawing.Color.White;
            this.myListView.HideSelection = false;
            this.myListView.Location = new System.Drawing.Point(19, 114);
            this.myListView.Margin = new System.Windows.Forms.Padding(4);
            this.myListView.Name = "myListView";
            this.myListView.Size = new System.Drawing.Size(627, 830);
            this.myListView.TabIndex = 5;
            this.myListView.UseCompatibleStateImageBehavior = false;
            this.myListView.SelectedIndexChanged += new System.EventHandler(this.myListView_SelectedIndexChanged);
            // 
            // comboBox_Category
            // 
            this.comboBox_Category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Category.FormattingEnabled = true;
            this.comboBox_Category.ItemHeight = 37;
            this.comboBox_Category.Items.AddRange(new object[] {
            "Burgers",
            "Pizza",
            "Chicken",
            "Soups",
            "Salads",
            "Beverages",
            "Desserts",
            "Indian",
            "Persian"});
            this.comboBox_Category.Location = new System.Drawing.Point(1065, 62);
            this.comboBox_Category.Name = "comboBox_Category";
            this.comboBox_Category.Size = new System.Drawing.Size(387, 45);
            this.comboBox_Category.TabIndex = 87;
            // 
            // comboBox_Name
            // 
            this.comboBox_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Name.FormattingEnabled = true;
            this.comboBox_Name.ItemHeight = 37;
            this.comboBox_Name.Location = new System.Drawing.Point(1002, 172);
            this.comboBox_Name.Name = "comboBox_Name";
            this.comboBox_Name.Size = new System.Drawing.Size(494, 45);
            this.comboBox_Name.TabIndex = 90;
            // 
            // textBox_recepie
            // 
            this.textBox_recepie.BackColor = System.Drawing.Color.White;
            this.textBox_recepie.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.textBox_recepie.Location = new System.Drawing.Point(1002, 264);
            this.textBox_recepie.Multiline = true;
            this.textBox_recepie.Name = "textBox_recepie";
            this.textBox_recepie.Size = new System.Drawing.Size(534, 241);
            this.textBox_recepie.TabIndex = 91;
            // 
            // textBox_price
            // 
            this.textBox_price.BackColor = System.Drawing.Color.White;
            this.textBox_price.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.textBox_price.Location = new System.Drawing.Point(1037, 649);
            this.textBox_price.Multiline = true;
            this.textBox_price.Name = "textBox_price";
            this.textBox_price.Size = new System.Drawing.Size(433, 38);
            this.textBox_price.TabIndex = 92;
            // 
            // foodDBDataSet
            // 
            this.foodDBDataSet.DataSetName = "FoodDBDataSet";
            this.foodDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // foodMenuTableBindingSource
            // 
            this.foodMenuTableBindingSource.DataMember = "FoodMenuTable";
            this.foodMenuTableBindingSource.DataSource = this.foodDBDataSet;
            // 
            // foodMenuTableTableAdapter
            // 
            this.foodMenuTableTableAdapter.ClearBeforeFill = true;
            // 
            // foodMenuTableBindingSource1
            // 
            this.foodMenuTableBindingSource1.DataMember = "FoodMenuTable";
            this.foodMenuTableBindingSource1.DataSource = this.foodDBDataSet;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FoodMenuTableTableAdapter = this.foodMenuTableTableAdapter;
            this.tableAdapterManager.UpdateOrder = RMS_MPD.FoodDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bunifuFlatButton_Browse
            // 
            this.bunifuFlatButton_Browse.Activecolor = System.Drawing.Color.DarkOrchid;
            this.bunifuFlatButton_Browse.BackColor = System.Drawing.Color.SlateBlue;
            this.bunifuFlatButton_Browse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton_Browse.BorderRadius = 30;
            this.bunifuFlatButton_Browse.ButtonText = "                        Browse";
            this.bunifuFlatButton_Browse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton_Browse.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton_Browse.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton_Browse.Iconimage = null;
            this.bunifuFlatButton_Browse.Iconimage_right = null;
            this.bunifuFlatButton_Browse.Iconimage_right_Selected = null;
            this.bunifuFlatButton_Browse.Iconimage_Selected = null;
            this.bunifuFlatButton_Browse.IconZoom = 110D;
            this.bunifuFlatButton_Browse.IsTab = false;
            this.bunifuFlatButton_Browse.Location = new System.Drawing.Point(1111, 542);
            this.bunifuFlatButton_Browse.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuFlatButton_Browse.Name = "bunifuFlatButton_Browse";
            this.bunifuFlatButton_Browse.Normalcolor = System.Drawing.Color.SlateBlue;
            this.bunifuFlatButton_Browse.OnHovercolor = System.Drawing.Color.DarkOrchid;
            this.bunifuFlatButton_Browse.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton_Browse.selected = false;
            this.bunifuFlatButton_Browse.Size = new System.Drawing.Size(297, 57);
            this.bunifuFlatButton_Browse.TabIndex = 106;
            this.bunifuFlatButton_Browse.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton_Browse.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton_Browse.Click += new System.EventHandler(this.button_Browse_Click);
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.Khaki;
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.Peru;
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 30;
            this.bunifuFlatButton3.ButtonText = "        Save/Edit";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = null;
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconZoom = 110D;
            this.bunifuFlatButton3.IsTab = false;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(1070, 735);
            this.bunifuFlatButton3.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.Peru;
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.SaddleBrown;
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(208, 110);
            this.bunifuFlatButton3.TabIndex = 109;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton3.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.Khaki;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.Peru;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 30;
            this.bunifuFlatButton1.ButtonText = "                          Clear";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = null;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconZoom = 110D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(1135, 868);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.Peru;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.SaddleBrown;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(297, 57);
            this.bunifuFlatButton1.TabIndex = 110;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.Khaki;
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.Peru;
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 30;
            this.bunifuFlatButton2.ButtonText = "        Delete";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = null;
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconZoom = 110D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(1298, 735);
            this.bunifuFlatButton2.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.Peru;
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.SaddleBrown;
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(178, 110);
            this.bunifuFlatButton2.TabIndex = 111;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // UserControl_Manager_CMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::RMS_MPD.Properties.Resources.restaurant4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(label_Suggest);
            this.Controls.Add(this.bunifuFlatButton2);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.bunifuFlatButton3);
            this.Controls.Add(this.bunifuFlatButton_Browse);
            this.Controls.Add(label8);
            this.Controls.Add(label7);
            this.Controls.Add(label5);
            this.Controls.Add(label4);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(this.textBox_price);
            this.Controls.Add(this.textBox_recepie);
            this.Controls.Add(this.comboBox_Name);
            this.Controls.Add(this.comboBox_Category);
            this.Controls.Add(this.rbTile);
            this.Controls.Add(this.rbLargeIcon);
            this.Controls.Add(this.myListView);
            this.DoubleBuffered = true;
            this.Name = "UserControl_Manager_CMenu";
            this.Size = new System.Drawing.Size(1580, 948);
            ((System.ComponentModel.ISupportInitialize)(this.foodDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodMenuTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodMenuTableBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbTile;
        private System.Windows.Forms.RadioButton rbLargeIcon;
        private System.Windows.Forms.ListView myListView;
        private System.Windows.Forms.ComboBox comboBox_Category;
        private System.Windows.Forms.ComboBox comboBox_Name;
        private System.Windows.Forms.TextBox textBox_recepie;
        private System.Windows.Forms.TextBox textBox_price;
        private FoodDBDataSet foodDBDataSet;
        private System.Windows.Forms.BindingSource foodMenuTableBindingSource;
        private FoodDBDataSetTableAdapters.FoodMenuTableTableAdapter foodMenuTableTableAdapter;
        private System.Windows.Forms.BindingSource foodMenuTableBindingSource1;
        private FoodDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton_Browse;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
    }
}
