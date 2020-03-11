using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace InfrastructureLayer
{
    static class RegExp
    {
        public static string Find(string regex,string value) {

            var regexp = new Regex(regex);
            var match = regexp.Match(value);
            return match.Groups[0].Value + match.Groups[1].Value;

        }
    }
}
