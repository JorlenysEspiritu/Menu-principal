
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
    public class ClassN_Empleado
    {
        public static DataTable D_Listar_Empleado(string co)
        {
            ClassD_Empleado datos = new ClassD_Empleado();
            return datos.D_Listar_Empleado(co);
        }


    }
}
