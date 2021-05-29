
namespace RBS_Restaurant_Billing_System.Layer_UI.AdminUI.UsersUI
{
    partial class Form_AddUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_AddUsers));
            this.rBS_DatabaseDataSet = new RBS_Restaurant_Billing_System.RBS_DatabaseDataSet();
            this.rBS_UsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rBS_UsersTableAdapter = new RBS_Restaurant_Billing_System.RBS_DatabaseDataSetTableAdapters.RBS_UsersTableAdapter();
            this.tableAdapterManager = new RBS_Restaurant_Billing_System.RBS_DatabaseDataSetTableAdapters.TableAdapterManager();
            this.rBS_UsersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.rBS_UsersBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_update = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.rBS_UsersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_AddUserContainer_frmAD = new System.Windows.Forms.Panel();
            this.comboBox_Role = new System.Windows.Forms.ComboBox();
            this.btn_addUser_frmAD = new System.Windows.Forms.Button();
            this.input_address = new System.Windows.Forms.TextBox();
            this.input_phone = new System.Windows.Forms.TextBox();
            this.input_email = new System.Windows.Forms.TextBox();
            this.input_password = new System.Windows.Forms.TextBox();
            this.input_username = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_paswordEmptymsg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rBS_DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rBS_UsersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rBS_UsersBindingNavigator)).BeginInit();
            this.rBS_UsersBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rBS_UsersDataGridView)).BeginInit();
            this.pnl_AddUserContainer_frmAD.SuspendLayout();
            this.SuspendLayout();
            // 
            // rBS_DatabaseDataSet
            // 
            this.rBS_DatabaseDataSet.DataSetName = "RBS_DatabaseDataSet";
            this.rBS_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rBS_UsersBindingSource
            // 
            this.rBS_UsersBindingSource.DataMember = "RBS_Users";
            this.rBS_UsersBindingSource.DataSource = this.rBS_DatabaseDataSet;
            // 
            // rBS_UsersTableAdapter
            // 
            this.rBS_UsersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.RBS_MenuTableAdapter = null;
            this.tableAdapterManager.RBS_TransactionsTableAdapter = null;
            this.tableAdapterManager.RBS_UsersTableAdapter = this.rBS_UsersTableAdapter;
            this.tableAdapterManager.UpdateOrder = RBS_Restaurant_Billing_System.RBS_DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // rBS_UsersBindingNavigator
            // 
            this.rBS_UsersBindingNavigator.AddNewItem = null;
            this.rBS_UsersBindingNavigator.BindingSource = this.rBS_UsersBindingSource;
            this.rBS_UsersBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.rBS_UsersBindingNavigator.DeleteItem = null;
            this.rBS_UsersBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.rBS_UsersBindingNavigatorSaveItem,
            this.toolStripButton1,
            this.toolStripButton_update,
            this.toolStripLabel1});
            this.rBS_UsersBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.rBS_UsersBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.rBS_UsersBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.rBS_UsersBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.rBS_UsersBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.rBS_UsersBindingNavigator.Name = "rBS_UsersBindingNavigator";
            this.rBS_UsersBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.rBS_UsersBindingNavigator.Size = new System.Drawing.Size(756, 25);
            this.rBS_UsersBindingNavigator.TabIndex = 0;
            this.rBS_UsersBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // rBS_UsersBindingNavigatorSaveItem
            // 
            this.rBS_UsersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rBS_UsersBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("rBS_UsersBindingNavigatorSaveItem.Image")));
            this.rBS_UsersBindingNavigatorSaveItem.Name = "rBS_UsersBindingNavigatorSaveItem";
            this.rBS_UsersBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.rBS_UsersBindingNavigatorSaveItem.Text = "Save Data";
            this.rBS_UsersBindingNavigatorSaveItem.Click += new System.EventHandler(this.rBS_UsersBindingNavigatorSaveItem_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::RBS_Restaurant_Billing_System.Properties.Resources.plus_icon;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "add_user_button";
            this.toolStripButton1.ToolTipText = "Add User";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton_update
            // 
            this.toolStripButton_update.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_update.Image = global::RBS_Restaurant_Billing_System.Properties.Resources.update_icon;
            this.toolStripButton_update.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_update.Name = "toolStripButton_update";
            this.toolStripButton_update.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_update.Text = "Update User";
            this.toolStripButton_update.Click += new System.EventHandler(this.toolStripButton_update_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(137, 22);
            this.toolStripLabel1.Text = "Passwords are Encrypted";
            // 
            // rBS_UsersDataGridView
            // 
            this.rBS_UsersDataGridView.AllowUserToAddRows = false;
            this.rBS_UsersDataGridView.AllowUserToDeleteRows = false;
            this.rBS_UsersDataGridView.AllowUserToOrderColumns = true;
            this.rBS_UsersDataGridView.AutoGenerateColumns = false;
            this.rBS_UsersDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(17)))), ((int)(((byte)(34)))));
            this.rBS_UsersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rBS_UsersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.Password});
            this.rBS_UsersDataGridView.DataSource = this.rBS_UsersBindingSource;
            this.rBS_UsersDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.rBS_UsersDataGridView.Location = new System.Drawing.Point(0, 25);
            this.rBS_UsersDataGridView.Name = "rBS_UsersDataGridView";
            this.rBS_UsersDataGridView.Size = new System.Drawing.Size(756, 340);
            this.rBS_UsersDataGridView.TabIndex = 1;
            this.rBS_UsersDataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.rBS_UsersDataGridView_RowHeaderMouseClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 40;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Username";
            this.dataGridViewTextBoxColumn2.HeaderText = "Username";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn3.HeaderText = "Email";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Role";
            this.dataGridViewTextBoxColumn5.HeaderText = "Role";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 80;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Phone";
            this.dataGridViewTextBoxColumn6.HeaderText = "Phone";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn7.HeaderText = "Address";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // Password
            // 
            this.Password.DataPropertyName = "Password";
            this.Password.HeaderText = "Password";
            this.Password.Name = "Password";
            this.Password.Visible = false;
            // 
            // pnl_AddUserContainer_frmAD
            // 
            this.pnl_AddUserContainer_frmAD.Controls.Add(this.lbl_paswordEmptymsg);
            this.pnl_AddUserContainer_frmAD.Controls.Add(this.comboBox_Role);
            this.pnl_AddUserContainer_frmAD.Controls.Add(this.btn_addUser_frmAD);
            this.pnl_AddUserContainer_frmAD.Controls.Add(this.input_address);
            this.pnl_AddUserContainer_frmAD.Controls.Add(this.input_phone);
            this.pnl_AddUserContainer_frmAD.Controls.Add(this.input_email);
            this.pnl_AddUserContainer_frmAD.Controls.Add(this.input_password);
            this.pnl_AddUserContainer_frmAD.Controls.Add(this.input_username);
            this.pnl_AddUserContainer_frmAD.Controls.Add(this.label6);
            this.pnl_AddUserContainer_frmAD.Controls.Add(this.label5);
            this.pnl_AddUserContainer_frmAD.Controls.Add(this.label4);
            this.pnl_AddUserContainer_frmAD.Controls.Add(this.label3);
            this.pnl_AddUserContainer_frmAD.Controls.Add(this.label2);
            this.pnl_AddUserContainer_frmAD.Controls.Add(this.label1);
            this.pnl_AddUserContainer_frmAD.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_AddUserContainer_frmAD.Location = new System.Drawing.Point(0, 371);
            this.pnl_AddUserContainer_frmAD.MinimumSize = new System.Drawing.Size(756, 189);
            this.pnl_AddUserContainer_frmAD.Name = "pnl_AddUserContainer_frmAD";
            this.pnl_AddUserContainer_frmAD.Size = new System.Drawing.Size(756, 189);
            this.pnl_AddUserContainer_frmAD.TabIndex = 2;
            this.pnl_AddUserContainer_frmAD.Visible = false;
            // 
            // comboBox_Role
            // 
            this.comboBox_Role.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(17)))), ((int)(((byte)(34)))));
            this.comboBox_Role.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_Role.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.comboBox_Role.FormattingEnabled = true;
            this.comboBox_Role.Items.AddRange(new object[] {
            "User",
            "Admin"});
            this.comboBox_Role.Location = new System.Drawing.Point(325, 70);
            this.comboBox_Role.Name = "comboBox_Role";
            this.comboBox_Role.Size = new System.Drawing.Size(168, 27);
            this.comboBox_Role.TabIndex = 13;
            this.comboBox_Role.Text = "User";
            // 
            // btn_addUser_frmAD
            // 
            this.btn_addUser_frmAD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btn_addUser_frmAD.FlatAppearance.BorderSize = 0;
            this.btn_addUser_frmAD.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.btn_addUser_frmAD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(20)))), ((int)(((byte)(50)))));
            this.btn_addUser_frmAD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addUser_frmAD.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_addUser_frmAD.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn_addUser_frmAD.Location = new System.Drawing.Point(325, 132);
            this.btn_addUser_frmAD.Name = "btn_addUser_frmAD";
            this.btn_addUser_frmAD.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_addUser_frmAD.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_addUser_frmAD.Size = new System.Drawing.Size(168, 45);
            this.btn_addUser_frmAD.TabIndex = 12;
            this.btn_addUser_frmAD.Text = "Add User";
            this.btn_addUser_frmAD.UseVisualStyleBackColor = false;
            this.btn_addUser_frmAD.Click += new System.EventHandler(this.btn_addUser_frmAD_Click);
            // 
            // input_address
            // 
            this.input_address.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(17)))), ((int)(((byte)(34)))));
            this.input_address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.input_address.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.input_address.Location = new System.Drawing.Point(575, 70);
            this.input_address.Multiline = true;
            this.input_address.Name = "input_address";
            this.input_address.Size = new System.Drawing.Size(168, 27);
            this.input_address.TabIndex = 11;
            // 
            // input_phone
            // 
            this.input_phone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(17)))), ((int)(((byte)(34)))));
            this.input_phone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.input_phone.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.input_phone.Location = new System.Drawing.Point(574, 27);
            this.input_phone.Name = "input_phone";
            this.input_phone.Size = new System.Drawing.Size(168, 27);
            this.input_phone.TabIndex = 10;
            // 
            // input_email
            // 
            this.input_email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(17)))), ((int)(((byte)(34)))));
            this.input_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.input_email.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.input_email.Location = new System.Drawing.Point(325, 27);
            this.input_email.Name = "input_email";
            this.input_email.Size = new System.Drawing.Size(168, 27);
            this.input_email.TabIndex = 8;
            // 
            // input_password
            // 
            this.input_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(17)))), ((int)(((byte)(34)))));
            this.input_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.input_password.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.input_password.Location = new System.Drawing.Point(93, 70);
            this.input_password.Name = "input_password";
            this.input_password.Size = new System.Drawing.Size(168, 27);
            this.input_password.TabIndex = 7;
            // 
            // input_username
            // 
            this.input_username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(17)))), ((int)(((byte)(34)))));
            this.input_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.input_username.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.input_username.Location = new System.Drawing.Point(93, 27);
            this.input_username.Name = "input_username";
            this.input_username.Size = new System.Drawing.Size(168, 27);
            this.input_username.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label6.Location = new System.Drawing.Point(508, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(508, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Phone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(274, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Role";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(12, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(274, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // lbl_paswordEmptymsg
            // 
            this.lbl_paswordEmptymsg.AutoSize = true;
            this.lbl_paswordEmptymsg.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_paswordEmptymsg.Location = new System.Drawing.Point(12, 100);
            this.lbl_paswordEmptymsg.Name = "lbl_paswordEmptymsg";
            this.lbl_paswordEmptymsg.Size = new System.Drawing.Size(267, 19);
            this.lbl_paswordEmptymsg.TabIndex = 14;
            this.lbl_paswordEmptymsg.Text = "Leave EMPTY To NOT Change Password";
            this.lbl_paswordEmptymsg.Visible = false;
            // 
            // Form_AddUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(17)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(756, 560);
            this.Controls.Add(this.pnl_AddUserContainer_frmAD);
            this.Controls.Add(this.rBS_UsersDataGridView);
            this.Controls.Add(this.rBS_UsersBindingNavigator);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_AddUsers";
            this.Text = "RBS : Add Users";
            this.Load += new System.EventHandler(this.Form_AddUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rBS_DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rBS_UsersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rBS_UsersBindingNavigator)).EndInit();
            this.rBS_UsersBindingNavigator.ResumeLayout(false);
            this.rBS_UsersBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rBS_UsersDataGridView)).EndInit();
            this.pnl_AddUserContainer_frmAD.ResumeLayout(false);
            this.pnl_AddUserContainer_frmAD.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RBS_DatabaseDataSet rBS_DatabaseDataSet;
        private System.Windows.Forms.BindingSource rBS_UsersBindingSource;
        private RBS_DatabaseDataSetTableAdapters.RBS_UsersTableAdapter rBS_UsersTableAdapter;
        private RBS_DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator rBS_UsersBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton rBS_UsersBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView rBS_UsersDataGridView;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Panel pnl_AddUserContainer_frmAD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox input_username;
        private System.Windows.Forms.TextBox input_address;
        private System.Windows.Forms.TextBox input_phone;
        private System.Windows.Forms.TextBox input_email;
        private System.Windows.Forms.TextBox input_password;
        private System.Windows.Forms.Button btn_addUser_frmAD;
        private System.Windows.Forms.ToolStripButton toolStripButton_update;
        private System.Windows.Forms.ComboBox comboBox_Role;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.Label lbl_paswordEmptymsg;
    }
}