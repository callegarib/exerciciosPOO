using System;
namespace FibonacciSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a quantidade de números da sequência Fibonacci a serem exibidos: ");

            int quantidade;

            while (!int.TryParse(Console.ReadLine(), out quantidade) || quantidade <= 0)
            {
                Console.WriteLine("Por favor, digite um número inteiro positivo.");
                Console.Write("Digite a quantidade de números da sequência Fibonacci a serem exibidos: ");
            }

            ExibirFibonacci(quantidade);
        }

        static void ExibirFibonacci(int quantidade)
        {
            int primeiro = 0;
            int segundo = 1;

            Console.Write("Sequência de Fibonacci: ");

            for (int i = 0; i < quantidade; i++)
            {
                Console.Write(primeiro + " ");

                int proximo = primeiro + segundo;
                primeiro = segundo;
                segundo = proximo;
            }

            Console.WriteLine();
        }
    }
}