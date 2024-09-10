using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Center_Booking_Devices
{
    public class clsBookingDevice
    {
        public short PlayerId { get; }
        public clsDevice Device { get; }
        public DateTime DateFrom { get; }
        public Nullable<DateTime> DateTo { get; set; }
        private string _DeviceId;
        public string DeviceId
        {
            get
            {
                return _DeviceId;
            }
        }

        private string _setDeviceId(short playerId)
        {
            return Device.DeviceName + " (" + PlayerId+")";
        }


        private clsBookingDevice(short playerId, clsDevice device, DateTime dateFrom, DateTime dateTo)
        {
            PlayerId = playerId;
            Device = device;
            DateFrom = dateFrom;
            DateTo = dateTo;
            _DeviceId = _setDeviceId(playerId);
        }

        private clsBookingDevice(short playerId, clsDevice device, DateTime dateFrom)
        {
            PlayerId = playerId;
            Device = device;
            DateFrom = dateFrom;
            DateTo = null;
            _DeviceId = _setDeviceId(playerId);
        }

        static public clsBookingDevice BookDevice(clsDevice device, DateTime dateFrom,DateTime dateTo)
        {
            if(device.IsThereAvailableDevices())
            {
                device.AvailableDevices--;
                return new clsBookingDevice((short)(device.NumberOfDevices - device.AvailableDevices), device, dateFrom, dateTo);
            }

            else
            {
                return null;
            }
        }



        static public clsBookingDevice BookDevice(clsDevice device, DateTime dateFrom)
        {
            if (device.IsThereAvailableDevices())
            {
                device.AvailableDevices--;
                return new clsBookingDevice((short)(device.NumberOfDevices - device.AvailableDevices), device, dateFrom);
            }

            else
            {
                return null;
            }
        }

        public TimeSpan GetTime()
        {
            if(DateTo!=null)
                return DateTo.Value - DateFrom;
            else 
                return DateTime.Now-DateFrom;
        }

        private float _GetCost(DateTime DateFrom ,DateTime DateTo )
        {
            float Cost = 0;
            TimeSpan Time = DateTo-DateFrom;
            Cost += Device.DeviceHourRate * Time.Hours;
                Cost += ((float)Time.Minutes / 60) * Device.DeviceHourRate;
            return Cost;
        }

        public TimeSpan GetTimeRemain()
        {
            if (DateTo != null)
            {   
                if (DateTo.Value >= DateTime.Now)
                    return DateTo.Value - DateTime.Now;
                else
                    return TimeSpan.Zero;
            }

            else return TimeSpan.Zero;
        }

        public TimeSpan GetPlayedTime()
        {
            return DateTime.Now - DateFrom;
        }

        public float GetCostUntilNow()
        {
            return _GetCost(DateFrom, DateTime.Now);
        }

        public float GetFinalCost()
        {
            if(DateTo!=null)
                return _GetCost(DateFrom, DateTo.Value);
            else
                return GetCostUntilNow();
        }
        
    }
}
