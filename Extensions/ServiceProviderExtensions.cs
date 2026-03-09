using DependencyInjection.Abstraction;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace DependencyInjection.Extensions
{
    public static class ServiceProviderExtensions
    {
        public static void ResolveTwiceAndCompare<T>
            (this IServiceProvider serviceProvider, string serviceType)
            where T : class, IHasInstanceId
        {
            Console.WriteLine($"\n--- {serviceType} ---");

            var first = serviceProvider.GetService<T>();
            Console.WriteLine($"First:  {first?.InstanceId}");

            var second = serviceProvider.GetService<T>();
            Console.WriteLine($"Second: {second?.InstanceId}");

            Console.WriteLine(first == second ? "Same instances" : "Different instances");
        }    
    }
}
