using CountryInfWpf.RegexCountry;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace CountryInfWpf
{
    //класс вывод население страны
    class RegexCountryPopulation : SerchCountry, IRegex
    {
        public List<string> regex(string Page)
        {
            Match countryPopulation = Regex.Match(Page, ("(?<=\"population\":)[^,]*"));// Регулярное выражение для вывода населения страны
            result.Add(Convert.ToString(countryPopulation));
            return result;
        }
    }
}