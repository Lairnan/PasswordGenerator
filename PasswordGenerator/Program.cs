using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleApplication2
{
    internal static class Program
    {
        private static readonly Random Random = new Random();
        public static void Main()
        {
            try
            {
                Console.Write("Введите количество паролей: ");
                var count = int.Parse(Console.ReadLine() ?? string.Empty);
                var password = new PasswordGenerator();
                using (var file = new StreamWriter("PassGen.txt", true, Encoding.UTF8))
                {
                    for (var i = 0; i < count; i++)
                    {
                        var length = Random.Next(5, 25);
                        file.WriteLine($"{i+1} - {password.Password(length)}");
                    }
                    file.WriteLine($"Создано - {DateTime.Now}");
                    file.WriteLine("------------------------------------------------------------------");
                }
            }
            catch (FormatException ex)
            {
                using (var file = new StreamWriter("Error.txt", true, Encoding.UTF8))
                {
                    file.WriteLine(ex.Message);
                    file.WriteLine(DateTime.Now);
                    file.WriteLine("------------------------------------------------------------------");
                }
            }
        }
    }
}