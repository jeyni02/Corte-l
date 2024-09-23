using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corte_1.Clase
{
    internal class Persona
    {
        public string nombres;
        public string apellidos;
        public DateTime fechaNacimiento;
        public string ciudad;

        public Persona(string nombres, string apellidos, DateTime fechaNacimiento, string ciudad)
        {
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.fechaNacimiento = fechaNacimiento;
            this.ciudad = ciudad;
        }
    }
}
