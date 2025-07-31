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
    public partial class frmListadoPreguntasDeSeguridad : Form
    {
        public frmListadoPreguntasDeSeguridad()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmListadoPreguntasDeSeguridad_Load(object sender, EventArgs e)
        {
            CargarPreguntas();
        }

        private void CargarPreguntas()
        {

            L_ListarPreguntas logica = new L_ListarPreguntas();
            DataTable preguntas = logica.ListarPreguntas();

            if (preguntas != null)
            {
                dgvPreguntas.DataSource = preguntas;

                dgvPreguntas.Columns["Id_Pregunta"].HeaderText = "ID";
                dgvPreguntas.Columns["Pregunta"].HeaderText = "Pregunta";

                dgvPreguntas.Columns["Respuesta"].Visible = false;
                dgvPreguntas.Columns["Id_Usuario"].Visible = false;
            }
            else
            {
                MessageBox.Show("No se pudieron cargar las preguntas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvPreguntas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Aca pone para que se pueda eliminar y modificar alexis o aguas

        }
    }
}
