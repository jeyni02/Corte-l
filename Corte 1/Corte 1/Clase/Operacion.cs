using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corte_1.Clase
{
    // Calcula la edad de una persona con base en su fecha de nacimiento.
    internal class Operacion
    {
        public int CalcularEdad(DateTime fechaNacimiento)
        {
            int edad = DateTime.Now.Year - fechaNacimiento.Year;
            if (DateTime.Now.DayOfYear < fechaNacimiento.DayOfYear)
            {
                edad--;
            }
            return edad;
        }

        // Determina si una persona es mayor de edad.
        public bool EsMayorDeEdad(int edad)
        {
            return edad >= 18;
        }
    }

    
}
