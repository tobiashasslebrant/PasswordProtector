using System;
using System.Windows.Forms;

namespace PasswordProtector
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm());
            }
            catch (Exception e)
            {
                Console.WriteLine("somehing went wrong");
            }
            
        }
    }
}
