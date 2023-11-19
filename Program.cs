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

            //Show first form and start the message loop
            ApplicationConfiguration.Initialize();
            Application.Run(FormManager.Current); 
            
        }
    }
}