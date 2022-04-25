using System;

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
                for (var i = 0; i < count; i++)
                {
                    var length = Random.Next(5, 25);
                    Console.WriteLine(password.Password(length));
                }

                Console.WriteLine("Вы вышли из программы.");
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}