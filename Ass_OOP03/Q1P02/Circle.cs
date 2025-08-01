﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass_OOP03.Q1P02
{
    internal class Circle : ICircle
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Area => Math.PI * Radius * Radius;

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Circle - Radius: {Radius:F2}, Area: {Area:F2}");
        }

    }
}
