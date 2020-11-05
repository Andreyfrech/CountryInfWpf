using CountryInfWpf.RegexCountry;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace CountryInfWpf
{
    //класс вывод столицы
    class RegexCountryCapital : SerchCountry, IRegex
    {
        public List<string> regex(string Page)
        {
            Match countryCapital = Regex.Match(Page, ("(?<=\"capital\":\")[^\"]*"));// Регулярное выражение для вывода столицы страны
            result.Add(Convert.ToString(countryCapital));
            return result;
        }
    }
}