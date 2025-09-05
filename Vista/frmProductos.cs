using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class frmProductos : Form
    {
        private L_ListarProductos logicaListarProductos = new L_ListarProductos();
        public frmProductos()
        {
            InitializeComponent();
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            CargarPersonas();
        }

        private void CargarPersonas()
        {
            try
            {
                DataTable dt = logicaListarProductos.ListarProductos();
                if (dt != null)
                {
                    dgvProductos.DataSource = dt;
                    dgvProductos.AutoResizeColumns();

                    dgvProductos.Columns[0].Visible = false;
                    
                }
                else
                {
                    MessageBox.Show("No se pudo cargar la lista de productos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar personas: " + ex.Message);
            }
        }

        private void btnCrearPersona_Click(object sender, EventArgs e)
        {

        }
    }
}
