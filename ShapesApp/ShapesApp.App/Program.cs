using System;
using ShapesApp.Library;

namespace ShapesApp.App
{
    static class Program
    {
        static void Main(string[] args)
        {
            double length;
            string input;
            do
            {
                Console.WriteLine("Enter a length:");
                input = Console.ReadLine();
            } while (!double.TryParse(input, out length));

            double width;
            do
            {
                Console.WriteLine("Enter a width:");
                input = Console.ReadLine();
            } while (!double.TryParse(input, out width));

            var rectangle = new Rectangle()
            {
                Length = length,
                Width = width
            };

            rectangle.PrintRectangle();
            double radius;
            do
            {
                Console.WriteLine("Enter a radius:");
                input = Console.ReadLine();
            } while (!double.TryParse(input, out radius));
            ColorCircle circle = new ColorCircle{

            };

        }

        public static void PrintRectangle(this Rectangle r){
            Console.WriteLine($"{r.Length}x{r.Width} rectangle");
            10.ToString();
             int ThirtyThree = 10.Triple(3);
        }

        public static int Triple(this int number, int plus = 0) {
            return 3 * number + plus;
        }

        public static string ShapeDetails(IShape shape) {
        }
    }
}
