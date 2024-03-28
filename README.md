# ModularDevelopment
Assignments and Classwork of Modular Development

# Steps Performed for Decorator Design Pattern
1. dotnet new console -o DecoratorDesignPattern
2. dotnet sln add ./DecoratorDesignPattern/DecoratorDesignPattern.csproj
3. dotnet build
4. 2 folders named Component and Decorator is created
5. IComponent.cs, ConcreteComponent.cs, Decorator.cs is created in its own folders and used the namespaces
6. Encountered this error
    'PlainDecorator.GetText()': cannot override inherited member 'Decorator<string>.GetText()' because it is not marked virtual, abstract, or overrideCS0506
7. After doing a quick fix 
    public virtual T GetText()
    {
        return component.GetText();
    }
8. Encountered this error in PlainDecorator When Commented this code
    //public PlainDecorator(IComponent<string> component) : base(component)
    // {
    // }
    Error:
    There is no argument given that corresponds to the required parameter 'component' of 'Decorator<string>.Decorator(IComponent<string>)'CS7036
9. Have to uncomment the above constructor
10. All Class Files have been created but have few questions in mind that need to be asked to sir in class.
    10.1 what is the meaning of virtual and why there is a need of that
    10.2 what is the need of 