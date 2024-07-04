using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace QLTUYENDUNG.Utilities
{
    internal class StringChecker
    {
        public static bool hasSpecialCharacters(string input)
        {
            string pattern = @"[~`!@#$%^&*()_\-+={}[\]|\\:;'<>,?/]";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(input);
        }
    }
}
