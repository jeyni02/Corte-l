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
    private Registro Registro;
    private Operación Operación;
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            registro = new Registro();
            operacion = new Operacion();

            // Agregar ciudades al ComboBox
            cbCiudad.Items.AddRange(new string[] { "Managua", "León", "Granada" });
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string nombres = tbNombres.Text;
                string apellidos = tbApellidos.Text;
                DateTime fechaNacimiento = dtpFechaNacimiento.Value;
                string ciudad = cbCiudad.SelectedItem.ToString();

                Persona nuevaPersona = new Persona(nombres, apellidos, fechaNacimiento, ciudad);
                registro.AgregarPersona(nuevaPersona);

                MessageBox.Show("Persona agregada exitosamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnMostrarEdad_Click(object sender, EventArgs e)
        {
            if (registro.ObtenerPersonas().Length > 0)
            {
                Persona persona = registro.ObtenerPersonas()[0]; // Ejemplo: Mostrar la primera persona
                int edad = operacion.CalcularEdad(persona.fechaNacimiento);
                string esMayorDeEdad = operación.EsMayorDeEdad(edad) ? "Mayor de edad" : "Menor de edad";

                MessageBox.Show($"{persona.nombres} {persona.apellidos} tiene {edad} años. Es {esMayorDeEdad}.");
            }
            else
            {
                MessageBox.Show("No hay personas registradas.");
            }

        }
    }
}
