using System;
using System.IO;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RequisicaoEnel.App.Configuration;

namespace RequisicaoEnel.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder()
                 .SetBasePath(Directory.GetCurrentDirectory())
                 .AddJsonFile("appsettings.json")
                 .Build();

            var serviceProvider = new ServiceCollection()
                .DeclareConfiguration(builder);
        }
    }
}
