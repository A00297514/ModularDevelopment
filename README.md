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