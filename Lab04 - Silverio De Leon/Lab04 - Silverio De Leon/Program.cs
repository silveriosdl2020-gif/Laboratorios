using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04___Silverio_De_Leon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("¿Cómo te llamas? ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Hola, " + nombre + " ¡Bienvenido a C#!");

            Console.WriteLine("Ejercicio 1:");
            string modelo = "Primer Modelo";
            int capacidadCarga = 80;
            float nivelCombustible = 50.6f;
            bool motorActivo = true;
            Console.WriteLine("El " + modelo + " tiene una capacidad de carga de " + capacidadCarga + ", el nivel de combustible es " + nivelCombustible + ", motor activo " + motorActivo);

            Console.WriteLine("Ejercicio 2:");
            short sensoresActivos = 128;
            int registroProcesador = sensoresActivos;
            double precisionTotal = registroProcesador;
            Console.WriteLine(precisionTotal);

            Console.WriteLine("Ejercicio 3:");
            double energiaGenerada = 987.65;
            int energiaLimitada = (int)energiaGenerada;
            Console.WriteLine(energiaGenerada + " a " + energiaLimitada);

            Console.WriteLine("Ejercicio 4:");
            Console.WriteLine("Ingresar la distancia del planeta mas cercano: ");
            string entradaRadar = Console.ReadLine();
            int distanciaBase = int.Parse(entradaRadar);
            int resultadoFinal = distanciaBase + 100;
            Console.WriteLine("La distancia procesada con margen de seguridad es: " + resultadoFinal);

            Console.WriteLine("Ejercicio 5: ");
            string señalOxigeno = "true";
            bool oxigenoActivo = Convert.ToBoolean(señalOxigeno);
            string temperaturaCabina = "22.8";
            double tempNumerica = Convert.ToDouble(temperaturaCabina);
            Console.WriteLine("¿Suministro de oxígeno activo? " + oxigenoActivo);
            Console.WriteLine("Temperatura actual de la cabina: " + tempNumerica);

            Console.WriteLine("Ejercicio 6: ");
            double velocidadLuz = 299792.458;
            string velocidadTextoSimple = velocidadLuz.ToString();
            string velocidadFormateada = velocidadLuz.ToString("N3");
            Console.WriteLine("Texto simple: " + velocidadTextoSimple);
            Console.WriteLine("Formato profesional (N3): " + velocidadFormateada);

            Console.WriteLine("Ejercicio 7: ");
            Console.WriteLine("Ingrese el precio por Galón de Litio:");
            string entradaPrecio = Console.ReadLine();
            double precioBase = Convert.ToDouble(entradaPrecio);
            double impuesto = precioBase * 0.12;
            double costoTotalDecimal = precioBase + impuesto;
            int costoFinalEntero = (int)costoTotalDecimal;
            Console.WriteLine("El costo final de suministro es: " + costoFinalEntero);
            Console.WriteLine("(Se ha redondeado hacia abajo para el presupuesto)");
        }
    }
}
