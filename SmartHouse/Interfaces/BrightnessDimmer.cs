using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHouse.Interfaces
{
    public class BrightnessDimmer : IDimmable
    {
        private int _brightness { get; set; }
        public void ChangeScale(int brightness)
        {
            _brightness = brightness;
        }

        public int GetScale()
        {
            return _brightness;
        }
    }
}
