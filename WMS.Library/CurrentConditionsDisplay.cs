namespace WMS.Library;
using WMS.Library.Interface;
/// <summary>
/// Observer for displaying current weather conditions and a decorator for adding data.
/// </summary>
public class CurrentConditionsDisplay :  IDisplay
{
     public void Display(int temp)
    {
        // Get current date and time
        DateTime currentDateTime = DateTime.Now;
        // Display current weather conditions
        Console.WriteLine($"--> Current Weather Conditions as of {currentDateTime}: Current Temprature: {temp} C");
    }
   
}