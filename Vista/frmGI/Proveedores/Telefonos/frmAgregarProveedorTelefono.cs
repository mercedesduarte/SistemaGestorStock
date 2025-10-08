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

namespace Vista.frmGI.Proveedores
{
    public partial class frmAgregarProveedorTelefono : Form
    {
        private int _idProveedor;
        private L_ProveedorTelefono logicaTelefono = new L_ProveedorTelefono();

        public frmAgregarProveedorTelefono(int idProveedor)
        {
            InitializeComponent();
            _idProveedor = idProveedor;

        }

        private void btnAgregarTelefono_Click(object sender, EventArgs e)
        {
            string mensaje;
            bool resultado = logicaTelefono.Insertar(
                _idProveedor,
                txtTelefono.Text.Trim(),
                txtContacto.Text.Trim(),
                txtSector.Text.Trim(),
                txtHorario.Text.Trim(),
                txtEmailContacto.Text.Trim(),
                out mensaje
            );

            if (resultado)
            {
                MessageBox.Show("Teléfono agregado correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK; // avisamos al form padre
                this.Close();
            }
            else
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
