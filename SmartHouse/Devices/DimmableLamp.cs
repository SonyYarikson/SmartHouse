using SmartHouse.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHouse.Devices
{
    public class DimmableLamp : Device
    {
        public BrightnessDimmer BrightnessDimmer { get; set; }
        public DimmableLamp(int brightness) : base()
        {
            BrightnessDimmer.ChangeScale(brightness);
        }
        public override void getStatus()
        {
            if (_isTurnedOn)
            {
                Console.WriteLine($"Включено, уровень яркости {BrightnessDimmer.GetScale()}%");
            }
            else{
                Console.WriteLine("Выключенно");
            }
        }
    }
}
