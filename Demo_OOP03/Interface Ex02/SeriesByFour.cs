using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_OOP03.Interface_Ex02
{
    internal class SeriesByFour : Iseries
    {
        public int Current { get; set; }


        public void Next()
        {
            Current += 4;
        }

        public void Reset()
        {
            Current = 0;
        }
    }
}
