namespace GeometryApp.Library;

public class Triangle : IShape
{
 // Assuming these are the properties of your Triangle class
        public double Base;
        public double Height;
        public double Side1;
        public double Side2;
        public double Side3;

        // Constructor to initialize the properties
        public Triangle(double _base, double height, double side1, double side2, double side3)
        {
            Base = _base;
            Height = height;
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
        }

        public double CalculateArea()
        {
            return 0.5 * Base * Height;
        }

        public double CalculatePerimeter()
        {
            return Side1 + Side2 + Side3;
        }
}