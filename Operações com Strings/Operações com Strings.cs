using System;

namespace operacoes_com_strings
{
    class Program
    {
        static void Main(string[] args)
        {
            // Usando '\n' para quebrar a linha:
            Console.WriteLine("Quebra de\nlinha"); 

            // Usando '\' para usar aspas em uma string:
            Console.WriteLine("Aspas em \"strings\"!");

            // Concatenação: 
            string s = "Concatenação" + " de string"; 

            // Retorna a quantidade de caracteres de uma string: 
            int len = s.Length; 
            
            // Retorna a string toda em maiúscula: 
            string upp = s.ToUpper(); 

            // Retorna a string toda em minuscula: 
            string low = s.ToLower(); 
            
            // Retorna True ou False se a string contem os caracteres informados:
            bool con = s.Contains("string"); 
            
            // Retorna o caracter do index informado entre colchetes: 
            char index = s[0]; 
            
            // Retorna o index de início da string entre parênteses: 
            int inicio = s.IndexOf("string"); 
            
            // Retorna o index do primeiro caractere entre aspas simples: 
            int indx = s.IndexOf('s'); // Caso o caracter não exista na string o resultado obtido será: '-1' 
            
            // Retorna a string até o final começando a partir do caracter do index informado:
            string subs = s.Substring(8); 
            
            // Retorna a string do index dado até o index informado: 
            string sub = s.Substring(8, 10);

            // Converte um valor numérico em uma string:
            int n = 10;
            Convert.ToString(n);

            // O 'Cancat' concatena diferentes strings em uma única:
            string firstName = "Lucas ";
            string lastName = "Camargo";
            string nome = string.Concat(firstName, lastName); // A variável 'name' recebe a string concatenada
            
            // USANDO O MÉTODO 'Split()':
            // Esse método transforma as palavra de uma string em elementos distintos.
            // Aqui uma string é atribuída a variável 'ts'.

            string ts = "teste de string";
            // Aqui um array de tipo 'string' é criado para receber as palavras da variável 'ts' usando o método 'Split()'
            // Criando um array de três elementos: ('teste', 'de' e 'string').
            string[] s2 = ts.Split();

            // Aqui o método 'Split()' é usado para que cada elemento (palavras) da string seja transformado em elementos distintos
            // Deixando de ser uma conjunto único de caracteres e já sendo atribuída em um array.
            string[] s3 = "teste de string".Split();

            // É possível acessar os elementos de uma string mesmo sem transforma-la em um array usando o método 'Split()'
            // Colocando um '[]' com a posição do elemento após o método 'Split()'.
            Console.WriteLine(ts.Split()[0]);
            
            // Output:
            //teste
            // ------------ //
            // INTERPOLAÇÃO DE STRINGS
            // O uso do '$' permite que o valor de uma váriavel seja reconhecido mesmo dentro de uma string:
            string name = $"My full name is: {firstName} {lastName}";
            Console.WriteLine(name);
            Console.WriteLine($"My full name is: {firstName} {lastName}");
        }
    }
}
