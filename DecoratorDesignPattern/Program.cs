using Component;


// Create a ConcreteComponent
IComponent<string> concreteComponent = new ConcreteComponent();

// Create decorators
IComponent<string> plainDecorator = new PlainDecorator(concreteComponent);
IComponent<string> colorDecorator = new ColorDecorator(concreteComponent);
IComponent<string> upperCaseDecorator = new UpperCaseDecorator(concreteComponent);

// Call GetText() method on each object and print the result to the console
Console.WriteLine("Plain Decorator: " + concreteComponent.GetText());
Console.WriteLine("Concrete Decorator: " + concreteComponent.GetText());
Console.WriteLine("Color Decorator: " + colorDecorator.GetText());
Console.WriteLine("Upper Case Decorator: " + upperCaseDecorator.GetText());
