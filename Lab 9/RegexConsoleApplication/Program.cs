using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Linq;
namespace RegexConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            RunTask();
        }
        public static void Example1()
        {
            // Массив тестируемых строк
            string[] test = {
            "Wuck World", "Hello world", "My wonderful world"
        };

            // Проверим, содержится ли в исходных строках слово World
            // при этом мы не укажем опции RegexOption
            Regex regex = new Regex("World");

            Console.WriteLine("Регистрозависимый поиск: ");
            foreach (string str in test)
            {
                if (regex.IsMatch(str))
                    Console.WriteLine("В исходной строке: \"{0}\" есть совпадения!", str);
            }
            Console.WriteLine();

            // Теперь укажем поиск, не зависимый от регистра
            regex = new Regex("World", RegexOptions.IgnoreCase);

            Console.WriteLine("РегистроНЕзависимый поиск: ");
            foreach (string str in test)
            {
                if (regex.IsMatch(str))
                    Console.WriteLine("В исходной строке: \"{0}\" есть совпадения!", str);
            }

        }
        public static void Example2()
        {
            // Допустим в исходной строке нужно найти все числа,
            // соответствующие стоимости продукта
            string input = "Добро пожаловать в наш магазин, вот наши цены: " +
                "1 кг. яблок - 20 руб. " +
                "2 кг. апельсинов - 30 руб. " +
                "0.5 кг. орехов - 50 руб.";

            string pattern = @"\b(\d+\W?руб)";
            Regex regex = new Regex(pattern);

            // Получаем совпадения в экземпляре класса Match
            Match match = regex.Match(input);

            // отображаем все совпадения
            while (match.Success)
            {
                // Т.к. мы выделили в шаблоне одну группу (одни круглые скобки),
                // ссылаемся на найденное значение через свойство Groups класса Match
                Console.WriteLine(match.Groups[1].Value);

                // Переходим к следующему совпадению
                match = match.NextMatch();
            }

        }


        public static void RunTask()
        {
            string fileName = @"C:\Users\enigm\source\repos\Yekteniya2202\dotNet-Labs\Lab 9\RegexConsoleApplication\Programm.txt";
            string str = String.Empty;
            using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite))
            using (StreamReader reader = new StreamReader(fs, true))
            {
                str = reader.ReadToEnd();
            }
            //(?:[}|{|;])\s*\n*(?:public|private|)\s*(?:class)\b\s*([a-zA-Z]+[0-9]*)\b
            // Теперь укажем поиск, не зависимый от регистра
            Regex regex = new Regex(@"(?:[}|{|;])\s*\n*(?:public|private|)\s*(?:class)\b\s*([a-zA-Z]+[0-9]*)\b");
            Match match = regex.Match(str);
            while (match.Success)
            {
                List<Group> groups = new List<Group>(match.Groups.Values);
                Console.WriteLine(groups.Last().Value);
                match = match.NextMatch();
            }
        }
    }

    public static class A
    {

    }
    static class B
    {

    }

    public class AA
    {

    }

    class BB
    {

    }
}
