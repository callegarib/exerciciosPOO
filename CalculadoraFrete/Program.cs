using System;

namespace CalculoFrete
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a distância em km entre o distribuidor e o local de entrega: ");
            double distancia;

            // Lê a distância fornecida pelo usuário
            while (!double.TryParse(Console.ReadLine(), out distancia) || distancia <= 0)
            {
                Console.WriteLine("Por favor, digite uma distância válida em km.");
                Console.Write("Digite a distância em km entre o distribuidor e o local de entrega: ");
            }

            Console.Write("Digite o peso da encomenda em kg: ");
            double peso;

            // Lê o peso fornecido pelo usuário
            while (!double.TryParse(Console.ReadLine(), out peso) || peso <= 0)
            {
                Console.WriteLine("Por favor, digite um peso válido em kg.");
                Console.Write("Digite o peso da encomenda em kg: ");
            }

            // Cálculo do valor do frete baseado na distância
            double valorFrete = CalcularFrete(distancia, peso);

            Console.WriteLine($"O valor do frete é R$ {valorFrete:F2}");
        }

        static double CalcularFrete(double distancia, double peso)
        {
            double valorFrete = distancia * 0.10; // Valor base por km

            // Adiciona taxa a cada 200km
            valorFrete += (int)(distancia / 200) * 1.00;

            // Adiciona taxa a cada 1000km
            valorFrete += (int)(distancia / 1000) * 10.00;

            // Verifica o peso e multiplica o valor do frete
            if (peso > 5 && peso <= 25)
            {
                valorFrete *= 5;
            }
            else if (peso > 25 && peso <= 75)
            {
                valorFrete *= 3;
            }

            return valorFrete;
        }
    }
}