using Component;

public class ConcreteComponent : IComponent<string>
{
    public string GetText()
    {
        return "This is the text from ConcreteComponent";
    }
}