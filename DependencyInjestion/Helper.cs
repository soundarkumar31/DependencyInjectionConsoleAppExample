using DependencyInjestion.Interfaces;
using DependencyInjestion.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjestion
{
    internal class Helper
    {
        public static void DisplayServiceNames()
        {
            //declare a service collection
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddTransient<IWork, Work>();
            serviceCollection.AddTransient<IWork2, Work2>();
            serviceCollection.AddTransient<IWork3, Work3>();

            var serviceProvider = serviceCollection.BuildServiceProvider();

            var work3Service = serviceProvider.GetService<IWork3>();

            work3Service.GetName();

            if (serviceProvider is IDisposable)
            {
                ((IDisposable)serviceProvider).Dispose();
            }
        }
    }
}
