using CountryInfWpf.RegexCountry;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace CountryInfWpf
{
    //класс вывод кода страны
    class RegexCountryCode : SerchCountry, IRegex
    {

        public List<string> regex(string Page)
        {
            Match countryCode = Regex.Match(Page, ("(?<=\"alpha2Code\":\")[^\"]*"));// Регулярное выражение для вывода кода страны
            result.Add(Convert.ToString(countryCode));
            return result;
        }
    }
}