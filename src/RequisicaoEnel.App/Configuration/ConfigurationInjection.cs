using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RequisicaoEnel.Infra.Configuration;
using RequisicaoEnel.Infra.SQLServer;
using RequisicaoEnel.Infra.Mongo;

namespace RequisicaoEnel.App.Configuration
{
    public static class ConfigurationInjection
    {
        public static IServiceCollection DeclareConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            var EnelSettings = configuration.GetSection("EnelSettings").Get<EnelSettings>();

            // Bases
            var SqlServerSettings = configuration.GetSection("SqlServerSettings").Get<SqlServerSettings>();
            var MongoSettings = configuration.GetSection("MongoSettings").Get<MongoSettings>();

            return services;
        }
    }
}