using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATBM_A_14
{
    internal static class Program
    {
        public static string connectionString = "";
        public static string username = ""; // just variable, dont touch
        public static string password = ""; // just variable, dont touch

        // config here
        public static string HOST = "localhost";
        public static string SERVICE = "PDB_PROJECT"; // SID is also fine here
        public static string PORT = "1521";
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}
