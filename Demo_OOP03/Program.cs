using Demo_OOP03.Interface_Ex01;
using Demo_OOP03.Interface_Ex02;
using Demo_OOP03.InterfaceEx03;
using System.Text;

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

            #region 05 Shallow Copy Vs Deep Copy


            // Shallow Copy Vs Deep Copy
            /* //1. Shallow Copy int[]
            Console.WriteLine(value: "1. Shallow Copy for int[] ");
            int[] Arr01 = { 1, 2, 3 };
            int[] Arr02 = { 4, 5, 6 };

            Console.WriteLine($"Arr01: {Arr01.GetHashCode()}");
            Console.WriteLine($"Arr02: {Arr02.GetHashCode()}");

            Arr02 = Arr01; // Shallow Copy
            // Copy Identity
            // { 1, 2, 3 } ---> Has Two References Arr01, Arr02
            // { 4, 5, 6 } ---> UnReachable Object

            Console.WriteLine();
            Console.WriteLine($"Arr01: {Arr01.GetHashCode()}");
            Console.WriteLine($"Arr02: {Arr02.GetHashCode()}");

            // Identity (Address) + Object State [Data]

            Arr02[0] = 100;
            Console.WriteLine(Arr01[0]);
            */


            /* // 2. Deep Copy for int[]
            Console.WriteLine(value: "Deep Copy for int[] ");

            int[] Arr01 = { 1, 2, 3 };
            int[] Arr02 = { 4, 5, 6 };

            Console.WriteLine($"Arr01: {Arr01.GetHashCode()}");
            Console.WriteLine($"Arr02: {Arr02.GetHashCode()}");

            Arr02 = (int[])Arr01.Clone();    // Deep Copy
            // Clone Method will copy the object State of the caller
            // Assign The New Object To Arr02, Will  Generate new Identity

            Console.WriteLine(    );
            Console.WriteLine($"Arr01: {Arr01.GetHashCode()}");
            Console.WriteLine($"Arr02: {Arr02.GetHashCode()}");

            // Identity (Address) + Object State [Data]

            Arr02[0] = 100;
            Console.WriteLine(Arr01[0]);
            */

            /* //3. Shallow Copy for string[]"
            Console.WriteLine(value: "3. Shallow Copy for string[]");
            string[] Arr01 = { "Ahmed", "Ali", "Omar" };
            string[] Arr02 = { "Ziad", "Adel", "Amr" };


            Console.WriteLine($"Arr01: {Arr01.GetHashCode()}");
            Console.WriteLine($"Arr02: {Arr02.GetHashCode()}");

            //Shallow Copy

            Arr02 = Arr01; // Shallow Copy
            // Copy Identity
            // { 1, 2, 3 } ---> Has Two References Arr01, Arr02
            // { 4, 5, 6 } ---> UnReachable Object

            Console.WriteLine(   );
            Console.WriteLine($"Arr01: {Arr01.GetHashCode()}");
            Console.WriteLine($"Arr02: {Arr02.GetHashCode()}");

            //// Identity (Address) + Object State [Data]

            Arr02[0] += " Ahmed Amin";
            Console.WriteLine(Arr01[0]);
            */

            /* //4. Deep Copy for string[] 
            Console.WriteLine(value: "4. Deep Copy for string[] ");
            string[] Arr01 = { "Ahmed", "Ali", "Omar" };
            string[] Arr02 = { "Ziad", "Adel", "Amr" };


            Console.WriteLine($"Arr01: {Arr01.GetHashCode()}");
            Console.WriteLine($"Arr02: {Arr02.GetHashCode()}");

            Arr02 = (string[])Arr01.Clone(); // 
            // Copy Identity
            // { 1, 2, 3 } ---> Has Two References Arr01, Arr02
            // { 4, 5, 6 } ---> UnReachable Object

            Console.WriteLine(   );
            Console.WriteLine($"Arr01: {Arr01.GetHashCode()}");
            Console.WriteLine($"Arr02: {Arr02.GetHashCode()}");

            //// Identity (Address) + Object State [Data]

            Arr02[0] += " Ahmed Amin";
            Console.WriteLine(Arr01[0]);
            */


            /*  //5. Shallow Copy for StringBuilder[]
             Console.WriteLine(value: "5. Shallow Copy for StringBuilder[]");
             StringBuilder[] Arr01 = new StringBuilder[]
               {
                  new StringBuilder("Ahmed"),
                  new StringBuilder("Ali"),
                  new StringBuilder("Omar")
               };

             StringBuilder[] Arr02 = new StringBuilder[]
               {
                 new StringBuilder("Amr"),
                 new StringBuilder("Adel"),
                 new StringBuilder("Ziad")
               };


             Console.WriteLine($"Arr01: {Arr01.GetHashCode()}");
             Console.WriteLine($"Arr02: {Arr02.GetHashCode()}");

             Arr02 = Arr01;

             Console.WriteLine(   );
             Console.WriteLine($"Arr01: {Arr01.GetHashCode()}");
             Console.WriteLine($"Arr02: {Arr02.GetHashCode()}");

             //// Identity (Address) + Object State [Data]

             Arr02[0].Append(" Ahmed Amin");
             Console.WriteLine(Arr01[0]);

             */


            /* //6. Deep Copy for StringBuilder[]
             Console.WriteLine(value: "6. Deep Copy for StringBuilder[]");
             StringBuilder[] Arr01 = new StringBuilder[]
                {
                       new StringBuilder("Ahmed"),
                        new StringBuilder("Ali"),
                        new StringBuilder("Omar")
                };

             StringBuilder[] Arr02 = new StringBuilder[]
             {
                    new StringBuilder("Amr"),
                   new StringBuilder("Adel"),
                 new StringBuilder("Ziad")
              };


             Console.WriteLine($"Arr01: {Arr01.GetHashCode()}");
             Console.WriteLine($"Arr02: {Arr02.GetHashCode()}");

             Arr02 = (StringBuilder[])Arr01.Clone();

             Console.WriteLine($"Arr01: {Arr01.GetHashCode()}");
             Console.WriteLine($"Arr02: {Arr02.GetHashCode()}");

             //// Identity (Address) + Object State [Data]

             Arr02[0].Append(" Ahmed Amin");
             Console.WriteLine(Arr01[0]);
             */

            #endregion

            #region 06 Built-in Interface - ICloneable

            //Employee e01 = new Employee()
            //{
            //    Id = 1,
            //    Name = "Ahmed",
            //    Age = 30,
            //    Salary = 12000
            //};

            //Employee e02 = new Employee()
            //{
            //    Id = 2,
            //    Name = "Amr",
            //    Age = 28,
            //    Salary = 11000
            //};

            ////e02 = e01;    // Shallow Copy
            ////e02 = (Employee) e01.Clone();   // Deep Copy
            //e02 = new Employee(e01);    // Deep copy using copy constructor

            //Console.WriteLine(e01.GetHashCode());
            //Console.WriteLine(e02.GetHashCode());
            //Console.WriteLine(e01);
            //Console.WriteLine(e02);

            #endregion

            #region 07 Built-in Interface - ICompareable

            //Employee[] employees =
            //  [
            //      new Employee { Id = 1, Name = "Ahmed", Age = 30, Salary = 12000 },
            //      new Employee { Id = 2, Name = "Omar", Age =  27, Salary = 11000 },
            //      new Employee { Id = 3, Name = "Ali", Age = 31, Salary = 13000 }
            //  ];

            ////Array.Sort(employees);

            ////int x = employees[0].CompareTo(employees[1]);
            ////// +ve : Caller greater than parameter
            ////// -ve : Caller less than parameter
            ////// 0   : Caller equal parameter

            ////Console.WriteLine(x);

            //foreach (Employee e in employees)
            //{
            //    Console.WriteLine(e);
            //}

            #endregion
        }
    }
}