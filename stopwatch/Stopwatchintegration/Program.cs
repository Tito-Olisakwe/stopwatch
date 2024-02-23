using System;
using System.Windows.Forms;

namespace   StopwatchApplication // Change to your actual namespace
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StopwatchForm());
        }
    }
}
