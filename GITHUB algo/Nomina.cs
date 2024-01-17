using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionNonimas
{
    public class Nomina
    {
        // CONSTANTES
        private const int LIMITE_HORAS = 60;
        private const float SALARIO_MAXIMO = 22.5f;
        private const int HORAS_SEMANALES = 35;
        //MIEMBROS PRIVADOS DE LA CLASE
        private string _nombe;
        private string _apellidos;
        private string _puesto;
        private int _horasTrabajadas;
        private float _salarioHora;

        // Datos Calculados

        private int _horasExtra; //No permitir ninugn valor externo


        #region Datos de Entrada -Salida
        // Propiedades publicas
        /// <summary>
        /// Nombre del Empelado.
        /// </summary>
        public string NombreEmpleado
        {
            get
            {
                // Control de Contenido
                if (String.IsNullOrEmpty(_nombe)) throw new Exception("Nombre del Trbajador no estabelcido.");
                // Devolucion del Valor
                return _nombe;
            }
            set
            {
                // Validacion de los Datos de Establecer
                if (string.IsNullOrEmpty(value)) throw new Exception("El Nombre del trabajador no puede ser null o cadena vacia.");
                //Establecimiento del valor al miembro privado
                _nombe = value;
            }
        }
        /// <summary>
        /// Apellidos del Empleado
        /// </summary>
        public string ApellidosEmpleado
        {
            get
            {

                return _apellidos;
            }
            set
            {
                _apellidos = value;
            }
        }
        public string PuestoEmpleado
        {
            get
            {
                if (String.IsNullOrEmpty(_puesto))
                {
                    throw new Exception("No se indico el puesto del empleado");
                }
                return _puesto;
            }
            set { _puesto = value; }
        }
        /// <summary>
        /// Horas trabajadas del empleado
        /// </summary>
        public int HorasTrabajadas   //Para aquellas variables que sean privadas y asi pueden acceder a ellas 
        {
            get // Se activa cuando se consulta el valor del miembro 
                // Resultado = ----.HorasTrabajadas - 10;
            {
                if (_horasTrabajadas == 0) throw new Exception("HorasTrabajadas");
                return _horasTrabajadas;
            }
            set   // cuando quiero mostralo por pantalla -- se activa cuando se le asigna a la propiedad un valor
                  // Ejemplo: ------.HorasTrabajadas = 34;
            {
                // Comprobacion 1: Horas no superiores al limite
                if (value > LIMITE_HORAS) throw new Exception($"Horas son superiores al {LIMITE_HORAS} horas");

                // Comprobacion 2: Horas inferiores o iguales a 0
                if (value <= 0) throw new Exception("Horas inferiores o iguales a 0");


                _horasTrabajadas = value;
            }
        }
        /// <summary>
        /// Salario que percibe el trabajador por hora trabajada
        /// </summary>
        public float SalarioHora
        {
            get // Get = mirar el miembro (SalarioHora)
            {
                //Comprobaciones 
                if (_salarioHora == 0) throw new Exception("No se establecio un salario por Hora");

                //Devolucion del valor el miembro
                return _salarioHora;
            }
            set
            {
                //Validacion del dato proporcionado
                if (value > SALARIO_MAXIMO) throw new Exception($"El salario hora supera los {SALARIO_MAXIMO} Euros");
                if (value <= 0) throw new Exception("El salario hora es inferior o igual a 0.");
                // Establecer el valor al miembro asociado
                _salarioHora = value;
            }
        }
        public int HorasExtra
        {
            get
            {
                return _horasExtra;
            }
        }
        #endregion
        //MÉTODOS PUBLICOS

        public void CalcularHorasExtra()
        {
            // CONSTANTES

            // RECURSOS LOCALES
            int extra = 0;

            // PROCESO
            /* Sin proteccion
            if (_horasTrabajadas > HORAS_SEMANALES)
            {
                _horasExtra = _horasTrabajadas - HORAS_SEMANALES;

                // SALIDA - Método
            }
            else _horasExtra = 0;
                */
            // V2: Con proteccion
            if (HorasTrabajadas > HORAS_SEMANALES)
            {
                _horasExtra = HorasTrabajadas - HORAS_SEMANALES;
            }
            else _horasExtra = 0;
        }
    }
}

