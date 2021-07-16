using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisconnectedMode_Startup
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

            // Specify the Startup Form
            //Application.Run(new Searchmedicine());
            //Application.Run(new DisplayDoctors());
            // Application.Run(new Formcrystal1());
            //Application.Run(new Formcrystal2());
            // Application.Run(new Form1()); // dis conn
            Application.Run(new Mainform());//conn
        }
    }
}
