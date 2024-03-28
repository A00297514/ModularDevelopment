using Component;

public class PlainDecorator : Decorator<string>
{
    public PlainDecorator(IComponent<string> component) : base(component)
    {
    }

    public override string GetText()
    {
        string baseText = base.GetText();
        return "Prefix Text: " + baseText;
    }
}
