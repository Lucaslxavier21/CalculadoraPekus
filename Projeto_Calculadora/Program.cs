


namespace Projeto_Calculadora
{
    using Microsoft.Extensions.Configuration;
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            var cfg = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            var connectionString = cfg.GetConnectionString("Padrão");
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm(connectionString));
        }
    }
}