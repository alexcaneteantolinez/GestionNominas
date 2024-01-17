using GestionNonimas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionNonimas
{
    public static class Interfaz
    {
        public static string? LeerCadena(string dato)
        {
            string cadena;

            Console.Write($"Introduzca {dato}:");

            cadena = Console.ReadLine();

            return cadena;
        }

        public static void MostrarEmpleado(Nomina obj)
        {

            Console.Write($"\tNombre: {obj.Nombre}");

            Console.Write($"\tApellidos: {obj.Apellidos}");

            Console.Write($"\tPuesto: {obj.Puesto}");

        }
        public static void MostrarDatosSemana(Nomina obj)
        {
            Console.WriteLine($"\tHoras Trabajadas:\t{obj.HorasTrabajadas} Horas\tHoras Extra:\t{obj.horasExtra} Horas");
            Console.WriteLine($"\tPrecio por Hora:\t{obj.salarioHora} Euros/Hora");
        }
        public static void MostrarHonorarios(Nomina obj)
        {
            Console.WriteLine($"\tSalario Base:\t{obj.salarioBase} Euros\tSalario Extra:\t{obj.salarioExtra} Euros");
        }
        public static void MostrarNomina(Nomina obj)
        {
            Console.WriteLine($"\tSalario Bruto:\t{obj.salarioBruto} Euros");
            Console.WriteLine($"\tImpuestos:\t{obj.impuestos} Euros");
            Console.WriteLine($"\tSalario Neto:\t{obj.salarioNeto}  Euros");
        }
        public static void MostrarLinea()
        {
            Console.WriteLine("***********************************************************************");
        }

        /// <summary>
        /// Captación de las Horas Trabajadas - Interfaz Modo Texto
        /// </summary>
        /// <returns>Horas Trabajadas</returns>
        public static int LeerHoras()
        {
            // VARIABLES
            int horas = 0;
            string aux = null;  // char[] aux;
            bool esValido;

            do
            {
                esValido = true;

                // Entrada - Interfaz en Modo Texto
                Console.Write("Introduzca Horas: ");
                aux = Console.ReadLine();

                try
                {
                    // Proceso de Validación
                    horas = Comprobaciones.ValidarHoras(aux);
                }
                catch (Exception error)
                {
                    // SALIDA - Retroalimentación de Errores
                    esValido = false;   // Actualización del detector de errores
                    Console.WriteLine("ERROR: " + error.Message);
                }

            } while (!esValido);

            // SALIDA - Método
            return horas;
        }
        public static void LeerHoras(Nomina obj)
        {
            bool key=false;
            do
            {
                try
                {

                    obj.HorasTrabajadas = LeerHoras();

                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                    key = true;
                }
            } while (key);
        }
        /// <summary>
         /// Captación del Salario por Hora del Trabajador - Interfaz Modo Texto
         /// </summary>
         /// <returns>Salario por Hora</returns>
        public static float LeerSalarioHora()
        {
            float salario = 0f;
            string aux = "";    // Inicialización a la cadena vacía
            bool esValido;      // Control de detección de errores

            do
            {
                esValido = true;    // Inicialización del centinela

                // Entrada - Interfaz en modo texto
                Console.Write("Introduzca el salario por hora: ");
                aux = Console.ReadLine();

                try
                {
                    // Procesamiento - Validación del dato de entrada
                    salario = Comprobaciones.ValidarSalarioHora(aux);
                }
                catch (Exception error)
                {
                    esValido = false;   // Detección del error
                    // Retroalimentación - Interfaz modo texto
                    Console.WriteLine($"ERROR: {error.Message}");
                }

            } while (!esValido);

            return salario;
        }
    }
}
