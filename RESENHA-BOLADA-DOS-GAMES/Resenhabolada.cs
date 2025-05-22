using System;

class Jogo
{
    public string Nome { get; set; }
    public string Genero { get; set; }
    public string Plataforma { get; set; }
    public string AnoLancamento { get; set; }
    public bool EBOM { get; private set; }
    public bool ERUIM { get; private set; }
    public bool EMAHOMENO { get; private set; }

    // Construtor dentro da classe
    public Jogo(string nome, string genero, string plataforma, string anoLancamento)
    {
        Nome = nome;
        Genero = genero;
        Plataforma = plataforma;
        AnoLancamento = anoLancamento;
    }

    public void Avaliar(bool EBOM = true, bool ERUIM = false)
    {
        this.EBOM = EBOM;
        this.ERUIM = ERUIM;
        this.EMAHOMENO = EBOM && ERUIM; // Se for bom e ruim ao mesmo tempo, será "mais ou menos"
    }

    public void ExibirAvaliação()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Gênero: {Genero}");
        Console.WriteLine($"Plataforma: {Plataforma}");
        Console.WriteLine($"Ano de Lançamento: {AnoLancamento}");
        Console.WriteLine($"Avaliação: {(EBOM ? "Bom" : ERUIM ? "Ruim" : EMAHOMENO ? "É MAIS OU MENOS..." : "Sem avaliação")}");
    }

    class Program

    {
        static void Main(string[] args)
        {
            Jogo jogo = new Jogo("The Last of Us", "Ação/Aventura", "PlayStation 4", "2013");
            jogo.Avaliar(EBOM: true);
            jogo.ExibirAvaliação();

            // Chama o método para obter a opinião do usuário
            jogo.ObterOpininao();
        }
    }
    public void ObterOpininao()
    {
        Console.WriteLine("Qual a sua opinião sobre o game?");
        string opiniao = Console.ReadLine();

        Console.WriteLine("Que nota vc daria pro jogo de 0 a 10?");
        string suanota = Console.ReadLine();

        Console.WriteLine($"Você disse: {opiniao} e deu a nota: {suanota}");//$ usado para interpolar
        //variaveis dentro de strings//
    }

}