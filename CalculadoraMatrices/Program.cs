using System;

namespace CalculadoraMatrices
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola soy Evie, yo multiplico matrices");
            Console.Write("");
            Console.WriteLine("Este es el tiempo en el que realizo las matrices");
            Matrices calculadora = new Matrices();
            int[,] matrizA = calculadora.CrearMatriz(7, 11);
            int[,] matrizB = calculadora.CrearMatriz(11, 10);
            var watch = System.Diagnostics.Stopwatch.StartNew();
            int[,] matrizAxB = calculadora.Multiplicar(matrizA, matrizB);
            watch.Stop();
            var tiempoEnTicks = watch.ElapsedTicks;
            Console.WriteLine($"El tiempo transcurrido en ticks es: {tiempoEnTicks}");
            var tiempoEnMilisegundos = watch.ElapsedMilliseconds;
            Console.WriteLine($"El tiempo transcurrido en milisegundos es: {tiempoEnMilisegundos}");

            for (int i = 0; i < matrizAxB.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < matrizAxB.GetLength(1); j++)
                {
                    Console.Write($"{matrizAxB[i, j]}\t");
                }
            }
        }
    }
}
