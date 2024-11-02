namespace iRANE_62
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Form mikser = new Mikser();
            Form odt1 = new Odtwarzacz();

            var thread1 = new System.Threading.Thread(() =>
            {   
                //Application.Run(mikser);
                Application.Run(odt1);
            });

            thread1.SetApartmentState(System.Threading.ApartmentState.STA);
            thread1.Start();


        }
    }
}
