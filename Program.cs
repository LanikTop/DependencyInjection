using DependencyInjection.Extensions;
using DependencyInjection.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Threading.Tasks;


namespace DependencyInjection
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            using (var host = CreateHostBuilder(args).Build())
            {
                using (var scope1 = host.Services.CreateScope())
                {
                    Console.WriteLine("=== SCOPE 1 ===");
                    var serviceProvider1 = scope1.ServiceProvider;

                    serviceProvider1.ResolveTwiceAndCompare<SingletonService1>("SingletonService1");
                    serviceProvider1.ResolveTwiceAndCompare<SingletonService2>("SingletonService2");

                    serviceProvider1.ResolveTwiceAndCompare<ScopedService1>("ScopedService1");
                    serviceProvider1.ResolveTwiceAndCompare<ScopedService2>("ScopedService2");

                    serviceProvider1.ResolveTwiceAndCompare<TransientService1>("TransientService1");
                    serviceProvider1.ResolveTwiceAndCompare<TransientService2>("TransientService2");

                    Console.WriteLine("\nDisposes \n");
                }

                Console.WriteLine();

                using (var scope2 = host.Services.CreateScope())
                {
                    Console.WriteLine("=== SCOPE 2 ===");
                    var serviceProvider2 = scope2.ServiceProvider;

                    serviceProvider2.ResolveTwiceAndCompare<SingletonService1>("SingletonService1");
                    serviceProvider2.ResolveTwiceAndCompare<SingletonService2>("SingletonService2");

                    serviceProvider2.ResolveTwiceAndCompare<ScopedService1>("ScopedService1");
                    serviceProvider2.ResolveTwiceAndCompare<ScopedService2>("ScopedService2");

                    serviceProvider2.ResolveTwiceAndCompare<TransientService1>("TransientService1");
                    serviceProvider2.ResolveTwiceAndCompare<TransientService2>("TransientService2");

                    Console.WriteLine("\nDisposes \n");
                }

                await host.StopAsync();
            }
        }

        static IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder(args)
                .ConfigureServices((_, services) =>
                {
                    services.AddSingleton<SingletonService1>();
                    services.AddSingleton<SingletonService2>();

                    services.AddScoped<ScopedService1>();
                    services.AddScoped<ScopedService2>();

                    services.AddTransient<TransientService1>();
                    services.AddTransient<TransientService2>();
                });
        }
    }
}
