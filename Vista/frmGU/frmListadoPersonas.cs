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
    public partial class frmListadoPersonas : Form
    {
        private L_ListarPersonas logicaPersonas = new L_ListarPersonas();

        public frmListadoPersonas()
        {
            InitializeComponent();
        }

        private void frmListadoPersonas_Load(object sender, EventArgs e)
        {
            CargarPersonas();
        }

        private void CargarPersonas()
        {
            try
            {
                DataTable dt = logicaPersonas.ListarPersonas();
                if (dt != null)
                {
                    dgvPersonas.DataSource = dt;
                    dgvPersonas.AutoResizeColumns();

                    //dgvPersonas.Columns[0].Visible = false;
                    //dgvPersonas.Columns[1].Visible = false;
                    //dgvPersonas.Columns[2].Visible = false;
                    //dgvPersonas.Columns[3].Visible = false;
                    //dgvPersonas.Columns[4].Visible = false;
                    //dgvPersonas.Columns[5].Visible = false;

                }
                else
                {
                    MessageBox.Show("No se pudo cargar la lista de personas.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar personas: " + ex.Message);
            }
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}