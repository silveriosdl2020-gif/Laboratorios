using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L9_SDL1332526
{
    internal class Program
    {
        static int aprobados = 0;
        static int reprobados = 0;
        static double sumaNotas = 0;
        static void Main()
        {
            int seleccion = -1;
            while (seleccion != 0)
            {
                Console.Clear();
                Console.WriteLine("1. Ejercicio 1. Saludo modularizado");
                Console.WriteLine("2. Ejercicio 2. Calculadora con procedimientos");
                Console.WriteLine("3. Ejercicio 3. Menú de figuras");
                Console.WriteLine("4. Ejercicio 4. Registro de notas");
                Console.WriteLine("5. Ejercicio 5. Intercambio de valores (ref)");
                Console.WriteLine("0. Salir");
                Console.Write("Seleccione una opción: ");
                seleccion = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (seleccion)
                {
                    case 1:
                        Ejercicio1_Saludo();
                        break;
                    case 2:
                        Ejercicio2_Areas();
                        break;
                    case 3:
                        Ejercicio3_Dibujos();
                        break;
                    case 4:
                        Ejercicio4_Notas();
                        break;
                    case 5:
                        Ejercicio5_Intercambio();
                        break;
                    case 0:
                        Console.WriteLine("Saliendo del programa");
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
                if (seleccion != 0)
                {
                    Console.WriteLine("Presiona cualquier tecla para volver al menú");
                    Console.ReadKey();
                }
            }
        }
        static void Ejercicio1_Saludo()
        {
            Console.Write("Ingrese su nombre: ");
            string nombreUsuario = Console.ReadLine();
            MostrarSaludo(nombreUsuario);
            MostrarInformacionCurso();
        }
        static void MostrarSaludo(string nombre)
        {
            Console.WriteLine("Hola, " + nombre + ". Es un gusto saludarte.");
        }
        static void MostrarInformacionCurso()
        {
            Console.WriteLine("Curso: Pensamiento Computacional");
            Console.WriteLine("Laboratorio: No. 1");
        }
        static void Ejercicio2_Areas()
        {
            Console.Write("Ingrese el lado del cuadrado: ");
            double lado = double.Parse(Console.ReadLine());
            AreaCuadrado(lado);
            Console.Write("Ingrese la base del rectángulo: ");
            double baseR = double.Parse(Console.ReadLine());
            Console.Write("Ingrese la altura del rectángulo: ");
            double alturaR = double.Parse(Console.ReadLine());
            AreaRectangulo(baseR, alturaR);
            Console.Write("Ingrese la base del triángulo: ");
            double baseT = double.Parse(Console.ReadLine());
            Console.Write("Ingrese la altura del triángulo: ");
            double alturaT = double.Parse(Console.ReadLine());
            AreaTriangulo(baseT, alturaT);
        }
        static void AreaCuadrado(double l)
        {
            double resultado = l * l;
            Console.WriteLine("El área del cuadrado es: " + resultado);
        }
        static void AreaRectangulo(double b, double h)
        {
            double resultado = b * h;
            Console.WriteLine("El área del rectángulo es: " + resultado);
        }
        static void AreaTriangulo(double b, double h)
        {
            double resultado = (b * h) / 2;
            Console.WriteLine("El área del triángulo es: " + resultado);
        }
        static void Ejercicio3_Dibujos()
        {
            Console.WriteLine("1. Cuadrado, 2. Triángulo, 3. Línea");
            Console.Write("Seleccione qué desea dibujar: ");
            int opcion = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el tamaño (N): ");
            int n = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    DibujarCuadrado(n);
                    break;
                case 2:
                    DibujarTriangulo(n);
                    break;
                case 3:
                    DibujarLinea(n);
                    break;
            }
        }
        static void DibujarCuadrado(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        static void DibujarTriangulo(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        static void DibujarLinea(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        static void Ejercicio4_Notas()
        {
            aprobados = 0;
            reprobados = 0;
            sumaNotas = 0;
            for (int i = 1; i <= 5; i++)
            {
                Console.Write("Ingrese la nota del estudiante " + i + ": ");
                double nota = double.Parse(Console.ReadLine());

                EvaluarNota(nota);
                sumaNotas = sumaNotas + nota;
            }
            MostrarResumen();
        }
        static void EvaluarNota(double nota)
        {
            if (nota >= 61)
            {
                Console.WriteLine("Resultado: APROBADO");
                aprobados = aprobados + 1;
            }
            else
            {
                Console.WriteLine("Resultado: REPROBADO");
                reprobados = reprobados + 1;
            }
        }
        static void MostrarResumen()
        {
            double promedio = sumaNotas / 5;
            Console.WriteLine("Aprobados: " + aprobados);
            Console.WriteLine("Reprobados: " + reprobados);
            Console.WriteLine("Promedio: " + promedio);
        }
        static void Ejercicio5_Intercambio()
        {
            Console.Write("Ingrese el valor de A: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el valor de B: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Originalmente: A = " + a + ", B = " + b);
            IntercambiarValores(ref a, ref b);
            Console.WriteLine("Intercambiados: A = " + a + ", B = " + b);
        }
        static void IntercambiarValores(ref int num1, ref int num2)
        {
            int auxiliar = num1;
            num1 = num2;
            num2 = auxiliar;
        }
    }
}
