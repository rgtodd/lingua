﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Lingua;

namespace LinguaDemo.Calculator
{
    [Terminal(@"[a-zA-Z][a-zA-Z0-9_]*")]
    public class Variable : CalculatorTerminal
    {
    }
}
