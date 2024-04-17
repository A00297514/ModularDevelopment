namespace GeometryApp.Library;

public class Triangle : IShape
{
        public double _Base;
        public double Height;
        public double Side1;
        public double Side2;
        public double Side3;

        public Triangle(double _base, double height, double side1, double side2, double side3)
        {
            _Base = _base;
            Height = height;
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
        }

        public double CalculateArea()
        {
            if(_Base<=0){
                throw new ArgumentException("The Base should be positive...!!");
            }
            else if(Height<=0){
                throw new ArgumentException("The Base should be positive...!!");
            }
            else{
                return 0.5 * _Base * Height;
            }    
        }

        public double CalculatePerimeter()
        {
            if(Side1<=0){
                throw new ArgumentException("The Side 1 should be positive...!!");
            }
            else if(Side2<=0){
                throw new ArgumentException("The Side 2 should be positive...!!");
            }
            else if(Side3<=0){
                throw new ArgumentException("The Side 3 should be positive...!!");
            }
            else{
                return Side1 + Side2 + Side3;
            } 
            
        }
}