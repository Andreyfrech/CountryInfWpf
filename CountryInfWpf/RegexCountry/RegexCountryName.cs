using CountryInfWpf.RegexCountry;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace CountryInfWpf
{
    //класс вывод название страны
    class RegexCountryName : SerchCountry, IRegex
    {
        public List<string> regex(string Page)
        {
            Match countryName = Regex.Match(Page, ("(?<=\"name\":\")[^\"]*"));// Регулярное выражение для вывода названия страны
            result.Add(Convert.ToString(countryName));
            return result;
        }
    }
}