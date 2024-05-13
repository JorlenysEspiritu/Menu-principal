using Capa_de_Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_de_Entidad;
using System.Data.SqlClient;

namespace Menu_principal
{
    public partial class FormInventario : Form
    {
        SqlConnection Conexion= new SqlConnection("Data Source=DESKTOP-JORLE;Initial Catalog=Ventas;User ID=\"Jumarelis Cuisine Emporium\";Password=123456;");
        public FormInventario()
        {
            InitializeComponent();
        }

        private void Listado_Inventario(String co)
        {

            try
            {
                dgvInventario.DataSource = ClassN_Inventario.D_Listar_Inventario(co);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);


            }

        }
        private void FormInventario_Load(object sender, EventArgs e)
        {
          
                this.Listado_Inventario("%");
            
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            try
            {


                SqlCommand command = new SqlCommand("RegistrarProductoEnInventario", Conexion);
                command.Parameters.Add("@Nombredeproducto", SqlDbType.VarChar).Value = txtNombre.Text.ToString();
                command.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = txtdescripcion.Text.ToString();
                command.Parameters.Add("@Categoria", SqlDbType.VarChar).Value = txtcategoria.Text.ToString();
                command.Parameters.Add("@Cantidad", SqlDbType.Int).Value = Convert.ToUInt32(txtcantidad.Text);
                command.Parameters.Add("@PrecioUnitario", SqlDbType.Int).Value = Convert.ToUInt32(txtprecioU.Text);
                command.Parameters.Add("@Estado", SqlDbType.Int).Value = Convert.ToUInt32(txtprecioU.Text);
                command.CommandType = CommandType.StoredProcedure;
                Conexion.Open();
                command.ExecuteNonQuery();
                this.Listado_Inventario("%");

                Conexion.Close();

            }
            catch (Exception)
            {

                
            }

            MessageBox.Show("Los datos se han guardado correctamente");
        }

       


            private void button3_Click(object sender, EventArgs e)
            {
                try
                {
                    // Verificar si se ha seleccionado una fila en el DataGridView
                    if (dgvInventario.SelectedRows.Count > 0)
                    {
                        // Obtener la fila seleccionada
                        DataGridViewRow selectedRow = dgvInventario.SelectedRows[0];

                        // Asignar los valores de la fila seleccionada a los TextBox
                        txtNombre.Text = selectedRow.Cells["Nombre_de_Producto"].Value.ToString();
                        txtdescripcion.Text = selectedRow.Cells["Descripcion"].Value.ToString();
                        txtcategoria.Text = selectedRow.Cells["Categoria"].Value.ToString();
                        txtcantidad.Text = selectedRow.Cells["Cantidad"].Value.ToString();
                        txtprecioU.Text = selectedRow.Cells["PrecioUnitario"].Value.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Por favor, seleccione una fila para modificar.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los datos para modificar: " + ex.Message);
                }
            }


        }
    }
    

