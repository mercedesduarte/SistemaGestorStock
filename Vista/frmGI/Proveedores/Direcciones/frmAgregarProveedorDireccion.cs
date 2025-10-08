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
    public partial class frmAgregarProveedorDireccion : Form
    {

        private int _idProveedor;
        private L_ProveedorDireccion logicaDireccion = new L_ProveedorDireccion();


        public frmAgregarProveedorDireccion(int idProveedor)
        {
            InitializeComponent();
            _idProveedor = idProveedor;

        }

        private void btnAgregarDireccion_Click(object sender, EventArgs e)
        {
            string direccion = txtDireccion.Text.Trim();
            string localidad = txtLocalidad.Text.Trim();
            string provincia = txtProvincia.Text.Trim();

            if (string.IsNullOrWhiteSpace(direccion))
            {
                MessageBox.Show("Debe ingresar una dirección.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(localidad))
            {
                MessageBox.Show("Debe ingresar una localidad.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(provincia))
            {
                MessageBox.Show("Debe ingresar una provincia.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string mensaje;
            bool insertado = logicaDireccion.Insertar(_idProveedor, direccion, localidad, provincia, out mensaje);

            if (insertado)
            {
                MessageBox.Show("Dirección agregada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
