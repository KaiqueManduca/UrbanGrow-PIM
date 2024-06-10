using UrbanGrow.Forms;

namespace UrbanGrow {
    internal static class Program {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Application.SetCompatibleTextRenderingDefault(false); // se der erro, apague
            Application.Run(new Login());
        }
    }
}