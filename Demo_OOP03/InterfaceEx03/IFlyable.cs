using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_OOP03.InterfaceEx03
{
    internal interface IFlyable
    {
        int Speed { get; set; }

        void Forward();
        void Backward();
        void Left();
        void Right();
    }
}
