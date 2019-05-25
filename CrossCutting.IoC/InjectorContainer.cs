using CrossCutting.IoC.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace CrossCutting.IoC
{
    public static class InjectorContainer
    {
        public static void ServicesRegister(IServiceCollection services, string connectionString)
        {
            Run(services, connectionString);
        }

        private static void Run(IServiceCollection services, string connectionString)
        {
            var typeSeed = typeof(IContainer);

            var types = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(w => typeSeed.IsAssignableFrom(w)
                         && !w.IsInterface
                         && !w.IsAbstract);

            foreach (var type in types)
            {
                var instance = (IContainer)Activator.CreateInstance(type);
                instance.Register(services, connectionString);
            }
        }
    }
}