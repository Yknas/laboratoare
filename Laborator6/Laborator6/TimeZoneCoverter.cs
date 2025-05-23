using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Laborator6
{
    public class TimeZoneConverter
    {
        public DateTime ConvertToTimeZone(DateTime utcTime, string gmtInput)
        {
            var regex = new Regex(@"^GMT([+-])(\d{1,2})$");
            var match = regex.Match(gmtInput.Trim().ToUpper());

            if (!match.Success)
                throw new ArgumentException("Format nevalid. Exemplu valid: GMT+2 sau GMT-5");

            int offset = int.Parse(match.Groups[2].Value);
            if (offset < 0 || offset > 11)
                throw new ArgumentException("Fus orar invalid. X trebuie sa fie intre 0 si 11.");

            return match.Groups[1].Value == "+" ? utcTime.AddHours(offset) : utcTime.AddHours(-offset);
        }
    }
}
