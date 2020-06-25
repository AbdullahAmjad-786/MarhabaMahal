using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MarhabaMahal.Views;

namespace MarhabaMahal
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static int roundupbyten(this int i)
        {
            // return i + (10 - i % 10); <-- logic error. Oops!
            return (int)(Math.Ceiling(i / 10.0d) * 10); // fixed
        }
        [STAThread]

        static void Main()
        {
            //Login obj = new Login();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
