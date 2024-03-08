using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace AplicacionEmpleadosNomina.ModelL
{
    internal class ConexionML
    {
        SqlConnection Conexion;

        public SqlConnection EstablecerConexion()
        {
            try
            {
                this.Conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaConexion"].ConnectionString.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine("Error en establecer la conexion " + e);
            }
            return Conexion;
        }

        //Metodo para insertar,Actualziar y/o Borrar a traves de la ejecucion de una query
        public bool EjecutarComandoSinRetorno( string strcomando)
        {
            try
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandText = strcomando;
                comando.Connection = this.EstablecerConexion();
                this.Conexion.Open();
                comando.ExecuteNonQuery();
                this.Conexion.Close();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error en la ejecucion del query" + e);
                return false;
            }
        }

        //Metodo para mostrar informacion de la BDD a traves de un Select
        public DataSet ConsultarInformacion (SqlCommand strcomando)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter adaptador = new SqlDataAdapter();

            try
            {
                SqlCommand comando = new SqlCommand();
                comando = strcomando;
                comando.Connection = this.EstablecerConexion();
                adaptador.SelectCommand = comando;
                this.Conexion.Open();
                adaptador.Fill(ds);
                this.Conexion.Close();
                return ds;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error en la ejecucion del query" + e);
                return ds;
            }
        }
    }
}
