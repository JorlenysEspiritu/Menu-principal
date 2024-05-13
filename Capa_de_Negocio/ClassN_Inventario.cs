using Capa_de_Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_de_Entidad;

namespace Capa_de_Negocio
{
    public class ClassN_Inventario
    {
        public static DataTable D_Listar_Inventario(string co)
        {
            ClassD_Inventario datos = new ClassD_Inventario();
            return datos.D_Listar_Inventario(co);
        }


    }
}
