using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_OOP03.Interface_Ex02
{
    internal interface Iseries
    {
        int Current { get; set; }        //1.Signature of property in interface

        void Next();
        void Reset();
    }
}
