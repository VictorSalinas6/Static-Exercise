﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    public static class TempConverter
    {
        public static double FahrenheitToCelsius(double fahrenheit)
        {
            var celcius = (fahrenheit - 32) / 1.8;

            return celcius;
        }

        public static double CelsiusToFahrenheit(double celsius)
        {
            double fahrenheit = (celsius * (1.8) + 32);

            return fahrenheit;
        }
    }
}
