namespace WMS.Library;
using WMS.Library.Interface
public class StatisticsDisplay : IDisplay<T>
{
    private double averageTemperature;
    private double maxTemperature;
    private double minTemperature;

    public StatisticsDisplay(double averageTemp, double maxTemp, double minTemp)
    {
        averageTemperature = averageTemp;
        maxTemperature = maxTemp;
        minTemperature = minTemp;
    }

    public void Display()
    {
        // Display weather statistics
        Console.WriteLine($"Average Temperature: {averageTemperature}°C, Max Temperature: {maxTemperature}°C, Min Temperature: {minTemperature}°C");
    }
}