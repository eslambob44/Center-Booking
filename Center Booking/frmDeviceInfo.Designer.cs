namespace Center_Booking
{
    partial class frmDeviceInfo
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
            this.cbDevices = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDeviceName = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblDeviceHourRate = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNumberOfAvailableDevices = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblNumberOfDevices = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblNumberOfBookedDevices = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.cbDevices.Location = new System.Drawing.Point(79, 59);
            this.cbDevices.Name = "cbDevices";
            this.cbDevices.Size = new System.Drawing.Size(168, 36);
            this.cbDevices.TabIndex = 4;
            this.cbDevices.SelectedIndexChanged += new System.EventHandler(this.cbDevices_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Device:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Device Name:";
            // 
            // lblDeviceName
            // 
            this.lblDeviceName.AutoSize = true;
            this.lblDeviceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeviceName.Location = new System.Drawing.Point(144, 50);
            this.lblDeviceName.Name = "lblDeviceName";
            this.lblDeviceName.Size = new System.Drawing.Size(51, 20);
            this.lblDeviceName.TabIndex = 7;
            this.lblDeviceName.Text = "Name";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.lblNumberOfBookedDevices);
            this.guna2Panel1.Controls.Add(this.label6);
            this.guna2Panel1.Controls.Add(this.lblDeviceHourRate);
            this.guna2Panel1.Controls.Add(this.label4);
            this.guna2Panel1.Controls.Add(this.lblNumberOfAvailableDevices);
            this.guna2Panel1.Controls.Add(this.label5);
            this.guna2Panel1.Controls.Add(this.lblNumberOfDevices);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.lblDeviceName);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2Panel1.Location = new System.Drawing.Point(319, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(334, 349);
            this.guna2Panel1.TabIndex = 8;
            this.guna2Panel1.Visible = false;
            // 
            // lblDeviceHourRate
            // 
            this.lblDeviceHourRate.AutoSize = true;
            this.lblDeviceHourRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeviceHourRate.Location = new System.Drawing.Point(178, 290);
            this.lblDeviceHourRate.Name = "lblDeviceHourRate";
            this.lblDeviceHourRate.Size = new System.Drawing.Size(51, 20);
            this.lblDeviceHourRate.TabIndex = 13;
            this.lblDeviceHourRate.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Device Hour Rate:";
            // 
            // lblNumberOfAvailableDevices
            // 
            this.lblNumberOfAvailableDevices.AutoSize = true;
            this.lblNumberOfAvailableDevices.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfAvailableDevices.Location = new System.Drawing.Point(271, 230);
            this.lblNumberOfAvailableDevices.Name = "lblNumberOfAvailableDevices";
            this.lblNumberOfAvailableDevices.Size = new System.Drawing.Size(51, 20);
            this.lblNumberOfAvailableDevices.TabIndex = 11;
            this.lblNumberOfAvailableDevices.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(245, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Number Of Available Devices:";
            // 
            // lblNumberOfDevices
            // 
            this.lblNumberOfDevices.AutoSize = true;
            this.lblNumberOfDevices.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfDevices.Location = new System.Drawing.Point(189, 110);
            this.lblNumberOfDevices.Name = "lblNumberOfDevices";
            this.lblNumberOfDevices.Size = new System.Drawing.Size(51, 20);
            this.lblNumberOfDevices.TabIndex = 9;
            this.lblNumberOfDevices.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Number Of Devices:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(234, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Number Of Booked Devices:";
            // 
            // lblNumberOfBookedDevices
            // 
            this.lblNumberOfBookedDevices.AutoSize = true;
            this.lblNumberOfBookedDevices.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfBookedDevices.Location = new System.Drawing.Point(260, 170);
            this.lblNumberOfBookedDevices.Name = "lblNumberOfBookedDevices";
            this.lblNumberOfBookedDevices.Size = new System.Drawing.Size(51, 20);
            this.lblNumberOfBookedDevices.TabIndex = 15;
            this.lblNumberOfBookedDevices.Text = "Name";
            // 
            // frmDeviceInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(653, 349);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbDevices);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmDeviceInfo";
            this.Text = "Device Info";
            this.Load += new System.EventHandler(this.frmDeviceInfo_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox cbDevices;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDeviceName;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNumberOfAvailableDevices;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblNumberOfDevices;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDeviceHourRate;
        private System.Windows.Forms.Label lblNumberOfBookedDevices;
        private System.Windows.Forms.Label label6;
    }
}