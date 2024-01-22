using System;
using System.Windows.Forms;

namespace Checkers_Game
{
    static class Program
    {
        /// <summary>
        /// Startup point of the application
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
