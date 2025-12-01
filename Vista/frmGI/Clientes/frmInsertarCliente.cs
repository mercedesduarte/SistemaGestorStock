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
            string codigo = txtCodigo.Text.Trim();
            string razonSocial = txtRazonSocial.Text.Trim();
            string email = txtEmail.Text.Trim();
            string formaPago = cmbFormaPago.Text.Trim();
            decimal descuento = nudDescuento.Value;
            decimal limiteCredito = nudLimiteCredito.Value;

                if (logicaCliente.Insertar(txtCodigo.Text.Trim(), txtRazonSocial.Text.Trim(),
                 txtEmail.Text.Trim(), cmbFormaPago.Text.Trim(), nudDescuento.Value, nudLimiteCredito.Value,
                txtDireccion.Text.Trim(), txtLocalidad.Text.Trim(), txtProvincia.Text.Trim(), 
                txtTelefono.Text.Trim(), txtContacto.Text.Trim(), txtSector.Text.Trim(), txtHorario.Text.Trim(), txtEmailContacto.Text.Trim(),

                         out string mensaje
                     ))
                {
                    MessageBox.Show("Cliente creado correctamente");
                }
                else
                {
                    MessageBox.Show(mensaje);
                }

            }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmInsertarCliente_Load(object sender, EventArgs e)
        {
            
            cmbFormaPago.Items.Add("Contado");
            cmbFormaPago.Items.Add("Crédito");
            cmbFormaPago.Items.Add("Transferencia");
            cmbFormaPago.SelectedIndex = 0;
        }

        private void LimpiarCampos()
        {
            
            txtRazonSocial.Clear();
            txtEmail.Clear();
            cmbFormaPago.SelectedIndex = 0;
            nudDescuento.Value = 0;
            nudLimiteCredito.Value = 0;
        }

        

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarDireccion_Click(object sender, EventArgs e)
        {

        }
    }
}
