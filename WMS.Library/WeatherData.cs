namespace WMS.Library;
using WMS.Library.Interface;
using System;
using System.Collections.Generic;

public class WeatherData<T>
{
    List<IDisplay<T>> displays = new List<IDisplay<T>>();
    private T? _value;

    public T? Value
    {
        get{
            return _value;
        }
        set
        {
            _value = value;
            Notify(_value);
        }
    }

    public void Subscribe(IDisplay<T> subscriber)
    {
        if(!subscribers.Contains((subscriber)))
        {
            subscribers.Add(subscriber);
        }
    }

    public void Unsubscribe(IObserver<T> subscriber)
    {
        if(subscribers.Contains((subscriber)))
        {
            subscribers.Remove(subscriber);
        }
    }

    private void Notify(T message)
    {
        foreach(var sub in subscribers)
        {
            sub.Display(message);
        }
    }
}
