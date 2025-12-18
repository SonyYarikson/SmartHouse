using SmartHouse.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHouse.Devices
{
    public class Thermostat : Device
    {
        public TemperatureDimmer TemperatureDimmer;
        public Thermostat(int temperature) : base()
        {
            TemperatureDimmer.ChangeScale(temperature);
        }
        public override void getStatus()
        {
            if (_isTurnedOn)
            {
                Console.WriteLine($"Включено, температура в доме {TemperatureDimmer.GetScale()}°С");
            }
            else
            {
                Console.WriteLine("Выключенно");
            }
        }
    }
}
