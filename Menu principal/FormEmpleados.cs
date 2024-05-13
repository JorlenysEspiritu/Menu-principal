using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Capa_de_Entidad;
using Capa_de_Negocio;

namespace Menu_principal
{
    public partial class FormEmpleados : Form
    {
        public FormEmpleados()
        {
            InitializeComponent();
        }

        #region "Mis metodos"
        private void Formato_cliente()
        {
            dataGridView2.Columns[0].Width = 100;
            dataGridView2.Columns[0].HeaderText = "Nombre";
            dataGridView2.Columns[1].Width = 300;
            dataGridView2.Columns[1].HeaderText = "Apellido";

        }
        #endregion

        private void Listado_Empleado(String co)
        {

            try
            {
                dataGridView2.DataSource = ClassN_Empleado.D_Listar_Empleado(co);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);


            }

        }

        private void FormEmpleados_Load(object sender, EventArgs e)
        {
            this.Listado_Empleado("%");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
