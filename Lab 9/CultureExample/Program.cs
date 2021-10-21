using System;
using System.Globalization;
using System.Threading;

namespace NumberAndDateFormatting
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberFormatDemo();
        }

        private static void NumberFormatDemo()
        {
            int val = 1234567890;

            // Культура текущего потока
            Console.WriteLine(val.ToString("N"));

            // Интерфейс IFormatProvider
            Console.WriteLine(val.ToString("N", new CultureInfo("fr-FR")));

            // Изменение культуры потока
            Thread.CurrentThread.CurrentCulture = new CultureInfo("de-DE");
            Console.WriteLine(val.ToString("N"));
        }
    }
}
