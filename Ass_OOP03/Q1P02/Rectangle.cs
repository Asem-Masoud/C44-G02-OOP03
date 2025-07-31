using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass_OOP03.Q1P02
{
    internal class Rectangle : IRectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public double Area => Width * Height;

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Rectangle - Width: {Width:F2}, Height: {Height:F2}, Area: {Area:F2}");
        }

    }
}
