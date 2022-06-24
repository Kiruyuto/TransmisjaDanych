using System;
using System.Windows.Forms;
// ReSharper disable InconsistentNaming

namespace Lab2_win_forms
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new WybierzZad());
        }
    }
}
