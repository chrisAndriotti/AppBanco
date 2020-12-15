using System;

namespace AppBanco
{
    class Conta
    {
        private int Numero { get; set; }
        private string Titular { get; set; }
        private double Saldo { get; set; }
        private double LimiteSaque { get; set; }

        public Conta() { }
        public Conta(int numero, string titular, double saldo, double limiteSaque)
        {
            this.Numero = numero;
            this.Titular = titular;
            this.Saldo = saldo;
            this.LimiteSaque = limiteSaque;
        }
        public void CriaConta()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("                   ADMIN                    ");
            Console.WriteLine("--------------------------------------------");
            Console.ResetColor();

            Console.Write("Entre com os dados solicitados:\nNúmero da conta:\n>>>  ");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Nome do titular:\n>>>  ");
            string titular = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Limite de saque:\n>>>  R$");
            double limiteSaque = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Cliente deseja fazer um depósito?\n[1] - SIM\n[2] - NÃO\n>>> ");
            int opcao = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (opcao)
            {
                case 1:
                    Console.Write("Informe o valor do depósito:\n>>>  ");
                    double deposito = double.Parse(Console.ReadLine());
                    Deposito(deposito);
                    break;
                case 2:
                    DadosAtualizados();
                    break;
            }

            Numero = numero;
            Titular = titular;
            LimiteSaque = limiteSaque;
        }
        public void Menu()
        {
            bool v = true;

            while (v == true)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("--------------------------------------------" +
                "\n                   CLIENTE                    " +
                "\n--------------------------------------------");
                Console.ResetColor();
                Console.Write("Entre com a opção desejada: " +
                    "\n[1] - Sacar" +
                    "\n[2] - Depositar" +
                    "\n[3] - Consultar dados da conta" +
                    "\n[4] - Sair" +
                    "\n>>>  ");
                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:

                        Console.Write("Bem Vinda(o), {0}! \nInforme o valor que deseja sacar:\n>>>  R$", Titular);
                        double saque = double.Parse(Console.ReadLine());
                        //Chamada do método Saque

                        if (saque > LimiteSaque || Saldo == 0 || saque > Saldo)
                            Console.WriteLine("Valor de saque não permitido, consulte seu saldo e limite para saques.");

                        else
                        {
                            Saque(saque);
                        }
                        Console.WriteLine();
                        DadosAtualizados();
                        break;
                    case 2:

                        Console.Write("Bem Vinda(o), {0}! \nInforme o valor que deseja depositar:\n>>>  R$", Titular);
                        double deposito = double.Parse(Console.ReadLine());
                        Console.WriteLine();
                        //Chamada do método Depósito
                        Deposito(deposito);
                        Console.WriteLine();
                        DadosAtualizados();

                        break;

                    case 3:
                        Console.WriteLine(ToString());
                        break;
                    case 4:
                        Console.WriteLine("Serviço concluído!");
                        v = false;
                        break;
                }
            }

        }

        public void Saque(double valorSaque)
        {
            Saldo -= valorSaque;
        }
        public void Deposito(double valorDeposito)
        {
            Saldo += valorDeposito;
        }

        public void DadosAtualizados()
        {
            Console.WriteLine("---------------Dados Atualizados------------");
            Console.WriteLine(ToString());
            Console.WriteLine("--------------------------------------------");
        }
        public override string ToString()
        {
            return "Conta: " + Numero + ", Titular: " + Titular + ", Saldo: $ " + Saldo.ToString("F2");
        }


    }
}
