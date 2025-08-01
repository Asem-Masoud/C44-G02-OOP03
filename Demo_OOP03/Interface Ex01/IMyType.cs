﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_OOP03.Interface_Ex01
{
    internal interface IMyType
    {
        #region 02 Interface Ex01

        //int x; // Error

        //what i can write in interface
        //1.signature of properity 
        //2.signature of method [name , Parameter , ReturnType]of Function
        //3.default implmented method [Fully implmented method ]

        //Example on
        //2.signature of method [name , Parameter , ReturnType]of Function
        void MyFun();
        //private void MyFun(); //Error //the default is only public

        //1.signature of properity
        double Salary { get; set; }//In Class this called automatic property

        //3.default implmented method [Fully implmented method ]
        void MyFunDefault()
        {
            Console.WriteLine("default implmented method [Fully implmented method ]");
        }

        #endregion
    }
}
