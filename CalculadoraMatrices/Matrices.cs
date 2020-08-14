﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraMatrices
{
    class Matrices
    {
        public int[,] Multiplicar(int[,] matrizA, int[,] matrizB)
        {
            int filas = matrizA.GetLength(0);
            int columnas = matrizB.GetLength(1);
            int columnasA = matrizA.GetLength(1);

            int[,] matrizAxB = new int[filas, columnas];

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    int acumulador = 0;
                    for (int k = 0; k < columnasA; k++)
                    {
                        acumulador += matrizA[i, k] * matrizB[k, j];
                    }
                    matrizAxB[i, j] = acumulador;
                }
            }
            return matrizAxB;
        }

        public int[,] CrearMatriz(int fila, int columna)
        {
            var generador = new Random();

            int[,] matriz = new int[fila, columna];
            for (int i = 0; i < fila; i++)
            {
                for (int j = 0; j < columna; j++)
                {
                    matriz[i, j] = generador.Next(10, 99);
                }
            }
            return matriz;
        }
    }
}

