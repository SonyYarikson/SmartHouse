using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHouse.Interfaces
{
    public interface IDimmable
    {
        void ChangeScale(int scale);
        int GetScale();
    }
}
