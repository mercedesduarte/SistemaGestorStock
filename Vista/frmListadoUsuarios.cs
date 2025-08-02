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
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.AllowUserToDeleteRows = false;
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.MultiSelect = false;
            dgvUsuarios.EditMode = DataGridViewEditMode.EditProgrammatically;

            label2.Visible = false; // Ocultamos el label que muestra el ID del usuario
            button2.Enabled = false; 
            button1.Text = "Editar usuario";
            button2.Text = "Eliminar usuario";
            button1.Enabled = false; // Deshabilitamos el botón de editar al inicio
            button1.BackColor = System.Drawing.Color.LightGray; // Cambiamos el color del botón para indicar que está deshabilitado
            button2.BackColor = System.Drawing.Color.LightGray; // Cambiamos el color del botón de eliminar para indicar que está deshabilitado
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

                button1.Enabled = true; // Habilitamos el botón para editar
                button1.Text = $"Editar usuario";
                button1.ForeColor = System.Drawing.Color.White; // Cambiamos el color del texto del botón
                button1.BackColor = System.Drawing.Color.RoyalBlue; // Cambiamos el color del botón para indicar que está habilitado
                button2.BackColor = System.Drawing.Color.Red; // Cambiamos el color del botón de eliminar para indicar que está habilitado
                button2.ForeColor = System.Drawing.Color.White; // Cambiamos el color del texto del botón de eliminar
                button2.Enabled = true; // Habilitamos el botón para eliminar
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

            button1.Enabled = false;
            button2.Enabled = false;
            button1.BackColor = System.Drawing.Color.LightGray;
            button2.BackColor = System.Drawing.Color.LightGray;
        }

    }
}
