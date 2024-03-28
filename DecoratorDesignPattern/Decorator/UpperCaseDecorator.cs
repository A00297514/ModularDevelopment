using Component;

public class UpperCaseDecorator : Decorator<string>
{
    public UpperCaseDecorator(IComponent<string> component) : base(component)
    {
    }

    public override string GetText()
    {
        string baseText = base.GetText();
        return baseText.ToUpper();
    }
}
