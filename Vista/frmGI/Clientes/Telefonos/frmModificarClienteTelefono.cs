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

namespace Vista.frmGI.Clientes.Telefonos
{
    public partial class frmModificarClienteTelefono : Form
    {
        private int _idClienteTelefono;
        private L_ClienteTelefono logicaTelefono = new L_ClienteTelefono();
        public frmModificarClienteTelefono(int idClienteTelefono)
        {
            InitializeComponent();
            _idClienteTelefono = idClienteTelefono;

        }

        private void frmModificarClienteTelefono_Load(object sender, EventArgs e)
        {
            CargarDatosTelefono();
        }

        private void CargarDatosTelefono()
        {
            string mensaje;
            DataRow row = logicaTelefono.ObtenerPorId(_idClienteTelefono, out mensaje);
            if (row != null)
            {
                txtTelefono.Text = row["Telefono"].ToString();
                txtContacto.Text = row["Contacto"].ToString();
                txtSector.Text = row["Sector"].ToString();
                txtHorario.Text = row["Horario"].ToString();
                txtEmailContacto.Text = row["EmailContacto"].ToString();
                chkActivo.Checked = Convert.ToBoolean(row["Activo"]);
            }
            else
            {
                MessageBox.Show("Error al cargar los datos del teléfono: " + mensaje,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                string telefono = txtTelefono.Text.Trim();
                string contacto = txtContacto.Text.Trim();
                string sector = txtSector.Text.Trim();
                string horario = txtHorario.Text.Trim();
                string emailContacto = txtEmailContacto.Text.Trim();
                bool activo = chkActivo.Checked;

                string mensaje;
                bool actualizado = logicaTelefono.Modificar(_idClienteTelefono, telefono, contacto, sector, horario, emailContacto, activo, out mensaje);

                if (actualizado)
                {
                    MessageBox.Show("Teléfono modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo modificar el teléfono.\n" + mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar cambios: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
