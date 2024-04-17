namespace GeometryApp.Library;

public class Rectangle : IShape
{
    private double length;
    private double width;

    public Rectangle(double length, double width)
    {
        this.length = length;
        this.width = width;
    }

    public double CalculateArea()
    {
        if(length<=0){
            throw new ArgumentException("The Length should be positive...!!");
        }

        else if(width<=0){
            throw new ArgumentException("The Width should be positive...!!");
        }

        else {
            return length * width; 
        }
    }

    public double CalculatePerimeter()
    {
        if(length<=0){
            throw new ArgumentException("The Length should be positive...!!");
        }

        else if(width<=0){
            throw new ArgumentException("The Width should be positive...!!");
        }

        else {
            return 2 * (length + width); 
        }
        
    }
}