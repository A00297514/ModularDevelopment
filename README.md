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

# Steps Performed for Weather Monitoring System
1. Watched the recording of class 8 for 2nd of April and understood the requirement for th assignment.
2. Created one classlibrary and one console app named WMS.Library and WMS.Console.
3. Also separate the interface by creating its folder in library from observers and factory.
4. As asked in the class have created 6 class files.
5. Tried to code for factory using switch statement and tried to create singleton yet no error has encountered but the program is incomplete
6. Added WMS.Console and WMS.Library to the sln file
7. WMS.Library is referenced in WMS.Console
8. Successfully created Singleton, Factory and Console app.
9. dotnet build is successfull as well as run with ForecastDisplay 
10. Forecast and Statistics are ready and only left part is current conditions and shown to professor during break in class


# Steps Performed for SplitBill Assignment
1. Created a class library named SplitTheBill
2. Created a test project named SplitTheBillTest
3. Added both to the solution file ModularDevelopment.sln
4. created SplitBill.cs in library and SplitBillTest.cs  in test project
5. created a method  "public decimal SplitTheAmount(decimal amount, int people)"
6. wrote 3 different test methods for the above created method
7. tried to create a method which calculateTip using weighted Average but work is pending
8. Reference the library project to test project
9. successfully performed 3 tests but confused with 2 test projects running parallely.
10. question for professor how to perform a single project test methods..??
11. created 2 methods to calculate tip using weighted average and calculate tip/person
12. Also wrote logic which throws exception if wrong values like 0s or negative value is passed in parameters

