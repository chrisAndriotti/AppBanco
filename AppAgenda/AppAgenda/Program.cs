using System;
using System.Globalization;

namespace AppAgenda
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira os dados da pessoa: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Data de nascimento: ");
            DateTime nascimento = DateTime.Parse(Console.ReadLine());

            Console.Write("Altura: ");
            float altura = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Instanciando a classe Pessoa
            Pessoa pessoa = new Pessoa(nome, nascimento, altura);

            Console.WriteLine(pessoa.ToString()); 
            Console.WriteLine();
            pessoa.CalculaIdade();

            //Instanciando a classe Agenda
            Agenda agenda = new Agenda();






        }
    }
}
