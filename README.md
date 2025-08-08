// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

class Pessoa
{
    //atributos
    public string Nome = "";
    public int idade = 0;

    //métodos
    public void apresentar()
    {
        Console.WriteLine($"Olá, meu nome é {Nome} e tenho {idade} anos.");
    }

}

class Program
{
    static void Main(string[] args)
    {
        //instanciando um objeto da classe Pessoa
        Pessoa pessoa1 = new Pessoa();
        pessoa1.Nome = "João";
        pessoa1.idade = 30;

        //chamando o método apresentar
        pessoa1.apresentar();

        //instanciando outro objeto da classe Pessoa
        Pessoa pessoa2 = new Pessoa();
        pessoa2.Nome = "Maria";
        pessoa2.idade = 25;

        //chamando o método apresentar
        pessoa2.apresentar();
    }
}   

