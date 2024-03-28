using Component;

public class ConcreteComponent : IComponent<string>
{
    public string GetText()
    {
        // Implement the logic to retrieve text
        return "This is the text from ConcreteComponent";
    }
}