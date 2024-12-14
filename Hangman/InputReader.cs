using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Hangman
{
    class InputReader
    {
        public string GetInput()
        {
            StringBuilder input = new StringBuilder();
            ConsoleKeyInfo key = Console.ReadKey();

            while (true)
            {
                if(Regex.IsMatch(key.KeyChar.ToString(), "^[а-яА-Я]*$"))
                {
                    Console.Write(key.KeyChar);
                    input.Append(key.KeyChar);
                }
                else if(key.Key == ConsoleKey.Enter)
                {
                    input.Append("\n");
                    return input.ToString();
                }
            }
        }
    }
}
