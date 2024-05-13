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
    public partial class FormCliente : Form
    {
        SqlConnection Conexion = new SqlConnection("Data Source=DESKTOP-JORLE;Initial Catalog=Ventas;User ID=\"Jumarelis Cuisine Emporium\";Password=123456;");

        public FormCliente()
        {
            InitializeComponent();
        }

        #region "Mis metodos"
        private void Formato_cliente()
        {
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[0].HeaderText = "Nombre";
            dataGridView1.Columns[1].Width = 300;
            dataGridView1.Columns[1].HeaderText = "Apellido";
             
        }
        #endregion


        private void Listado_Cliente(String co)
        {

            try
            {
                dataGridView1.DataSource = ClassNegocio.D_Listado_Cliente(co);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);


            }
          
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
          
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
         
        }

        private void FormCliente_Load(object sender, EventArgs e)
        {
            this.Listado_Cliente("%");
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
           
    }
    }
}

