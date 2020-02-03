using System;

namespace _03_ByteBanck
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente ContaDaGabriel = new ContaCorrente();

            ContaDaGabriel.titular = "Gabriela";
            ContaDaGabriel.agencia = 863;
            ContaDaGabriel.numero = 869452;

            ContaCorrente ContaDaGabrielCosta = new ContaCorrente();

            ContaDaGabrielCosta.titular = "Gabriela";
            ContaDaGabrielCosta.agencia = 863;
            ContaDaGabrielCosta.numero = 869452;

            Console.WriteLine(ContaDaGabriel == ContaDaGabrielCosta);

            Console.ReadLine();
        }
    }
}
