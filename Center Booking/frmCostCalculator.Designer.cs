namespace Center_Booking
{
    partial class frmCostCalculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbDevices = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnCalculateCost = new Guna.UI2.WinForms.Guna2CircleButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nudHours = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.nudMinutes = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.rbChooseTime = new Guna.UI2.WinForms.Guna2RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpTo = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFrom = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.rbFromDateToDate = new Guna.UI2.WinForms.Guna2RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.chkNow = new Guna.UI2.WinForms.Guna2CheckBox();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Device:";
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
            this.cbDevices.Location = new System.Drawing.Point(99, 57);
            this.cbDevices.Name = "cbDevices";
            this.cbDevices.Size = new System.Drawing.Size(168, 36);
            this.cbDevices.TabIndex = 6;
            this.cbDevices.SelectedIndexChanged += new System.EventHandler(this.cbDevices_SelectedIndexChanged);
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox1.Controls.Add(this.chkNow);
            this.guna2GroupBox1.Controls.Add(this.btnCalculateCost);
            this.guna2GroupBox1.Controls.Add(this.label5);
            this.guna2GroupBox1.Controls.Add(this.label4);
            this.guna2GroupBox1.Controls.Add(this.nudHours);
            this.guna2GroupBox1.Controls.Add(this.nudMinutes);
            this.guna2GroupBox1.Controls.Add(this.rbChooseTime);
            this.guna2GroupBox1.Controls.Add(this.label3);
            this.guna2GroupBox1.Controls.Add(this.dtpTo);
            this.guna2GroupBox1.Controls.Add(this.label2);
            this.guna2GroupBox1.Controls.Add(this.dtpFrom);
            this.guna2GroupBox1.Controls.Add(this.rbFromDateToDate);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(413, 36);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(339, 321);
            this.guna2GroupBox1.TabIndex = 8;
            this.guna2GroupBox1.Text = "Choose Time";
            this.guna2GroupBox1.Visible = false;
            // 
            // btnCalculateCost
            // 
            this.btnCalculateCost.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCalculateCost.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCalculateCost.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCalculateCost.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCalculateCost.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.btnCalculateCost.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCalculateCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.btnCalculateCost.Location = new System.Drawing.Point(234, 245);
            this.btnCalculateCost.Name = "btnCalculateCost";
            this.btnCalculateCost.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnCalculateCost.Size = new System.Drawing.Size(80, 71);
            this.btnCalculateCost.TabIndex = 13;
            this.btnCalculateCost.Text = "Calculate Cost";
            this.btnCalculateCost.Click += new System.EventHandler(this.btnCalculateCost_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(141, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Minutes:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Hours:";
            // 
            // nudHours
            // 
            this.nudHours.AutoRoundedCorners = true;
            this.nudHours.BackColor = System.Drawing.Color.Transparent;
            this.nudHours.BorderRadius = 13;
            this.nudHours.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudHours.Enabled = false;
            this.nudHours.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudHours.IndicateFocus = true;
            this.nudHours.Location = new System.Drawing.Point(40, 276);
            this.nudHours.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.nudHours.Name = "nudHours";
            this.nudHours.Size = new System.Drawing.Size(75, 28);
            this.nudHours.TabIndex = 10;
            this.nudHours.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.nudHours.ValueChanged += new System.EventHandler(this.nudHours_ValueChanged);
            // 
            // nudMinutes
            // 
            this.nudMinutes.AutoRoundedCorners = true;
            this.nudMinutes.BackColor = System.Drawing.Color.Transparent;
            this.nudMinutes.BorderRadius = 13;
            this.nudMinutes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudMinutes.Enabled = false;
            this.nudMinutes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMinutes.Increment = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nudMinutes.IndicateFocus = true;
            this.nudMinutes.Location = new System.Drawing.Point(153, 276);
            this.nudMinutes.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudMinutes.Name = "nudMinutes";
            this.nudMinutes.Size = new System.Drawing.Size(75, 28);
            this.nudMinutes.TabIndex = 9;
            this.nudMinutes.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.nudMinutes.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nudMinutes.ValueChanged += new System.EventHandler(this.nudMinutes_ValueChanged);
            // 
            // rbChooseTime
            // 
            this.rbChooseTime.AutoSize = true;
            this.rbChooseTime.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbChooseTime.CheckedState.BorderThickness = 0;
            this.rbChooseTime.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbChooseTime.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbChooseTime.CheckedState.InnerOffset = -4;
            this.rbChooseTime.Location = new System.Drawing.Point(19, 213);
            this.rbChooseTime.Name = "rbChooseTime";
            this.rbChooseTime.Size = new System.Drawing.Size(94, 19);
            this.rbChooseTime.TabIndex = 5;
            this.rbChooseTime.Text = "Choose Time";
            this.rbChooseTime.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbChooseTime.UncheckedState.BorderThickness = 2;
            this.rbChooseTime.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbChooseTime.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbChooseTime.CheckedChanged += new System.EventHandler(this.rbTime_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.Location = new System.Drawing.Point(178, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "To";
            // 
            // dtpTo
            // 
            this.dtpTo.Checked = true;
            this.dtpTo.CustomFormat = "hh:mm tt";
            this.dtpTo.FillColor = System.Drawing.Color.White;
            this.dtpTo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTo.Location = new System.Drawing.Point(172, 136);
            this.dtpTo.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpTo.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.ShowUpDown = true;
            this.dtpTo.Size = new System.Drawing.Size(125, 36);
            this.dtpTo.TabIndex = 3;
            this.dtpTo.Value = new System.DateTime(2024, 9, 3, 17, 9, 45, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.Location = new System.Drawing.Point(26, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "From";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Checked = true;
            this.dtpFrom.CustomFormat = "hh:mm tt";
            this.dtpFrom.Enabled = false;
            this.dtpFrom.FillColor = System.Drawing.Color.White;
            this.dtpFrom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFrom.Location = new System.Drawing.Point(20, 136);
            this.dtpFrom.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpFrom.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.ShowUpDown = true;
            this.dtpFrom.Size = new System.Drawing.Size(125, 36);
            this.dtpFrom.TabIndex = 1;
            this.dtpFrom.Value = new System.DateTime(2024, 9, 3, 17, 9, 45, 0);
            // 
            // rbFromDateToDate
            // 
            this.rbFromDateToDate.AutoSize = true;
            this.rbFromDateToDate.Checked = true;
            this.rbFromDateToDate.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbFromDateToDate.CheckedState.BorderThickness = 0;
            this.rbFromDateToDate.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbFromDateToDate.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbFromDateToDate.CheckedState.InnerOffset = -4;
            this.rbFromDateToDate.Location = new System.Drawing.Point(19, 70);
            this.rbFromDateToDate.Name = "rbFromDateToDate";
            this.rbFromDateToDate.Size = new System.Drawing.Size(122, 19);
            this.rbFromDateToDate.TabIndex = 0;
            this.rbFromDateToDate.TabStop = true;
            this.rbFromDateToDate.Text = "From Date To Date";
            this.rbFromDateToDate.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbFromDateToDate.UncheckedState.BorderThickness = 2;
            this.rbFromDateToDate.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbFromDateToDate.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbFromDateToDate.CheckedChanged += new System.EventHandler(this.rbTime_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Cost:";
            this.label6.Visible = false;
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost.Location = new System.Drawing.Point(89, 139);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(46, 20);
            this.lblCost.TabIndex = 10;
            this.lblCost.Text = "Cost:";
            this.lblCost.Visible = false;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(89, 105);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(43, 20);
            this.lblTime.TabIndex = 12;
            this.lblTime.Text = "Time";
            this.lblTime.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(32, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Time:";
            this.label8.Visible = false;
            // 
            // chkNow
            // 
            this.chkNow.AutoSize = true;
            this.chkNow.Checked = true;
            this.chkNow.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkNow.CheckedState.BorderRadius = 0;
            this.chkNow.CheckedState.BorderThickness = 0;
            this.chkNow.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkNow.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNow.Location = new System.Drawing.Point(19, 183);
            this.chkNow.Name = "chkNow";
            this.chkNow.Size = new System.Drawing.Size(51, 19);
            this.chkNow.TabIndex = 14;
            this.chkNow.Text = "Now";
            this.chkNow.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkNow.UncheckedState.BorderRadius = 0;
            this.chkNow.UncheckedState.BorderThickness = 0;
            this.chkNow.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkNow.CheckedChanged += new System.EventHandler(this.chkNow_CheckedChanged);
            // 
            // frmCostCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(764, 389);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbDevices);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmCostCalculator";
            this.Text = "Cost Calculator";
            this.Load += new System.EventHandler(this.frmCostCalculator_Load);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cbDevices;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2RadioButton rbFromDateToDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpFrom;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpTo;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2RadioButton rbChooseTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudHours;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudMinutes;
        private Guna.UI2.WinForms.Guna2CircleButton btnCalculateCost;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2CheckBox chkNow;
    }
}