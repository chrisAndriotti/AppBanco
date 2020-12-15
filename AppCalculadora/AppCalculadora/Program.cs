using System;

namespace AppCalculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os valores a serem calculados: ");
            Console.Write("N1: ");
            double n1 = double.Parse(Console.ReadLine());
            Console.Write("N2: ");
            double n2 = double.Parse(Console.ReadLine());

            Calculadora calculadora = new Calculadora(n1, n2);

            Console.WriteLine("Escolha a operação que deseja usar no cálculo: ");
            char op = char.Parse(Console.ReadLine());

            double resultado = calculadora.DefinirOperacao(op);
            Console.WriteLine("Resultado: "+resultado);

            

        }
    }
}
