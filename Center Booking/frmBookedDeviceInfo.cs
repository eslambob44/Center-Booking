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
    public partial class frmBookedDeviceInfo : Form
    {

        clsBookingDevice _device;
        public frmBookedDeviceInfo(clsBookingDevice device)
        {
            _device = device;
            InitializeComponent();
        }

        private void frmBookedDeviceInfo_Load(object sender, EventArgs e)
        {
            lblDeviceId.Text = _device.DeviceId;
            if (_device.DateTo == null)
            {
                lblDeviceBookedTime.Text = "Open Time";
                lblRemainTime.Text = "Open Time";
            }
            else
            {
                lblDeviceBookedTime.Text = _device.GetTime().ToString(@"hh\:mm");
                lblRemainTime.Text = _device.GetTimeRemain().ToString(@"hh\:mm");
            }
            lblPlayedTime.Text=_device.GetPlayedTime().ToString(@"hh\:mm");
            lblPlayedCost.Text = _device.GetCostUntilNow().ToString("0.00") + "$";
            lblFinalCost.Text = _device.GetFinalCost().ToString("0.00") + "$";

        }
    }
}
