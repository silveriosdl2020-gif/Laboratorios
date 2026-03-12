using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace L05_SDL1332526
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 1");
            Console.WriteLine();
            int id, pin1, token, modo;
            bool idCorrecto, pinCorrecto, tokenCorrecto;
            Console.WriteLine("Escribir el ID: ");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("Escribir el PIN: ");
            pin1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Escribir Token de seguridad: ");
            token = int.Parse(Console.ReadLine());
            Console.WriteLine("Modo seguro (1 = Si, 0 = No): ");
            modo = int.Parse(Console.ReadLine());
            idCorrecto = (id == 2026);
            if (idCorrecto)
            {
                Console.WriteLine("Ususario reconocido");
            }
            else
            {
                Console.WriteLine("Usuario no reconocido");
            }
            pinCorrecto = (pin1 == 1234);
            if (pinCorrecto)
            {
                Console.WriteLine("PIN correcto");
            }
            else
            {
                Console.WriteLine("PIN incorrecto");
            }
            tokenCorrecto = (token == 777);
            if (tokenCorrecto)
            {
                Console.WriteLine("Token valido");
            }
            else
            {
                Console.WriteLine("Token no valido");
            }
            if (modo == 1)
            {
                Console.WriteLine("Modo seguro activado: se aplican reglas extra");
            }
            else
            {
                Console.WriteLine("Modo seguro desactivado");
            }
            if (idCorrecto && pinCorrecto && tokenCorrecto)
            {
                Console.WriteLine("Acceso total concedido");
            }
            else
            {
                Console.WriteLine("Acceso denegado");
            }
            if (modo == 1)
            {
                if (token >= 700)
                {
                    Console.WriteLine("Regla extra aprobada");
                }
                else
                {
                    Console.WriteLine("Regla extra fallida");
                }
            }
            Console.WriteLine();
            Console.WriteLine("Presionar cualquier tecla para pasar al \"Ejercico 2\"");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Ejercicio 2");
            Console.WriteLine();
            int pin2;
            Console.WriteLine("Ingresar el PIN: ");
            pin2 = int.Parse(Console.ReadLine());
            if (pin2 >= 1000 && pin2 <= 9999)
            {
                Console.WriteLine("PIN de 4 dígitos: OK");
            }
            else
            {
                Console.WriteLine("PIN inválido: debe tener 4 dígitos");
            }
            if (pin2 % 2 == 0)
            {
                Console.WriteLine("PIN par");
            }
            else
            {
                Console.WriteLine("PIN impar");
            }
            if (pin2 % 5 == 0)
            {
                Console.WriteLine("Multiplo de 5");
            }
            else
            {
                Console.WriteLine("No es multiplo de 5");
            }
            if ((pin2 >= 1000 && pin2 <= 9999) && (pin2 % 2 == 0) && (pin2 % 5 != 0))
            {
                Console.WriteLine("PIN aceptado por politica");
            }
            else
            {
                Console.WriteLine("PIN rechazado por politica");
            }
            Console.WriteLine();
            Console.WriteLine("Presionar cualquier tecla para pasar al \"Ejercico 3\"");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Ejercicio 3");
            Console.WriteLine();
            int codigoAct, edad, terminos, verificacion, puntaje;
            bool codigoCorrecto, edadCorrecta, terminosAceptados, verificacionActivada, puntajeSuficiente, cuentaActivada;
            Console.Write("Ingresar código de activación: ");
            codigoAct = int.Parse(Console.ReadLine());
            Console.Write("Ingresa tu edad: ");
            edad = int.Parse(Console.ReadLine());
            Console.Write("¿Aceptó términos? (1=Sí, 0=No): ");
            terminos = int.Parse(Console.ReadLine());
            Console.Write("¿Activó 2FA? (1=Sí, 0=No): ");
            verificacion = int.Parse(Console.ReadLine());
            Console.Write("Ingrese puntaje de verificación (0-100): ");
            puntaje = int.Parse(Console.ReadLine());
            codigoCorrecto = (codigoAct == 2026);
            if (codigoCorrecto)
            {
                Console.WriteLine("Estado: Código correcto");
            }
            else
            {
                Console.WriteLine("Estado: Código incorrecto");
            }
            edadCorrecta = (edad >= 18);
            if (edadCorrecta)
            {
                Console.WriteLine("Estado: Edad válida");
            }
            else
            {
                Console.WriteLine("Estado: Edad no válida");
            }
            terminosAceptados = (terminos == 1);
            if (terminosAceptados)
            {
                Console.WriteLine("Estado: Términos aceptados");
            }
            else
            {
                Console.WriteLine("Estado: Debe aceptar terminos");
            }
            verificacionActivada = (verificacion == 1);
            if (verificacionActivada)
            {
                Console.WriteLine("Estado: 2FA activado");
            }
            else
            {
                Console.WriteLine("Estado: 2FA no activado");
            }
            puntajeSuficiente = (puntaje >= 70);
            if (puntajeSuficiente)
            {
                Console.WriteLine("Estado: Puntaje suficiente");
            }
            else
            {
                Console.WriteLine("Estado: Puntaje insuficiente");
            }
            cuentaActivada = codigoCorrecto && edadCorrecta && terminosAceptados && verificacionActivada && puntajeSuficiente;
            if (cuentaActivada)
            {
                Console.WriteLine("Cuenta activada exitosamente");
            }
            else
            {
                Console.WriteLine("Cuenta NO activada");
            }
            Console.WriteLine();
            Console.WriteLine("Presionar cualquier tecla para pasar al \"Reto Final\"");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Reto Final");
            Console.WriteLine();
            int notaPrevia, minutosTarde, solvencia, identificacion, calculadora;
            bool notaAprobada, tiempoValido, tieneSolvencia, tieneId, tieneCalculadora, accesoConcedido;
            Console.Write("Ingrese nota previa (0-100): ");
            notaPrevia = int.Parse(Console.ReadLine());
            Console.Write("Ingrese minutos de llegada tarde: ");
            minutosTarde = int.Parse(Console.ReadLine());
            Console.Write("¿Tiene solvencia de pagos? (1=Sí, 0=No): ");
            solvencia = int.Parse(Console.ReadLine());
            Console.Write("¿Trae identificación física? (1=Sí, 0=No): ");
            identificacion = int.Parse(Console.ReadLine());
            Console.Write("¿Trae calculadora permitida? (1=Sí, 0=No): ");
            calculadora = int.Parse(Console.ReadLine());
            notaAprobada = (notaPrevia >= 61);
            if (notaAprobada)
            {
                Console.WriteLine("Requisito académico aprobado");
            }
            else
            {
                Console.WriteLine("Requisito académico NO aprobado");
            }
            tiempoValido = (minutosTarde <= 10);
            if (tiempoValido)
            {
                Console.WriteLine("Hora válida");
            }
            else
            {
                Console.WriteLine("Llegada tarde: fuera de tiempo");
            }
            if (minutosTarde > 0 && minutosTarde <= 10)
            {
                Console.WriteLine("Advertencia: llegó tarde, pero aún puede ingresar");
            }
            tieneSolvencia = (solvencia == 1);
            if (tieneSolvencia)
            {
                Console.WriteLine("Solvencia validada");
            }
            else
            {
                Console.WriteLine("Sin solvencia");
            }
            tieneId = (identificacion == 1);
            if (tieneId)
            {
                Console.WriteLine("Identificación validada");
            }
            else
            {
                Console.WriteLine("Sin identificación");
            }
            tieneCalculadora = (calculadora == 1);
            if (tieneCalculadora)
            {
                Console.WriteLine("Calculadora permitida: OK");
            }
            else
            {
                Console.WriteLine("Sin calculadora permitida");
            }
            accesoConcedido = notaAprobada && tiempoValido && tieneSolvencia && tieneId;
            if (accesoConcedido)
            {
                Console.WriteLine("Acceso a sala de examen concedido");
            }
            else
            {
                Console.WriteLine("Acceso denegado");
            }
            Console.WriteLine();
            Console.WriteLine("Presionar cualquier tecla para pasar al \"San Valentín Hacker Edition\"");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("San Valentín Hacker Edition");
            Console.WriteLine();
            string nombre;
            int valentia, legustaProgramar, legustanMemes, interes, estaSoltera;
            bool interesAlto, valentiaFavorable, solteraFavorable, compatibilidadGeek, declaracionAprobada, miedoalExito;
            Console.Write("Ingresa el nombre la persona: ");
            nombre = Console.ReadLine();
            Console.Write("Nivel de valentía (0-100): ");
            valentia = int.Parse(Console.ReadLine());
            Console.Write("¿Le gusta la programación? (1=Sí, 0=No): ");
            legustaProgramar = int.Parse(Console.ReadLine());
            Console.Write("¿Le gustan los memes técnicos? (1=Sí, 0=No): ");
            legustanMemes = int.Parse(Console.ReadLine());
            Console.Write("Nivel de interés (0-100): ");
            interes = int.Parse(Console.ReadLine());
            Console.Write("¿Está soltera/o? (1=Sí, 0=No): ");
            estaSoltera = int.Parse(Console.ReadLine());
            interesAlto = (interes >= 70);
            if (interesAlto)
            {
                Console.WriteLine("Interés alto detectado");
            }
            else
            {
                Console.WriteLine("Interés insuficiente.Riesgo de friend zone elevado");
            }
            valentiaFavorable = (valentia >= 70);
            if (valentiaFavorable)
            {
                Console.WriteLine("Valentía favorable. Confía en sí mismo(a)");
            }
            else
            {
                Console.WriteLine("Nivel de valentía bajo. Actualización de hardware requerida (vaya al gym)");
            }
            solteraFavorable = (estaSoltera == 1);
            if (solteraFavorable)
            {
                Console.WriteLine("Estado sentimental favorable... aunque lo esté, no le crea: todos/todas mienten");
            }
            else
            {
                Console.WriteLine("Estado sentimental comprometido, no es recomendable hackear esa relación");
            }
            compatibilidadGeek = (legustaProgramar == 1 && legustanMemes == 1);
            if (compatibilidadGeek)
            {
                Console.WriteLine("Compatibilidad geek detectada");
            }
            else
            {
                Console.WriteLine("Compatibilidad parcial o inexistente");
            }
            declaracionAprobada = interesAlto && solteraFavorable && compatibilidadGeek && valentiaFavorable;
            miedoalExito = interesAlto && solteraFavorable && compatibilidadGeek && (valentia < 70);
            if (declaracionAprobada)
            {
                Console.WriteLine("DECLARACIÓN APROBADA.Proceder con chocolates y flores");
            }
            else
            {
                if (miedoalExito)
                {
                    Console.WriteLine("No le tengas miedo al éxito porque vida solo hay 1");
                }
                else
                {
                    Console.WriteLine(nombre + ", no te ama por ahora.");
                }
            }
        }
    }
}
