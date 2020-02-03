using System;

namespace _01_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaCorrente contaDaGabriela = new ContaCorrente();
            
            contaDaGabriela.titular = "Gabriela";
            contaDaGabriela.agencia = 863;
            contaDaGabriela.numero = 863146;
            contaDaGabriela.saldo = 100;

            Console.WriteLine(contaDaGabriela.titular);
            Console.WriteLine("Agencia: " + contaDaGabriela.agencia);
            Console.WriteLine("Número:  " + contaDaGabriela.numero);
            Console.WriteLine("saldo:   " + contaDaGabriela.saldo);

            contaDaGabriela.saldo += 200;
            Console.WriteLine("saldo:   " + contaDaGabriela.saldo);


            Console.ReadLine();
        }
    }
}
