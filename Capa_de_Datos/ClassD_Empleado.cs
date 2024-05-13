using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_de_Datos
{
    public class ClassD_Empleado
    {
        public DataTable D_Listar_Empleado(String co)
        {
            SqlDataReader Resultado;
            DataTable table = new DataTable();

            SqlConnection SQLcon = new SqlConnection();

            try
            {
                SQLcon = Conexion.getIntancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("SeleccionarEmpleado", SQLcon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("co", SqlDbType.VarChar).Value = co;

                SQLcon.Open();
                Resultado = Comando.ExecuteReader();
                table.Load(Resultado);
                return table;
            }

            catch (Exception ex)
            {
                throw ex;


            }

            finally
            {
                if (SQLcon.State == ConnectionState.Open) SQLcon.Close();
                {

                }
            }
        }
    }
}
