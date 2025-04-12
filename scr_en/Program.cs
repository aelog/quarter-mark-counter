using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quarter_Mark_Counter_GUI.NET_
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]

        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public static float sum = 0;
        public static float div = 0;

        public static string count_mark(float mark, float coef) 
        {
            Console.WriteLine(Convert.ToString(mark));
            Console.WriteLine(Convert.ToString(coef));
            string out_mark = "";

            mark *= coef;
            Console.WriteLine(Convert.ToString(mark));
            sum += mark;
            div += coef;
            Console.WriteLine(Convert.ToString(sum));
            Console.WriteLine(Convert.ToString(div));
            out_mark = Convert.ToString(Convert.ToSingle(Math.Round(sum / div, 2)));
            Console.WriteLine(out_mark);
            return out_mark;
        }

        public static void reset()
        {
            sum = 0;
            div = 0;
        }
    }
}
