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
using Vista.frmGI.Clientes.Telefonos;
using Vista.frmGI.Clientes.Direcciones;

namespace Vista.frmGI.Clientes
{
    public partial class frmDetalleCliente : Form
    {
        private int _idCliente;
        private L_Cliente logicaCliente = new L_Cliente();
        private L_ClienteTelefono logicaTelefono = new L_ClienteTelefono();

        public frmDetalleCliente(int idCliente)
        {
            InitializeComponent();
            _idCliente = idCliente;

        }


        private void frmDetalleCliente_Load(object sender, EventArgs e)
        {
            // Cargar opciones de Forma de Pago
            cmbFormaPago.Items.Add("Contado");
            cmbFormaPago.Items.Add("Crédito");
            cmbFormaPago.Items.Add("Transferencia");
            cmbFormaPago.SelectedIndex = 0;

            CargarDatosCliente();
            CargarTelefonos();
            CargarDirecciones();

        }

        //---------------------------------- START DATOS GENERALES ----------------------------------------

        private void CargarDatosCliente()
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos del cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnGuardarGeneral_Click(object sender, EventArgs e)
        {
            try
            {
                string codigo = txtCodigo.Text.Trim();
                string razonSocial = txtRazonSocial.Text.Trim();
                string email = txtEmail.Text.Trim();
                string formaPago = cmbFormaPago.Text;
                decimal descuento = nudDescuento.Value;
                decimal limiteCredito = nudLimiteCredito.Value;
                bool activo = chkActivo.Checked;

                string mensaje;
                bool actualizado = logicaCliente.Modificar(_idCliente, codigo, razonSocial, email, formaPago, descuento, limiteCredito, activo, out mensaje);

                if (actualizado)
                {
                    MessageBox.Show("Cliente modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btn2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        //---------------------------------- END DATOS GENERALES ----------------------------------------



        //---------------------------------- START TELEFONOS ----------------------------------------
        private void btnAgregarTelefono_Click(object sender, EventArgs e)
        {
            using (var frm = new frmAgregarClienteTelefono(_idCliente))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    // Recargamos el DataGridView de teléfonos después de agregar uno nuevo
                    CargarTelefonos();
                }
            }
        }

        private void CargarTelefonos()
        {
            try
            {
                DataTable dt = logicaTelefono.ListarPorCliente(_idCliente);
                dgvTelefonos.DataSource = dt;

                // Ocultar columnas de IDs
                dgvTelefonos.Columns["IdClienteTelefono"].Visible = false;
                dgvTelefonos.Columns["IdCliente"].Visible = false;

                // Configuración opcional
                dgvTelefonos.AutoResizeColumns();
                dgvTelefonos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvTelefonos.MultiSelect = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los teléfonos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificarTelefono_Click(object sender, EventArgs e)
        {
            if (dgvTelefonos.CurrentRow != null)
            {
                int idTelefono = Convert.ToInt32(dgvTelefonos.CurrentRow.Cells["IdClienteTelefono"].Value);

                // Abrimos el formulario de modificación como modal
                frmModificarClienteTelefono frm = new frmModificarClienteTelefono(idTelefono);
                frm.StartPosition = FormStartPosition.CenterParent;
                frm.ShowDialog();

                // Luego de cerrar el frmModificar, recargamos la lista
                CargarTelefonos();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un teléfono de la lista.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //---------------------------------- END TELEFONOS ----------------------------------------



        //---------------------------------- START DIRECCIONES ----------------------------------------

        private void btnAgregarDireccion_Click(object sender, EventArgs e)
        {
            using (var frm = new frmAgregarClienteDireccion(_idCliente))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    // Recargamos el DataGridView de direcciones después de agregar una nueva
                    CargarDirecciones();
                }
            }
        }

        private void btnModificarDireccion_Click(object sender, EventArgs e)
        {
            if (dgvDirecciones.CurrentRow != null)
            {
                int idDireccion = Convert.ToInt32(dgvDirecciones.CurrentRow.Cells["IdClienteDireccion"].Value);
                // Abrimos el formulario de modificación como modal
                frmModificarClienteDireccion frm = new frmModificarClienteDireccion(idDireccion);
                frm.StartPosition = FormStartPosition.CenterParent;
                frm.ShowDialog();
                // Luego de cerrar el frmModificar, recargamos la lista
                CargarDirecciones();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una dirección de la lista.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CargarDirecciones()
        {
            try
            {
                L_ClienteDireccion logicaDireccion = new L_ClienteDireccion();
                DataTable dt = logicaDireccion.ListarPorCliente(_idCliente);
                dgvDirecciones.DataSource = dt;
                // Ocultar columnas de IDs
                dgvDirecciones.Columns["IdClienteDireccion"].Visible = false;
                dgvDirecciones.Columns["IdCliente"].Visible = false;
                // Configuración opcional
                dgvDirecciones.AutoResizeColumns();
                dgvDirecciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvDirecciones.MultiSelect = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las direcciones: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //---------------------------------- END DIRECCIONES ----------------------------------------
    }
}
