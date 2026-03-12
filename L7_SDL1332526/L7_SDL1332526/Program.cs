using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L7_SDL1332526
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese su nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Hola, " + nombre + ". ¡Bienvenido/a al Laboratorio 7!");
            Console.WriteLine();
            Console.WriteLine("Presione cualquier tecla para pasar al \"Ejercicio 1\"");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Ejercicio 1");
            Console.WriteLine();
            int n = 0;
            int contador = 1;
            double suma = 0, numeroIngresado, promedio;
            while (n <= 0)
            {
                Console.Write("¿Cuántos números deseas sumar?: ");
                n = int.Parse(Console.ReadLine());
                if (n <= 0)
                {
                    Console.WriteLine("El número debe ser positivo");
                }
            }
            while (contador <= n)
            {
                Console.Write("Ingrese el número " + contador + " de " + n + ": ");
                numeroIngresado = double.Parse(Console.ReadLine());
                suma = suma + numeroIngresado;
                contador++;
            }
            promedio = suma / n;
            Console.WriteLine("Total de la suma: " + suma);
            Console.WriteLine("Promedio: " + promedio);
            Console.WriteLine();
            Console.WriteLine("Presione cualquier tecla para pasar al \"Ejercicio 2\"");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Ejercicio 2");
            Console.WriteLine();
            int opcion;
            double valor, resultado;
            do
            {
                Console.WriteLine("1. Convertir Celsius a Fahrenheit");
                Console.WriteLine("2. Convertir Fahrenheit a Celsius");
                Console.WriteLine("3. Convertir Kilómetros a Millas");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción (1, 2, 3 o 4): ");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese grados Celsius: ");
                        valor = double.Parse(Console.ReadLine());
                        resultado = (valor * 9 / 5) + 32;
                        Console.WriteLine("Resultado: " + resultado.ToString("F2") + " °F");
                        break;
                    case 2:
                        Console.Write("Ingrese grados Fahrenheit: ");
                        valor = double.Parse(Console.ReadLine());
                        resultado = (valor - 32) * 5 / 9;
                        Console.WriteLine("Resultado: " + resultado.ToString("F2") + " °C");
                        break;
                    case 3:
                        Console.Write("Ingrese Kilómetros: ");
                        valor = double.Parse(Console.ReadLine());
                        resultado = valor * 0.621371;
                        Console.WriteLine("Resultado: " + resultado.ToString("F2") + " Millas");
                        break;
                    case 4:
                        Console.WriteLine("Saliendo del programa");
                        break;
                    default:
                        Console.WriteLine("Opción inválida");
                        break;
                }
            } while (opcion != 4);
            Console.WriteLine("Programa finalizado");
            Console.WriteLine();
            Console.WriteLine("Presione cualquier tecla para pasar al \"Ejercicio 3\"");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Ejercicio 3");
            Console.WriteLine();
            Random aleatorio = new Random();
            int numeroAleatorio = aleatorio.Next(1, 101);
            int intentoUsuario = 0;
            int cantidadIntentos = 0;
            Console.WriteLine("Adivina el numero que estoy pensando entre el 1 y 100 ¿Lo podes adivinar?");
            while (intentoUsuario != numeroAleatorio)
            {
                Console.Write("Escribe el numero: ");
                if (int.TryParse(Console.ReadLine(), out intentoUsuario))
                {
                    if (intentoUsuario < 1 || intentoUsuario > 100)
                    {
                        Console.WriteLine("El número debe estar entre 1 y 100. Intenta de nuevo.");
                        continue;
                    }
                    cantidadIntentos++;
                    if (intentoUsuario < numeroAleatorio)
                    {
                        Console.WriteLine("Pista: ¡Más alto!");
                    }
                    else if (intentoUsuario > numeroAleatorio)
                    {
                        Console.WriteLine("Pista: ¡Más bajo!");
                    }
                    else
                    {
                        Console.WriteLine("¡CORRECTO! El número es " + numeroAleatorio);
                        Console.WriteLine("Te tomo " + cantidadIntentos + " intentos");
                    }
                }
                else
                {
                    Console.WriteLine("Ingresa un número válido");
                }
            }
            Console.WriteLine();
            Console.WriteLine("Presione cualquier tecla para pasar al \"Ejercicio 4\"");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Ejercicio 4");
            Console.WriteLine();
            string password = "";
            int intentos = 0;
            while (password != "1234" && intentos < 3)
            {
                Console.Write("Ingrese su PIN: ");
                password = Console.ReadLine();
                if (password != "1234")
                {
                    intentos++;
                    Console.WriteLine("PIN incorrecto. Intento " + intentos + " de 3");
                }
            }
            if (password == "1234")
            {
                Console.WriteLine("Acceso concedido");
            }
            else
            {
                Console.WriteLine("Cuenta bloqueada");
            }
        }
    }
}
