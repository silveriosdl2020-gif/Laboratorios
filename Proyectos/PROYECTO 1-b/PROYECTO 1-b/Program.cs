using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_1_b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombreOperador = "", codigoTurno = "", placaVehiculo = "", nombreCliente = "";
            int capacidadParqueo = 0, tipoVehiculo = 0, esClienteVIP = 0, minutoEntrada = 0;
            int tiempoSimuladoTotal = 0, opcionMenu = 0, totalTicketsCreados = 0, totalTicketsCerrados = 0;
            double dineroRecaudado = 0.0, montoCobroActual = 0.0, tarifaAplicada = 0.0;
            bool existeTicketActivo = false;
            Console.Clear();
            Console.WriteLine(" - CONFIGURACION DE SISTEMA - ");
            Console.Write("Nombre del Operador: ");
            nombreOperador = Console.ReadLine();
            while (codigoTurno.Length != 4)
            {
                Console.Write("Código de Turno (4 caracteres): ");
                codigoTurno = Console.ReadLine();
                if (codigoTurno.Length != 4)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error: El código debe ser de 4 caracteres");
                    Console.ResetColor();
                }
            }
            while (capacidadParqueo < 10)
            {
                Console.Write("Capacidad del Parqueo (mín. 10): ");
                int.TryParse(Console.ReadLine(), out capacidadParqueo);
                if (capacidadParqueo < 10)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error: Capacidad insuficiente");
                    Console.ResetColor();
                }
            }
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine();
                Console.WriteLine(" OPERADOR: " + nombreOperador);
                Console.WriteLine();
                Console.ResetColor();
                Console.WriteLine("1. Ingreso de Vehículo");
                Console.WriteLine("2. Cobro y Salida");
                Console.WriteLine("3. Ver Estado del Parqueo");
                Console.WriteLine("4. Simular Tiempo");
                Console.WriteLine("5. Cerrar Turno y Salir");
                Console.WriteLine();
                Console.Write("Seleccione una opción: ");
                int.TryParse(Console.ReadLine(), out opcionMenu);
                switch (opcionMenu)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine(" - REGISTRO DE INGRESO - ");
                        if (existeTicketActivo)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Error: Ya hay un vehículo activo");
                        }
                        else if ((totalTicketsCreados - totalTicketsCerrados) >= capacidadParqueo)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Error: Parqueo lleno");
                        }
                        else
                        {
                            Console.Write("Placa: "); placaVehiculo = Console.ReadLine();
                            Console.Write("Cliente: "); nombreCliente = Console.ReadLine();
                            Console.Write("Tipo (1.Moto / 2.Carro / 3.Camión): ");
                            int.TryParse(Console.ReadLine(), out tipoVehiculo);
                            Console.Write("¿VIP? (1.Sí / 2.No): ");
                            int.TryParse(Console.ReadLine(), out esClienteVIP);
                            minutoEntrada = tiempoSimuladoTotal;
                            existeTicketActivo = true;
                            totalTicketsCreados++;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("¡Ticket creado exitosamente!");
                        }
                        Console.ResetColor();
                        Console.WriteLine("Presione cualquier tecla para volver al menú...");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        if (!existeTicketActivo)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Error: No hay vehículos estacionados");
                        }
                        else
                        {
                            int tiempoTranscurrido = tiempoSimuladoTotal - minutoEntrada;
                            int horasACobrar = (tiempoTranscurrido + 59) / 60;
                            if (tipoVehiculo == 1) tarifaAplicada = 5;
                            else if (tipoVehiculo == 2) tarifaAplicada = 10;
                            else tarifaAplicada = 15;
                            montoCobroActual = horasACobrar * tarifaAplicada;
                            if (tiempoTranscurrido <= 15) montoCobroActual = 0;
                            else
                            {
                                if (tiempoTranscurrido > 360) montoCobroActual += 25;
                                if (esClienteVIP == 1) montoCobroActual *= 0.90;
                            }
                            dineroRecaudado += montoCobroActual;
                            totalTicketsCerrados++;
                            existeTicketActivo = false;
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine(" - TICKET DE SALIDA - ");
                            Console.WriteLine();
                            Console.WriteLine("Cliente: " + nombreCliente);
                            Console.WriteLine("Placa: " + placaVehiculo);
                            Console.WriteLine("Tiempo: " + tiempoTranscurrido + " min");
                            Console.WriteLine();
                            Console.WriteLine("TOTAL A PAGAR: Q" + montoCobroActual);
                        }
                        Console.ResetColor();
                        Console.WriteLine("\nPresione cualquier tecla para volver al menú...");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        int actuales = totalTicketsCreados - totalTicketsCerrados;
                        Console.WriteLine(" - ESTADO DEL PARQUEO - ");
                        Console.WriteLine("Espacios ocupados: " + actuales);
                        Console.WriteLine("Espacios disponibles: " + (capacidadParqueo - actuales));
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Recaudación total: Q" + dineroRecaudado);
                        Console.ResetColor();
                        Console.WriteLine("Presione cualquier tecla para volver al menú...");
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        Console.Write("Minutos a adelantar (1-1440): ");
                        int min;
                        int.TryParse(Console.ReadLine(), out min);
                        if (min > 0)
                        {
                            tiempoSimuladoTotal += min;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Tiempo transcurrido actualizado exitosamente");
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Cantidad no válida");
                        }
                        Console.ResetColor();
                        Console.WriteLine("Presione cualquier tecla para volver al menú...");
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Saliendo del sistema...");
                        Console.ResetColor();
                        break;
                }
            } while (opcionMenu != 5);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine();
            Console.WriteLine(" - REPORTE FINAL - ");
            Console.WriteLine();
            Console.ResetColor();
            Console.WriteLine("Operador: " + nombreOperador);
            Console.WriteLine("Tickets Cerrados: " + totalTicketsCerrados);
            Console.WriteLine("Total Recaudado: Q" + dineroRecaudado);
            Console.WriteLine("Cierre de turno exitoso");
        }
    }
}
