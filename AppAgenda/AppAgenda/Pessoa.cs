using System;

namespace AppAgenda
{
    class Pessoa
    {
        private string Nome { get; set; }
        private DateTime Nascimento { get; set; }
        private float Altura { get; set; }

        public Pessoa()
        {

        }

        public Pessoa(string nome, DateTime nascimento, float altura)
        {
            this.Nome = nome;
            this.Nascimento = nascimento;
            this.Altura = altura;
        }

        public void CalculaIdade()
        {
            int idade = DateTime.Now.Year - Nascimento.Year;
            Console.WriteLine("Idade: {0} anos ",idade);
        }

        public override string ToString()
        {
            return "Nome: " + Nome + " - Data de nascimento: " + Nascimento.ToShortDateString()+" - Altura: "+Altura.ToString("F2");
        }


    }
}
