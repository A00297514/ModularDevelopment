namespace WMS.Library;
using WMS.Library.Interface;

public class CurrentConditionsDisplay : IDisplay
{
    public void Display(int temp)
    {
        // Display weather forecast
        Console.WriteLine("Displaying current condition...");
    }
}