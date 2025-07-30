using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_OOP03.InterfaceEx03
{
    internal class AirPlan : IMovable, IFlyable
    {
        int IMovable.Speed { get; set; }
        int IFlyable.Speed { get; set; }

        void IMovable.Backward()
        {
            Console.WriteLine("Car IMovable Backward ");
        }

        void IFlyable.Backward()
        {
            Console.WriteLine("Car IFlyable Backward ");
        }

        void IMovable.Forward()
        {
            Console.WriteLine("Car IMovable ForWard ");
        }

        void IFlyable.Forward()
        {
            Console.WriteLine("Car IFlyable Forward ");
        }

        void IMovable.Left()
        {
            Console.WriteLine("Car IMovable Left ");
        }

        void IFlyable.Left()
        {
            Console.WriteLine("Car IFlyable Left ");
        }

        void IMovable.Right()
        {
            Console.WriteLine("Car IMovable Right ");
        }

        void IFlyable.Right()
        {
            Console.WriteLine("Car IFlyable Right ");
        }
    }
}
