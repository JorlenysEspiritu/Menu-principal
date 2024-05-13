using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Capa_de_Datos
{
    public class Conexion
    {
        private string Base;
        private string Servidor;
        private string Usuario;
        private string Clave;
        private bool seguridad;
        private static Conexion con=null;

        private Conexion()
        {
            this.Base="Ventas";
            this.Servidor="DESKTOP-JORLE";
            this.Usuario = "Jumarelis Cuisine Emporium";
            this.Clave = "123456";
            this.seguridad=false;


        }

        public SqlConnection CrearConexion()
        {
            SqlConnection cadena = new SqlConnection();


            try
            {
                cadena.ConnectionString = "Server=" + this.Servidor + " ; Database=" + this.Base + ";";

                if (seguridad)
                {
                    cadena.ConnectionString = cadena.ConnectionString + "Integrated security= SSPI";
                   
                }

                else
                {
cadena.ConnectionString = cadena.ConnectionString + "User Id=" + this.Usuario+" ; Password=" + this.Clave;
                }

            }
            catch(Exception ex)
            {
                cadena = null;
                throw ex;
            }
            
            return cadena;   
        }

        public static Conexion getIntancia ()
        {
            if (con==null)
            {
                con = new Conexion();  
            }
            return con;
        }
    }
}
