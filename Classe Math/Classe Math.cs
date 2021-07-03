using System;
namespace classe_math
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Retorna o primeiro número elevado à potência do segundo.
            double pow = Math.Pow(2, 3);
            
            // Retorna a raiz quadrada.
            double sqrt = Math.Sqrt(16);
            
            // Recebe dois valores, retorna o maior.
            int max = Math.Max(8, 3);
            // Recebe dois valores, retorna o menor.
            int min = Math.Min(10, 26);
            // Retorna o valor arredondado seguindo a regra de arredondamento.
            double round = Math.Round(37.47);
            // Retorna o valor arredondado para baixo.
            double floor = Math.Floor(37.47);
            // Retorna o valor arredondado para cima.
            double ceiling = Math.Ceiling(37.47);
            // Resultados
            Console.WriteLine($"Potência: {pow}");
            Console.WriteLine($"Raiz quadrada: {sqrt}");
            Console.WriteLine($"Maior valor: {max}");
            Console.WriteLine($"Monor valor: {min}");
            Console.WriteLine($"Valor arredondado seguindo a regra de arredondamento: {round}");
            Console.WriteLine($"Valor arredondado para baixo: {floor}");
            Console.WriteLine($"Valor arredondado para cima: {ceiling}");
            
        }
    }
}
