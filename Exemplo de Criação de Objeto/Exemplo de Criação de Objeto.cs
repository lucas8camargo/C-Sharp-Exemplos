// Um objeto é criado a partir de uma classe. 
 
class Pessoa 
{ 
   // Os atributos ficam privados para outras classes. 
    private string nome; 
    private string cor_do_olho;
    private int idade; 
    private string cor_do_cabelo; 
    private double altura; 
    private string genero; 
 
   // Os atributos são encapsulados para poderem ser usados em outras classes. 
    public string Nome {get=>nome;set=>nome=value; } 
    public string Cor_do_olho {get=>cor_do_olho;set=>cor_do_olho=value; } 
    public int Idade {get=>idade;set=>idade=value; } 
    public string Cor_do_cabelo {get=>cor_do_cabelo;set=>cor_do_cabelo=value; } 
    public double Altura {get=>altura;set=>altura=value; } 
    public string Genero {get=>genero;set=>genero=value; } 
 
    // Metodo para exibir todos os atributos dos objetos 
    public void exibe() 
    { 
        // exibe os valores 
        Console.WriteLine("\n---------------------------------"); 
        Console.WriteLine("Nome:"+Nome); 
        Console.WriteLine("Idade: "+Idade); 
        Console.WriteLine("Cor dos olhos: "+Cor_do_olho); 
        Console.WriteLine("Cor dos cabelos: "+Cor_do_cabelo); 
        Console.WriteLine("Altura: "+Altura); 
    } 
} 
 
 
// Na classe 'Program' que é a principal, o objeto pode ser criado e usado. 
 
class Program 
{ 
    staticvoidMain(string[]args) 
    { 
        // Instanciação do objeto da classe Pessoa 
        Pessoa fulano = new Pessoa(); 
        
        // Obtendo valores 
        Console.WriteLine("Digite o nome do objeto"); 
        fulano.Nome = Console.ReadLine(); 
        
        Console.WriteLine("Digite a idade do objeto"); 
        fulano.Idade=int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a altura do objeto"); 
        fulano.Altura=double.Parse(Console.ReadLine()); 

        Console.WriteLine("Digite a cor do cabelo do objeto"); 
        fulano.Cor_do_cabelo=Console.ReadLine(); 
        
        Console.WriteLine("Digite a cor do olho do objeto"); 
        fulano.Cor_do_olho=Console.ReadLine(); 

        fulano.exibe(); 
    } 
 
}