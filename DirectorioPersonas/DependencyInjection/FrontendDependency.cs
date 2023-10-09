using CoreMessageBox.Abstracciones;
using CoreMessageBox.Servicios;
using Serilog;
using WinFormsClient.Repositorio;

namespace WinFormsClient.DependencyInjection
{
    public static class FrontendDependency
    {
        public static IServiceCollection AddFrontendServices(this IServiceCollection serviceCollection, 
            IConfiguration configuration)
        {
            serviceCollection.AddDbContextFactory<Repository>(options =>
            {
                if (options.IsConfigured == false)
                {
                    ISecurityBase64 security = new SecurityBase64();
                    string decryptingConnectionString = security.Decrypting(configuration.GetConnectionString("Integration"));
                    options.UseSqlServer(decryptingConnectionString);

                    options.EnableDetailedErrors();
                    options.EnableSensitiveDataLogging();
                }
            });

            serviceCollection.AddScoped<IPersonaRepository, PersonaRepository>();
            serviceCollection.AddScoped<ICreditoRepository, CreditoRepository>();
            serviceCollection.AddScoped<IDomicilioRepository, DomicilioRepository>();
            serviceCollection.AddScoped<IUserRepository, UserRepository>();

            
            serviceCollection.AddSingleton<FormPersonas>();
            serviceCollection.AddTransient<FormDomicilios>();
            serviceCollection.AddSingleton<IMessageBox<DialogResult>, WindowsMessageBox>();
            serviceCollection.AddSingleton<FormLogin>();

            LoggerConfiguration loggerConfiguration = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.File($"{Application.StartupPath}\\ApplicationLog.txt", rollingInterval: RollingInterval.Day, retainedFileCountLimit: 7);

            serviceCollection.AddSingleton<ILogger>(loggerConfiguration.CreateLogger());

            serviceCollection.AddSingleton<ISecurityBase64, SecurityBase64>();
            serviceCollection.AddSingleton<ISecurityIntelix, SecurityIntelix>();

            return serviceCollection;
        }
    }
}
