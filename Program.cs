using System;

namespace AppBanco
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta = new Conta();
            conta.CriaConta();
            conta.Menu();
        }
    }
}
