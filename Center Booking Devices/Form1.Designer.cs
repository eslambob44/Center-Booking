namespace Center_Booking_Devices
{
    partial class frmCenterDevicesControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlAddDevices = new Guna.UI2.WinForms.Guna2Panel();
            this.btnAddDevice = new Guna.UI2.WinForms.Guna2Button();
            this.txtDeviceHourRage = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nudNumberOfDevices = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDeviceName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDevices = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colDeviceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumberOfDevices = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDeviceHourRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errUnvalidInput = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlAddDevices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfDevices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevices)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errUnvalidInput)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAddDevices
            // 
            this.pnlAddDevices.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pnlAddDevices.Controls.Add(this.btnAddDevice);
            this.pnlAddDevices.Controls.Add(this.txtDeviceHourRage);
            this.pnlAddDevices.Controls.Add(this.label4);
            this.pnlAddDevices.Controls.Add(this.nudNumberOfDevices);
            this.pnlAddDevices.Controls.Add(this.label3);
            this.pnlAddDevices.Controls.Add(this.txtDeviceName);
            this.pnlAddDevices.Controls.Add(this.label2);
            this.pnlAddDevices.Controls.Add(this.label1);
            this.pnlAddDevices.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlAddDevices.Location = new System.Drawing.Point(0, 0);
            this.pnlAddDevices.Name = "pnlAddDevices";
            this.pnlAddDevices.Size = new System.Drawing.Size(232, 564);
            this.pnlAddDevices.TabIndex = 0;
            // 
            // btnAddDevice
            // 
            this.btnAddDevice.AutoRoundedCorners = true;
            this.btnAddDevice.BorderRadius = 21;
            this.btnAddDevice.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddDevice.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddDevice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddDevice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddDevice.FillColor = System.Drawing.Color.Blue;
            this.btnAddDevice.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDevice.ForeColor = System.Drawing.Color.Black;
            this.btnAddDevice.Location = new System.Drawing.Point(26, 435);
            this.btnAddDevice.Name = "btnAddDevice";
            this.btnAddDevice.Size = new System.Drawing.Size(180, 45);
            this.btnAddDevice.TabIndex = 3;
            this.btnAddDevice.Text = "Add Device";
            this.btnAddDevice.Click += new System.EventHandler(this.btnAddDevice_Click);
            // 
            // txtDeviceHourRage
            // 
            this.txtDeviceHourRage.AutoRoundedCorners = true;
            this.txtDeviceHourRage.BorderRadius = 17;
            this.txtDeviceHourRage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDeviceHourRage.DefaultText = "";
            this.txtDeviceHourRage.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDeviceHourRage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDeviceHourRage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDeviceHourRage.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDeviceHourRage.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDeviceHourRage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDeviceHourRage.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDeviceHourRage.Location = new System.Drawing.Point(46, 354);
            this.txtDeviceHourRage.Name = "txtDeviceHourRage";
            this.txtDeviceHourRage.PasswordChar = '\0';
            this.txtDeviceHourRage.PlaceholderText = "Device Hour Rate";
            this.txtDeviceHourRage.SelectedText = "";
            this.txtDeviceHourRage.Size = new System.Drawing.Size(156, 36);
            this.txtDeviceHourRage.TabIndex = 2;
            this.txtDeviceHourRage.Validating += new System.ComponentModel.CancelEventHandler(this.txtDeviceHourRage_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Device Hour Rate:";
            // 
            // nudNumberOfDevices
            // 
            this.nudNumberOfDevices.AutoRoundedCorners = true;
            this.nudNumberOfDevices.BackColor = System.Drawing.Color.Transparent;
            this.nudNumberOfDevices.BorderRadius = 17;
            this.nudNumberOfDevices.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudNumberOfDevices.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nudNumberOfDevices.Location = new System.Drawing.Point(74, 250);
            this.nudNumberOfDevices.Name = "nudNumberOfDevices";
            this.nudNumberOfDevices.Size = new System.Drawing.Size(100, 36);
            this.nudNumberOfDevices.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Number Of Devices:";
            // 
            // txtDeviceName
            // 
            this.txtDeviceName.AutoRoundedCorners = true;
            this.txtDeviceName.BorderRadius = 17;
            this.txtDeviceName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDeviceName.DefaultText = "";
            this.txtDeviceName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDeviceName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDeviceName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDeviceName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDeviceName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDeviceName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDeviceName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDeviceName.Location = new System.Drawing.Point(46, 150);
            this.txtDeviceName.Name = "txtDeviceName";
            this.txtDeviceName.PasswordChar = '\0';
            this.txtDeviceName.PlaceholderText = "Device Name";
            this.txtDeviceName.SelectedText = "";
            this.txtDeviceName.Size = new System.Drawing.Size(156, 36);
            this.txtDeviceName.TabIndex = 0;
            this.txtDeviceName.Validating += new System.ComponentModel.CancelEventHandler(this.txtDeviceName_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Device Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Device";
            // 
            // dgvDevices
            // 
            this.dgvDevices.AllowUserToAddRows = false;
            this.dgvDevices.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDevices.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDevices.BackgroundColor = System.Drawing.Color.DarkBlue;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDevices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDevices.ColumnHeadersHeight = 22;
            this.dgvDevices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDeviceName,
            this.colNumberOfDevices,
            this.colDeviceHourRate});
            this.dgvDevices.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDevices.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDevices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDevices.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.dgvDevices.Location = new System.Drawing.Point(232, 0);
            this.dgvDevices.MultiSelect = false;
            this.dgvDevices.Name = "dgvDevices";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.MediumBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDevices.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDevices.RowHeadersVisible = false;
            this.dgvDevices.Size = new System.Drawing.Size(790, 564);
            this.dgvDevices.TabIndex = 4;
            this.dgvDevices.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Blue;
            this.dgvDevices.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            this.dgvDevices.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDevices.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvDevices.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvDevices.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvDevices.ThemeStyle.BackColor = System.Drawing.Color.DarkBlue;
            this.dgvDevices.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.dgvDevices.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            this.dgvDevices.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDevices.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDevices.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDevices.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDevices.ThemeStyle.HeaderStyle.Height = 22;
            this.dgvDevices.ThemeStyle.ReadOnly = false;
            this.dgvDevices.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            this.dgvDevices.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDevices.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDevices.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvDevices.ThemeStyle.RowsStyle.Height = 22;
            this.dgvDevices.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            this.dgvDevices.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvDevices.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDevices_CellValidated);
            this.dgvDevices.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvDevices_CellValidating);
            // 
            // colDeviceName
            // 
            this.colDeviceName.HeaderText = "Device Name";
            this.colDeviceName.Name = "colDeviceName";
            // 
            // colNumberOfDevices
            // 
            this.colNumberOfDevices.HeaderText = "Number Of Devices";
            this.colNumberOfDevices.Name = "colNumberOfDevices";
            // 
            // colDeviceHourRate
            // 
            this.colDeviceHourRate.HeaderText = "Device Hour Rate";
            this.colDeviceHourRate.Name = "colDeviceHourRate";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(132, 26);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.deleteToolStripMenuItem.Text = "&Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click_1);
            // 
            // errUnvalidInput
            // 
            this.errUnvalidInput.ContainerControl = this;
            // 
            // frmCenterDevicesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(1022, 564);
            this.Controls.Add(this.dgvDevices);
            this.Controls.Add(this.pnlAddDevices);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmCenterDevicesControl";
            this.Text = "Center Devices";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCenterDevicesControl_FormClosing);
            this.Load += new System.EventHandler(this.frmCenterDevicesControl_Load);
            this.pnlAddDevices.ResumeLayout(false);
            this.pnlAddDevices.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfDevices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevices)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errUnvalidInput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlAddDevices;
        private Guna.UI2.WinForms.Guna2DataGridView dgvDevices;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDeviceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumberOfDevices;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDeviceHourRate;
        private Guna.UI2.WinForms.Guna2TextBox txtDeviceName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudNumberOfDevices;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button btnAddDevice;
        private Guna.UI2.WinForms.Guna2TextBox txtDeviceHourRage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errUnvalidInput;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}

