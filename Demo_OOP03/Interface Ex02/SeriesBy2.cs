using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_OOP03.Interface_Ex02
{
    internal class SeriesBy2 : Iseries
    {
        public int Current { get; set; }

        public void Next()
        {
            Current += 2;
        }

        void Iseries.Next()
        {
            Next();
        }

        void Reset()
        {
            Current = 0;
        }

        void Iseries.Reset()
        {
            Reset();
        }
    }
}
