using System;
using System.Windows.Forms;

namespace _6b6tStatsGUI
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1()); // Launch the main form (Form1)
        }
    }
}
