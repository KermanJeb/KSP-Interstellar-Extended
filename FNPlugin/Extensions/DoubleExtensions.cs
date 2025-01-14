﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FNPlugin.Extensions
{
    static class DoubleExtensions
    {
        public static bool IsInfinityOrNaN(this double d)
        {
            return double.IsInfinity(d) || double.IsNaN(d);
        }

        public static bool IsInfinityOrNaNorZero(this double d)
        {
            return double.IsInfinity(d) || double.IsNaN(d) || d == 0;
        }
    }
}
