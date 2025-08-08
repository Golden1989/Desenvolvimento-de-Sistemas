// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

class Carro
{
    private string marca = "";

    private string modelo = "";

    private int anoDeFabricacao = 0;

    public void Ligar()
    {
        Console.WriteLine($"{marca} {modelo} fabricado em  {anoDeFabricacao} está ligando.");

    }

    public void Setmarca(string marca)
    {
        if (marca != null) { }
        {
            this.marca = marca;
        }

    }
    public void Setmodelo(string modelo)
    {
        this.modelo = modelo;
    }
    public void SetanoDeFabricacao(int anoDeFabricacao)
    {
        if (anoDeFabricacao >= 2010)
        {
            this.anoDeFabricacao = anoDeFabricacao;

        }

    }


}


class Program
{
    static void Main(string[] args)
    {
        Carro carro = new Carro();
        carro.Setmarca("Toyota");
        carro.Setmodelo("Corolla");
        carro.SetanoDeFabricacao(2022);
        carro.Ligar();

        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();


    }
}


