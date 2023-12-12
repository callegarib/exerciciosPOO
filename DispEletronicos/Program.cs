using DispEletronicos;

class Program
{
    static void Main(string[] args)
    {
        Celular meuCelular = new Celular();
        meuCelular.Ligar();
        Console.WriteLine($"Status do celular: {meuCelular.StatusDispositivo()}");
        meuCelular.Desligar();
        Console.WriteLine($"Status do celular: {meuCelular.StatusDispositivo()}");

        Cafeteira minhaCafeteira = new Cafeteira();
        minhaCafeteira.Ligar();
        Console.WriteLine($"Status da cafeteira: {minhaCafeteira.StatusDispositivo()}");
        minhaCafeteira.Desligar();
        Console.WriteLine($"Status da cafeteira: {minhaCafeteira.StatusDispositivo()}");
    }
}