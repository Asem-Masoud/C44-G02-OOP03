using Ass_OOP03.Q1P02;
using Ass_OOP03.Q2P02;

namespace Ass_OOP03
{
    internal class Program
    {
        static void Main()
        {

            #region Part01 MCQ

            /*
              
            1. ( C )
            
            2. (a )

            3. (b )

            4. (b )

            5. ( d)

            6. ( a)

            7. ( b)

            8. ( a)

            9. ( b)

            10. ( c)


            */

            #endregion

            #region Q1P02
            /*
             Define an interface named IShape with a property Area and a method DisplayShapeInfo. Create two interfaces, ICircle and IRectangle, that inherit from IShape. Implement these interfaces in classes Circle and Rectangle. Test your implementation by creating instances of both classes and displaying their shape information. 
             */

            IShape circle = new Circle(5.0);
            IShape rectangle = new Rectangle(4.0, 6.0);

            Console.WriteLine("Shape Information:");
            circle.DisplayShapeInfo();
            rectangle.DisplayShapeInfo();

            ICircle specificCircle = new Circle(3.0);
            IRectangle specificRectangle = new Rectangle(2.0, 8.0);

            Console.WriteLine("\nUsing specific interfaces:");
            Console.WriteLine($"Circle Radius: {specificCircle.Radius}");
            Console.WriteLine($"Rectangle Width: {specificRectangle.Width}, Height: {specificRectangle.Height}");


            #endregion


            #region Q2P02

            IAuthenticationService authService = new BasicAuthenticationService();

            string username = "admin";
            string password = "admin123";

            if (authService.AuthenticateUser(username, password))
            {
                Console.WriteLine($"User {username} authenticated successfully!");

                if (authService.AuthorizeUser(username, "Administrator"))
                {
                    Console.WriteLine($"User {username} has Administrator privileges.");
                }
                else
                {
                    Console.WriteLine($"User {username} does not have Administrator privileges.");
                }
            }
            else
            {
                Console.WriteLine("Authentication failed!");
            }
        }

        #endregion


        #region Q3P02




        #endregion


    }
}
