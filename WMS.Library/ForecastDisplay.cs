namespace WMS.Library;
using WMS.Library.Interface;

/// <summary>
/// Observer that displays weather forecast based on recieved data.
/// </summary>
public class ForecastDisplay : IDisplay
{
    public void Display(int temp)
    {
       if(temp>=-50 && temp<=-41){
            Console.WriteLine("Severely Cold...!!!");
       }

       else if(temp>=-40 && temp<=-31){
            Console.WriteLine("Extremely Cold...!!!");
       }

       else if(temp>=-30 && temp<=-16){
            Console.WriteLine("Freezing cold...!!!");
       }

       else if(temp>=-15 && temp<=-1){
            Console.WriteLine("Very Cold...!!!");
       }

       else if(temp >= 0 && temp <= 15){
            Console.WriteLine("Pleasent Weather...!!!");
       }

       else if (temp >= 16 && temp <= 30){
            Console.WriteLine("Hot outside...!!!");
       }

       else if (temp >=31 && temp <= 40){
            Console.WriteLine("Extremely hot...!!!");
       }

       else{
            Console.WriteLine("Burning outside...!!!");
       }
    }
}