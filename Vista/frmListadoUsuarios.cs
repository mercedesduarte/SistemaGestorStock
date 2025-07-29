using Logica;
using Sesion;
using System;
using System.Data;
using System.Windows.Forms;

namespace Vista
{
    public partial class frmListadoUsuarios : Form
    {
        public frmListadoUsuarios()
        {
            InitializeComponent();
            this.Load += frmListadoUsuarios_Load; // Aseguramos que el evento Load esté conectado
        }

        private void frmListadoUsuarios_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
        }

        private void CargarUsuarios()
        {
            L_ListarUsuarios logica = new L_ListarUsuarios();
            DataTable usuarios = logica.ListarUsuarios();

            if (usuarios != null)
            {
                dgvUsuarios.DataSource = usuarios;
                dgvUsuarios.AutoResizeColumns();
            }
            else
            {
                MessageBox.Show("No se pudieron cargar los usuarios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Aca pone para que se pueda eliminar y modificar alexis o aguas
        }
    }
}
