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
            Console.WriteLine("Ingrese su nombre: ");
            nombreEstudiante = Console.ReadLine();
            Console.WriteLine("Ingrese el nombre del curso: ");
            nombreCurso = Console.ReadLine();
            Console.WriteLine("Estudiante: " + nombreEstudiante);
            Console.WriteLine("Curso: " + nombreCurso);
            Console.WriteLine("Bienvenido a mi primer proyecto");
            Console.WriteLine("Presionar la tecla \"ENTER\" para finalizar");
            while (Console.ReadKey(true).Key != ConsoleKey.Enter) ;
        }
    }
}
