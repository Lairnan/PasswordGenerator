using System;
using System.Collections.Generic;

namespace ConsoleApplication2;

public class PasswordGenerator
{
    private static readonly Random Random = new Random();
    public string Password(int length)
    {
        var password = "";
        var pass = new List<string>
        {
            "ABCDEFGHIJKLMNOPQRSTUXYZ",
            "abcdefghijklmnopqrstuxyz",
            "0123456789",
            "!@#$%^&*()_+-:;\"'\\|/,.<>[]{}~"
        };
        for (int i = 0; i < length; i++)
        {
            var k = Random.Next(0, pass.Count);
            password += pass[k][Random.Next(0, pass[k].Length)].ToString();
        }

        return password;
    }
}