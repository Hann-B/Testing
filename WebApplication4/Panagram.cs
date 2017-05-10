using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication4
{
    public class Panagram
    {
        public String PanagramTest(String s)
        {
            var rv = "";
            bool newStr = s.ToLower()
                .Where(c => Char.IsLetter(c))
                .GroupBy(c => c)
                .Count() == 26;
            if (newStr)
            { rv = "pangram"; }
            else
            { rv="not pangram";}
            return rv;
        }
    }
}