using CountryInfWpf.RegexCountry;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace CountryInfWpf
{
    //класс вывод региона
    class RegexCountryRegion : SerchCountry, IRegex
    {
        public List<string> regex(string Page)
        {
            Match countryRegion = Regex.Match(Page, ("(?<=\"region\":\")[^\"]*"));// Регулярное выражение для вывода региона страны
            result.Add(Convert.ToString(countryRegion));
            return result;
        }
    }
}