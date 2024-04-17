namespace GeometryApp.Library;

public class Square : IShape
{
    private double side;

    public Square(double side)
    {
        this.side = side;
    }

    public double CalculateArea()
    {
        if(side<=0){
            throw new ArgumentException("The value should be positive and >0...!!");
        }
        return side * side; 
    }

    public double CalculatePerimeter()
    {
        if(side<=0){
            throw new ArgumentException("The value should be positive and >0...!!");
        }
        return 4 * side; 
    }

}