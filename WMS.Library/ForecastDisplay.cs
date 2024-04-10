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
            Console.WriteLine("\n--> Forecast: Severely Cold...!!!");
       }

       else if(temp>=-40 && temp<=-31){
            Console.WriteLine("\n--> Forecast: Extremely Cold...!!!");
       }

       else if(temp>=-30 && temp<=-16){
            Console.WriteLine("\n--> Forecast: Freezing cold...!!!");
       }

       else if(temp>=-15 && temp<=-1){
            Console.WriteLine("\n--> Forecast: Very Cold...!!!");
       }

       else if(temp >= 0 && temp <= 15){
            Console.WriteLine("\n--> Forecast: Pleasent Weather...!!!");
       }

       else if (temp >= 16 && temp <= 30){
            Console.WriteLine("\n--> Forecast: Hot outside...!!!");
       }

       else if (temp >=31 && temp <= 40){
            Console.WriteLine("\n--> Forecast: Extremely hot...!!!");
       }

       else{
            Console.WriteLine("\n--> Forecast: Burning outside...!!!");
       }
    }
}