using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Center_Booking_Devices
{
    public partial class frmCenterDevicesControl : Form
    {
        public frmCenterDevicesControl()
        {
            InitializeComponent();
        }

        bool CheckEmptytxt(Guna2TextBox txt,string ErrorMessage)
        {
            if(txt.Text=="")
            {

                errUnvalidInput.SetError(txt, ErrorMessage);
                return true;
            }
            return false;
        }

        private void txtDeviceName_Validating(object sender, CancelEventArgs e)
        {
            if(!CheckEmptytxt(txtDeviceName,"Must Enter Name"))
            {   
                errUnvalidInput.SetError(txtDeviceName, "");
            }

        }

        private void txtDeviceHourRage_Validating(object sender, CancelEventArgs e)
        {
            if (!CheckEmptytxt(txtDeviceHourRage, "Must Enter Valid Number"))
            {
                float Value;
                if(!(float.TryParse(txtDeviceHourRage.Text,out Value)))
                {
                    errUnvalidInput.SetError(txtDeviceHourRage, "Must Enter Valid Number");

                }
                else
                {
                    errUnvalidInput.SetError(txtDeviceHourRage, "");
                }
                
            }
        }

        bool IsValidInput()
        {
            float DeviceHourRate;
            if (txtDeviceHourRage.Text == "" || !float.TryParse(txtDeviceHourRage.Text, out DeviceHourRate))
                return false;
            
            if(txtDeviceName.Text=="")
                return false;

            return true;
        }

        void ShowNotValidInputError()
        {
            MessageBox.Show("Complete Data!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        void AddDataTodgvDevices(string DeviceName, int NumberOfDevices, float DeviceHourRate)
        {
            object[] data = { DeviceName, NumberOfDevices, DeviceHourRate +"$" };

            dgvDevices.Rows.Add(data);
        }

        void ResetInput()
        {
            txtDeviceName.Clear();
            txtDeviceHourRage.Clear();
            nudNumberOfDevices.Value = 0;
        }
        private void btnAddDevice_Click(object sender, EventArgs e)
        {
            if(!IsValidInput())
            {
                ShowNotValidInputError();
                return;
            }
            
            AddDataTodgvDevices(txtDeviceName.Text,(int)nudNumberOfDevices.Value,float.Parse(txtDeviceHourRage.Text));
            ResetInput();
        }

        private void deleteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (dgvDevices.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Are You Sure To Delete "+ dgvDevices.SelectedRows[0].Cells[0].Value.ToString(), "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dgvDevices.Rows.RemoveAt(dgvDevices.SelectedRows[0].Index);
                }
            }
        }

        private void frmCenterDevicesControl_Load(object sender, EventArgs e)
        {
            List<clsDevice> Devices = clsDevice.GetDevices();
            if (Devices != null)
            {
                foreach (clsDevice device in Devices)
                {
                    AddDataTodgvDevices(device.DeviceName, device.NumberOfDevices, device.DeviceHourRate);
                }
            }
            
        }

        clsDevice ConvertdgvRowIntoObject(DataGridViewRow row ,  int Id)
        {
            string DeviceName = row.Cells[0].Value.ToString();
            int NumberOfDevices = Convert.ToInt32(row.Cells[1].Value);
            float DeviceHourRate = Convert.ToSingle(row.Cells[2].Value.ToString().Substring(0, row.Cells[2].Value.ToString().Count() - 1));
            return new clsDevice(Id ,DeviceName, NumberOfDevices, DeviceHourRate);
        }

        private void frmCenterDevicesControl_FormClosing(object sender, FormClosingEventArgs e)
        {
            List<clsDevice> Devices = new List<clsDevice>();
            foreach (DataGridViewRow row in dgvDevices.Rows)
            {
                Devices.Add(ConvertdgvRowIntoObject(row,Devices.Count+1));
            }

            clsDevice.SaveDevices(Devices);
        }

        private void dgvDevices_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {

            if (e.FormattedValue.ToString() == "")
            {
                e.Cancel = true;
                return;
            }

            if (e.ColumnIndex==2)
            {
                float value;
                if (e.FormattedValue.ToString().IndexOf("$")!=-1&&!float.TryParse(e.FormattedValue.ToString().Substring(0, e.FormattedValue.ToString().Count()-1), out value))
                {
                    e.Cancel = true;
                    MessageBox.Show("Enter Numeric Value");
                    return;
                }
                else if(e.FormattedValue.ToString().IndexOf("$") == -1 && !float.TryParse(e.FormattedValue.ToString(),out value))
                {
                    e.Cancel = true;
                    MessageBox.Show("Enter Numeric Value");
                    return;
                }
                else
                {
                    e.Cancel= false;
                }
            }

            

            if(e.ColumnIndex==1)
            {
                float value;
                if(!float.TryParse(e.FormattedValue.ToString(),out value))
                {
                    e.Cancel = true;
                    MessageBox.Show("Enter Numeric Value");
                    return;
                }
                else
                {
                    e.Cancel= false;
                }
            }
        }

        private void dgvDevices_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex==2)
            {
                if(dgvDevices.SelectedCells[2].Value.ToString().IndexOf("$")==-1)
                    dgvDevices.SelectedCells[2].Value += "$";
            }
        }

    }
}
