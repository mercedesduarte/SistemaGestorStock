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
    public partial class frmInsertarCliente : Form
    {
        private L_Cliente logicaCliente = new L_Cliente();

        public frmInsertarCliente()
        {
            InitializeComponent();
        }

        private void btnInsertarCliente_Click(object sender, EventArgs e)
        {
            InsertarCliente();
        }

        private void InsertarCliente()
        {
            try
            {
                if (!ValidarCamposObligatorios())
                    return;

                bool resultado = logicaCliente.Insertar(
                    txtCodigo.Text.Trim(),
                    txtRazonSocial.Text.Trim(),
                    txtEmail.Text.Trim(),
                    cmbFormaPago.Text.Trim(),
                    nudDescuento.Value,
                    nudLimiteCredito.Value,
                    txtDireccion.Text.Trim(),
                    txtLocalidad.Text.Trim(),
                    txtProvincia.Text.Trim(),
                    txtTelefono.Text.Trim(),
                    txtContacto.Text.Trim(),
                    txtSector.Text.Trim(),
                    txtHorario.Text.Trim(),
                    txtEmailContacto.Text.Trim(),
                    out string mensaje
                );

                if (resultado)
                {
                    MessageBox.Show($"✅ {mensaje}", "Éxito",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show($"❌ {mensaje}", "Error al insertar",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"💥 Error inesperado: {ex.Message}", "Error crítico",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarCamposObligatorios()
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                MessageBox.Show("El código del cliente es obligatorio", "Validación",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigo.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtRazonSocial.Text))
            {
                MessageBox.Show("La razón social es obligatoria", "Validación",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRazonSocial.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                MessageBox.Show("La dirección es obligatoria", "Validación",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDireccion.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MessageBox.Show("El teléfono es obligatorio", "Validación",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTelefono.Focus();
                return false;
            }

            return true;
        }

        private void LimpiarCampos()
        {
            txtCodigo.Clear();
            txtRazonSocial.Clear();
            txtEmail.Clear();
            cmbFormaPago.SelectedIndex = 0;
            nudDescuento.Value = 0;
            nudLimiteCredito.Value = 0;
            txtDireccion.Clear();
            txtLocalidad.Clear();
            txtProvincia.Clear();
            txtTelefono.Clear();
            txtContacto.Clear();
            txtSector.Clear();
            txtHorario.Clear();
            txtEmailContacto.Clear();

            txtCodigo.Focus();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmInsertarCliente_Load(object sender, EventArgs e)
        {
            cmbFormaPago.Items.Clear();
            cmbFormaPago.Items.Add("Contado");
            cmbFormaPago.Items.Add("Crédito");
            cmbFormaPago.Items.Add("Transferencia");
            cmbFormaPago.SelectedIndex = 0;

            txtCodigo.Focus();
        }

    }
}