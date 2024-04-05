namespace DesignPattern.Observer.Interfaces;

public interface IObserver<T>
{
    void Update(T param);
}
