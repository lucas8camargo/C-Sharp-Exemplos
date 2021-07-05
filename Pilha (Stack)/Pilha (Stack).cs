// Stack<T>(); - Representa uma coleção UEPS (último a entrar, primeiro a sair) de tamanho variável das instâncias do mesmo tipo especificado.

           //  ------------------------------------------ //
            Stack<string> Pilha = new Stack<string>();
            using System.Collections.Generic 
            //  ------------------------------------------ //

            // Pilha.Push(Recebe()); => O valor retornado na função é adicionado a pilha 
            static string Recebe() 
                { 
                    Console.WriteLine("Digite um nome"); 
                    string nome = Console.ReadLine(); 
                    return nome; 
                } 
            //  ------------------------------------------ //

            // Mostrar(Pilha); => Função para mostrar a pilha. 
            
            static void Mostrar(Stack<string> nomes) 
                { 
                    Console.WriteLine("\nElementos da pilha"); 
            
                    foreach (string item in pilha) 
                    { 
                        Console.WriteLine(item); 
                    } 
                } 
            //  ------------------------------------------ //

            // Remove(Pilha); => Função para remover o item da pilha. 
            
            static void Remove(Stack<string> pilha) 
                { 
                    Console.WriteLine(pilha.Pop()); 
                } 
            //  ------------------------------------------ //

            // Principais métodos de uma Pilha: 
            Pilha.Count => Retorna o número de elementos da pilha. 
            Pilha.Clear() => Limpa toda a pilha. 
            Pilha.Peek() => Retorna o objeto na parte superior da pilha sem removê-lo. 
            Pilha.Pop() => Remove e retorna o objeto na parte superior da pilha. 
            Pilha.Push() => Insere um objeto na parte superior da pilha. 
            Pilha.Contains('X') => Verifica se o item "X" existe na pilha.
