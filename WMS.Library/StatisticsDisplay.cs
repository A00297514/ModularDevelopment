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
        
        Console.WriteLine($"\n--> Statistics:  Current : {temp} C  Average : {Math.Round(average,2)} C  Maximum : {max} C  Minimum : {min} C");
    }
 
}