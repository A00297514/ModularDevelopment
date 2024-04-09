namespace WMS.Library;
using WMS.Library.Interface;

/// <summary>
/// Observer that displays weather forecast based on recieved data.
/// </summary>
public class ForecastDisplay : IDisplay<T>
{
    public void Display(T param)
    {
        // Display weather forecast
        Console.WriteLine("Displaying weather forecast...");
    }
}