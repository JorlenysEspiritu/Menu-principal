using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Capa_de_Datos;
using Capa_de_Entidad;


namespace Capa_de_Negocio
{
    public class ClassNegocio
    {
      public static DataTable D_Listado_Cliente(string co)
        {
            ClassDatos datos = new ClassDatos();
            return datos.D_Listar_clientes(co);
        }

       
    }
}
