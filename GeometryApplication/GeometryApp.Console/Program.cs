using GeometryApp.Library;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.FeatureManagement;
var featureManagement = new Dictionary<string, string> {{ "FeatureManagement:Square", "true"}, { "FeatureManagement:Rectangle", "false"}, { "FeatureManagement:Triangle", "true"}};

IConfigurationRoot configuration = new ConfigurationBuilder().AddInMemoryCollection(featureManagement).Build();

var services = new ServiceCollection();
services.AddFeatureManagement(configuration);
var serviceProvider = services.BuildServiceProvider();

var featureManager = serviceProvider.GetRequiredService<IFeatureManagerSnapshot>();
if (await featureManager.IsEnabledAsync("Square"))
{
    Console.WriteLine("Calculate the Area and Perimeter of a Square");
    Console.WriteLine("Enter the length of a side:");
    var num = Console.ReadLine();
    IShape objSquare = new Square(double.Parse(num));
    Console.WriteLine("Area of a Square: " + objSquare.CalculateArea());
    Console.WriteLine("Perimeter of a Square: " + objSquare.CalculatePerimeter());
    Console.WriteLine();
}

if (await featureManager.IsEnabledAsync("Rectangle"))
{
    Console.WriteLine("Calculate the Area and Perimeter of a Rectangle");
    Console.WriteLine("Enter the length: ");
    var length = Console.ReadLine();
    Console.WriteLine("Enter the width: ");
    var width = Console.ReadLine();
    IShape objRectangle = new Rectangle(double.Parse(length),double.Parse(width));
    Console.WriteLine("Area of a Rectangle: " + objRectangle.CalculateArea());
    Console.WriteLine("Perimeter of a Rectangle: " + objRectangle.CalculatePerimeter());
    Console.WriteLine();
}

if (await featureManager.IsEnabledAsync("Triangle"))
{
    Console.WriteLine("To Calculate the Area of a Triangle");
    Console.WriteLine("Enter the base: ");
    var _base = Console.ReadLine();
    Console.WriteLine("Enter the height: ");
    var height = Console.ReadLine();
    Console.WriteLine();
    Console.WriteLine("To calculate the Perimeter of a Triangle");
    Console.WriteLine("Enter the length of a side 1: ");
    var side1 = Console.ReadLine();
    Console.WriteLine("Enter the length of a side 2: ");
    var side2 = Console.ReadLine();
    Console.WriteLine("Enter the length of a side 3: ");
    var side3 = Console.ReadLine();
    Console.WriteLine();
    IShape objTriangle = new Triangle(double.Parse(_base),double.Parse(height),double.Parse(side1),double.Parse(side2),double.Parse(side3));
    Console.WriteLine("Area of a Triangle: " + objTriangle.CalculateArea());
    Console.WriteLine("Perimeter of a Triangle: " + objTriangle.CalculatePerimeter());
    Console.WriteLine();
}



