using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using Program;

namespace ConversoesTemperatura;

    public class Conversoes
    {
        public double CelsiusFahrenheit(double valorFornecido)
        {
            return (valorFornecido * 9 / 5) + 32;
        }

        public double FahrenheitCelsius(double valorFornecido)
        {
            return (valorFornecido - 32) * 5 / 9;
        }

        public double CelsiusKelvin(double valorFornecido)
        {
            return (valorFornecido + 273.15);
        }

        public double KelvinFahrenheit(double valorFornecido)
        {
            return (valorFornecido - 273.15) * 9 / 5 + 32;
        }

        public double KelvinCelsius(double valorFornecido)
        {
            return (valorFornecido - 273.15);
        }
    }
