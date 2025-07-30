using Demo_OOP03.Interface_Ex01;
using Demo_OOP03.Interface_Ex02;
using Demo_OOP03.InterfaceEx03;

namespace Demo_OOP03
{

    // DataTypes that could create in name space
    // 1.Class
    // 2.Struct
    // 3.Enum
    // 4.Interface 

    internal class Program
    {
        #region 03 Interface Ex02

        static void Print10Number(SeriesBy2 series)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{series.Current}");
                series.Next();
            }
        }

        static void Print10Number(SeriesByThree series)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{series.Current}");
                series.Next();
            }
        }

        static void Print10Number(SeriesByFour series)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{series.Current}");
                series.Next();
            }
        }

        // u can do ine function
        static void print10number(Iseries series)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{series.Current}");
                series.Next();
            }
        }

        #endregion
        static void Main()
        {

            #region 02 Interface Ex01

            //// Interface : One of the dataTypes that could create in name space
            ////Code Contract between the developer who write and the developer who use

            ////Note : u can't Create Object from Interface

            ////Mytype mytype = new Mytype();
            ////mytype.Salary = 12000;
            ////Console.WriteLine(mytype.Salary);
            ////mytype.MyFun();


            ////Note U can create any ref throw interface

            //IMyType myType;
            ////Ref --> Can refer to Object From any Class which implement the interface"IMytype"
            //MyType mytype = new MyType();
            //mytype.Salary = 12000;
            //Console.WriteLine(mytype.Salary);
            //mytype.MyFun();

            #endregion

            #region 03 Interface Ex02


            ////SeriesBy2 seriesBy2 = new SeriesBy2();
            ////Print10Number(seriesBy2);

            ////SeriesByThree seriesByThree = new SeriesByThree();

            ////Print10Number(seriesByThree);

            ////SeriesByFour seriresByFour = new SeriesByFour();
            ////Print10Number(seriresByFour);


            //////int[] numbers = { 7, 5, 3, 4, 6, 7, 8, 9, 14, };
            //////Array.Sort(numbers); //Sortng By Asce
            //////foreach (int item in numbers) 
            //////{
            //////    Console.WriteLine(item);
            //////}

            //Employee[] employees = new Employee[3]
            //{
            //    new Employee() {Id =1, Name="Ahmed" , Age=30,Salary=12000 },
            //    new Employee() {Id =2, Name="Omar" , Age=27,Salary=13000 },
            //    new Employee() {Id =3, Name="Amr" , Age=28,Salary=11000 },
            //};

            //Array.Sort(employees);
            //foreach (Employee item in employees)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 04 Interface Ex03

            //Cars car = new Cars();
            //car.Speed = 120;
            //car.Forward();

            //AirPlan airPlan = new AirPlan();

            ////Create ref to call the function
            //IMovable movable = new Cars();
            //movable.Forward();

            //IFlyable flyable = airPlan;
            //flyable.Forward();

            #endregion
        }
    }
}