using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.FeatureManagement;

var features = new Dictionary<string, string> {{"FeatureManagement:Premium","false"}};

IConfigurationRoot config = new ConfigurationBuilder().AddInMemoryCollection(features).Build();

IServiceCollection services = new ServiceCollection();
services.AddFeatureManagement(config);

IServiceProvider serviceProvider = services.BuildServiceProvider();

IFeatureManager featureManager = serviceProvider.GetRequiredService<IFeatureManager>();

if(await featureManager.IsEnabledAsync("Premium"))
{
    Console.WriteLine("Welcome to Premium Calculator");
}

else
{
    Console.WriteLine("Welcome to Calculator");
}

Console.WriteLine("Choose your function");
Console.WriteLine("1. Addition");
Console.WriteLine("2. Subtraction");
if(await featureManager.IsEnabledAsync("Premium"))
{
    
    Console.WriteLine("3. Multiplication");
    Console.WriteLine("4. Division");
}

var num = Console.ReadLine();

switch(num)
{
    case "1":
        Console.WriteLine("Do Addition");
        break;
    case "2":
        Console.WriteLine("Do Subtraction");
        break;
   
    case "3":
        if(await featureManager.IsEnabledAsync("Premium"))
        {
            Console.WriteLine("Do Multiplication");
        }

        else{
            Console.WriteLine("Wrong Choice");
        }
        break;
    
    case "4":
        if(await featureManager.IsEnabledAsync("Premium"))
        {
            Console.WriteLine("Do Divison");
        }

        else{
            Console.WriteLine("Wrong Choice");
        }
        break;
    default:
        Console.WriteLine("Wrong Choice");
        break;
    
}
