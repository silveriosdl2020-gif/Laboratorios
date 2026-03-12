using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L6_SDL13332526
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("¿Cómo te llamas? ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Hola, " + nombre + " ¡Bienvenido a C#!");
            Console.WriteLine();
            Console.WriteLine("Presionar cualquier tecla para pasar a \"Ejercicio 1\"");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("\"Ejercicio 1\"");
            Console.WriteLine();
            int tipoVehiculo;
            string clasificacion;
            Console.WriteLine("Escribir el tipo de vehiculo (1: Bicicleta, 2: Motocicleta, 3: Auto, 4: Camión, 5: Autobús): ");
            tipoVehiculo = int.Parse(Console.ReadLine());
            switch (tipoVehiculo)
            {
                case 1:
                    clasificacion = "No motorizado";
                    break;
                case 2:
                    clasificacion = "Ligero";
                    break;
                case 3:
                    clasificacion = "Mediano";
                    break;
                case 4:
                    clasificacion = "Pesado";
                    break;
                case 5:
                    clasificacion = "Transporte publico";
                    break;
                default:
                    clasificacion = "Error, vehiculo no reconocido";
                    break;
            }
            Console.WriteLine("Resultado: " + clasificacion);
            Console.WriteLine();
            Console.WriteLine("\"Presionar cualquier tecla para pasar a \"Ejercicio 2\"");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("\"Ejercicio 2\"");
            Console.WriteLine();
            Console.WriteLine("BANCO INDUSTRIAL");
            int tipoTarjeta;
            string aumento;
            Console.WriteLine("Tipo de taejeta (numero): ");
            tipoTarjeta = int.Parse(Console.ReadLine());
            switch (tipoTarjeta)
            {
                case 1:
                    aumento = "25%";
                    break;
                case 2:
                    aumento = "35%";
                    break;
                case 3:
                    aumento = "40%";
                    break;
                default:
                    aumento = "50%";
                    break;
            }
            Console.WriteLine("El aumento es de " + aumento);
            Console.WriteLine();
            Console.WriteLine("Presionar cualquier tecla para pasar a \"Ejercicio 3\"");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("\"Ejercicio 3\"");
            Console.WriteLine();
            double puntos, dinero;
            string nivel;
            Console.WriteLine("Ingresar la puntuacion del empleado (0.0, 0.4 o 0.6): ");
            puntos = double.Parse(Console.ReadLine());
            if (puntos == 0.0)
            {
                nivel = "Inaceptable";
            }
            else
            {
                if (puntos == 0.4)
                {
                    nivel = "Aceptable";
                }
                else
                {
                    if (puntos >= 0.6)
                    {
                        nivel = "Metioro";
                    }
                    else
                    {
                        nivel = "Puntuacion NO VALIDA";
                    }
                }
            }
            dinero = puntos * 2400;
            if (nivel != "Puntuacion NO VALIDA")
            {
                Console.WriteLine("El nivel es " + nivel);
                Console.WriteLine("Cantidad que recibira: " + dinero);
            }
            else
            {
                Console.WriteLine(nivel);
            }
            Console.WriteLine();
            Console.WriteLine("Presionar cualquier tecla para pasar a \"Ejercicio 4\"");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("\"Ejercicio 4\"");
            Console.WriteLine();
            string tipoPizza;
            int tipo, ingrediente;
            string ingredienteNombre = "NO VALIDO";
            Console.WriteLine("¿Que tipo de pizza desea? (1: Vegetariana, 2: No vegetariana): ");
            tipo = int.Parse(Console.ReadLine());
            switch (tipo)
            {
                case 1:
                    tipoPizza = "Vegetariana";
                    Console.WriteLine("Ingrediente extra (1: Pimiento, 2: Tofu): ");
                    ingrediente = int.Parse(Console.ReadLine());
                    switch (ingrediente)
                    {
                        case 1:
                            ingredienteNombre = "Pimiento";
                            break;
                        case 2:
                            ingredienteNombre = "Tofu";
                            break;
                        default:
                            ingredienteNombre = "NO VALIDO";
                            break;
                    }
                    break;
                case 2:
                    tipoPizza = "No vegetariana";
                    Console.WriteLine("Ingrediente extra (1: Peperoni, 2: Jamon, 3: Salmon): ");
                    ingrediente = int.Parse(Console.ReadLine());
                    switch (ingrediente)
                    {
                        case 1:
                            ingredienteNombre = "Peperoni";
                            break;
                        case 2:
                            ingredienteNombre = "Jamon";
                            break;
                        case 3:
                            ingredienteNombre = "Salmon";
                            break;
                        default:
                            ingredienteNombre = "NO VALIDO";
                            break;
                    }
                    break;
                default:
                    tipoPizza = "NO VALIDO";
                    break;
            }
            if (tipoPizza != "NO VALIDO" && ingredienteNombre != "NO VALIDO") 
            {
                Console.WriteLine("Usted eligió una pizza: " + tipoPizza);
                Console.WriteLine("Con ingredientes: Mozarella, Tomate, " + ingredienteNombre);
            }
            else
            {
                Console.WriteLine("Pedido no valido");
            }
        }
    }
}
