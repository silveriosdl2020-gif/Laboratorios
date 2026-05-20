using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L14_SDL1332526
{
    class Libro
    {
        public string titulo;
        public string autor;
        public int anio;
        public bool disponible;
        public Libro(string pTitulo, string pAutor, int pAnio, bool pDisponible)
        {
            titulo = pTitulo;
            autor = pAutor;
            anio = pAnio;
            disponible = pDisponible;
        }
        public void MostrarInfo()
        {
            string estado = disponible ? "Disponible" : "Prestado";
            Console.WriteLine($"- {titulo} por {autor} ({anio}) [{estado}]");
        }

        public void Prestar()
        {
            if (disponible)
            {
                disponible = false;
                Console.WriteLine($"Has pedido prestado: {titulo}");
            }
            else
            {
                Console.WriteLine($"Lo sentimos, {titulo} ya está prestado.");
            }
        }

        public void Devolver()
        {
            disponible = true;
            Console.WriteLine($"Has devuelto: {titulo}");
        }
    }
    class Mascota
    {
        public string nombre;
        public string especie;
        public int edad;
        public bool vacunado;

        public Mascota(string pNombre, string pEspecie, int pEdad, bool pVacunado)
        {
            nombre = pNombre;
            especie = pEspecie;
            edad = pEdad;
            vacunado = pVacunado;
        }

        public void MostrarInfo()
        {
            string estadoVacuna = vacunado ? "Sí" : "No";
            Console.WriteLine($"- {nombre} ({especie}), Edad: {edad}, Vacunado: {estadoVacuna}");
        }

        public void Vacunar()
        {
            vacunado = true;
            Console.WriteLine($"{nombre} ha sido vacunado con éxito.");
        }

        public void CumplirAnios()
        {
            edad = edad + 1;
            Console.WriteLine($"{nombre} ahora tiene {edad} años.");
        }
    }
    class Estudiante
    {
        public string nombre;
        public int edad;
        public string grado;
        public decimal[] notas; 

        public Estudiante(string pNombre, int pEdad, string pGrado, decimal[] pNotas)
        {
            nombre = pNombre;
            edad = pEdad;
            grado = pGrado;
            notas = pNotas;
        }

        public decimal CalcularPromedio()
        {
            decimal suma = 0;
            foreach (decimal n in notas) { suma += n; }
            return suma / notas.Length;
        }

        public void MostrarInfo()
        {
            decimal promedio = CalcularPromedio();
            Console.WriteLine($"- {nombre}, Grado: {grado}, Promedio: {promedio:F2}");
        }

        public void VerificarAprobacion()
        {
            if (CalcularPromedio() >= 61)
                Console.WriteLine($"{nombre} ha APROBADO.");
            else
                Console.WriteLine($"{nombre} ha REPROBADO.");
        }

        public void AgregarNota(decimal nuevaNota)
        {
            Array.Resize(ref notas, notas.Length + 1);
            notas[notas.Length - 1] = nuevaNota;
            Console.WriteLine($"Se agregó la nota {nuevaNota} a {nombre}.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- EJERCICIO 1: BIBLIOTECA ---");
            Libro miLibro1 = new Libro("El Quijote", "Cervantes", 1605, true);
            Libro miLibro2 = new Libro("Harry Potter", "J.K. Rowling", 1997, false);
            miLibro1.MostrarInfo();
            miLibro2.MostrarInfo();
            miLibro1.Prestar();
            miLibro1.MostrarInfo();
            Console.WriteLine("--- EJERCICIO 2: VETERINARIA ---");
            Mascota miMascota = new Mascota("Rex", "Perro", 4, false);
            miMascota.MostrarInfo();
            miMascota.Vacunar();
            miMascota.CumplirAnios();
            miMascota.MostrarInfo();
            Console.WriteLine("--- EJERCICIO 3: ESCUELA ---");
            decimal[] notasIniciales = { 60, 70, 50 };
            Estudiante miEstudiante = new Estudiante("Juan Pérez", 17, "5to Bachillerato", notasIniciales);
            miEstudiante.MostrarInfo();
            miEstudiante.VerificarAprobacion();
            miEstudiante.AgregarNota(95);
            miEstudiante.MostrarInfo();
            miEstudiante.VerificarAprobacion();
            Console.WriteLine("Presiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
