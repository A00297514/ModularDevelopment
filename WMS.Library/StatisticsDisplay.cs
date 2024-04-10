namespace WMS.Library;
using WMS.Library.Interface;
public class StatisticsDisplay : IDisplay
{
   // private double averageTemperature;
    //private double maxTemperature;
    //private double minTemperature;

    public void Display(int temp)
    {
        
        //Console.WriteLine($"Average Temperature: {averageTemperature}°C, Max Temperature: {maxTemperature}°C, Min Temperature: {minTemperature}°C");
        Console.WriteLine("Displaying weather Statistics...");
    }
}