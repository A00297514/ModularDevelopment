using Component;

public class PlainDecorator : Decorator<string>
{
    public PlainDecorator(IComponent<string> component) : base(component)
    {
    }

    public override string GetText()
    {
        
        return  base.GetText() + "text added.";
    }
}
