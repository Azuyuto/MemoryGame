using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraMemory
{
    static class Program
    {
        public static int countCards = 64;
        public static int initialVisibilityTime = 3;
        public static int visibilityTimeFlippedPair = 1;
        public static bool allowMultipleCardsToBeFlipped = false;
        public static string userName = "User";
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LayoutForm());
        }
    }
}
