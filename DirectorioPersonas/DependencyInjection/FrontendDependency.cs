using CoreMessageBox.Servicios;
using Microsoft.Extensions.Logging;
using Serilog;
using WinFormsClient.Repositorio;

namespace WinFormsClient.DependencyInjection
{
    public static class FrontendDependency
    {
        public static IServiceCollection AddFrontendServices(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddDbContextFactory<RepositoryQuery>(options =>
            {
                if (options.IsConfigured == false)
                {
                    ISecurityBase64 security = new SecurityBase64();
                    string decryptingConnectionString = security.Decrypting(configuration.GetConnectionString("Integration"));
                    options.UseSqlServer(decryptingConnectionString);

                    options.EnableDetailedErrors();
                    options.EnableSensitiveDataLogging();
                    options.LogTo(Console.WriteLine, LogLevel.Information);

                }
            });

            services.AddDbContextFactory<RepositoryCommand>(options =>
            {
                if (options.IsConfigured == false)
                {
                    ISecurityBase64 security = new SecurityBase64();
                    string decryptingConnectionString = security.Decrypting(configuration.GetConnectionString("Integration"));
                    options.UseSqlServer(decryptingConnectionString);

                    options.EnableDetailedErrors();
                    options.EnableSensitiveDataLogging();
                    options.LogTo(Console.WriteLine, LogLevel.Information);

                }
            });

            services.AddScoped<IPersonaRepository, PersonaRepository>();
            services.AddScoped<ICreditoRepository, CreditoRepository>();
            services.AddScoped<IDomicilioRepository, DomicilioRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<ISucursalRepository, SucursalRepository>();


            services.AddSingleton<FormPersonas>();
            services.AddTransient<FormDomicilios>();
            services.AddSingleton<IMessageBox<DialogResult>, WindowsMessageBox>();
            services.AddSingleton<FormLogin>();

            LoggerConfiguration loggerConfiguration = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.File($"{Application.StartupPath}\\ApplicationLog.txt", rollingInterval: RollingInterval.Day, retainedFileCountLimit: 7);

            services.AddSingleton<Serilog.ILogger>(loggerConfiguration.CreateLogger());

            services.AddSingleton<ISecurityBase64, SecurityBase64>();
            services.AddSingleton<ISecurityIntelix, SecurityIntelix>();

            services.AddMemoryCache();

            return services;
        }
    }
}
