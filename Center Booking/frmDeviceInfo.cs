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
    public partial class frmDeviceInfo : Form
    {
        List<clsDevice> _liDevices;
        public frmDeviceInfo(List<clsDevice> liDevices)
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

        private void frmDeviceInfo_Load(object sender, EventArgs e)
        {
            FillcbDevicesWithDevices();
        }

        void ShowDeviceDetails(clsDevice device)
        {
            lblDeviceName.Text = device.DeviceName;
            lblNumberOfDevices.Text=device.NumberOfDevices.ToString();
            lblNumberOfAvailableDevices.Text=device.AvailableDevices.ToString();
            lblDeviceHourRate.Text = device.DeviceHourRate + "$";
            lblNumberOfBookedDevices.Text = (device.NumberOfDevices - device.AvailableDevices).ToString();
        }

        private void cbDevices_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbDevices.SelectedIndex !=-1) 
            {
                guna2Panel1.Visible = true;
                ShowDeviceDetails(_liDevices[cbDevices.SelectedIndex]);
            }
           

        }
    }
}
