using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Center_Booking_Devices
{
    public class clsDevice
    {
        
        private static string _Path { get; }
        public int Id { get; }
        public string DeviceName { get; }
        public int NumberOfDevices { get;}
        public float DeviceHourRate { get;}

        private int _AvailableDevices;
        public int AvailableDevices
        {
            get
            {
                return _AvailableDevices;
            }

            set
            {
                if(value>=0)
                    _AvailableDevices = value;
            }
        }


        public bool IsThereAvailableDevices()
        {
            return _AvailableDevices > 0;
        }
        static clsDevice()
        {
            _Path= @"C:\Users\"+Environment.UserName+@"\Documents\Devices.txt";
        }

        public clsDevice(int Id ,string deviceName, int numberOfDevices, float deviceHourRate)
        {
            this.Id = Id;
            DeviceName = deviceName;
            NumberOfDevices = numberOfDevices;
            DeviceHourRate = deviceHourRate;
            _AvailableDevices = NumberOfDevices;
        }

        private static clsDevice ConvertLineRecordIntoObject(string Line)
        {
            string[] Delim = { "/##/" };
            string[] Lines = Line.Split(Delim,StringSplitOptions.RemoveEmptyEntries);
            return new clsDevice(Convert.ToInt32(Line[0]),Lines[1], Convert.ToInt32(Lines[2]), Convert.ToSingle(Lines[3]));
        }

        public static List<clsDevice> GetDevices()
        {
            if(File.Exists(_Path))
            {
                StreamReader srDevices = new StreamReader(_Path);
                string Line;
                List<clsDevice> liDevices = new List<clsDevice>();
                while((Line = srDevices.ReadLine())!=null)
                {
                    liDevices.Add(ConvertLineRecordIntoObject(Line));
                }
                srDevices.Close();
                return liDevices;
            }
            return null;
        }

        public new string ToString()
        {
            return Id+ "/##/" + DeviceName + "/##/" + NumberOfDevices + "/##/" + DeviceHourRate;

        }



        public static void SaveDevices(List<clsDevice> Devices)
        {

            StreamWriter swDevices = new StreamWriter(_Path);
            foreach(clsDevice device in Devices)
            {
                swDevices.WriteLine(device.ToString());
            }
            swDevices.Close();
        }
    }
}
