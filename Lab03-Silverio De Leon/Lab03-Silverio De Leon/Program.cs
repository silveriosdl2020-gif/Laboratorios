using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_Silverio_De_Leon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombreEstudiante;
            string nombreCurso;
            Console.Write("Ingrese su nombre: ");
            nombreEstudiante = Console.ReadLine();
            Console.Write("Ingrese el nombre del curso: ");
            nombreCurso = Console.ReadLine();
            Console.WriteLine("Información del Registro");
            Console.WriteLine("Estudiante: " + nombreEstudiante);
            Console.WriteLine("Curso: " + nombreCurso);
            Console.WriteLine("¡Bienvenido al sistema académico!");
            Console.WriteLine("Presione cualquier tecla para finalizar...");
            Console.ReadKey();
        }
    }
}
