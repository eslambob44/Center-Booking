using Center_Booking_Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Center_Booking
{
    public partial class frmCostCalculator : Form
    {
        List<clsDevice> _liDevices;
        public frmCostCalculator(List<clsDevice> liDevices)
        {
            _liDevices = liDevices;
            InitializeComponent();
        }

        void FillcbDevicesWithDevices()
        {
            foreach (clsDevice device in _liDevices)
            {
                cbDevices.Items.Add(device.DeviceName);
            }
        }

        private void frmCostCalculator_Load(object sender, EventArgs e)
        {
            FillcbDevicesWithDevices();
            dtpFrom.Value = DateTime.Now;
            dtpTo.Value = dtpFrom.Value.AddMinutes(15);
        }

        void ChangeTimeInput()
        {
            if(!chkNow.Checked)
                dtpFrom.Enabled=rbFromDateToDate.Checked;

            chkNow.Enabled = rbFromDateToDate.Checked;
            dtpTo.Enabled = rbFromDateToDate.Checked;
            nudMinutes.Enabled = !rbFromDateToDate.Checked;
            nudHours.Enabled = !rbFromDateToDate.Checked;
        }

        private void rbTime_CheckedChanged(object sender, EventArgs e)
        {
            ChangeTimeInput();
        }

        private void nudMinutes_ValueChanged(object sender, EventArgs e)
        {
            if (nudMinutes.Value >= 60)
            {
                nudMinutes.Value = 0;
                nudHours.Value++;
            }

            if (nudMinutes.Value == 0 && nudHours.Value == 0)
            {
                nudMinutes.Value = 15;
            }
        }

        private void nudHours_ValueChanged(object sender, EventArgs e)
        {
            if (nudMinutes.Value == 0 && nudHours.Value == 0)
            {
                nudMinutes.Value = 15;
            }
        }

        private void dtpTo_Validating(object sender, CancelEventArgs e)
        {
            DateTime DateFrom = new DateTime();
            if(!chkNow.Checked)
            {
                DateFrom = DateTime.Now;
            }
            else
            {
                DateFrom=dtpFrom.Value;
            }
            if(dtpTo.Value<=DateFrom)
            {
                MessageBox.Show("Date To Cannot be grater than or equal to Date From", 
                    "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
            else
            {
                e.Cancel=false;
            }
        }

        private void cbDevices_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbDevices.SelectedIndex != -1)
            {
                guna2GroupBox1.Visible = true;
            }
        }

        TimeSpan GetTime()
        {
            if(rbFromDateToDate.Checked)
            {
                if(chkNow.Checked) 
                {
                    dtpFrom.Value=DateTime.Now;
                }
                if (dtpFrom.Value >= dtpTo.Value)
                    return new TimeSpan(24,0,0)+(dtpTo.Value - dtpFrom.Value);
                else
                    return dtpTo.Value - dtpFrom.Value;
            }
            else
            {
                return new TimeSpan((int)nudHours.Value,(int)nudMinutes.Value,0);
            }
        }

        float CalculateCost(clsDevice device , TimeSpan Time)
        {
            float Cost = 0;
            Cost = Time.Hours * device.DeviceHourRate;
            Cost += ((float)Time.Minutes / 60) * device.DeviceHourRate;
            return Cost;
        }

        private void btnCalculateCost_Click(object sender, EventArgs e)
        {
            TimeSpan Time = GetTime();
            label8.Visible = true;
            lblTime.Visible = true;
            label6.Visible = true;
            lblCost.Visible = true;
            lblCost.Text = CalculateCost(_liDevices[cbDevices.SelectedIndex], Time).ToString("0.00")+"$";
            lblTime.Text = Time.ToString(@"hh\:mm");
        }

        private void chkNow_CheckedChanged(object sender, EventArgs e)
        {
            dtpFrom.Enabled = !chkNow.Checked;
            
        }
    }
}
