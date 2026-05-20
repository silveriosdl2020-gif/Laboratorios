using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L15_SDL1332526
{
    using System;

    // EJERCICIO 1: Identificación y corrección de errores de sintaxis

    class Ejercicio1
    {
        public static void Ejecutar()
        {
            Console.WriteLine("--- EJERCICIO 1 ---");

            // Error encontrado: Falta el punto y coma al final de la declaración de la variable 'nombre'.
            // Tipo de error: sintaxis
            // Corrección realizada: Se cambió 'string nombre' por 'string nombre;'.
            // Explicación: Todas las declaraciones de variables y sentencias en C# deben finalizar con punto y coma.
            string nombre;
            int edad;

            Console.WriteLine("Ingrese su nombre:");
            nombre = Console.ReadLine();

            Console.WriteLine("Ingrese su edad:");
            // Error encontrado: Falta el punto y coma al final de la asignación a la variable 'edad'.
            // Tipo de error: sintaxis
            // Corrección realizada: Se agregó ';' al final de 'edad = int.Parse(Console.ReadLine())'.
            // Explicación: El compilador necesita el punto y coma para identificar el término de la instrucción de asignación.
            edad = int.Parse(Console.ReadLine());

            Console.WriteLine("Hola " + nombre);
            Console.WriteLine("Tienes " + edad + " años");

            if (edad >= 18)
            {
                Console.WriteLine("Eres mayor de edad");
            }
            else
            {
                Console.WriteLine("Eres menor de edad");
            }
            Console.WriteLine();
        }
    }
 
    // EJERCICIO 2: Corrección de errores lógicos

    class Ejercicio2
    {
        public static void Ejecutar()
        {
            Console.WriteLine("--- EJERCICIO 2 ---");
            double nota1, nota2, nota3, promedio;

            Console.WriteLine("Ingrese la primera nota:");
            nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la segunda nota:");
            nota2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la tercera nota:");
            nota3 = double.Parse(Console.ReadLine());

            // Error encontrado: En la fórmula original (nota1 + nota2 + nota3 / 3), la división tiene prioridad sobre la suma.
            // Tipo de error: lógico
            // Corrección realizada: Se envolvió la suma de las tres notas entre paréntesis: (nota1 + nota2 + nota3) / 3;
            // Explicación: Los paréntesis fuerzan al programa a sumar primero todas las notas antes de efectuar la división.
            promedio = (nota1 + nota2 + nota3) / 3;

            Console.WriteLine("El promedio es: " + promedio);

            // Error encontrado: La condición original (promedio > 61) excluía la nota exacta de 61 como aprobación.
            // Tipo de error: lógico
            // Corrección realizada: Se cambió el operador de comparación '>' por '>='.
            // Explicación: Al usar el operador mayor o igual que (>=), se asegura que los estudiantes que obtengan exactamente un promedio de 61 aprueben.
            if (promedio >= 61)
            {
                Console.WriteLine("El estudiante aprobó");
            }
            else
            {
                Console.WriteLine("El estudiante reprobó");
            }
            Console.WriteLine();
        }
    }

    // EJERCICIO 3: Identificación de errores de ejecución en arreglos

    class Ejercicio3
    {
        public static void Ejecutar()
        {
            Console.WriteLine("--- EJERCICIO 3 ---");
            int[] numeros = new int[5];
            int suma = 0;

            // Error encontrado: Las condiciones originales (i <= 5) provocan una excepción de ejecución 'IndexOutOfRangeException' al intentar acceder al índice 5.
            // Tipo de error: ejecución
            // Corrección realizada: Se modificaron las condiciones de parada de ambos ciclos 'for' a 'i < 5'. Además, se implementó validación con 'int.TryParse'.
            // Explicación: En C#, los arreglos tienen base cero. Un arreglo de tamaño 5 contiene los índices del 0 al 4. El índice 5 está fuera de los límites.
            for (int i = 0; i < 5; i++)
            {
                int numero;
                bool valido = false;

                while (!valido)
                {
                    Console.WriteLine($"Ingrese un número (Posición {i + 1}):");
                    if (int.TryParse(Console.ReadLine(), out numero))
                    {
                        numeros[i] = numero;
                        valido = true;
                    }
                    else
                    {
                        Console.WriteLine("Entrada inválida. Intente de nuevo.");
                    }
                }
            }

            for (int i = 0; i < 5; i++)
            {
                suma = suma + numeros[i];
            }

            Console.WriteLine("La suma total es: " + suma);
            Console.WriteLine();
        }
    }

    // EJERCICIO 4: Depuración de un programa con métodos
 
    class Ejercicio4
    {
        public static void Ejecutar()
        {
            Console.WriteLine("--- EJERCICIO 4 ---");
            double baseRectangulo = 0, alturaRectangulo = 0;
            bool baseValida = false;
            bool alturaValida = false;

            // Error encontrado: Falta validación de datos para evitar que el programa falle si el usuario ingresa texto o valores menores o iguales a cero.
            // Tipo de error: lógico / ejecución
            // Corrección realizada: Se implementó un bucle 'while' usando 'double.TryParse' y la condición 'baseRectangulo > 0'.
            // Explicación: Garantiza la estabilidad frente a cadenas de texto no válidas y mantiene la coherencia física de un objeto real.
            while (!baseValida)
            {
                Console.WriteLine("Ingrese la base del rectángulo:");
                if (double.TryParse(Console.ReadLine(), out baseRectangulo) && baseRectangulo > 0)
                {
                    baseValida = true;
                }
                else
                {
                    Console.WriteLine("Error: El valor ingresado debe ser un número estrictamente mayor a cero.");
                }
            }

            while (!alturaValida)
            {
                Console.WriteLine("Ingrese la altura del rectángulo:");
                if (double.TryParse(Console.ReadLine(), out alturaRectangulo) && alturaRectangulo > 0)
                {
                    alturaValida = true;
                }
                else
                {
                    Console.WriteLine("Error: El valor ingresado debe ser un número estrictamente mayor a cero.");
                }
            }

            double area = CalcularArea(baseRectangulo, alturaRectangulo);
            Console.WriteLine("El área es: " + area);

            // Error encontrado: La condición original (area > 100) excluía el valor exacto de 100 como una clasificación "grande".
            // Tipo de error: lógico
            // Corrección realizada: Se modificó la condición evaluativa de '>' a '>='.
            // Explicación: De este modo, un área calculada con un valor de 100 exactos se clasificará correctamente bajo la categoría de área grande.
            if (area >= 100)
            {
                Console.WriteLine("El área es grande");
            }
            else
            {
                Console.WriteLine("El área es pequeña");
            }
            Console.WriteLine();
        }

        static double CalcularArea(double baseRectangulo, double alturaRectangulo)
        {
            // Error encontrado: La función original realizaba una operación de suma (+) en lugar del producto matemático correspondiente.
            // Tipo de error: lógico
            // Corrección realizada: Se cambió el operador aritmético '+' por el operador de multiplicación '*'.
            // Explicación: Por definición geométrica estándar, el área de un rectángulo equivale al producto de su base por su altura.
            double resultado = baseRectangulo * alturaRectangulo;
            return resultado;
        }
    }

    // EJERCICIO 5: Análisis de solución generada por Inteligencia Artificial

    class Ejercicio5
    {
        // Formato obligatorio de análisis dentro del código
        // Análisis de la solución generada por IA:
        // Error 1: IndexOutOfRangeException (Ejecución). El ciclo for iniciaba en i = 1 y evaluaba hasta i <= 5. Esto omitía el índice 0 del arreglo y provocaba una caída al intentar acceder a la posición 'edades[5]'.
        // Error 2: Error de lógica en conteo. La condición 'edades[i] > 18' excluía erróneamente a los jóvenes con 18 años exactos de la categoría de mayores de edad.
        // Error 3: Pérdida de precisión matemática (Lógico). La operación 'suma / 5' realizaba una división entera truncando los decimales antes de guardar el valor en la variable double 'promedio'.
        // Limitación encontrada: Carencia absoluta de controles preventivos. Si el usuario ingresaba un texto o un valor numérico negativo, el programa fallaba inmediatamente o distorsionaba el resultado real.
        // Importancia de la validación humana: La IA es capaz de estructurar un código estéticamente funcional, pero suele fallar en las reglas de indexación del lenguaje (base cero) o pasar por alto los casos de frontera en la lógica de negocio y la seguridad de las entradas. La supervisión de un programador humano garantiza la robustez y estabilidad ante entornos de producción reales.

        public static void Ejecutar()
        {
            Console.WriteLine("--- EJERCICIO 5 ---");
            int[] edades = new int[5];
            int suma = 0;
            int mayores = 0;
            double promedio;

            // Error encontrado: Ciclo original 'for (int i = 1; i <= 5; i++)' generaba un error de ejecución por desbordamiento de límites.
            // Tipo de error: ejecución / lógico
            // Corrección realizada: Se reconfiguró el bucle para que iterara estrictamente de 'int i = 0' a 'i < 5'.
            // Explicación: En C#, los arreglos asignan sus componentes partiendo desde la posición 0 hasta el tamaño total menos 1.
            for (int i = 0; i < 5; i++)
            {
                int edadIngresada;
                bool entradaValida = false;

                while (!entradaValida)
                {
                    Console.WriteLine($"Ingrese la edad de la persona {i + 1}:");
                    string entrada = Console.ReadLine();

                    if (int.TryParse(entrada, out edadIngresada) && edadIngresada >= 0)
                    {
                        edades[i] = edadIngresada;
                        entradaValida = true;
                    }
                    else
                    {
                        Console.WriteLine("Dato no válido. Asegúrese de ingresar un número entero que no sea negativo.");
                    }
                }

                suma = suma + edades[i];

                // Error encontrado: La condicional 'if (edades[i] > 18)' ignoraba a las personas de 18 años.
                // Tipo de error: lógico
                // Corrección realizada: Se cambió por el operador relacional de comparación '>= 18'.
                // Explicación: Por legislación estándar aplicable al flujo del ejercicio, la mayoría de edad inicia de forma inclusiva a los 18 años.
                if (edades[i] >= 18)
                {
                    mayores++;
                }
            }

            // Error encontrado: La expresión 'suma / 5' truncaba la parte fraccionaria al operar de forma nativa entre variables de tipo int.
            // Tipo de error: lógico
            // Corrección realizada: Se aplicó un moldeo explícito de tipo '(double)suma / 5'.
            // Explicación: Forzar que al menos uno de los operandos sea double le indica al compilador que ejecute una división real con punto flotante conservando los decimales.
            promedio = (double)suma / 5;

            Console.WriteLine("El promedio de edades es: " + promedio);
            Console.WriteLine("Cantidad de mayores de edad: " + mayores);
            Console.WriteLine();
        }
    }

    // CLASE PRINCIPAL: Control de ejecución del Laboratorio

    class Program
    {
        static void Main(string[] args)
        {
            // Ejecución secuencial y ordenada de todos los ejercicios depurados
            Ejercicio1.Ejecutar();
            Ejercicio2.Ejecutar();
            Ejercicio3.Ejecutar();
            Ejercicio4.Ejecutar();
            Ejercicio5.Ejecutar();

            // Pregunta final de reflexión:
            // ¿Por qué una solución generada por Inteligencia Artificial debe ser revisada, probada y validada por una persona antes de considerarse correcta?
            //
            // Respuesta:
            // Las herramientas de IA generan código basándose en patrones probabilísticos de texto y no en una comprensión real del entorno de ejecución ni de la lógica del negocio.
            // Como se evidenció en los ejercicios anteriores, la IA suele cometer errores críticos de desbordamiento de memoria (como omitir la indexación base cero de los arreglos) o truncamiento de datos numéricos.
            // Los modelos de lenguaje tienden a omitir de forma recurrente las capas de validación y sanitización de entradas, dejando los programas vulnerables a excepciones imprevistas frente a entradas de texto o valores inválidos.
            // Un programador humano posee el pensamiento lógico, el contexto real del problema y la capacidad de realizar pruebas de frontera o de estrés que aseguran la robustez del software.
            // La validación humana actúa como un filtro indispensable de control de calidad y seguridad, garantizando que el código final no solo sea sintácticamente correcto, sino también estable y eficiente.

            Console.WriteLine("Presione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
