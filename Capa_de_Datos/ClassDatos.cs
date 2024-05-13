using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Capa_de_Entidad;


namespace Capa_de_Datos
{
    public class ClassDatos
    {
        public DataTable D_Listar_clientes(String co)
        {
            SqlDataReader Resultado;
            DataTable table = new DataTable();

            SqlConnection SQLcon = new SqlConnection();

            try
            {
             SQLcon=Conexion.getIntancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("SeleccionarCliente", SQLcon);
                   Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("co", SqlDbType.VarChar).Value = co;
                
                SQLcon.Open();
                Resultado=Comando.ExecuteReader();
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
