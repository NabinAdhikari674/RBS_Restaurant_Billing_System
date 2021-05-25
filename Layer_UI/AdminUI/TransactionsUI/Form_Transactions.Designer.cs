
namespace RBS_Restaurant_Billing_System.Layer_UI.AdminUI.TransactionsUI
{
    partial class Form_Transactions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Transactions));
            this.rBS_DatabaseDataSet = new RBS_Restaurant_Billing_System.RBS_DatabaseDataSet();
            this.rBS_TransactionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rBS_TransactionsTableAdapter = new RBS_Restaurant_Billing_System.RBS_DatabaseDataSetTableAdapters.RBS_TransactionsTableAdapter();
            this.tableAdapterManager = new RBS_Restaurant_Billing_System.RBS_DatabaseDataSetTableAdapters.TableAdapterManager();
            this.rBS_TransactionsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.rBS_TransactionsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.rBS_TransactionsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.rBS_DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rBS_TransactionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rBS_TransactionsBindingNavigator)).BeginInit();
            this.rBS_TransactionsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rBS_TransactionsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // rBS_DatabaseDataSet
            // 
            this.rBS_DatabaseDataSet.DataSetName = "RBS_DatabaseDataSet";
            this.rBS_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rBS_TransactionsBindingSource
            // 
            this.rBS_TransactionsBindingSource.DataMember = "RBS_Transactions";
            this.rBS_TransactionsBindingSource.DataSource = this.rBS_DatabaseDataSet;
            // 
            // rBS_TransactionsTableAdapter
            // 
            this.rBS_TransactionsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.RBS_MenuTableAdapter = null;
            this.tableAdapterManager.RBS_TransactionsTableAdapter = this.rBS_TransactionsTableAdapter;
            this.tableAdapterManager.RBS_UsersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = RBS_Restaurant_Billing_System.RBS_DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // rBS_TransactionsBindingNavigator
            // 
            this.rBS_TransactionsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.rBS_TransactionsBindingNavigator.BindingSource = this.rBS_TransactionsBindingSource;
            this.rBS_TransactionsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.rBS_TransactionsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.rBS_TransactionsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.rBS_TransactionsBindingNavigatorSaveItem});
            this.rBS_TransactionsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.rBS_TransactionsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.rBS_TransactionsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.rBS_TransactionsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.rBS_TransactionsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.rBS_TransactionsBindingNavigator.Name = "rBS_TransactionsBindingNavigator";
            this.rBS_TransactionsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.rBS_TransactionsBindingNavigator.Size = new System.Drawing.Size(756, 25);
            this.rBS_TransactionsBindingNavigator.TabIndex = 0;
            this.rBS_TransactionsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
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
            // rBS_TransactionsBindingNavigatorSaveItem
            // 
            this.rBS_TransactionsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rBS_TransactionsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("rBS_TransactionsBindingNavigatorSaveItem.Image")));
            this.rBS_TransactionsBindingNavigatorSaveItem.Name = "rBS_TransactionsBindingNavigatorSaveItem";
            this.rBS_TransactionsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.rBS_TransactionsBindingNavigatorSaveItem.Text = "Save Data";
            this.rBS_TransactionsBindingNavigatorSaveItem.Click += new System.EventHandler(this.rBS_TransactionsBindingNavigatorSaveItem_Click);
            // 
            // rBS_TransactionsDataGridView
            // 
            this.rBS_TransactionsDataGridView.AllowUserToOrderColumns = true;
            this.rBS_TransactionsDataGridView.AutoGenerateColumns = false;
            this.rBS_TransactionsDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(17)))), ((int)(((byte)(34)))));
            this.rBS_TransactionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rBS_TransactionsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.rBS_TransactionsDataGridView.DataSource = this.rBS_TransactionsBindingSource;
            this.rBS_TransactionsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rBS_TransactionsDataGridView.Location = new System.Drawing.Point(0, 25);
            this.rBS_TransactionsDataGridView.Name = "rBS_TransactionsDataGridView";
            this.rBS_TransactionsDataGridView.Size = new System.Drawing.Size(756, 535);
            this.rBS_TransactionsDataGridView.TabIndex = 1;
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Cashier";
            this.dataGridViewTextBoxColumn2.HeaderText = "Cashier";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Amount";
            this.dataGridViewTextBoxColumn3.HeaderText = "Amount";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Items";
            this.dataGridViewTextBoxColumn4.HeaderText = "Items";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn5.HeaderText = "Date";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // Form_Transactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(17)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(756, 560);
            this.Controls.Add(this.rBS_TransactionsDataGridView);
            this.Controls.Add(this.rBS_TransactionsBindingNavigator);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_Transactions";
            this.Text = "RBS : Transactions";
            this.Load += new System.EventHandler(this.Form_Transactions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rBS_DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rBS_TransactionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rBS_TransactionsBindingNavigator)).EndInit();
            this.rBS_TransactionsBindingNavigator.ResumeLayout(false);
            this.rBS_TransactionsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rBS_TransactionsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RBS_DatabaseDataSet rBS_DatabaseDataSet;
        private System.Windows.Forms.BindingSource rBS_TransactionsBindingSource;
        private RBS_DatabaseDataSetTableAdapters.RBS_TransactionsTableAdapter rBS_TransactionsTableAdapter;
        private RBS_DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator rBS_TransactionsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton rBS_TransactionsBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView rBS_TransactionsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}