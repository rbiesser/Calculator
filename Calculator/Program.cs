using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
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
            Application.Run(new StandardCalculator());
        }
    }

    public class Unicode
    {
        // https://www.fileformat.info/info/unicode/category/Sm/list.htm
        public const char PLUS_SIGN = '\u002B';
        public const char MULTIPLICATION_SIGN = '\u00D7';
        public const char DIVISION_SIGN = '\u00F7';
        public const char MINUS_SIGN = '\u2212';
        public const char EQUALS_SIGN = '\u003D';
        public const char PLUS_MINUS_SIGN = '\u00B1';
    }
}
