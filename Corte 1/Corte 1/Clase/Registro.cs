using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corte_1.Clase
{
    internal class Registro
    {
        // Arreglo de personas con un límite de 30.
        private Persona[] personas = new Persona[30];
        private int contador = 0; // Contador para rastrear cuántas personas han sido registradas.

        // Agrega una persona al registro si no se ha alcanzado el máximo de 30.
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

        // Retorna todas las personas registradas hasta el momento.
        public Persona[] ObtenerPersonas()
        {
            // Crear un arreglo con solo las personas ingresadas.
            Persona[] listaPersonas = new Persona[contador];
            for (int i = 0; i < contador; i++)
            {
                listaPersonas[i] = personas[i];
            }
            return listaPersonas;
        }


    }



}
