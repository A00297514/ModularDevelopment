namespace WMS.Library;
using WMS.Library.Interface;
using System;
using System.Collections.Generic;

/// <summary>
/// Singleton class that collects temprature data from console app and notifies to the observers.
/// </summary>
public class WeatherData
{
    private static WeatherData? _instance;
    public int temperature;
    
    private WeatherData() { }

    /// <summary>
    /// Gets the singleton instance of the WeatherData class.
    /// </summary>
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

    /// <summary>
    /// Sets the weather data and notifies all registered observers.
    /// </summary>
    /// <param name="temperature">The current temperature.</param>
    
    public void setTemperature(int temperature){
        this.temperature = temperature;
        NotifyObservers();
    }

    private List<IDisplay> displays = new List<IDisplay>();

    /// <summary>
    /// Adds an observer in the list of observers.
    /// </summary>
    /// <param name="display">The observer to be registered.</param>
    public void Subscribe(IDisplay display)
    {
        if(!displays.Contains(display))
        {
            displays.Add(display);
        }   
    }

    /// <summary>
    /// Removes an observer from the list of observers.
    /// </summary>
    /// <param name="display">The observer to be removed.</param>
    public void Unsubscribe(IDisplay display)
    {
        if(displays.Contains(display))
        {
            displays.Remove(display);
        }
    }

    /// <summary>
    /// Notifies all subscribed observers that the weather data has changed.
    /// </summary>
    private void NotifyObservers()
    {
        foreach (var display in displays)
        {
            display.Display(temperature);
        }
    }
}
