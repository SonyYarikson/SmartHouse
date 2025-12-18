using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHouse.Interfaces
{
    public class TemperatureDimmer : IDimmable
    {
        private int _temperature;
        public void ChangeScale(int temperature)
        {
            _temperature = temperature;
        }

        public int GetScale()
        {
            return _temperature;
        }
    }
}
