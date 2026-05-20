using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L12_SDL1332526
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;

            while (opcion != 5)
            {
                Console.WriteLine("1. Ejercicio 1: Suma de fila y columna (4x4)");
                Console.WriteLine("2. Ejercicio 2: Buscar el número mayor (3x5 float)");
                Console.WriteLine("3. Ejercicio 3: Multiplicación de matrices (3x2)");
                Console.WriteLine("4. Ejercicio 4: Diagonales principal y secundaria (5x5)");
                Console.WriteLine("5. Salir");
                Console.Write("Seleccione una opción: ");
                opcion = int.Parse(Console.ReadLine());

                if (opcion == 1)
                {
                    EjecutarEjercicio1();
                }
                if (opcion == 2)
                {
                    EjecutarEjercicio2();
                }
                if (opcion == 3)
                {
                    EjecutarEjercicio3();
                }
                if (opcion == 4)
                {
                    EjecutarEjercicio4();
                }
            }
        }
        static void EjecutarEjercicio1()
        {
            int[,] matriz = new int[4, 4];
            LlenarMatriz1(matriz);
            Console.Write("Ingrese fila a sumar (0-3): ");
            int f = int.Parse(Console.ReadLine());
            Console.WriteLine("Suma fila: " + SumaFila(matriz, f));
            Console.Write("Ingrese columna a sumar (0-3): ");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("Suma columna: " + SumaColumna(matriz, c));
        }
        static void LlenarMatriz1(int[,] m)
        {
            for (int i = 0; i < 4; i = i + 1)
            {
                for (int j = 0; j < 4; j = j + 1)
                {
                    Console.Write("Matriz [ " + i + "," + j + "]: ");
                    m[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
        static int SumaFila(int[,] m, int fila)
        {
            int suma = 0;
            for (int j = 0; j < 4; j = j + 1)
            {
                suma = suma + m[fila, j];
            }
            return suma;
        }
        static int SumaColumna(int[,] m, int col)
        {
            int suma = 0;
            for (int i = 0; i < 4; i = i + 1)
            {
                suma = suma + m[i, col];
            }
            return suma;
        }
        static void EjecutarEjercicio2()
        {
            float[,] matrizF = new float[3, 5];
            CargarMatriz2(matrizF);
            Console.WriteLine("El mayor es: " + MayorMatriz(matrizF));
        }
        static void CargarMatriz2(float[,] m)
        {
            for (int i = 0; i < 3; i = i + 1)
            {
                for (int j = 0; j < 5; j = j + 1)
                {
                    Console.Write("Valor [" + i + "," + j + "]: ");
                    m[i, j] = float.Parse(Console.ReadLine());
                }
            }
        }
        static float MayorMatriz(float[,] m)
        {
            float mayor = m[0, 0];
            for (int i = 0; i < 3; i = i + 1)
            {
                for (int j = 0; j < 5; j = j + 1)
                {
                    if (m[i, j] > mayor)
                    {
                        mayor = m[i, j];
                    }
                }
            }
            return mayor;
        }
        static void EjecutarEjercicio3()
        {
            int[,] A = new int[3, 2];
            int[,] B = new int[3, 2];
            int[,] R = new int[3, 2];
            Console.WriteLine("Llenar A:");
            LlenarMatriz3(A, "A");
            Console.WriteLine("Llenar B:");
            LlenarMatriz3(B, "B");
            Multiplicar(A, B, R);
            Console.WriteLine("Resultado:");
            for (int i = 0; i < 3; i = i + 1)
            {
                for (int j = 0; j < 2; j = j + 1)
                {
                    Console.Write(R[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        static void LlenarMatriz3(int[,] m, string n)
        {
            for (int i = 0; i < 3; i = i + 1)
            {
                for (int j = 0; j < 2; j = j + 1)
                {
                    Console.Write("Matriz " + n + "[" + i + "," + j + "]: ");
                    m[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
        static void Multiplicar(int[,] A, int[,] B, int[,] R)
        {
            for (int i = 0; i < 3; i = i + 1)
            {
                for (int j = 0; j < 2; j = j + 1)
                {
                    R[i, j] = A[i, j] * B[i, j];
                }
            }
        }
        static void EjecutarEjercicio4()
        {
            int[,] matrizC = new int[5, 5];
            Llenar4(matrizC);
            Console.WriteLine("Suma Diagonal Principal: " + SumaDiagonalPrincipal(matrizC));
            Console.WriteLine("Suma Diagonal Secundaria: " + SumaDiagonalSecundaria(matrizC));
        }
        static void Llenar4(int[,] m)
        {
            for (int i = 0; i < 5; i = i + 1)
            {
                for (int j = 0; j < 5; j = j + 1)
                {
                    Console.Write("Valor [" + i + "," + j + "]: ");
                    m[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
        static int SumaDiagonalPrincipal(int[,] m)
        {
            int suma = 0;
            for (int i = 0; i < 5; i = i + 1)
            {
                suma = suma + m[i, i];
            }
            return suma;
        }
        static int SumaDiagonalSecundaria(int[,] m)
        {
            int suma = 0;
            int c = 4;
            for (int i = 0; i < 5; i = i + 1)
            {
                suma = suma + m[i, c];
                c = c - 1;
            }
            return suma;
        }
    }
}
