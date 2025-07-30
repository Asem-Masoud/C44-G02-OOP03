using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_OOP03.InterfaceEx03
{
    internal class Cars : IMovable
    {
        public int Speed { get; set; }

        public void Backward()
        {
            Console.WriteLine("Car IMovable Backward ");
        }

        public void Forward()
        {
            Console.WriteLine("Car IMovable ForWard ");
        }

        public void Left()
        {
            Console.WriteLine(value: "Car IMovable Left ");
        }

        public void Right()
        {
            Console.WriteLine(value: "Car IMovable Right ");
        }
    }
}
