using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kurs2023
{
    public static class LetterCode
    {

        private static Dictionary<int, List<char>> buttons = new Dictionary<int, List<char>>()
        {
            { 2, new List<char>() {  'A', 'B', 'C' } },
            { 3, new List<char>() {  'D', 'E', 'F' } },
            { 4, new List<char>() { 'G', 'H', 'I' } },
            { 5, new List<char>() {  'J', 'K', 'L' } },
            { 6, new List<char>() {  'M', 'N', 'O' } },
            { 7, new List<char>() { 'P', 'Q', 'R','S' } },
            { 8, new List<char>() {  'T', 'U', 'V' } },
            { 9, new List<char>() {  'W', 'X', 'Y', 'Z' } },

        };

        public static string GetLetterCode(char letter)
        {
            foreach (var button in buttons)
            {
                if (button.Value.Contains(char.ToUpper(letter)))
                {
                    string number = button.Key.ToString();
                    string res = number;
                    foreach (var element in button.Value)
                    {
                        if (element.Equals(char.ToUpper(letter)))
                        {
                            return res+="|";
                        }
                        else
                        {
                            res += number;
                        }
                    }

                }
            }
            return string.Empty;
        }
    }
}
