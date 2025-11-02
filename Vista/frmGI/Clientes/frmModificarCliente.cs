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

namespace Vista.frmGI.Clientes
{
    public partial class frmModificarCliente : Form
    {
        private int _idCliente;
        private L_Cliente logicaCliente = new L_Cliente();

        public frmModificarCliente(int idCliente)
        {
            InitializeComponent();
            _idCliente = idCliente;

        }

        private void frmModificarCliente_Load(object sender, EventArgs e)
        {
            cmbFormaPago.Items.Add("Contado");
            cmbFormaPago.Items.Add("Crédito");
            cmbFormaPago.Items.Add("Transferencia");
            cmbFormaPago.SelectedIndex = 0;
            CargarDatosCliente();
        }

        private void CargarDatosCliente()
        {
            DataRow row = logicaCliente.ObtenerPorId(_idCliente);
            if (row != null)
            {
                txtCodigo.Text = row["Codigo"].ToString();
                txtRazonSocial.Text = row["RazonSocial"].ToString();
                txtEmail.Text = row["Email"].ToString();
                cmbFormaPago.Text = row["FormaPago"].ToString();
                nudDescuento.Value = Convert.ToDecimal(row["Descuento"]);
                nudLimiteCredito.Value = Convert.ToDecimal(row["LimiteCredito"]);
                chkActivo.Checked = Convert.ToBoolean(row["Activo"]);
            }
            else
            {
                MessageBox.Show("No se encontró el cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string mensaje;
            bool actualizado = logicaCliente.Modificar(
                _idCliente,
                txtCodigo.Text.Trim(),
                txtRazonSocial.Text.Trim(),
                txtEmail.Text.Trim(),
                cmbFormaPago.Text.Trim(),
                nudDescuento.Value,
                nudLimiteCredito.Value,
                chkActivo.Checked,
                out mensaje
            );

            if (actualizado)
            {
                MessageBox.Show("Cliente modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
