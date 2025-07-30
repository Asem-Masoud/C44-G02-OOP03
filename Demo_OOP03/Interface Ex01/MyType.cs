using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_OOP03.Interface_Ex01
{
    internal class MyType : IMyType
    {

        #region 02 Interface Ex01

        //  automatic Properity
        public double Salary { get; set; }
        //public double Salary
        //{
        //    get { throw new NotImplementedException(); }
        //    set { throw new NotImplementedException(); }


        //}

        public void MyFun()
        {
            Console.WriteLine("Hello World");
        }
        #endregion

    }
}
