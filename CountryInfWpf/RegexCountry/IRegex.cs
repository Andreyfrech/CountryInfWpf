﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryInfWpf.RegexCountry
{
    //Интерфей для классов регулярных выражений
    interface IRegex
    {
        List<string> regex(string Page);
    }
}
