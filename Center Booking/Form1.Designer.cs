namespace Center_Booking
{
    partial class frmCenterBooking
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBookDevice = new Guna.UI2.WinForms.Guna2Button();
            this.nudNumberOfDevices = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tswOpenTime = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nudHours = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.nudMinutes = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.cbDevices = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lvBookingDevices = new System.Windows.Forms.ListView();
            this.colDeviceId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDateFrom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDateTo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsDevices = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BookedDeviceInfoStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.devicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deviceInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.toolStripContainer2 = new System.Windows.Forms.ToolStripContainer();
            this.timerDeviceBookingTimeEnd = new System.Windows.Forms.Timer(this.components);
            this.ntfBookedDeviceEnd = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfDevices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutes)).BeginInit();
            this.cmsDevices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.toolStripContainer2.ContentPanel.SuspendLayout();
            this.toolStripContainer2.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.btnBookDevice);
            this.panel1.Controls.Add(this.nudNumberOfDevices);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tswOpenTime);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.nudHours);
            this.panel1.Controls.Add(this.nudMinutes);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbDevices);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 571);
            this.panel1.TabIndex = 0;
            // 
            // btnBookDevice
            // 
            this.btnBookDevice.AutoRoundedCorners = true;
            this.btnBookDevice.BorderRadius = 21;
            this.btnBookDevice.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBookDevice.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBookDevice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBookDevice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBookDevice.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnBookDevice.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnBookDevice.ForeColor = System.Drawing.Color.White;
            this.btnBookDevice.Location = new System.Drawing.Point(50, 516);
            this.btnBookDevice.Name = "btnBookDevice";
            this.btnBookDevice.Size = new System.Drawing.Size(180, 45);
            this.btnBookDevice.TabIndex = 14;
            this.btnBookDevice.Text = "Book Devive";
            this.btnBookDevice.Click += new System.EventHandler(this.btnBookDevice_Click);
            // 
            // nudNumberOfDevices
            // 
            this.nudNumberOfDevices.AutoRoundedCorners = true;
            this.nudNumberOfDevices.BackColor = System.Drawing.Color.Transparent;
            this.nudNumberOfDevices.BorderRadius = 13;
            this.nudNumberOfDevices.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudNumberOfDevices.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudNumberOfDevices.IndicateFocus = true;
            this.nudNumberOfDevices.Location = new System.Drawing.Point(151, 449);
            this.nudNumberOfDevices.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumberOfDevices.Name = "nudNumberOfDevices";
            this.nudNumberOfDevices.Size = new System.Drawing.Size(75, 28);
            this.nudNumberOfDevices.TabIndex = 13;
            this.nudNumberOfDevices.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 412);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(172, 22);
            this.label7.TabIndex = 12;
            this.label7.Text = "Number Of Devices:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(34, 359);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "Open Time:";
            // 
            // tswOpenTime
            // 
            this.tswOpenTime.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tswOpenTime.CheckedState.FillColor = System.Drawing.Color.DarkRed;
            this.tswOpenTime.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.tswOpenTime.CheckedState.InnerColor = System.Drawing.Color.White;
            this.tswOpenTime.Location = new System.Drawing.Point(138, 360);
            this.tswOpenTime.Name = "tswOpenTime";
            this.tswOpenTime.Size = new System.Drawing.Size(43, 20);
            this.tswOpenTime.TabIndex = 10;
            this.tswOpenTime.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tswOpenTime.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tswOpenTime.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.tswOpenTime.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.tswOpenTime.CheckedChanged += new System.EventHandler(this.tswOpenTime_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(139, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Minutes:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Hours:";
            // 
            // nudHours
            // 
            this.nudHours.AutoRoundedCorners = true;
            this.nudHours.BackColor = System.Drawing.Color.Transparent;
            this.nudHours.BorderRadius = 13;
            this.nudHours.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudHours.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudHours.IndicateFocus = true;
            this.nudHours.Location = new System.Drawing.Point(38, 301);
            this.nudHours.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.nudHours.Name = "nudHours";
            this.nudHours.Size = new System.Drawing.Size(75, 28);
            this.nudHours.TabIndex = 6;
            this.nudHours.ValueChanged += new System.EventHandler(this.nudHours_ValueChanged);
            this.nudHours.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.guna2NumericUpDown1_KeyPress);
            // 
            // nudMinutes
            // 
            this.nudMinutes.AutoRoundedCorners = true;
            this.nudMinutes.BackColor = System.Drawing.Color.Transparent;
            this.nudMinutes.BorderRadius = 13;
            this.nudMinutes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudMinutes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMinutes.Increment = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nudMinutes.IndicateFocus = true;
            this.nudMinutes.Location = new System.Drawing.Point(151, 301);
            this.nudMinutes.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudMinutes.Name = "nudMinutes";
            this.nudMinutes.Size = new System.Drawing.Size(75, 28);
            this.nudMinutes.TabIndex = 5;
            this.nudMinutes.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nudMinutes.ValueChanged += new System.EventHandler(this.nudMinutes_ValueChanged);
            this.nudMinutes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.guna2NumericUpDown1_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Booking Time:";
            // 
            // cbDevices
            // 
            this.cbDevices.AutoRoundedCorners = true;
            this.cbDevices.BackColor = System.Drawing.Color.Transparent;
            this.cbDevices.BorderRadius = 17;
            this.cbDevices.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDevices.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbDevices.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbDevices.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbDevices.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbDevices.ItemHeight = 30;
            this.cbDevices.Location = new System.Drawing.Point(69, 165);
            this.cbDevices.Name = "cbDevices";
            this.cbDevices.Size = new System.Drawing.Size(168, 36);
            this.cbDevices.TabIndex = 3;
            this.cbDevices.Validating += new System.ComponentModel.CancelEventHandler(this.cbDevices_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Device:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Book Device";
            // 
            // lvBookingDevices
            // 
            this.lvBookingDevices.BackColor = System.Drawing.Color.White;
            this.lvBookingDevices.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvBookingDevices.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colDeviceId,
            this.colDateFrom,
            this.colDateTo});
            this.lvBookingDevices.ContextMenuStrip = this.cmsDevices;
            this.lvBookingDevices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvBookingDevices.FullRowSelect = true;
            this.lvBookingDevices.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvBookingDevices.HideSelection = false;
            this.lvBookingDevices.Location = new System.Drawing.Point(280, 0);
            this.lvBookingDevices.Name = "lvBookingDevices";
            this.lvBookingDevices.Size = new System.Drawing.Size(697, 571);
            this.lvBookingDevices.TabIndex = 1;
            this.lvBookingDevices.UseCompatibleStateImageBehavior = false;
            this.lvBookingDevices.View = System.Windows.Forms.View.Details;
            // 
            // colDeviceId
            // 
            this.colDeviceId.Text = "Device Id";
            this.colDeviceId.Width = 273;
            // 
            // colDateFrom
            // 
            this.colDateFrom.Text = "Date From";
            this.colDateFrom.Width = 202;
            // 
            // colDateTo
            // 
            this.colDateTo.Text = "Date To";
            this.colDateTo.Width = 183;
            // 
            // cmsDevices
            // 
            this.cmsDevices.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem,
            this.BookedDeviceInfoStripMenuItem});
            this.cmsDevices.Name = "cmsDevices";
            this.cmsDevices.Size = new System.Drawing.Size(177, 48);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.deleteToolStripMenuItem.Text = "&Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // BookedDeviceInfoStripMenuItem
            // 
            this.BookedDeviceInfoStripMenuItem.Name = "BookedDeviceInfoStripMenuItem";
            this.BookedDeviceInfoStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.BookedDeviceInfoStripMenuItem.Text = "Booked Device Info";
            this.BookedDeviceInfoStripMenuItem.Click += new System.EventHandler(this.BookedDeviceInfoStripMenuItem_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.devicesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(977, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // devicesToolStripMenuItem
            // 
            this.devicesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deviceInfoToolStripMenuItem,
            this.calculatorToolStripMenuItem});
            this.devicesToolStripMenuItem.Name = "devicesToolStripMenuItem";
            this.devicesToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.devicesToolStripMenuItem.Text = "&Devices";
            // 
            // deviceInfoToolStripMenuItem
            // 
            this.deviceInfoToolStripMenuItem.Name = "deviceInfoToolStripMenuItem";
            this.deviceInfoToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.deviceInfoToolStripMenuItem.Text = "Device &Info";
            this.deviceInfoToolStripMenuItem.Click += new System.EventHandler(this.deviceInfoToolStripMenuItem_Click);
            // 
            // calculatorToolStripMenuItem
            // 
            this.calculatorToolStripMenuItem.Name = "calculatorToolStripMenuItem";
            this.calculatorToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.calculatorToolStripMenuItem.Text = "&Calculator";
            this.calculatorToolStripMenuItem.Click += new System.EventHandler(this.calculatorToolStripMenuItem_Click);
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.AutoScroll = true;
            this.toolStripContainer1.ContentPanel.Controls.Add(this.lvBookingDevices);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.panel1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(977, 571);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(977, 596);
            this.toolStripContainer1.TabIndex = 3;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer2
            // 
            this.toolStripContainer2.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer2.ContentPanel
            // 
            this.toolStripContainer2.ContentPanel.AutoScroll = true;
            this.toolStripContainer2.ContentPanel.Controls.Add(this.toolStripContainer1);
            this.toolStripContainer2.ContentPanel.Size = new System.Drawing.Size(977, 596);
            this.toolStripContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer2.LeftToolStripPanelVisible = false;
            this.toolStripContainer2.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer2.Name = "toolStripContainer2";
            this.toolStripContainer2.RightToolStripPanelVisible = false;
            this.toolStripContainer2.Size = new System.Drawing.Size(977, 620);
            this.toolStripContainer2.TabIndex = 4;
            this.toolStripContainer2.Text = "toolStripContainer2";
            // 
            // toolStripContainer2.TopToolStripPanel
            // 
            this.toolStripContainer2.TopToolStripPanel.Controls.Add(this.menuStrip1);
            // 
            // timerDeviceBookingTimeEnd
            // 
            this.timerDeviceBookingTimeEnd.Enabled = true;
            this.timerDeviceBookingTimeEnd.Interval = 1000;
            this.timerDeviceBookingTimeEnd.Tick += new System.EventHandler(this.timerDeviceBookingTimeEnd_Tick);
            // 
            // ntfBookedDeviceEnd
            // 
            this.ntfBookedDeviceEnd.BalloonTipText = "Temp";
            this.ntfBookedDeviceEnd.BalloonTipTitle = "Temp";
            this.ntfBookedDeviceEnd.Text = "Device End";
            this.ntfBookedDeviceEnd.Visible = true;
            // 
            // frmCenterBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(977, 620);
            this.Controls.Add(this.toolStripContainer2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmCenterBooking";
            this.Text = "Center Booking";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfDevices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutes)).EndInit();
            this.cmsDevices.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.toolStripContainer2.ContentPanel.ResumeLayout(false);
            this.toolStripContainer2.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer2.TopToolStripPanel.PerformLayout();
            this.toolStripContainer2.ResumeLayout(false);
            this.toolStripContainer2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lvBookingDevices;
        private System.Windows.Forms.ColumnHeader colDateFrom;
        private System.Windows.Forms.ColumnHeader colDateTo;
        private System.Windows.Forms.ColumnHeader colDeviceId;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cbDevices;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudMinutes;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudHours;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2ToggleSwitch tswOpenTime;
        private Guna.UI2.WinForms.Guna2Button btnBookDevice;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudNumberOfDevices;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ContextMenuStrip cmsDevices;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem devicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deviceInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStripMenuItem BookedDeviceInfoStripMenuItem;
        private System.Windows.Forms.ToolStripContainer toolStripContainer2;
        private System.Windows.Forms.Timer timerDeviceBookingTimeEnd;
        private System.Windows.Forms.NotifyIcon ntfBookedDeviceEnd;
    }
}

