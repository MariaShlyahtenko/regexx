using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace RegexApp.Models
{
    public class MRegex
    {

        public static string? FindRegexInText(string text, string pattern)
        {
            string result = "";
            Regex reg = new Regex(pattern);
            MatchCollection a = reg.Matches(text);
            foreach (Match x in a)
            {
                result += (x.Value + "\n");
            }
            return result;
        }
    }
}