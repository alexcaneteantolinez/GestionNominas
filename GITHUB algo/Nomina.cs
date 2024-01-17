using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionNonimas
{
    public class Nomina
    {
        //MIEMBROS PRIVADOS DE LA CLASE
        private string _nombe;
        private string _apellidos;
        private string _puesto;
        private int _horasTrabajadas;
        private float _salarioHora;

        // Propiedades publicas
        /// <summary>
        /// Nombre del Empelado.
        /// </summary>
        public string NombreEmpleado
        {
            get {
                // Control de Contenido
                if (String.IsNullOrEmpty(_nombe)) throw new Exception("Nombre del Trbajador no estabelcido.");
                // Devolucion del Valor
                return _nombe;
            }
            set {
                // Validacion de los Datos de Establecer
                if (string.IsNullOrEmpty(value)) throw new Exception("El Nombre del trabajador no puede ser null o cadena vacia.");
                //Establecimiento del valor al miembro privado
                _nombe = value;
            }
        }
        public string ApellidosEmpleado{
            get{

                return _apellidos;
            }
            set{
                _apellidos = value;
            }
        }
    }
}

