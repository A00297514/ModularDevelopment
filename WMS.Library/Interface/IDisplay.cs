namespace WMS.Library.Interface;
/// <summary>
/// Interface for all display elements.
/// </summary>
public interface IDisplay<T>
{
    /// <summary>
    /// Method to display the weather data.
    /// </summary>
    void Display(T param);
}
