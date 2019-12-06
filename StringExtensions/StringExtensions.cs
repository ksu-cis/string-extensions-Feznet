using System;
using System.Collections.Generic;
using System.Text;

namespace StringExtensions
{
    public static class StringExtensions
    {
        public static int WordCount(this String str)
        {
            return str.Split(new char[] { ' ', '.', '?', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }

        public static string Capitalize(this String str)
        {
            string first = str[0].ToString().ToUpper();
            return first + str.Substring(1);
        }

        public static string Decapitalize(this String str)
        {
            string first = str[0].ToString().ToLower();
            return first + str.Substring(1);
        }
        public static string Titlize(this String title)
        {
            List<string> articles = new List<string>()
            {
                "A",
                 "An",
                 "The"
            };
            List<string> parts = new List<string>(title.Split(" "));
            string first = parts[0];
            if (articles.Contains(parts[0].ToLower()))
            {
                parts.RemoveAt(0);
                parts.Add(", ");
                parts.Add(first);
                first = parts[0];
            }
            string result = "";
            foreach (string part in parts)
            {
                result += part + " ";
            }
        }
    }
}
