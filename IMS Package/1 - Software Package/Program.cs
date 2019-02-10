using System;
using System.Windows.Forms;

namespace _1___Software_Package
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormPages._1___SignIn.AdminLoginWindow());
        }
    }
}
