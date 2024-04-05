namespace DesignPattern.Observer;
using DesignPattern.Observer.Interfaces;
public class LowerCaseObserver : IObserver<string>
{
    public void Update(string param)
    {
        Console.WriteLine(param.ToLower());
    }
}