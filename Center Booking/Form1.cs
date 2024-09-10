using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Center_Booking_Devices;

namespace Center_Booking
{
    public partial class frmCenterBooking : Form
    {
        public frmCenterBooking()
        {
            InitializeComponent();
        }

        List<clsBookingDevice> liBookedDevices = new List<clsBookingDevice>();

        List<clsDevice> liDevices = new List<clsDevice>();

        void _FillcbDevicesWithDevices()
        {
            foreach (clsDevice device in liDevices)
            {
                cbDevices.Items.Add(device.DeviceName);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            liDevices = clsDevice.GetDevices();
            _FillcbDevicesWithDevices();
        }

        private void guna2NumericUpDown1_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
        }

        private void guna2NumericUpDown1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
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

        private void tswOpenTime_CheckedChanged(object sender, EventArgs e)
        {
            nudMinutes.Enabled = !tswOpenTime.Checked;
            nudHours.Enabled = !tswOpenTime.Checked;
        }

        void BookDevice(clsDevice device)
        {
            if (tswOpenTime.Checked)
            {
                liBookedDevices.Add(clsBookingDevice.BookDevice(device, DateTime.Now));
            }
            else
            {
                DateTime DateTo = DateTime.Now.Add(new TimeSpan((int)nudHours.Value, (int)nudMinutes.Value, 0));
                liBookedDevices.Add(clsBookingDevice.BookDevice(device, DateTime.Now, DateTo));
            }
        }

        void AddBookingDeviceTolvBookingDevices(clsBookingDevice device)
        {
            ListViewItem lviBookedDevice = new ListViewItem(device.DeviceId);
            lviBookedDevice.SubItems.Add(device.DateFrom.ToString("hh:mm tt"));
            if (device.DateTo != null)
            {
                lviBookedDevice.SubItems.Add(device.DateTo.Value.ToString("hh:mm tt"));
            }
            else
            {
                lviBookedDevice.SubItems.Add("Open Time");
            }

            lvBookingDevices.Items.Add(lviBookedDevice);
        }

        void ResetInput()
        {
            cbDevices.SelectedIndex = -1;
            tswOpenTime.Checked = false;
            nudHours.Value = 0;
            nudMinutes.Value = 15;
            nudNumberOfDevices.Value = 1;
        }

        private void btnBookDevice_Click(object sender, EventArgs e)
        {
            if (cbDevices.SelectedIndex == -1)
            {
                MessageBox.Show("Choose a device", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (nudNumberOfDevices.Value > liDevices[cbDevices.SelectedIndex].AvailableDevices)
            {
                MessageBox.Show($"Number of {liDevices[cbDevices.SelectedIndex].DeviceName} Available Is {liDevices[cbDevices.SelectedIndex].AvailableDevices} "
                    , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            for (int i = 1; i <= nudNumberOfDevices.Value; i++)
            {
                BookDevice(liDevices[cbDevices.SelectedIndex]);
                AddBookingDeviceTolvBookingDevices(liBookedDevices[liBookedDevices.Count - 1]);
            }


            ResetInput();


        }

        private void nudHours_ValueChanged(object sender, EventArgs e)
        {
            if (nudMinutes.Value == 0 && nudHours.Value == 0)
            {
                nudMinutes.Value = 15;
            }
        }

        private void cbDevices_Validating(object sender, CancelEventArgs e)
        {
            if (cbDevices.SelectedIndex == -1)
            {
                errorProvider1.SetError(cbDevices, "Choose a device");
            }
            else
            {
                errorProvider1.SetError(cbDevices, "");
            }
        }

        string GetDeviceDetails(clsBookingDevice device)
        {
            string Details = "";
            Details += "Device Id: " + device.DeviceId + Environment.NewLine;
            Details += "Time: ";
            if (device.DateTo != null)
            {
                Details += device.GetTime().ToString(@"hh\:mm") + Environment.NewLine;
            }
            else
            {
                Details += "Open Time" + Environment.NewLine;
            }
            Details += "Time Played: " + device.GetPlayedTime().ToString(@"hh\:mm") + Environment.NewLine;

            if (device.DateTo != null)
            {
                Details += "Time Remains: ";
                Details += device.GetTimeRemain().ToString(@"hh\:mm") + Environment.NewLine;

            }
            Details += "Cost For Now: " + device.GetCostUntilNow().ToString("0.00") + "$" + Environment.NewLine;
            Details += "Final Cost: ";
            if (device.DateTo != null)
            {
                Details += device.GetFinalCost().ToString("0.00") + "$" + Environment.NewLine;

            }
            else
            {
                Details += device.GetCostUntilNow().ToString("0.00") + "$" + Environment.NewLine;
            }

            return Details;

        }

        void DeleteBookedDevice(ushort Index)
        {

            liBookedDevices[Index].Device.AvailableDevices++;
            liBookedDevices.RemoveAt(Index);
            lvBookingDevices.SelectedItems[0].Remove();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvBookingDevices.SelectedItems.Count>0)
            {
                foreach(ListViewItem lviBookedDevice in lvBookingDevices.SelectedItems)
                {
                    if (MessageBox.Show(GetDeviceDetails(liBookedDevices[lviBookedDevice.Index])
                , "Are you sure you want to delete this?"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        ushort Index = ((ushort)lviBookedDevice.Index);
                        DeleteBookedDevice(Index);
                    }
                }

                
            }


        }

        private void deviceInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmDeviceInfo(liDevices);
            frm.ShowDialog();
        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmCostCalculator(liDevices);
            frm.ShowDialog();
        }

        private void BookedDeviceInfoStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvBookingDevices.SelectedItems.Count == 1)
            {
                clsBookingDevice BookedDevice = liBookedDevices[lvBookingDevices.SelectedItems[0].Index];
                Form frm = new frmBookedDeviceInfo(BookedDevice);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Must select only one device","",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

        }

        private void timerDeviceBookingTimeEnd_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < liBookedDevices.Count; i++)
            {
                {
                    if (liBookedDevices[i].DateTo != null)
                    {
                        if (liBookedDevices[i].DateTo.Value.Hour == DateTime.Now.Hour && liBookedDevices[i].DateTo.Value.Minute == DateTime.Now.Minute && liBookedDevices[i].DateTo.Value.Second == DateTime.Now.Second)
                        {
                            ntfBookedDeviceEnd.Icon = this.Icon;
                            ntfBookedDeviceEnd.BalloonTipTitle = liBookedDevices[i].DeviceId + " End Time";
                            ntfBookedDeviceEnd.BalloonTipText = liBookedDevices[i].DeviceId + " End Time" + Environment.NewLine + "Cost: " + liBookedDevices[i].GetFinalCost().ToString("0.00") + "$";
                            ntfBookedDeviceEnd.ShowBalloonTip(5000);
                            lvBookingDevices.Items[i].BackColor = Color.Red;
                        }
                    }
                }
            }


        }
    }
}
