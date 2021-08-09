namespace RMS_MPD.Customer
{
    partial class Customer_Signup
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
            System.Windows.Forms.Label fullnameLabel;
            System.Windows.Forms.Label socialIDLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label phoneNumberLabel;
            System.Windows.Forms.Label passwordLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer_Signup));
            this.customersInfoDataSet = new RMS_MPD.CustomersInfoDataSet();
            this.customersInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersInfoTableAdapter = new RMS_MPD.CustomersInfoDataSetTableAdapters.CustomersInfoTableAdapter();
            this.tableAdapterManager = new RMS_MPD.CustomersInfoDataSetTableAdapters.TableAdapterManager();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.label_Error = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.confirmpasswordTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.socialIDTextBox = new System.Windows.Forms.TextBox();
            this.fullnameTextBox = new System.Windows.Forms.TextBox();
            this.ConpasswordLabel = new System.Windows.Forms.Label();
            this.button_Signup = new Bunifu.Framework.UI.BunifuFlatButton();
            this.button_Exit = new System.Windows.Forms.Button();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            fullnameLabel = new System.Windows.Forms.Label();
            socialIDLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            phoneNumberLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.customersInfoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersInfoBindingSource)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fullnameLabel
            // 
            fullnameLabel.AutoSize = true;
            fullnameLabel.BackColor = System.Drawing.Color.Transparent;
            fullnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fullnameLabel.ForeColor = System.Drawing.Color.White;
            fullnameLabel.Location = new System.Drawing.Point(103, 189);
            fullnameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            fullnameLabel.Name = "fullnameLabel";
            fullnameLabel.Size = new System.Drawing.Size(119, 29);
            fullnameLabel.TabIndex = 1;
            fullnameLabel.Text = "Fullname:";
            // 
            // socialIDLabel
            // 
            socialIDLabel.AutoSize = true;
            socialIDLabel.BackColor = System.Drawing.Color.Transparent;
            socialIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            socialIDLabel.ForeColor = System.Drawing.Color.White;
            socialIDLabel.Location = new System.Drawing.Point(107, 264);
            socialIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            socialIDLabel.Name = "socialIDLabel";
            socialIDLabel.Size = new System.Drawing.Size(115, 29);
            socialIDLabel.TabIndex = 3;
            socialIDLabel.Text = "Social ID:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.BackColor = System.Drawing.Color.Transparent;
            emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            emailLabel.ForeColor = System.Drawing.Color.White;
            emailLabel.Location = new System.Drawing.Point(142, 344);
            emailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(80, 29);
            emailLabel.TabIndex = 5;
            emailLabel.Text = "Email:";
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.BackColor = System.Drawing.Color.Transparent;
            phoneNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            phoneNumberLabel.ForeColor = System.Drawing.Color.White;
            phoneNumberLabel.Location = new System.Drawing.Point(40, 418);
            phoneNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new System.Drawing.Size(182, 29);
            phoneNumberLabel.TabIndex = 7;
            phoneNumberLabel.Text = "Phone Number:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.BackColor = System.Drawing.Color.Transparent;
            passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            passwordLabel.ForeColor = System.Drawing.Color.White;
            passwordLabel.Location = new System.Drawing.Point(96, 496);
            passwordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(126, 29);
            passwordLabel.TabIndex = 9;
            passwordLabel.Text = "Password:";
            // 
            // customersInfoDataSet
            // 
            this.customersInfoDataSet.DataSetName = "CustomersInfoDataSet";
            this.customersInfoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersInfoBindingSource
            // 
            this.customersInfoBindingSource.DataMember = "CustomersInfo";
            this.customersInfoBindingSource.DataSource = this.customersInfoDataSet;
            // 
            // customersInfoTableAdapter
            // 
            this.customersInfoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomersInfoTableAdapter = this.customersInfoTableAdapter;
            this.tableAdapterManager.UpdateOrder = RMS_MPD.CustomersInfoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.Black;
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.label_Error);
            this.bunifuGradientPanel1.Controls.Add(this.label2);
            this.bunifuGradientPanel1.Controls.Add(this.confirmpasswordTextBox);
            this.bunifuGradientPanel1.Controls.Add(this.passwordTextBox);
            this.bunifuGradientPanel1.Controls.Add(this.phoneNumberTextBox);
            this.bunifuGradientPanel1.Controls.Add(this.emailTextBox);
            this.bunifuGradientPanel1.Controls.Add(this.socialIDTextBox);
            this.bunifuGradientPanel1.Controls.Add(this.fullnameTextBox);
            this.bunifuGradientPanel1.Controls.Add(this.ConpasswordLabel);
            this.bunifuGradientPanel1.Controls.Add(fullnameLabel);
            this.bunifuGradientPanel1.Controls.Add(socialIDLabel);
            this.bunifuGradientPanel1.Controls.Add(this.button_Signup);
            this.bunifuGradientPanel1.Controls.Add(emailLabel);
            this.bunifuGradientPanel1.Controls.Add(this.button_Exit);
            this.bunifuGradientPanel1.Controls.Add(phoneNumberLabel);
            this.bunifuGradientPanel1.Controls.Add(passwordLabel);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.SlateBlue;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.Black;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.MidnightBlue;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Black;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(716, 869);
            this.bunifuGradientPanel1.TabIndex = 12;
            // 
            // label_Error
            // 
            this.label_Error.AutoSize = true;
            this.label_Error.BackColor = System.Drawing.Color.Transparent;
            this.label_Error.ForeColor = System.Drawing.Color.Red;
            this.label_Error.Location = new System.Drawing.Point(191, 658);
            this.label_Error.Name = "label_Error";
            this.label_Error.Size = new System.Drawing.Size(60, 21);
            this.label_Error.TabIndex = 81;
            this.label_Error.Text = "label1";
            this.label_Error.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(91, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(565, 32);
            this.label2.TabIndex = 80;
            this.label2.Text = "Enter you\'re information to create an account";
            // 
            // confirmpasswordTextBox
            // 
            this.confirmpasswordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.confirmpasswordTextBox.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.confirmpasswordTextBox.Location = new System.Drawing.Point(243, 571);
            this.confirmpasswordTextBox.Multiline = true;
            this.confirmpasswordTextBox.Name = "confirmpasswordTextBox";
            this.confirmpasswordTextBox.Size = new System.Drawing.Size(433, 38);
            this.confirmpasswordTextBox.TabIndex = 6;
            this.confirmpasswordTextBox.UseSystemPasswordChar = true;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.passwordTextBox.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.passwordTextBox.Location = new System.Drawing.Point(244, 494);
            this.passwordTextBox.Multiline = true;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(433, 38);
            this.passwordTextBox.TabIndex = 5;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.phoneNumberTextBox.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.phoneNumberTextBox.Location = new System.Drawing.Point(244, 417);
            this.phoneNumberTextBox.Multiline = true;
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(433, 38);
            this.phoneNumberTextBox.TabIndex = 4;
            // 
            // emailTextBox
            // 
            this.emailTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.emailTextBox.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.emailTextBox.Location = new System.Drawing.Point(243, 340);
            this.emailTextBox.Multiline = true;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(433, 38);
            this.emailTextBox.TabIndex = 3;
            // 
            // socialIDTextBox
            // 
            this.socialIDTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.socialIDTextBox.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.socialIDTextBox.Location = new System.Drawing.Point(243, 263);
            this.socialIDTextBox.Multiline = true;
            this.socialIDTextBox.Name = "socialIDTextBox";
            this.socialIDTextBox.Size = new System.Drawing.Size(433, 38);
            this.socialIDTextBox.TabIndex = 2;
            // 
            // fullnameTextBox
            // 
            this.fullnameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.fullnameTextBox.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.fullnameTextBox.Location = new System.Drawing.Point(243, 186);
            this.fullnameTextBox.Multiline = true;
            this.fullnameTextBox.Name = "fullnameTextBox";
            this.fullnameTextBox.Size = new System.Drawing.Size(433, 38);
            this.fullnameTextBox.TabIndex = 1;
            // 
            // ConpasswordLabel
            // 
            this.ConpasswordLabel.AllowDrop = true;
            this.ConpasswordLabel.AutoSize = true;
            this.ConpasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.ConpasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConpasswordLabel.ForeColor = System.Drawing.Color.White;
            this.ConpasswordLabel.Location = new System.Drawing.Point(6, 572);
            this.ConpasswordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ConpasswordLabel.Name = "ConpasswordLabel";
            this.ConpasswordLabel.Size = new System.Drawing.Size(216, 29);
            this.ConpasswordLabel.TabIndex = 79;
            this.ConpasswordLabel.Text = "Confirm Password:";
            // 
            // button_Signup
            // 
            this.button_Signup.Activecolor = System.Drawing.Color.Blue;
            this.button_Signup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button_Signup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Signup.BorderRadius = 30;
            this.button_Signup.ButtonText = "                         Signup";
            this.button_Signup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Signup.Font = new System.Drawing.Font("Century Gothic", 90F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Signup.Iconcolor = System.Drawing.Color.Transparent;
            this.button_Signup.Iconimage = null;
            this.button_Signup.Iconimage_right = null;
            this.button_Signup.Iconimage_right_Selected = null;
            this.button_Signup.Iconimage_Selected = null;
            this.button_Signup.IconZoom = 110D;
            this.button_Signup.IsTab = false;
            this.button_Signup.Location = new System.Drawing.Point(204, 722);
            this.button_Signup.Margin = new System.Windows.Forms.Padding(5);
            this.button_Signup.Name = "button_Signup";
            this.button_Signup.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button_Signup.OnHovercolor = System.Drawing.Color.Navy;
            this.button_Signup.OnHoverTextColor = System.Drawing.Color.White;
            this.button_Signup.selected = false;
            this.button_Signup.Size = new System.Drawing.Size(325, 75);
            this.button_Signup.TabIndex = 7;
            this.button_Signup.TabStop = false;
            this.button_Signup.Textcolor = System.Drawing.Color.White;
            this.button_Signup.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Signup.Click += new System.EventHandler(this.button_Signup_Click);
            // 
            // button_Exit
            // 
            this.button_Exit.BackColor = System.Drawing.Color.Transparent;
            this.button_Exit.BackgroundImage = global::RMS_MPD.Properties.Resources.Exit;
            this.button_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Exit.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button_Exit.FlatAppearance.BorderSize = 0;
            this.button_Exit.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button_Exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Exit.Location = new System.Drawing.Point(633, 2);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(70, 68);
            this.button_Exit.TabIndex = 5;
            this.button_Exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_Exit.UseVisualStyleBackColor = false;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 35;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.bunifuGradientPanel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // Customer_Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(716, 869);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Customer_Signup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer_Signup";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Customer_Signup_FormClosing);
            this.Load += new System.EventHandler(this.Customer_Signup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customersInfoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersInfoBindingSource)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomersInfoDataSet customersInfoDataSet;
        private System.Windows.Forms.BindingSource customersInfoBindingSource;
        private CustomersInfoDataSetTableAdapters.CustomersInfoTableAdapter customersInfoTableAdapter;
        private CustomersInfoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuFlatButton button_Signup;
        private System.Windows.Forms.Button button_Exit;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Label ConpasswordLabel;
        private System.Windows.Forms.TextBox fullnameTextBox;
        private System.Windows.Forms.TextBox confirmpasswordTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox socialIDTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_Error;
    }
}