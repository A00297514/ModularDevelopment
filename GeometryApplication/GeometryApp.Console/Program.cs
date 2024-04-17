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
// Provide access to Square
}

if (await featureManager.IsEnabledAsync("Rectangle"))
{
// Provide access to Square
}

if (await featureManager.IsEnabledAsync("Triangle"))
{
// Provide access to Square
}