using System;
using Shapes;

namespace Consoles
{
    class Program
    {
        static void Main(string[] args)
        {

            Square sq1;
            Rectangle rec1;
            RightAngleTriangle ra1;
            EquilateralTriangle eq1;
            Input t = new Input();

            Console.WriteLine("Hello World!");

            Console.WriteLine("A: Square, B: Rectangle, C: Equilateral, D: Right-Angled");

            string input = Console.ReadLine();
            //int s1;
            //int s2;
            int count = 0;
            //float t1;
            //float t2;
            //float t3;
            string tests;
            
            while (count == 0)
            {
                if (input == "A")
                {
                    Console.WriteLine("Please enter required values");
                    Console.WriteLine("Please enter a colour");
                    tests = Console.ReadLine();
                    Console.WriteLine("Side 1: ");
                    try
                    {
                        t.s1 = int.Parse(Console.ReadLine());
                    }
                    catch (Exception ex)
                    {
                        if(ex is FormatException || ex is InvalidInput)
                        {
                            Console.WriteLine("Test: " + ex.Message);
                        }
                    }

                    sq1 = new Square(tests, t.s1);

                    Console.WriteLine(sq1.GetArea());
                    Console.WriteLine(sq1.GetPerimeter());

                }
                else if (input == "B")
                {
                    Console.WriteLine("Please enter required values");
                    Console.WriteLine("Please enter a colour");
                    tests = Console.ReadLine();
                    try
                    {
                        Console.WriteLine("Side 1: ");
                        t.s1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Side 2: ");
                        t.s2 = int.Parse(Console.ReadLine());
                    }
                    catch (Exception ex)
                    {
                        if (ex is FormatException || ex is InvalidInput)
                        {
                            Console.WriteLine("Test: " + ex.Message);
                        }
                    }

                    rec1 = new Rectangle(tests, t.s1, t.s2);

                    Console.WriteLine(rec1.GetArea());
                    Console.WriteLine(rec1.GetPerimeter());


                }
                else if (input == "C")
                {
                    Console.WriteLine("Please enter required values");
                    Console.WriteLine("Please enter a colour");
                    tests = Console.ReadLine();
                    Console.WriteLine("Side 1: ");
                    try
                    {
                        t.t1 = float.Parse(Console.ReadLine());
                    }
                    catch (Exception ex)
                    {
                        if (ex is FormatException || ex is InvalidInput)
                        {
                            Console.WriteLine("Test: " + ex.Message);
                        }
                    }

                    eq1 = new EquilateralTriangle(tests, t.t1);

                    Console.WriteLine(eq1.GetArea());
                }
                else if (input == "D")
                {
                    Console.WriteLine("Please enter required values");
                    Console.WriteLine("Please enter a colour");
                    tests = Console.ReadLine();
                    try
                    {
                        Console.WriteLine("Side 1: ");
                        t.t1 = float.Parse(Console.ReadLine());
                        Console.WriteLine("Side 2: ");
                        t.t2 = float.Parse(Console.ReadLine());
                    }
                    catch (Exception ex)
                    {
                        if (ex is FormatException || ex is InvalidInput)
                        {
                            Console.WriteLine("Test: " + ex.Message);
                        }
                    }

                    ra1 = new RightAngleTriangle(tests, t.t1, t.t2);

                    Console.WriteLine(ra1.GetArea());
                    Console.WriteLine(ra1.GetPerimeter());
                }
                else
                {
                    Console.WriteLine("Invalid option, press any key to exit.");
                    Console.ReadKey(true);
                }
            }
            

            Console.WriteLine("test");
            Console.ReadKey(true);


        }
    }

    public class InvalidInput : Exception
    {
        public InvalidInput(string message) : base(message)
        {

        }
    }

    public class Input
    {
        public int s1 = 0;
        public int s2 = 0;
        public float t1 = 0;
        public float t2 = 0;
        public void ShowInput()
        {
            if (s1 <= 0 || s2 <= 0)
            {
                throw (new InvalidInput("Number less than or equal to 0 detected."));
            }


        }

    }

}
