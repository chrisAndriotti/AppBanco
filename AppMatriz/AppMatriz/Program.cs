using System;

namespace AppMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.BackgroundColor = ConsoleColor.Blue;

            int[,] m = new int[3, 3];

            ObjMatriz objMatriz = new ObjMatriz(m);

            objMatriz.CriarMatriz();
            objMatriz.DiagonalPrincipal();
            int resultado = objMatriz.DiagonalPrincipal();
            Console.WriteLine("Resultado: "+resultado);
 
        }
    }
}
