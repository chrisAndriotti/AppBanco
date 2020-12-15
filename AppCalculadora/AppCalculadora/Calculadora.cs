namespace AppCalculadora
{
    class Calculadora
    {
        private double Numero1 { get; set; }
        private double Numero2 { get; set; }


        public Calculadora()
        {

        }

        public Calculadora(double numero1, double numero2)
        {
            this.Numero1 = numero1;
            this.Numero2 = numero2;
        }

        public double DefinirOperacao(char op)
        {
            double resultado = 0.0;

            switch (op)
            {
                case '+':
                    resultado = Soma(Numero1, Numero2);
                    break;
                case '-':
                    resultado = Subtrai(Numero1, Numero2);
                    break;
                case '*':
                    resultado = Multiplica(Numero1, Numero2);
                    break;
                case '/':
                    resultado = Divide(Numero1, Numero2);
                    break;

            }
            return resultado;
        }



        public double Soma(double numero1, double numero2)
        {
            return numero1 + numero2;
        }

        public double Subtrai(double numero1, double numero2)
        {
            return numero1 - numero2;
        }

        public double Multiplica(double numero1, double numero2)
        {
            return numero1 * numero2;
        }

        public double Divide(double numero1, double numero2)
        {
            return numero1 / numero2;
        }

        public override string ToString() {
            return "Resultado do calculo"+Numero1+ " "+Numero2+" = ";
        }   
    }

}
