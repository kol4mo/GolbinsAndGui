namespace GolbinsAndGui
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
            setupChar m_setup = new setupChar();
            m_setup.SetController(new Controller());
            Application.Run(m_setup);
        }
    }
}