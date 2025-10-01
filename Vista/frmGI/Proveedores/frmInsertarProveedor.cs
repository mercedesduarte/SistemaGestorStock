
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
    public partial class frmInsertarProveedor : Form
    {
        private L_Proveedor logicaProveedor = new L_Proveedor();

        public frmInsertarProveedor()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmInsertarProveedor_Load(object sender, EventArgs e)
        {
            // Cargar opciones de Forma de Pago
            cmbFormaPago.Items.Add("Contado");
            cmbFormaPago.Items.Add("Crédito");
            cmbFormaPago.Items.Add("Transferencia");
            cmbFormaPago.SelectedIndex = 0;
        }

        private void btnInsertarProveedor_Click(object sender, EventArgs e)
        {
            string mensaje;
            bool ok = logicaProveedor.Insertar(
                txtCodigo.Text.Trim(),
                txtRazonSocial.Text.Trim(),
                txtCuit.Text.Trim(),
                txtEmail.Text.Trim(),
                cmbFormaPago.SelectedItem.ToString(),
                (int)nudTiempoEntrega.Value,
                decimal.TryParse(txtDescuento.Text.Trim(), out decimal descuento) ? descuento : 0,
                out mensaje
            );

            if (ok)
            {
                MessageBox.Show("Proveedor registrado correctamente.");
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            txtCodigo.Clear();
            txtRazonSocial.Clear();
            txtCuit.Clear();
            txtEmail.Clear();
            txtDescuento.Clear();
            nudTiempoEntrega.Value = 0;
            cmbFormaPago.SelectedIndex = 0;
        }
    }
}
