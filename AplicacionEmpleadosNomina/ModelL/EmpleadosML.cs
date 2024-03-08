using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AplicacionEmpleadosNomina;
using AplicacionEmpleadosNomina.ControllerL;
using System.Data;
using System.Data.SqlClient;

namespace AplicacionEmpleadosNomina.ModelL
{
    class EmpleadosML
    {
        ConexionML conexion;
        EmpleadosCL oempleadoCL;

        public EmpleadosML() 
        {
            conexion = new ConexionML();
        }
        public bool AgregarEmpleado(EmpleadosCL oempleadoCL)
        {
            try
            {
                conexion.EjecutarComandoSinRetorno("Insert into tbl_employees values ('"+oempleadoCL.birth_date+"','"+oempleadoCL.first_name + "','" +oempleadoCL.last_name + "','" +char.Parse(oempleadoCL.genger.Substring(0,1)) + "','" +oempleadoCL.hire_date.ToString("yyyy/mm/dd")+"')");
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error en el registro de los datos del empleado " + e);
                return false;
            }
        }

        public DataSet MostrarEmpleados()
        {
            string query = "Select * from tbl_employees";
            SqlCommand sentencia = new SqlCommand(query);
            return conexion.ConsultarInformacion(sentencia);
        }
    }
}
