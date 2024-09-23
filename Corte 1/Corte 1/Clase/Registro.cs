using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corte_1.Clase
{
    internal class Registro
    {
        private Persona[] personas = new Persona[30];
        private int contador = 0;

        public void AgregarPersona(Persona persona)
        {
            if (contador < 30)
            {
                personas[contador] = persona;
                contador++;
            }
            else
            {
                throw new Exception("No se pueden agregar más personas, el registro está lleno.");
            }
        }

        public Persona[] ObtenerPersonas()
        {
            Persona[] listaPersonas = new Persona[contador];
            for (int i = 0; i < contador; i++)
            {
                listaPersonas[i] = personas[i];
            }
            return listaPersonas;
        }
    }
}
