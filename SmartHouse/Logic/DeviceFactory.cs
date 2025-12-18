using SmartHouse.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHouse.Logic
{
    public class DeviceFactory
    {   
        public Device CreateDevice(string type)
        {
            Device device = null;
            if (type.Equals("SimpleLamp"))
            {
                device = new SimpleLamp();
            }else if (type.Equals("DimmableLamp"))
            {
                device = new DimmableLamp(0);
            }else if (type.Equals("Thermostat"))
            {
                device= new Thermostat(0);
            }
            return device;
        }
    }
}
