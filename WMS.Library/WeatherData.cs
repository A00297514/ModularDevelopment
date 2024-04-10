namespace WMS.Library;
using WMS.Library.Interface;
using System;
using System.Collections.Generic;


public class WeatherData
{
    private static WeatherData? _instance;
    public int temperature;
    
    private List<IDisplay> displays = new List<IDisplay>();

    private WeatherData() { }

    public static WeatherData Instance
    {
        get
        { 
            if (_instance == null)
            {
                _instance = new WeatherData();
            }
            return _instance;
        }
    }

    public void setTemperature(int temperature){
        this.temperature = temperature;
        NotifyObservers();
    }
    public void Subscribe(IDisplay display)
    {
        if(!displays.Contains(display)){
            displays.Add(display);
        }
        
    }

    public void Unsubscribe(IDisplay display)
    {
        if(displays.Contains(display))
        {
            displays.Remove(display);
        }
    }

    private void NotifyObservers()
    {
        foreach (var display in displays)
        {
            display.Display(temperature);
        }
    }
}
