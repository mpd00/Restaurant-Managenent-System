using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace RMS_MPD
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

            if (Directory.Exists($@"{Path.GetDirectoryName(Application.ExecutablePath)}\temp"))
            {
            Directory.Delete($@"{Path.GetDirectoryName(Application.ExecutablePath)}\temp", true);
            }
            Directory.CreateDirectory($@"{Path.GetDirectoryName(Application.ExecutablePath)}\temp");
            
            //Application.Run(new Customer.Customer_Dashboard_Main());
            //Application.Run(new Manager.Manager_Dashboard_Main());
            //Application.Run(new MenuMain());
            Application.Run(new SplashScreen());
        }
    }
}
