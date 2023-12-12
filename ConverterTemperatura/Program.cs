using System;

namespace ConverterTemperatura
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a temperatura em graus Celsius: ");

            // Lê a temperatura fornecida pelo usuário
            double celsius;
            while (!double.TryParse(Console.ReadLine(), out celsius))
            {
                Console.WriteLine("Por favor, digite um número válido para a temperatura em Celsius.");
                Console.Write("Digite a temperatura em graus Celsius: ");
            }

            // Converte para Fahrenheit
            double fahrenheit = (celsius * 9 / 5) + 32;

            // Converte para Kelvin
            double kelvin = celsius + 273.15;

            Console.WriteLine($"{celsius} graus Celsius são {fahrenheit} °F e {kelvin} Kelvin.");
        }
    }
}