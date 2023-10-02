using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.VoroshilovNA.Sprint1.Task6.V8.Lib
{
    public class DataService : ISprint1Task6V8
    {
        public string MoveLetterToEnd(string value)
        {
            string[] words = value.Split(' ');

            StringBuilder result = new StringBuilder();
            foreach (string word in words)
            {
                if (!string.IsNullOrWhiteSpace(word))
                {
                    char firstLetter = word[0];
                    string modifiedWord = word.Substring(1) + firstLetter;
                    result.Append(modifiedWord + " ");
                }
            }
            return result.ToString().Trim();
        }
    }
}
