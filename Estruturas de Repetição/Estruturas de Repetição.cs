using System;

namespace Estruturas_de_Repetição
{
    class Program
    {
        static void Main(string[] args)
        {
            // While Loop:
            int a = 0;
            while (a < 5) 
            {
                Console.WriteLine(a);
                    a++;
            }

            // ------------------------------------------ //

            // Do - While Loop:
            int b = 0;
            do 
            {
                Console.WriteLine(b);
                    b++;
            }
            while (b < 5);

            // ------------------------------------------ //

            // For Loop:
            for (int c = 0; c < 5; c++) 
            {
                Console.WriteLine(c);
            }

            // ------------------------------------------ //

            // Foreach:
            string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
            foreach (string car in cars) 
            {
                Console.WriteLine(car);
            }

            // BREAK e CONTINUE

            // A instrução 'break' quebra o loop se a condição especificada ocorrer.
            for (int i = 0; i < 10; i++) 
            {
                if (i == 4) 
                {
                    break;
                }
                Console.WriteLine(i);
            }

            // A instrução 'continue' interrompe uma iteração no loop, se a condição especificada ocorrer, continua com a próxima iteração no loop.

            // Este exemplo pula o valor '4':
            for (int i = 0; i < 10; i++) 
            {
                if (i == 4) 
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
    }
}
