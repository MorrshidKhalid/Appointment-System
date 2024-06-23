using ClinicPresentationLayerDesktop.ui.login;
using System;
using System.Windows.Forms;

namespace ClinicPresentationLayerDesktop
{
    internal static class Program
    {
        public static int OnApplicationExit { get; private set; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormLogin());
        }
    }
}
