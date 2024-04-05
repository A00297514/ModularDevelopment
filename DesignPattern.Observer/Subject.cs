namespace DesignPattern.Observer;
using DesignPattern.Observer.Interfaces;
public class Subject<T>
{
    IList<IObserver<T>> subscribers = new List<IObserver<T>>();

    private T? _value;

    public T Value
    {
        get{
            return _value;
        }

        set{
            _value = value;
            Notify(_value);
        }
    }
    public void Subscribe(IObserver<T> subscriber)
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
            sub.Update(message);
        }
    }
}