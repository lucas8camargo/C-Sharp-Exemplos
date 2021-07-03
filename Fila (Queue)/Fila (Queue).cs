Queue<T>(); - Representa uma coleção 'primeiro a entrar, primeiro a sair' de objetos.

// ----------------------------------- //
Queue<int> Fila = new Queue<int>(); 
using System.Collections.Generic; 

// ----------------------------------- //

// Fila.Enqueue(recebe_elementos()); => O valor retornado na função é adicionado a fila
 
 static int recebe_elementos() 
    { 
        Console.WriteLine("Digite um elemento"); 
        int num = int.Parse(Console.ReadLine()); 
        return num; 
} 
// ----------------------------------- //

// mostra_fila(fila); => Função para mostrar a fila, (Uma fila genérica é criada na função). 
 
static void mostra_fila(Queue<int> fila) 
    { 
        foreach (int x in fila) 
          { 
             Console.WriteLine(x); 
          } 
    } 
// ----------------------------------- //

// remove_elementos(fila); => Função para mostrar a fila com verificação de fila vazia. 
 
static void remove_elementos(Queue<int> fila) 
     { 
         if (fila.Count != 0) 
         { 
                fila.Dequeue(); 
         } 
         else 
         { 
                Console.WriteLine("Fila Vazia"); 
         } 
      } 
// ----------------------------------- //

// Principais métodos de uma Fila: 

Fila.Clear() => Remove todos os objetos da fila. 
Fila.Count => Retorna o número de elementos da fila. 
Fila.Peek() => Retorna o objeto ao início da fila sem removê-lo. 
Fila.Dequeue() => Remove e retorna o objeto no início da fila. 
Fila.Enqueue() => Adiciona um objeto ao final da fila. 
Fila.Contains('X') => Verifica se o item 'X' existe na fila.