using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Hangman
{
    static class InputReader
    {
        public static string GetInput(int maxInputCounts = 0)
        {
            StringBuilder input = new StringBuilder();
            ConsoleKeyInfo key = Console.ReadKey(true);
            int inputCounts = 0;

            while (inputCounts < maxInputCounts || maxInputCounts == 0)
            {
                if (Regex.IsMatch(key.KeyChar.ToString(), "^[а-яёА-ЯЁ]*$"))
                {
                    ++inputCounts;
                    Console.Write(key.KeyChar.ToString().ToUpper());
                    input.Append(key.KeyChar);
                }
                else if (key.Key == ConsoleKey.Enter && input.Length > 0)
                {
                    inputCounts = 0;
                    Console.Write("\n");
                    return input.ToString().ToUpper();
                }

                key = Console.ReadKey(true);
            }

            return input.ToString().ToUpper();
        }
    }
}
