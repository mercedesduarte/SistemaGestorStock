using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logica;
using System;
using System.Windows.Forms;

namespace Vista.frmGI.Proveedores
{
    public partial class frmModificarProveedorTelefono : Form
    {

        private int idTelefono;
        private int idProveedor;
        private L_ProveedorTelefono logicaTelefono = new L_ProveedorTelefono();

        public frmModificarProveedorTelefono(int idTelefono, int idProveedor)
        {
            InitializeComponent();
            this.idTelefono = idTelefono;
            this.idProveedor = idProveedor;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmModificarProveedorTelefono_Load(object sender, EventArgs e)
        {
            CargarDatosTelefono();
        }

        private void CargarDatosTelefono()
        {
            string mensaje;
            DataRow telefono = logicaTelefono.ObtenerPorId(idTelefono, out mensaje);

            if (telefono != null)
            {
                txtTelefono.Text = telefono["Telefono"].ToString();
                txtContacto.Text = telefono["Contacto"].ToString();
                txtSector.Text = telefono["Sector"].ToString();
                txtHorario.Text = telefono["Horario"].ToString();
                txtEmailContacto.Text = telefono["EmailContacto"].ToString();
                chkActivo.Checked = Convert.ToBoolean(telefono["Activo"]);
            }
            else
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string telefono = txtTelefono.Text.Trim();
            string contacto = txtContacto.Text.Trim();
            string sector = txtSector.Text.Trim();
            string horario = txtHorario.Text.Trim();
            string emailContacto = txtEmailContacto.Text.Trim();
            bool activo = chkActivo.Checked;
            string mensaje;

            bool resultado = logicaTelefono.Modificar(idTelefono, telefono, contacto, sector, horario, emailContacto, activo, out mensaje);

            if (resultado)
            {
                MessageBox.Show("Teléfono modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
