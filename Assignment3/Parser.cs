using System;
using System.Text.RegularExpressions;

namespace Sort
{
    public class Parsed
    {
        public int Arg1, Arg2;
        public string Op;
    }
    public static class Parser
    {
        public static Parsed Parse(string input)
        {
            int arg1 = 0;
            Match firstMatch = Regex.Match(input, "^\\d+");
            if (firstMatch.Success)
            {
                arg1 = Convert.ToInt32(firstMatch.Value);
            }
            string op = Regex.Match(input, "\\D+").Value;
            Match secondMatch = Regex.Match(input, "\\d+$");
            int arg2 = 0;
            if (secondMatch.Success)
            {
                arg2 = Convert.ToInt32(secondMatch.Value);
            }
            return new Parsed()
            {
                Arg1 = arg1,
                Op = op,
                Arg2 = arg2
            };
        }
    }
}