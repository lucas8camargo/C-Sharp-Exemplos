using System;
namespace switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            char letter;
 
            Console.WriteLine("Digite uma letra: "); 
            letter = Convert.ToChar(Console.ReadLine());  
            switch (letter) 
            { 
                case 'a': 
                case 'e': 
                case 'i': 
                case 'o': 
                case 'u': 
                    Console.WriteLine("Vogal"); 
                break; 
                default: 
                    Console.WriteLine("Não é vogal"); 
                break; 
            }
        }
    }
}