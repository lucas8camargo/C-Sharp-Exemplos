using System;
namespace classe_random
{
    class Program
    {
        static void Main(string[] args)
        {
            Random n = new Random();
            // Retorna um número inteiro aleatório entre 0 e 9.
            int exemplo1 = n.Next(10);
            // Retorna um número inteiro aleatório entre 5 e 9.
            int exemplo2 = n.Next(10);
            // Retorna um número de ponto flutuante aleatório maior ou igual a 0,0 e menor que 1.0.
            double exemplo3 = n.NextDouble();
            // Resultados
            Console.WriteLine($"Exemplo 1: {exemplo1}");
            Console.WriteLine($"Exemplo 2: {exemplo2}");
            Console.WriteLine($"Exemplo 3: {exemplo3}");
        }
    }
}