using KatmanliOrnek.UI.EfContextForm;

namespace KatmanliOrnek.UI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var form = EfContextForm.EfContextForm.ConfigureService<Form1>();

            Application.Run(form);
        }
    }
}