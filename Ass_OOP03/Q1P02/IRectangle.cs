using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass_OOP03.Q1P02
{
    internal interface IRectangle : IShape
    {
        double Width { get; set; }
        double Height { get; set; }

    }
}
