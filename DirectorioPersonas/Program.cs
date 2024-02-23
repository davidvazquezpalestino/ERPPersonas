namespace WinFormsClient
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            UserLookAndFeel.Default.SetSkinStyle(SkinSvgPalette.WXICompact);

            IHost host = Host.CreateDefaultBuilder().ConfigureAppConfiguration(configurationBuilder =>
            {
                configurationBuilder.AddJsonFile("appsettings.json", true);
            }).ConfigureServices((context, collection) =>
            {
                collection.AddFrontendServices(context.Configuration);
            }).Build();

            Application.Run(host.Services.GetRequiredService<FormLogin>());
        }
    }
}
