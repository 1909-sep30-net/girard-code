using System;

namespace ShapesApp.Library
{

    public class Circle : IShape
    {

        public Circle(double radius)
        {
            Radius = radius;
        }

        public int Dimensions => 2;
        public int Sides => 8;
        public double Area => Math.PI * Radius * Radius;
        public double Radius { get; set; }

        public virtual double GetPerimeter() => 2 * Math.PI * Radius;

    }
}