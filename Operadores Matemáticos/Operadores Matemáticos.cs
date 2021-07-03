using System;
namespace operadores_matematicos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Atribuição
            int ex1 = 6;

            //Soma
            int ex2 = 5 + 5;
            
            // Subtração    
            int ex3 = 5 - 5;
            
            // Multiplicação
            int ex4 = 5 * 5;

            // Divisão
            int ex5 = 5 / 5;

            // Incremento do valor existente com um novo valor recebido
            int ex6 = 10;
            ex6 += 1;

            // Decremento do valor existente com um novo valor recebido
            int ex7 = 10;
            ex7 -= 1;

            //  Regra de prioridade é considerada, a divisão ocorrerá antes da soma
            int ex8 = 5 + 5 / 10;

            // Uso de parêntesis para controlar a prioridade do cálculo
            int ex9 = (5 + 5) / 10;

            // Incremento continuo. Sempre que executado, o valor existente receberá +1
            int ex10 = 10;
            ex10++; // 10 + 1
            ex10++; // 11 + 1

            // Decremento continuo. Sempre que executado, o valor existente receberá -1
            int ex11 = 10;
            ex11--; // 10 - 1
            ex11--; // 9 - 1

            // Concatenação de strings
            string ex12 = "Hello" + " World";
            
            // Resultados
            Console.WriteLine($"Exemplo 1: {ex1}");
            Console.WriteLine($"Exemplo 2: {ex2}");
            Console.WriteLine($"Exemplo 3: {ex3}");
            Console.WriteLine($"Exemplo 4: {ex4}");
            Console.WriteLine($"Exemplo 5: {ex5}");
            Console.WriteLine($"Exemplo 6: {ex6}");
            Console.WriteLine($"Exemplo 7: {ex7}");
            Console.WriteLine($"Exemplo 8: {ex8}");
            Console.WriteLine($"Exemplo 9: {ex9}");
            Console.WriteLine($"Exemplo 10: {ex10}");
            Console.WriteLine($"Exemplo 11: {ex11}");
            Console.WriteLine($"Exemplo 12: {ex12}");
        }
    }
}
