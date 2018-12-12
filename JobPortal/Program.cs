using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobPortal
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
            Form login = new Form1();
            login.ShowDialog();
            if (Form1.state.login == 1)
            {
                Application.Run(new Main());
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
