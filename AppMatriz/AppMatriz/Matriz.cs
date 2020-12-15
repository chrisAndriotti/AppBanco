using System;

namespace AppMatriz
{
    public class ObjMatriz
    {
        private int[,] Matriz { get; set; }

        public ObjMatriz() { }

        public ObjMatriz(int[,] matriz)
        {
            Matriz = matriz;
        }

        public void CriarMatriz()
        {
            try
            {
                Console.WriteLine("Para calcular a diagonal principal da matriz entre com os seguintes dados");
                int tamanho = Matriz.Length / 3;
                //for para percorrer as linhas da matriz
                for (int i = 0; i < tamanho; i++)
                {
                    //for que percorre as colunas da matriz
                    for (int j = 0; j < tamanho; j++)
                    {
                        Console.Write("Linha: " + i + ", Coluna: " + j + ": ");
                        int valor = int.Parse(Console.ReadLine());

                        Matriz[i, j] = valor;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Ocorreu um erro ao ler um número interio: " + e.Message);
            }

        }

        public int DiagonalPrincipal()
        {
            int aux = 0;

            //for para percorrer as linhas da matriz
            for (int i = 0; i < 3; i++)
            {
                //for que percorre as colunas da matriz
                for (int j = 0; j < 3; j++)
                {
                    if (i == j)
                    {
                        int soma = Matriz[i, j];
                        aux += soma;
                    }
                }    
            }
            return aux;
        }
        
    }



}
