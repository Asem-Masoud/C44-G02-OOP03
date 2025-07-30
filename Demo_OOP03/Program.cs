using Demo_OOP03.Interface_Ex01;

namespace Demo_OOP03
{

    // DataTypes that could create in name space
    // 1.Class
    // 2.Struct
    // 3.Enum
    // 4.Interface 

    internal class Program
    {
        static void Main()
        {
            #region 02 Interface Ex01

            // Interface : One of the dataTypes that could create in name space
            //Code Contract between the developer who write and the developer who use

            //Note : u can't Create Object from Interface

            //Mytype mytype = new Mytype();
            //mytype.Salary = 12000;
            //Console.WriteLine(mytype.Salary);
            //mytype.MyFun();


            //Note U can create any ref throw interface

            IMyType myType;
            //Ref --> Can refer to Object From any Class which implement the interface"IMytype"
            MyType mytype = new MyType();
            mytype.Salary = 12000;
            Console.WriteLine(mytype.Salary);
            mytype.MyFun();

            #endregion
        }
    }
}