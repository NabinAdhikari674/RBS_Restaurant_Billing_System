
namespace RBS_Restaurant_Billing_System.Layer_UI
{
    partial class Form_Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Dashboard));
            this.fpnl_frmDashboard = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_T1_frmDashboard = new System.Windows.Forms.Button();
            this.btn_T2_frmDashboard = new System.Windows.Forms.Button();
            this.btn_T3_frmDashboard = new System.Windows.Forms.Button();
            this.btn_T4_frmDashboard = new System.Windows.Forms.Button();
            this.btn_T5_frmDashboard = new System.Windows.Forms.Button();
            this.btn_T6_frmDashboard = new System.Windows.Forms.Button();
            this.btn_T7_frmDashboard = new System.Windows.Forms.Button();
            this.btn_T8_frmDashboard = new System.Windows.Forms.Button();
            this.pnl_receipt_frmDashboard = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_print_frmDashboard = new System.Windows.Forms.Button();
            this.btn_pending_frmDashboard = new System.Windows.Forms.Button();
            this.contextMenuStrip_pending = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cancelPendingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_cancel_frmDashboard = new System.Windows.Forms.Button();
            this.btn_checkout_frmDashboard = new System.Windows.Forms.Button();
            this.pnl_billContainer_frmDashboard = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_menu_frmDashboard = new System.Windows.Forms.Button();
            this.lbl_username_frmDashboard = new System.Windows.Forms.Label();
            this.lbl_Date_frmDashboard = new System.Windows.Forms.Label();
            this.rBS_DatabaseDataSet = new RBS_Restaurant_Billing_System.RBS_DatabaseDataSet();
            this.rBSMenuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rBS_MenuTableAdapter = new RBS_Restaurant_Billing_System.RBS_DatabaseDataSetTableAdapters.RBS_MenuTableAdapter();
            this.pnl_MenuContainer_frmDashboard = new System.Windows.Forms.Panel();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.fpnl_frmDashboard.SuspendLayout();
            this.pnl_receipt_frmDashboard.SuspendLayout();
            this.panel3.SuspendLayout();
            this.contextMenuStrip_pending.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rBS_DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rBSMenuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // fpnl_frmDashboard
            // 
            this.fpnl_frmDashboard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fpnl_frmDashboard.AutoScroll = true;
            this.fpnl_frmDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(30)))), ((int)(((byte)(57)))));
            this.fpnl_frmDashboard.Controls.Add(this.btn_T1_frmDashboard);
            this.fpnl_frmDashboard.Controls.Add(this.btn_T2_frmDashboard);
            this.fpnl_frmDashboard.Controls.Add(this.btn_T3_frmDashboard);
            this.fpnl_frmDashboard.Controls.Add(this.btn_T4_frmDashboard);
            this.fpnl_frmDashboard.Controls.Add(this.btn_T5_frmDashboard);
            this.fpnl_frmDashboard.Controls.Add(this.btn_T6_frmDashboard);
            this.fpnl_frmDashboard.Controls.Add(this.btn_T7_frmDashboard);
            this.fpnl_frmDashboard.Controls.Add(this.btn_T8_frmDashboard);
            this.fpnl_frmDashboard.Location = new System.Drawing.Point(0, 3);
            this.fpnl_frmDashboard.Name = "fpnl_frmDashboard";
            this.fpnl_frmDashboard.Size = new System.Drawing.Size(558, 283);
            this.fpnl_frmDashboard.TabIndex = 4;
            // 
            // btn_T1_frmDashboard
            // 
            this.btn_T1_frmDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btn_T1_frmDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_T1_frmDashboard.FlatAppearance.BorderSize = 0;
            this.btn_T1_frmDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(21)))), ((int)(((byte)(51)))));
            this.btn_T1_frmDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_T1_frmDashboard.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_T1_frmDashboard.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_T1_frmDashboard.Location = new System.Drawing.Point(10, 10);
            this.btn_T1_frmDashboard.Margin = new System.Windows.Forms.Padding(10);
            this.btn_T1_frmDashboard.Name = "btn_T1_frmDashboard";
            this.btn_T1_frmDashboard.Size = new System.Drawing.Size(216, 73);
            this.btn_T1_frmDashboard.TabIndex = 0;
            this.btn_T1_frmDashboard.Text = "Table 1";
            this.btn_T1_frmDashboard.UseVisualStyleBackColor = false;
            // 
            // btn_T2_frmDashboard
            // 
            this.btn_T2_frmDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btn_T2_frmDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_T2_frmDashboard.FlatAppearance.BorderSize = 0;
            this.btn_T2_frmDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(21)))), ((int)(((byte)(51)))));
            this.btn_T2_frmDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_T2_frmDashboard.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_T2_frmDashboard.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_T2_frmDashboard.Location = new System.Drawing.Point(246, 10);
            this.btn_T2_frmDashboard.Margin = new System.Windows.Forms.Padding(10);
            this.btn_T2_frmDashboard.Name = "btn_T2_frmDashboard";
            this.btn_T2_frmDashboard.Size = new System.Drawing.Size(216, 73);
            this.btn_T2_frmDashboard.TabIndex = 1;
            this.btn_T2_frmDashboard.Text = "Table 2";
            this.btn_T2_frmDashboard.UseVisualStyleBackColor = false;
            // 
            // btn_T3_frmDashboard
            // 
            this.btn_T3_frmDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btn_T3_frmDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_T3_frmDashboard.FlatAppearance.BorderSize = 0;
            this.btn_T3_frmDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(21)))), ((int)(((byte)(51)))));
            this.btn_T3_frmDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_T3_frmDashboard.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_T3_frmDashboard.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_T3_frmDashboard.Location = new System.Drawing.Point(10, 103);
            this.btn_T3_frmDashboard.Margin = new System.Windows.Forms.Padding(10);
            this.btn_T3_frmDashboard.Name = "btn_T3_frmDashboard";
            this.btn_T3_frmDashboard.Size = new System.Drawing.Size(216, 73);
            this.btn_T3_frmDashboard.TabIndex = 2;
            this.btn_T3_frmDashboard.Text = "Table 3";
            this.btn_T3_frmDashboard.UseVisualStyleBackColor = false;
            // 
            // btn_T4_frmDashboard
            // 
            this.btn_T4_frmDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btn_T4_frmDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_T4_frmDashboard.FlatAppearance.BorderSize = 0;
            this.btn_T4_frmDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(21)))), ((int)(((byte)(51)))));
            this.btn_T4_frmDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_T4_frmDashboard.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_T4_frmDashboard.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_T4_frmDashboard.Location = new System.Drawing.Point(246, 103);
            this.btn_T4_frmDashboard.Margin = new System.Windows.Forms.Padding(10);
            this.btn_T4_frmDashboard.Name = "btn_T4_frmDashboard";
            this.btn_T4_frmDashboard.Size = new System.Drawing.Size(216, 73);
            this.btn_T4_frmDashboard.TabIndex = 3;
            this.btn_T4_frmDashboard.Text = "Table 4";
            this.btn_T4_frmDashboard.UseVisualStyleBackColor = false;
            // 
            // btn_T5_frmDashboard
            // 
            this.btn_T5_frmDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btn_T5_frmDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_T5_frmDashboard.FlatAppearance.BorderSize = 0;
            this.btn_T5_frmDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(21)))), ((int)(((byte)(51)))));
            this.btn_T5_frmDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_T5_frmDashboard.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_T5_frmDashboard.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_T5_frmDashboard.Location = new System.Drawing.Point(10, 196);
            this.btn_T5_frmDashboard.Margin = new System.Windows.Forms.Padding(10);
            this.btn_T5_frmDashboard.Name = "btn_T5_frmDashboard";
            this.btn_T5_frmDashboard.Size = new System.Drawing.Size(216, 73);
            this.btn_T5_frmDashboard.TabIndex = 4;
            this.btn_T5_frmDashboard.Text = "Table 5";
            this.btn_T5_frmDashboard.UseVisualStyleBackColor = false;
            // 
            // btn_T6_frmDashboard
            // 
            this.btn_T6_frmDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btn_T6_frmDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_T6_frmDashboard.FlatAppearance.BorderSize = 0;
            this.btn_T6_frmDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(21)))), ((int)(((byte)(51)))));
            this.btn_T6_frmDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_T6_frmDashboard.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_T6_frmDashboard.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_T6_frmDashboard.Location = new System.Drawing.Point(246, 196);
            this.btn_T6_frmDashboard.Margin = new System.Windows.Forms.Padding(10);
            this.btn_T6_frmDashboard.Name = "btn_T6_frmDashboard";
            this.btn_T6_frmDashboard.Size = new System.Drawing.Size(216, 73);
            this.btn_T6_frmDashboard.TabIndex = 5;
            this.btn_T6_frmDashboard.Text = "Table 6";
            this.btn_T6_frmDashboard.UseVisualStyleBackColor = false;
            // 
            // btn_T7_frmDashboard
            // 
            this.btn_T7_frmDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btn_T7_frmDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_T7_frmDashboard.FlatAppearance.BorderSize = 0;
            this.btn_T7_frmDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(21)))), ((int)(((byte)(51)))));
            this.btn_T7_frmDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_T7_frmDashboard.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_T7_frmDashboard.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_T7_frmDashboard.Location = new System.Drawing.Point(10, 289);
            this.btn_T7_frmDashboard.Margin = new System.Windows.Forms.Padding(10);
            this.btn_T7_frmDashboard.Name = "btn_T7_frmDashboard";
            this.btn_T7_frmDashboard.Size = new System.Drawing.Size(216, 73);
            this.btn_T7_frmDashboard.TabIndex = 6;
            this.btn_T7_frmDashboard.Text = "Table 7";
            this.btn_T7_frmDashboard.UseVisualStyleBackColor = false;
            // 
            // btn_T8_frmDashboard
            // 
            this.btn_T8_frmDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btn_T8_frmDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_T8_frmDashboard.FlatAppearance.BorderSize = 0;
            this.btn_T8_frmDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(21)))), ((int)(((byte)(51)))));
            this.btn_T8_frmDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_T8_frmDashboard.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_T8_frmDashboard.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_T8_frmDashboard.Location = new System.Drawing.Point(246, 289);
            this.btn_T8_frmDashboard.Margin = new System.Windows.Forms.Padding(10);
            this.btn_T8_frmDashboard.Name = "btn_T8_frmDashboard";
            this.btn_T8_frmDashboard.Size = new System.Drawing.Size(216, 73);
            this.btn_T8_frmDashboard.TabIndex = 7;
            this.btn_T8_frmDashboard.Text = "Table 8";
            this.btn_T8_frmDashboard.UseVisualStyleBackColor = false;
            // 
            // pnl_receipt_frmDashboard
            // 
            this.pnl_receipt_frmDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.pnl_receipt_frmDashboard.Controls.Add(this.panel3);
            this.pnl_receipt_frmDashboard.Controls.Add(this.pnl_billContainer_frmDashboard);
            this.pnl_receipt_frmDashboard.Controls.Add(this.panel1);
            this.pnl_receipt_frmDashboard.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_receipt_frmDashboard.Location = new System.Drawing.Point(564, 0);
            this.pnl_receipt_frmDashboard.Name = "pnl_receipt_frmDashboard";
            this.pnl_receipt_frmDashboard.Size = new System.Drawing.Size(410, 611);
            this.pnl_receipt_frmDashboard.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(30)))), ((int)(((byte)(57)))));
            this.panel3.Controls.Add(this.btn_print_frmDashboard);
            this.panel3.Controls.Add(this.btn_pending_frmDashboard);
            this.panel3.Controls.Add(this.btn_cancel_frmDashboard);
            this.panel3.Controls.Add(this.btn_checkout_frmDashboard);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 549);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(410, 62);
            this.panel3.TabIndex = 4;
            // 
            // btn_print_frmDashboard
            // 
            this.btn_print_frmDashboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_print_frmDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btn_print_frmDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_print_frmDashboard.FlatAppearance.BorderSize = 0;
            this.btn_print_frmDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(21)))), ((int)(((byte)(51)))));
            this.btn_print_frmDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_print_frmDashboard.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print_frmDashboard.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_print_frmDashboard.Location = new System.Drawing.Point(347, 13);
            this.btn_print_frmDashboard.Margin = new System.Windows.Forms.Padding(10);
            this.btn_print_frmDashboard.Name = "btn_print_frmDashboard";
            this.btn_print_frmDashboard.Size = new System.Drawing.Size(63, 39);
            this.btn_print_frmDashboard.TabIndex = 6;
            this.btn_print_frmDashboard.Text = "Print";
            this.btn_print_frmDashboard.UseVisualStyleBackColor = false;
            // 
            // btn_pending_frmDashboard
            // 
            this.btn_pending_frmDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btn_pending_frmDashboard.ContextMenuStrip = this.contextMenuStrip_pending;
            this.btn_pending_frmDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pending_frmDashboard.FlatAppearance.BorderSize = 0;
            this.btn_pending_frmDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(21)))), ((int)(((byte)(51)))));
            this.btn_pending_frmDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pending_frmDashboard.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pending_frmDashboard.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_pending_frmDashboard.Location = new System.Drawing.Point(123, 13);
            this.btn_pending_frmDashboard.Margin = new System.Windows.Forms.Padding(10);
            this.btn_pending_frmDashboard.Name = "btn_pending_frmDashboard";
            this.btn_pending_frmDashboard.Size = new System.Drawing.Size(101, 39);
            this.btn_pending_frmDashboard.TabIndex = 5;
            this.btn_pending_frmDashboard.Text = "Pending";
            this.btn_pending_frmDashboard.UseVisualStyleBackColor = false;
            this.btn_pending_frmDashboard.Click += new System.EventHandler(this.btn_pending_frmDashboard_Click);
            // 
            // contextMenuStrip_pending
            // 
            this.contextMenuStrip_pending.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(30)))), ((int)(((byte)(57)))));
            this.contextMenuStrip_pending.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cancelPendingToolStripMenuItem});
            this.contextMenuStrip_pending.Name = "contextMenuStrip_pending";
            this.contextMenuStrip_pending.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStrip_pending.ShowImageMargin = false;
            this.contextMenuStrip_pending.Size = new System.Drawing.Size(133, 26);
            // 
            // cancelPendingToolStripMenuItem
            // 
            this.cancelPendingToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.cancelPendingToolStripMenuItem.Name = "cancelPendingToolStripMenuItem";
            this.cancelPendingToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.cancelPendingToolStripMenuItem.Text = "Cancel Pending";
            this.cancelPendingToolStripMenuItem.Click += new System.EventHandler(this.cancelPendingToolStripMenuItem_Click);
            // 
            // btn_cancel_frmDashboard
            // 
            this.btn_cancel_frmDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btn_cancel_frmDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancel_frmDashboard.FlatAppearance.BorderSize = 0;
            this.btn_cancel_frmDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(21)))), ((int)(((byte)(51)))));
            this.btn_cancel_frmDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel_frmDashboard.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel_frmDashboard.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_cancel_frmDashboard.Location = new System.Drawing.Point(7, 13);
            this.btn_cancel_frmDashboard.Margin = new System.Windows.Forms.Padding(10);
            this.btn_cancel_frmDashboard.Name = "btn_cancel_frmDashboard";
            this.btn_cancel_frmDashboard.Size = new System.Drawing.Size(101, 39);
            this.btn_cancel_frmDashboard.TabIndex = 4;
            this.btn_cancel_frmDashboard.Text = "Cancel";
            this.btn_cancel_frmDashboard.UseVisualStyleBackColor = false;
            this.btn_cancel_frmDashboard.Click += new System.EventHandler(this.btn_cancel_frmDashboard_Click);
            // 
            // btn_checkout_frmDashboard
            // 
            this.btn_checkout_frmDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btn_checkout_frmDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_checkout_frmDashboard.FlatAppearance.BorderSize = 0;
            this.btn_checkout_frmDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(21)))), ((int)(((byte)(51)))));
            this.btn_checkout_frmDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_checkout_frmDashboard.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_checkout_frmDashboard.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_checkout_frmDashboard.Location = new System.Drawing.Point(235, 13);
            this.btn_checkout_frmDashboard.Margin = new System.Windows.Forms.Padding(10);
            this.btn_checkout_frmDashboard.Name = "btn_checkout_frmDashboard";
            this.btn_checkout_frmDashboard.Size = new System.Drawing.Size(101, 39);
            this.btn_checkout_frmDashboard.TabIndex = 3;
            this.btn_checkout_frmDashboard.Text = "Checkout";
            this.btn_checkout_frmDashboard.UseVisualStyleBackColor = false;
            this.btn_checkout_frmDashboard.Click += new System.EventHandler(this.btn_checkout_frmDashboard_Click);
            // 
            // pnl_billContainer_frmDashboard
            // 
            this.pnl_billContainer_frmDashboard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_billContainer_frmDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(30)))), ((int)(((byte)(57)))));
            this.pnl_billContainer_frmDashboard.Location = new System.Drawing.Point(0, 56);
            this.pnl_billContainer_frmDashboard.Name = "pnl_billContainer_frmDashboard";
            this.pnl_billContainer_frmDashboard.Size = new System.Drawing.Size(410, 487);
            this.pnl_billContainer_frmDashboard.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(30)))), ((int)(((byte)(57)))));
            this.panel1.Controls.Add(this.btn_menu_frmDashboard);
            this.panel1.Controls.Add(this.lbl_username_frmDashboard);
            this.panel1.Controls.Add(this.lbl_Date_frmDashboard);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(410, 50);
            this.panel1.TabIndex = 2;
            // 
            // btn_menu_frmDashboard
            // 
            this.btn_menu_frmDashboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_menu_frmDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btn_menu_frmDashboard.BackgroundImage = global::RBS_Restaurant_Billing_System.Properties.Resources.gear;
            this.btn_menu_frmDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_menu_frmDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_menu_frmDashboard.FlatAppearance.BorderSize = 0;
            this.btn_menu_frmDashboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Violet;
            this.btn_menu_frmDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(21)))), ((int)(((byte)(51)))));
            this.btn_menu_frmDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menu_frmDashboard.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_menu_frmDashboard.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_menu_frmDashboard.Location = new System.Drawing.Point(2, 9);
            this.btn_menu_frmDashboard.Margin = new System.Windows.Forms.Padding(10);
            this.btn_menu_frmDashboard.Name = "btn_menu_frmDashboard";
            this.btn_menu_frmDashboard.Size = new System.Drawing.Size(31, 25);
            this.btn_menu_frmDashboard.TabIndex = 7;
            this.btn_menu_frmDashboard.Text = "-";
            this.btn_menu_frmDashboard.UseVisualStyleBackColor = false;
            this.btn_menu_frmDashboard.Click += new System.EventHandler(this.btn_menu_frmDashboard_Click);
            // 
            // lbl_username_frmDashboard
            // 
            this.lbl_username_frmDashboard.AutoSize = true;
            this.lbl_username_frmDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.lbl_username_frmDashboard.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username_frmDashboard.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_username_frmDashboard.Location = new System.Drawing.Point(36, 9);
            this.lbl_username_frmDashboard.Name = "lbl_username_frmDashboard";
            this.lbl_username_frmDashboard.Padding = new System.Windows.Forms.Padding(3);
            this.lbl_username_frmDashboard.Size = new System.Drawing.Size(117, 25);
            this.lbl_username_frmDashboard.TabIndex = 0;
            this.lbl_username_frmDashboard.Text = "User : Leonardo";
            // 
            // lbl_Date_frmDashboard
            // 
            this.lbl_Date_frmDashboard.AutoSize = true;
            this.lbl_Date_frmDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.lbl_Date_frmDashboard.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date_frmDashboard.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Date_frmDashboard.Location = new System.Drawing.Point(156, 9);
            this.lbl_Date_frmDashboard.Name = "lbl_Date_frmDashboard";
            this.lbl_Date_frmDashboard.Padding = new System.Windows.Forms.Padding(3);
            this.lbl_Date_frmDashboard.Size = new System.Drawing.Size(98, 25);
            this.lbl_Date_frmDashboard.TabIndex = 1;
            this.lbl_Date_frmDashboard.Text = "Current Date";
            // 
            // rBS_DatabaseDataSet
            // 
            this.rBS_DatabaseDataSet.DataSetName = "RBS_DatabaseDataSet";
            this.rBS_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rBSMenuBindingSource
            // 
            this.rBSMenuBindingSource.DataMember = "RBS_Menu";
            this.rBSMenuBindingSource.DataSource = this.rBS_DatabaseDataSet;
            // 
            // rBS_MenuTableAdapter
            // 
            this.rBS_MenuTableAdapter.ClearBeforeFill = true;
            // 
            // pnl_MenuContainer_frmDashboard
            // 
            this.pnl_MenuContainer_frmDashboard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_MenuContainer_frmDashboard.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnl_MenuContainer_frmDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(30)))), ((int)(((byte)(57)))));
            this.pnl_MenuContainer_frmDashboard.Location = new System.Drawing.Point(0, 292);
            this.pnl_MenuContainer_frmDashboard.Name = "pnl_MenuContainer_frmDashboard";
            this.pnl_MenuContainer_frmDashboard.Size = new System.Drawing.Size(558, 319);
            this.pnl_MenuContainer_frmDashboard.TabIndex = 5;
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.Visible = false;
            // 
            // Form_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(974, 611);
            this.Controls.Add(this.pnl_receipt_frmDashboard);
            this.Controls.Add(this.pnl_MenuContainer_frmDashboard);
            this.Controls.Add(this.fpnl_frmDashboard);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(990, 650);
            this.Name = "Form_Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RBS : Dashboard";
            this.Load += new System.EventHandler(this.Form_Dashboard_Load);
            this.fpnl_frmDashboard.ResumeLayout(false);
            this.pnl_receipt_frmDashboard.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.contextMenuStrip_pending.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rBS_DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rBSMenuBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel fpnl_frmDashboard;
        private System.Windows.Forms.Button btn_T1_frmDashboard;
        private System.Windows.Forms.Button btn_T2_frmDashboard;
        private System.Windows.Forms.Button btn_T3_frmDashboard;
        private System.Windows.Forms.Button btn_T4_frmDashboard;
        private System.Windows.Forms.Button btn_T5_frmDashboard;
        private System.Windows.Forms.Button btn_T6_frmDashboard;
        private System.Windows.Forms.Button btn_T7_frmDashboard;
        private System.Windows.Forms.Button btn_T8_frmDashboard;
        private System.Windows.Forms.Panel pnl_receipt_frmDashboard;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_pending_frmDashboard;
        private System.Windows.Forms.Button btn_cancel_frmDashboard;
        private System.Windows.Forms.Button btn_checkout_frmDashboard;
        private System.Windows.Forms.Button btn_print_frmDashboard;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_username_frmDashboard;
        private System.Windows.Forms.Label lbl_Date_frmDashboard;
        private RBS_DatabaseDataSet rBS_DatabaseDataSet;
        private System.Windows.Forms.BindingSource rBSMenuBindingSource;
        private RBS_DatabaseDataSetTableAdapters.RBS_MenuTableAdapter rBS_MenuTableAdapter;
        private System.Windows.Forms.Button btn_menu_frmDashboard;
        private System.Windows.Forms.Panel pnl_MenuContainer_frmDashboard;
        private System.Windows.Forms.Panel pnl_billContainer_frmDashboard;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_pending;
        private System.Windows.Forms.ToolStripMenuItem cancelPendingToolStripMenuItem;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
    }
}