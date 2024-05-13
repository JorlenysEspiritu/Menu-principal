using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu_principal
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnslifde_Click(object sender, EventArgs e)
        {
            if (menuvertical.Width == 200)
            {
                menuvertical.Width = 70;
            }
            else
            {
                menuvertical.Width = 200;
                
            }
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            FormCliente FormCliente = new FormCliente();

        
            FormCliente.Show();
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            FormEmpleados FormEmpleados = new FormEmpleados();


            FormEmpleados.Show();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {

            FormInventario FormInventario = new FormInventario();


            FormInventario.Show();
        }

        private void btnFactura_Click(object sender, EventArgs e)
        {

            FormFactura FormFactura = new  FormFactura();


            FormFactura.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
