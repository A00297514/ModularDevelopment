namespace WMS.Library;
using WMS.Library.Interface;
/// <summary>
/// Factory for creating different types of displays.
/// </summary>
public class WeatherStation
{
    /// <summary>
    /// Factory method to create displays of different observers.
    /// </summary>
    /// <param name="display">Type of display to create.</param>
    /// <returns>An instance of the display type.</returns>
    public static IDisplay CreateDisplay(string display)
    {
        switch (display)
        {
            case "current":
                return new CurrentConditionsDisplay();

            case "statistic":
                return new StatisticsDisplay();

            case "forecast":
               return new ForecastDisplay();
            
            default:
                throw new ArgumentException("Invalid Display Type");
        }
    }
}
