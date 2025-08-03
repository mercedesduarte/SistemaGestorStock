using Logica;
using Sesion;
using System;
using System.Data;
using System.Reflection.Emit;
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
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.AllowUserToDeleteRows = false;
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.MultiSelect = false;
            dgvUsuarios.EditMode = DataGridViewEditMode.EditProgrammatically;

            label2.Visible = false; // Ocultamos el label que muestra el ID del usuario
            btnEliminar.Enabled = false; 
            btnModificar.Text = "Editar usuario";
            btnEliminar.Text = "Eliminar usuario";
            btnModificar.Enabled = false; // Deshabilitamos el botón de editar al inicio
            btnModificar.BackColor = System.Drawing.Color.LightGray; // Cambiamos el color del botón para indicar que está deshabilitado
            btnEliminar.BackColor = System.Drawing.Color.LightGray; // Cambiamos el color del botón de eliminar para indicar que está deshabilitado
        }

        private void CargarUsuarios()
        {
            L_ListarUsuarios logica = new L_ListarUsuarios();
            DataTable usuarios = logica.ListarUsuarios();

            if (usuarios != null)
            {
                dgvUsuarios.DataSource = usuarios;
                dgvUsuarios.AutoResizeColumns();

                dgvUsuarios.Columns[0].Visible = false; //Aca almacenamos id
                dgvUsuarios.Columns[1].Visible = false; // ID Persona
                dgvUsuarios.Columns[3].Visible = false; // Contrasena
                dgvUsuarios.Columns[8].Visible = false; // Id Rol
            }
            else
            {
                MessageBox.Show("No se pudieron cargar los usuarios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Aseguramos que no sea un clic en el encabezado
            if (e.RowIndex >= 0)
            {
                // Obtenemos la fila seleccionada
                DataGridViewRow filaSeleccionada = dgvUsuarios.Rows[e.RowIndex];

                // Obtenemos el ID de la primera celda (columna 0)
                int idUsuario = Convert.ToInt32(filaSeleccionada.Cells[0].Value);
                string usuario = filaSeleccionada.Cells[2].Value.ToString(); // Obtenemos el nombre de usuario

                //MessageBox.Show($"ID del usuario seleccionado: {idUsuario}", "Usuario seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                label2.Text = idUsuario.ToString();

                btnModificar.Enabled = true; // Habilitamos el botón para editar
                btnModificar.Text = $"Editar usuario";
                btnModificar.ForeColor = System.Drawing.Color.White; // Cambiamos el color del texto del botón
                btnModificar.BackColor = System.Drawing.Color.RoyalBlue; // Cambiamos el color del botón para indicar que está habilitado
                btnEliminar.BackColor = System.Drawing.Color.Red; // Cambiamos el color del botón de eliminar para indicar que está habilitado
                btnEliminar.ForeColor = System.Drawing.Color.White; // Cambiamos el color del texto del botón de eliminar
                btnEliminar.Enabled = true; // Habilitamos el botón para eliminar
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(label2.Text);
            frmEditarUsuario frmEditar = new frmEditarUsuario();
            frmEditar.IdUsuario = id;

            var resultado = frmEditar.ShowDialog(); // Espera hasta que se cierre

            // Cuando se cierra, recargar los usuarios
            CargarUsuarios();

            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            btnModificar.BackColor = System.Drawing.Color.LightGray;
            btnEliminar.BackColor = System.Drawing.Color.LightGray;
        }

        private void txtPregunta_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(label2.Text);
            frmEditarUsuario frmEditar = new frmEditarUsuario();
            frmEditar.IdUsuario = id;

            var resultado = frmEditar.ShowDialog(); // Espera hasta que se cierre

            // Cuando se cierra, recargar los usuarios
            CargarUsuarios();

            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            btnEliminar.BackColor = System.Drawing.Color.LightGray;
            btnModificar.BackColor = System.Drawing.Color.LightGray;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
