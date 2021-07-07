using System;

/* Crie uma classe chamada Circulo. Esta classe terá uma propriedade, chamada Raio, como
métodos acessores. Na classe, defina uma constante privada chamada PI e atribua a ela
o valor 3.14. Implemente dois métodos, chamados Area() e Comprimento(). Em sua classe
principal, consuma estes serviços após informar o valor do Raio. */

Class Circulo
{
    private readonly double PI = 3.14;
    private const double PI = 3.14; // Opção com melhor velocidade de execução

    public double Raio { get; set; }

    public double Area()
    {
        return PI * Math.Pow(Raio, 2);
    }

    public double Comprimento()
    {
        return PI * Raio;
    }
}