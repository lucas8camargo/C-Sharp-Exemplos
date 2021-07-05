using System;
using System.Linq;
namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // ARRAYS
            // Arrays são conjuntos de elementos, são como variáveis que podem armazenar vários valores distintos.
            // Cada elemento possui uma posição no array chamado de ‘index’
            // Assim é possível acessar e manipular um elemento específico identificando o index do elemento.
            // Exemplo: 'nomes[0]' - Primeito elemento do array.

            // Declarando um array vazio sem definir a quantidade.
            int[] numeros0; // Esse array não pode receber valores sem ser inicializado.

            // Declarando um array com elementos
            int[] numeros1 = {2,5,3,6,2,4}; // Esse array por conter elementos e espaços definidos pode receber valores.

            // Declarando e inicializando um array vazio.
            int[] numeros2 = new int[5]; // É obrigatório informar o tamanho do array.

            // Declarando e inicializando um array com elementos.
            int[] numeros3 = new int[] {2,4,2,6,3};
            int[] numeros4 = new int[5] {2,4,2,6,3};

            // Criando um array que recebe uma cópia de outro array.
            int[] copia = numeros1;

            // Atribuindo valores ao array.
            numeros1[0] = 2; // O elemento na posição '0' será trocado pelo valor '2'.

            // Método para retornas a quantidade de elementos de um array.
            Console.WriteLine(numeros1.Length);
            int quantidade = numeros1.Length;

            // Usando o foreach para navegar entre os valores.
            foreach (int item in numeros1)
            {
                Console.WriteLine(item);
            }

            // Também é possível usar outras estruturas de repetição como o For.
            for (int i = 0; i < numeros1.Length; i++)
            {
                Console.WriteLine(numeros1[i]);
            }

            // Coloca o array em ordem crescente.
            Array.Sort(numeros1);
                        
            // Usando estrutura de repetição para adicionar valores ao array.
            for (int c = 0; c < 5; c++)
            {
                Console.WriteLine("Digite um valor: ");
                numeros2[c] = Convert.ToInt32(Console.ReadLine());
            }

            // Colocando o array em Ordem Crescente sem usar o método 'Array.Sort()'.
            // Desta maneira um teste é realizado para comparar o tamanho dos elementos de
            // duas posições diferentes e então troca-los se necessário.
            int aux;
            for (int i = 0 ; i < 5 ; i++)
            {
                    for (int j = i  + 1 ; j < 5 ;  j++ )
                {
                    if ( numeros2[i] > numeros2[j])
                    {
                        aux = numeros2[i];
                        numeros2[i] =  numeros2[j];
                        numeros2[j] = aux;
                    }
                }   
            }

            // Usando a biblioteca 'System.Linq' para ter os seguintes métodos:
            int[] numeros = {4, 6, 2, 8, 9, 3, 1};

            numeros.Max(); // Retorna o maior elemento.
            numeros.Min(); // Retorna o menor elemento.
            numeros.Sum(); // Retorna a soma dos elementos.
                        
            Console.WriteLine($"{numeros.Max()}\n{numeros.Min()}\n{numeros.Sum()}");
            
            // Output:
            /*
            9
            1
            33
            */
        }
    }
}
