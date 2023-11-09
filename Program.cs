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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Show first form and start the message loop
            setupChar m_setup = new setupChar();
            m_setup.SetController(new Controller());
            (m_setup).Show();
            Application.Run(); // needed, otherwise app closes immediately
        }
    }
}