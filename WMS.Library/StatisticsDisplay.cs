namespace WMS.Library;
using WMS.Library.Interface;
public class StatisticsDisplay : IDisplay
{
    private List<int> temperatures = new List<int>();

   
    public void Display(int temp)
    {
        temperatures.Add(temp);

        double average = temperatures.Count > 0 ? temperatures.Average() : 0;
        int max = temperatures.Count > 0 ? temperatures.Max() : 0;
        int min = temperatures.Count > 0 ? temperatures.Min() : 0;
        Console.WriteLine($"Average Temperature: {average} C, Max Temperature: {max} C, Min Temperature: {min} C");
    }
 
}