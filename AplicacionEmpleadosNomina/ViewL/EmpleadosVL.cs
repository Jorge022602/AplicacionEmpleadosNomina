using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AplicacionEmpleadosNomina.ControllerL;
using AplicacionEmpleadosNomina.ModelL;

namespace AplicacionEmpleadosNomina
{
    public partial class EmpleadosVL : Form
    {
        EmpleadosCL oempleadosCL;
        EmpleadosML oempleadosML;

        public EmpleadosVL()
        {
            oempleadosCL = new EmpleadosCL();
            oempleadosML = new EmpleadosML();
            InitializeComponent();
            dgvEmpleados.DataSource = oempleadosML.MostrarEmpleados().Tables[0];
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void lblApellido_Click(object sender, EventArgs e)
        {

        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            //ConexionML modelConexion = new ConexionML();
            //MessageBox.Show("El estado de la conexion a la base de datos es: " + modelConexion.ProbarConexion());

            DialogResult r = MessageBox.Show("¿Esta seguro de guardar la informacion del empleado?","Pregunta",MessageBoxButtons.YesNoCancel);
            if (r== DialogResult.Yes)
            {
                oempleadosML.AgregarEmpleado(CapturarDatos());
                MessageBox.Show("Los datos del empleado han sido guardado de manera satisfactorio");
                dgvEmpleados.DataSource = oempleadosML.MostrarEmpleados().Tables[0];
                Limpiar();
            }
            if (r== DialogResult.No)
            {
                Limpiar();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //CAPTURAR LOS DATOS DEL FORMUARIO (Encapsular todos los atributos en un objeto de la clase EmpleadosCL)

        private EmpleadosCL CapturarDatos() 
        {
            oempleadosCL.first_name = textNombre.Text;
            oempleadosCL.last_name = textApellido.Text;
            oempleadosCL.birth_date = dtFechaNacimiento.Text;
            oempleadosCL.genger = cmbGenero.Text;
            oempleadosCL.hire_date = dtbFechaIngreso.Value;
            
            return oempleadosCL;
        }


        //LIMPIAR LOS DATOS DEL FORMULARIO 

        private void Limpiar()
        {
            textNombre.Clear();
            textApellido.Clear();
            dtFechaNacimiento.Value = DateTime.Now;
            cmbGenero.SelectedIndex = -1;
            dtbFechaIngreso.Value = DateTime.Now;
        }

        private void EmpleadosVL_Load(object sender, EventArgs e)
        {

        }

    }
}
