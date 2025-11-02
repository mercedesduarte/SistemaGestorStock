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
    public partial class frmAgregarClienteTelefono : Form
    {

        private int _idCliente;
        private L_ClienteTelefono logicaTelefono = new L_ClienteTelefono();

        public frmAgregarClienteTelefono(int idCliente)
        {
            InitializeComponent();
            _idCliente = idCliente;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            chkActivo.Checked = true;

        }

        private void btnAgregarTelefono_Click(object sender, EventArgs e)
        {
            try
            {
                string telefono = txtTelefono.Text.Trim();
                string contacto = txtContacto.Text.Trim();
                string sector = txtSector.Text.Trim();
                string horario = txtHorario.Text.Trim();
                string emailContacto = txtEmailContacto.Text.Trim();
                bool activo = chkActivo.Checked;

                if (string.IsNullOrWhiteSpace(telefono))
                {
                    MessageBox.Show("El campo 'Teléfono' es obligatorio.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string mensaje;
                bool insertado = logicaTelefono.Insertar(
                    _idCliente,
                    telefono,
                    contacto,
                    sector,
                    horario,
                    emailContacto,
                    activo,
                    out mensaje
                );

                if (insertado)
                {
                    MessageBox.Show("Teléfono agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo agregar el teléfono.\n" + mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar teléfono: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
