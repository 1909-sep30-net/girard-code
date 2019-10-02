using System;

namespace ShapesApp.Library
{

    public class ColorCircle : Circle
    {
        public string Color { get; set; }

        public ColorCircle(double radius, string color) : base(radius)
        {
            Color = color;
        }

        public ColorCircle(double radius) : this(radius, "clear")
        {

        }

        public override double GetPerimeter()
        {
            Console.WriteLine("calculating perimeter");
            //return 2 * Math.PI * Radius;
            return base.GetPerimeter();
        }

    }

}