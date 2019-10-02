namespace ShapesApp.Library
{

    public class Rectangle : IShape
    {
        public double Length { get; set; }
        public double Width { get; set; }

        //not all properties have to be based on 1 field

        public double Area
        {
            get
            {
                return Length * Width;
            }
        }

        public int Dimensions
        {
            get { return 2; }
        }

        public int Sides => 4;

        public double GetPerimeter() {
            return (double)Length*2 +  (double) Width*2;
        }

        public bool Validate()
        {
            if (Length <= 0)
            {
                return false;
            }
            if (Width <= 0)
            {
                return false;
            }
            return true;
        }
    }
}