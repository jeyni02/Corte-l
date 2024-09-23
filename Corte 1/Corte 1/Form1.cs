using Corte_1.Clase;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Corte_1
{

    public partial class Form1 : Form
    {
        private Registro registro; // Instancia para almacenar las personas.
        private Operacion operacion; // Instancia para realizar operaciones de cálculo de edad.
        public Form1()
        {
            InitializeComponent();
            registro = new Registro();
            operacion = new Operacion();

            // Agregar ciudades al ComboBox.
            cbCity.Items.AddRange(new string[] { "Managua", "Chontales", "Granada" });

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener los datos desde los controles del formulario.
                string nombres = tbName.Text;
                string apellidos = tbLastName.Text;
                DateTime fechaNacimiento = dtpDate.Value;
                string ciudad = cbCity.SelectedItem.ToString();

                // Crear una nueva instancia de Persona y agregarla al registro.
                Persona nuevaPersona = new Persona(nombres, apellidos, fechaNacimiento, ciudad);
                registro.AgregarPersona(nuevaPersona);

                MessageBox.Show("Persona agregada exitosamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (registro.ObtenerPersonas().Length > 0)
            {
                // Obtener la primera persona registrada (puedes modificar esto según el requisito).
                Persona persona = registro.ObtenerPersonas()[0];
                int edad = operacion.CalcularEdad(persona.fechaNacimiento);
                string esMayorDeEdad = operacion.EsMayorDeEdad(edad) ? "Mayor de edad" : "Menor de edad";

                // Mostrar el resultado en un cuadro de diálogo.
                MessageBox.Show($"{persona.nombres} {persona.apellidos} tiene {edad} años. Es {esMayorDeEdad}.");
            }
            else
            {
                MessageBox.Show("No hay personas registradas.");
            }
        }
    }
}
