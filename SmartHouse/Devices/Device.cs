using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartHouse.Interfaces;

namespace SmartHouse.Devices
{
    public abstract class Device
    {
        protected Device()
        {
            _isTurnedOn = false;
        }
        public bool _isTurnedOn { get; set; }
        public void turnOn()
        {
            _isTurnedOn = true;
        }
        public void turnOff()
        {
            _isTurnedOn = false;
        }
        public virtual void getStatus()
        {
            if (_isTurnedOn)
            {
                Console.WriteLine("Включено");
            }
            else
            {
                Console.WriteLine("Выключенно");
            }
        }
        

    }
}
