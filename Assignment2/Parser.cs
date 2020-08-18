using System;
using System.Text.RegularExpressions;

namespace Calculator
{
    public class Parser
    {
        public Parsed Parse(string input)
        {
            long arg1 = 0;
            Match firstMatch = Regex.Match(input, "^\\d+");
            if (firstMatch.Success)
            {
                arg1 = Convert.ToInt64(firstMatch.Value);
            }
            string op = Regex.Match(input, "\\D+").Value;
            Match secondMatch = Regex.Match(input, "\\d+$");
            long arg2 = 0;
            if (secondMatch.Success)
            {
                arg2 = Convert.ToInt64(secondMatch.Value);
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