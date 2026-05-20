using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_2_b
{
    // Clase que representa una parcela de la granja
    class Parcela
    {
        public string TipoCultivo { get; set; }
        public int MesesCrecimiento { get; set; }
        public int MesesParaCosecha { get; set; }
        public decimal IngresoCosecha { get; set; }
        public bool RegadaEsteMes { get; set; }
        // Constructor: inicializa la parcela como vacía
        public Parcela()
        {
            Vaciar();
        }
        // Llena la parcela con un cultivo
        public void Sembrar(string tipo, int meses, decimal ingreso)
        {
            TipoCultivo = tipo;
            MesesCrecimiento = 0;
            MesesParaCosecha = meses;
            IngresoCosecha = ingreso;
            RegadaEsteMes = false;
        }
        // Resetea la parcela a estado vacío
        public void Vaciar()
        {
            TipoCultivo = "Vacía";
            MesesCrecimiento = 0;
            MesesParaCosecha = 0;
            IngresoCosecha = 0;
            RegadaEsteMes = false;
        }
    }
    class Program
    {
        // Métodos auxiliares para leer entradas validadas
        // Lee un entero positivo; repite hasta obtener uno válido
        static int LeerEnteroPositivo(string mensaje)
        {
            int valor;
            Console.Write(mensaje);
            while (!int.TryParse(Console.ReadLine(), out valor) || valor <= 0)
            {
                Console.Write("Entrada inválida. Ingrese un número entero positivo: ");
            }
            return valor;
        }
        static decimal LeerDecimalPositivo(string mensaje)
        {
            decimal valor;
            Console.Write(mensaje);
            while (!decimal.TryParse(Console.ReadLine(), out valor) || valor <= 0)
            {
                Console.Write("Entrada inválida. Ingrese un número positivo: ");
            }
            return valor;
        }
        static int LeerEnteroEnRango(string mensaje, int min, int max)
        {
            int valor;
            Console.Write(mensaje);
            while (!int.TryParse(Console.ReadLine(), out valor) || valor < min || valor > max)
            {
                Console.Write("Entrada inválida. Ingrese un número entre " + min + " y " + max + ": ");
            }
            return valor;
        }
        // Programa principal
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("--- BIENVENIDO A LA GESTIÓN DE GRANJA ---");
            // 1. Configuración inicial
            decimal dineroActual = LeerDecimalPositivo("Ingrese la cantidad de dinero inicial (Q): ");
            int empleados = LeerEnteroPositivo("Ingrese el número de empleados: ");
            decimal sueldo = LeerDecimalPositivo("Ingrese el sueldo por empleado (Q): ");
            int mesesRestantes = LeerEnteroPositivo("Ingrese la cantidad de meses por simular: ");
            int filas = LeerEnteroPositivo("Ingrese la cantidad de filas para las parcelas: ");
            int columnas = LeerEnteroPositivo("Ingrese la cantidad de columnas para las parcelas: ");
            int mesesSimuladosTotales = 0;
            // Inicialización de la matriz de parcelas
            Parcela[,] matrizParcelas = new Parcela[filas, columnas];
            for (int i = 0; i < filas; i++)
                for (int j = 0; j < columnas; j++)
                    matrizParcelas[i, j] = new Parcela();
            // Variables para el reporte final
            decimal totalIngresos = 0;
            decimal totalEgresos = 0;
            int totalRiegos = 0;
            int papasSembradas = 0, tomatesSembrados = 0, fresasSembradas = 0;
            int papasCosechadas = 0, tomatesCosechados = 0, fresasCosechadas = 0;
            bool salir = false;
            // 2. Ciclo principal del programa
            while (!salir && mesesRestantes > 0 && dineroActual > 0)
            {
                Console.Clear();
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("Meses restantes: " + mesesRestantes + " | Dinero actual: Q" + dineroActual);
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("1. Sembrar");
                Console.WriteLine("2. Regar Parcelas");
                Console.WriteLine("3. Consultar parcela");
                Console.WriteLine("4. Avanzar de mes");
                Console.WriteLine("5. Salir");
                Console.Write("Elija una opción: ");
                string opcion = Console.ReadLine();
                Console.WriteLine();

                switch (opcion)
                {
                    case "1": // SEMBRAR
                        Console.Clear();
                        int fSiembra = LeerEnteroEnRango("Ingrese fila (0 a " + (filas - 1) + "): ", 0, filas - 1);
                        int cSiembra = LeerEnteroEnRango("Ingrese columna (0 a " + (columnas - 1) + "): ", 0, columnas - 1);

                        if (matrizParcelas[fSiembra, cSiembra].TipoCultivo == "Vacía")
                        {
                            Console.WriteLine("Opciones de cultivo:");
                            Console.WriteLine("  1. Papa   (Q450, 2 meses)");
                            Console.WriteLine("  2. Tomate (Q650, 3 meses)");
                            Console.WriteLine("  3. Fresa  (Q900, 4 meses)");
                            Console.Write("Elija el cultivo (1-3): ");
                            string tipo = Console.ReadLine();

                            if (tipo == "1")
                            {
                                matrizParcelas[fSiembra, cSiembra].Sembrar("Papa", 2, 450);
                                papasSembradas++;
                                Console.WriteLine("¡Siembra de Papa realizada con éxito!");
                            }
                            else if (tipo == "2")
                            {
                                matrizParcelas[fSiembra, cSiembra].Sembrar("Tomate", 3, 650);
                                tomatesSembrados++;
                                Console.WriteLine("¡Siembra de Tomate realizada con éxito!");
                            }
                            else if (tipo == "3")
                            {
                                matrizParcelas[fSiembra, cSiembra].Sembrar("Fresa", 4, 900);
                                fresasSembradas++;
                                Console.WriteLine("¡Siembra de Fresa realizada con éxito!");
                            }
                            else
                            {
                                Console.WriteLine("Opción de cultivo no válida. No se realizó la siembra.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Error: La parcela no está vacía. Elija otra parcela.");
                        }
                        break;
                    case "2": // REGAR PARCELAS
                        Console.Clear();
                        int fRiego = LeerEnteroEnRango("Ingrese fila (0 a " + (filas - 1) + "): ", 0, filas - 1);
                        int cRiego = LeerEnteroEnRango("Ingrese columna (0 a " + (columnas - 1) + "): ", 0, columnas - 1);

                        Parcela pRiego = matrizParcelas[fRiego, cRiego];

                        if (pRiego.TipoCultivo == "Vacía")
                        {
                            Console.WriteLine("No se puede regar una parcela vacía. Primero siembre algo.");
                        }
                        else if (pRiego.RegadaEsteMes)
                        {
                            Console.WriteLine("Esta parcela ya fue regada este mes. Solo se puede regar una vez por mes.");
                        }
                        else if (dineroActual < 40)
                        {
                            Console.WriteLine("No tienes suficiente dinero para regar (cuesta Q40). Dinero actual: Q" + dineroActual);
                        }
                        else
                        {
                            pRiego.RegadaEsteMes = true;
                            dineroActual -= 40;
                            totalEgresos += 40;
                            totalRiegos++;
                            Console.WriteLine("¡Parcela regada exitosamente! Se dedujeron Q40.");
                            Console.WriteLine("Dinero restante: Q" + dineroActual);
                        }
                        break;
                    case "3": // CONSULTAR PARCELA
                        Console.Clear();
                        int fConsulta = LeerEnteroEnRango("Ingrese fila (0 a " + (filas - 1) + "): ", 0, filas - 1);
                        int cConsulta = LeerEnteroEnRango("Ingrese columna (0 a " + (columnas - 1) + "): ", 0, columnas - 1);

                        Parcela pConsulta = matrizParcelas[fConsulta, cConsulta];

                        Console.WriteLine("\n--- Estado de la parcela [" + fConsulta + "," + cConsulta + "] ---");
                        if (pConsulta.TipoCultivo == "Vacía")
                        {
                            Console.WriteLine("La parcela está disponible para siembra.");
                        }
                        else
                        {
                            Console.WriteLine("Tipo de cultivo: " + pConsulta.TipoCultivo);
                            Console.WriteLine("Crecimiento: " + pConsulta.MesesCrecimiento + " / " + pConsulta.MesesParaCosecha + " meses");
                            Console.WriteLine("Regada este mes: " + (pConsulta.RegadaEsteMes ? "Sí" : "No"));
                        }
                        break;
                    case "4": // AVANZAR DE MES
                        Console.Clear();
                        Console.WriteLine("--- AVANZANDO DE MES ---");
                        // Pago de planilla a empleados
                        decimal pagoPlanilla = empleados * sueldo;
                        dineroActual -= pagoPlanilla;
                        totalEgresos += pagoPlanilla;
                        Console.WriteLine("Pago de planilla a " + empleados + " empleado(s): -Q" + pagoPlanilla);
                        Console.WriteLine("Dinero tras planilla: Q" + dineroActual);
                        // Crecimiento y cosecha de cada parcela
                        for (int i = 0; i < filas; i++)
                        {
                            for (int j = 0; j < columnas; j++)
                            {
                                Parcela p = matrizParcelas[i, j];
                                if (p.TipoCultivo != "Vacía")
                                {
                                    // Si fue regada crece 2 meses, si no solo 1
                                    int aumento = p.RegadaEsteMes ? 2 : 1;
                                    p.MesesCrecimiento += aumento;
                                    Console.WriteLine("Parcela [" + i + "," + j + "] (" + p.TipoCultivo + "): creció " + aumento + " mes(es) -> " + p.MesesCrecimiento + "/" + p.MesesParaCosecha + " meses.");
                                    // Reiniciar estado de riego para el siguiente mes
                                    p.RegadaEsteMes = false;
                                    // Cosechar si alcanzó los meses requeridos
                                    if (p.MesesCrecimiento >= p.MesesParaCosecha)
                                    {
                                        Console.WriteLine("  ¡Cosecha! Parcela [" + i + "," + j + "] (" + p.TipoCultivo + ") lista -> +Q" + p.IngresoCosecha);
                                        dineroActual += p.IngresoCosecha;
                                        totalIngresos += p.IngresoCosecha;
                                        // Registrar estadística de cosecha
                                        if (p.TipoCultivo == "Papa") papasCosechadas++;
                                        else if (p.TipoCultivo == "Tomate") tomatesCosechados++;
                                        else if (p.TipoCultivo == "Fresa") fresasCosechadas++;

                                        p.Vaciar();
                                    }
                                }
                            }
                        }
                        mesesRestantes--;
                        mesesSimuladosTotales++;
                        Console.WriteLine("\nFin del mes. Dinero actual: Q" + dineroActual + " | Meses restantes: " + mesesRestantes);
                        break;
                    case "5": // SALIR
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Por favor elija una opción del 1 al 5.");
                        break;
                }
            }
            // 3. Reporte final (se muestra al salir o cuando se acaba el dinero/tiempo)
            Console.Clear();
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("           FIN DE LA SIMULACIÓN");
            Console.WriteLine("----------------------------------------");
            if (dineroActual <= 0)
                Console.WriteLine("Motivo de fin: ¡Te quedaste sin dinero!");
            else if (mesesRestantes <= 0)
                Console.WriteLine("Motivo de fin: ¡Se alcanzó el límite de meses!");
            else
                Console.WriteLine("Motivo de fin: El usuario eligió salir.");
            Console.WriteLine("--- Resumen financiero ---");
            Console.WriteLine("Dinero final:       Q" + dineroActual);
            Console.WriteLine("Total de ingresos:  Q" + totalIngresos);
            Console.WriteLine("Total de egresos:   Q" + totalEgresos);
            Console.WriteLine("Meses simulados:    " + mesesSimuladosTotales);
            Console.WriteLine("--- Parcelas sembradas ---");
            Console.WriteLine("Papas:    " + papasSembradas);
            Console.WriteLine("Tomates:  " + tomatesSembrados);
            Console.WriteLine("Fresas:   " + fresasSembradas);
            Console.WriteLine("--- Cosechas realizadas ---");
            Console.WriteLine("Papas:    " + papasCosechadas);
            Console.WriteLine("Tomates:  " + tomatesCosechados);
            Console.WriteLine("Fresas:   " + fresasCosechadas);
            Console.WriteLine("--- Otros datos ---");
            Console.WriteLine("Total de riegos realizados: " + totalRiegos);
            // Contar parcelas vacías al finalizar
            int parcelasVacias = 0;
            for (int i = 0; i < filas; i++)
                for (int j = 0; j < columnas; j++)
                    if (matrizParcelas[i, j].TipoCultivo == "Vacía")
                        parcelasVacias++;
            Console.WriteLine("Parcelas vacías al finalizar: " + parcelasVacias);
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Presione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
