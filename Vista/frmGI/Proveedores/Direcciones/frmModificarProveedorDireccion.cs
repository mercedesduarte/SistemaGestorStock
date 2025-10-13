using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logica;
using System.Windows.Forms;

namespace Vista.frmGI.Proveedores.Direcciones
{
    public partial class frmModificarProveedorDireccion : Form
    {
        private int _idDireccion;
        private int _idProveedor;
        private L_ProveedorDireccion logicaDirecciones = new L_ProveedorDireccion();

        public frmModificarProveedorDireccion(int idDireccion, int idProveedor)
        {
            InitializeComponent();
            _idDireccion = idDireccion;
            _idProveedor = idProveedor;
        }

        private void frmModificarProveedorDireccion_Load(object sender, EventArgs e)
        {
            CargarDatosDireccion();

        }

        private void CargarDatosDireccion()
        {
            string mensaje;
            DataRow row = logicaDirecciones.ObtenerPorId(_idDireccion, out mensaje);

            if (row != null)
            {
                txtDireccion.Text = row["Direccion"].ToString();
                txtLocalidad.Text = row["Localidad"].ToString();
                txtProvincia.Text = row["Provincia"].ToString();
                chkActivo.Checked = Convert.ToBoolean(row["Activo"]);
            }
            else
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            string direccion = txtDireccion.Text.Trim();
            string localidad = txtLocalidad.Text.Trim();
            string provincia = txtProvincia.Text.Trim();
            bool activo = chkActivo.Checked;

            string mensaje;
            bool actualizado = logicaDirecciones.Modificar(_idDireccion, direccion, localidad, provincia, activo, out mensaje);

            if (actualizado)
            {
                MessageBox.Show("Dirección modificada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
