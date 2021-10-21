using System;
using System.IO;
using System.Text;

namespace EncodingExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string unicodeString = "This string contains the unicode character Pi(\u03a0)";
            // Создаем объекты двух кодировок.
            Encoding ascii = Encoding.ASCII, unicode = Encoding.Unicode;
            // Перевод строки в массив байт (byte[]).
            byte[] unicodeBytes = unicode.GetBytes(unicodeString);
            // Выполняем конвертацию из одной кодировки в другую.
            byte[] asciiBytes = Encoding.Convert(unicode, ascii, unicodeBytes);
            // Конвертация массива байт в массив символов и строку.
            // Пример использования GetCharCount/GetChars.
            char[] asciiChars = new char[ascii.GetCharCount(asciiBytes, 0, asciiBytes.Length)];
            ascii.GetChars(asciiBytes, 0, asciiBytes.Length, asciiChars, 0);
            string asciiString = new string(asciiChars);
            // Отображаем результаты.
            File.WriteAllText("unicode.txt", String.Format("Original string: {0}", unicodeString));
            File.WriteAllText("ascii.txt", String.Format("Ascii converted string: {0}", asciiString));

        }
    }
}
