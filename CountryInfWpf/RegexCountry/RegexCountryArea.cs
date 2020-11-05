using CountryInfWpf.RegexCountry;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace CountryInfWpf
{
    //Класс вывод площади
    class RegexCountryArea : SerchCountry, IRegex
    {
        public List<string> regex(string Page)
        {
            Match countryArea = Regex.Match(Page, ("(?<=\"area\":)[^,]*"));// Регулярное выражение для вывода площади страны
            result.Add(Convert.ToString(countryArea));
            return result;
        }
    }
}