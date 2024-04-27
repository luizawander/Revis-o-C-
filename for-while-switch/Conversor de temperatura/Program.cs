using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using ConversoesTemperatura;

namespace Program;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual valor da temperatura que deseja converter?");
            string entrada = Console.ReadLine();

            double valorFornecido;
            double.TryParse(entrada, out valorFornecido);

            Console.WriteLine($"O valor fornecido foi {valorFornecido}. Agora escolha o tipo de conversão que quer fazer:");
            Console.WriteLine("1- Celsius para Fahrenheit\n2- Celsius para Kelvin\n3- Fahrenheit para Celsius\n4- Fahrenheit para Kelvin\n5- Kelvin para Celsius\n6- Kelvin para Fahrenheit");

            string escolha = Console.ReadLine();

            double valorConvertido;

            Conversoes conversor = new Conversoes();

            switch (escolha)
            {
                case "1":
                    valorConvertido = conversor.CelsiusFahrenheit(valorFornecido);
                    Console.WriteLine($" A temperatura em Fahrenheit é {valorConvertido}°F");
                    break;

                case "2":
                    valorConvertido = conversor.CelsiusKelvin(valorFornecido);
                    Console.WriteLine($" A temperatura em Kelvin é {valorConvertido}°K");
                    break;

                case "3":
                    valorConvertido = conversor.FahrenheitCelsius(valorFornecido);
                    Console.WriteLine($" A temperatura em Celsius é {valorConvertido}°C");
                    break;

                case "4":
                    valorConvertido = conversor.KelvinFahrenheit(valorFornecido);
                    Console.WriteLine($" A temperatura em Fahrenheit é {valorConvertido}°F");
                    break;

                case "5":
                    valorConvertido = conversor.KelvinCelsius(valorFornecido);
                    Console.WriteLine($" A temperatura em Celsius é {valorConvertido}°C");
                    break;

                case "6":
                    valorConvertido = conversor.KelvinFahrenheit(valorFornecido);
                    Console.WriteLine($" A temperatura em Fahrenheit é {valorConvertido}°F");
                    break;

                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
    }

