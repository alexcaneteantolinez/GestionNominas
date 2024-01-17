using GestionNonimas;

namespace GestionNonimas
{
    /// <summary>
    /// Objetivo V3: Dotar de Proteccion y Segurirdad a la Clase
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            //CONSTANTES

            //RECURSOS

            Nomina nominaEmpleado; //Aqui vale NUll.

            //INICIALIZACION

            nominaEmpleado = new Nomina(); // Aqui si que tiene memoria.

            //ENTRADA

            nominaEmpleado.NombreEmpleado = Interfaz.LeerCadena("Nombre");

            nominaEmpleado.ApellidosEmpleado = Interfaz.LeerCadena("Apellidos");

            nominaEmpleado.PuestoEmpleado = Interfaz.LeerCadena("Puesto");

            // Captar las horas

            Interfaz.LeerHoras(nominaEmpleado);

            nominaEmpleado.SalarioHora = Interfaz.LeerSalarioHora();

            //PROCESO

            nominaEmpleado.salarioBase = CalculosNomina.SalarioBase(nominaEmpleado.HorasTrabajadas, nominaEmpleado.salarioHora);

            nominaEmpleado.salarioExtra = CalculosNomina.SalarioExtra(nominaEmpleado.HorasTrabajadas, nominaEmpleado.salarioHora);

            nominaEmpleado.salarioBruto = CalculosNomina.SalarioBruto(nominaEmpleado.salarioBase, nominaEmpleado.salarioExtra);

            nominaEmpleado.impuestos = CalculosNomina.Impuestos(nominaEmpleado.salarioBruto);

            nominaEmpleado.salarioNeto = CalculosNomina.SalarioNeto(nominaEmpleado.salarioBruto, nominaEmpleado.impuestos);

            //SALIDA

            Interfaz.MostrarLinea();

            Interfaz.MostrarEmpleado(nominaEmpleado);

            Interfaz.MostrarDatosSemana(nominaEmpleado);

            Interfaz.MostrarHonorarios(nominaEmpleado);

            Interfaz.MostrarLinea();

            Interfaz.MostrarNomina(nominaEmpleado);

        }
    }
}
