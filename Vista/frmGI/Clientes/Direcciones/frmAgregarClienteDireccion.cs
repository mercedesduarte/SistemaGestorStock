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

namespace Vista.frmGI.Clientes.Direcciones
{
    public partial class frmAgregarClienteDireccion : Form
    {
        private int _idCliente;
        private L_ClienteDireccion logicaDireccion = new L_ClienteDireccion();
        public frmAgregarClienteDireccion(int idCliente)
        {
            InitializeComponent();
            _idCliente = idCliente;

        }

        private void frmAgregarClienteDireccion_Load(object sender, EventArgs e)
        {
            chkActivo.Checked = true;

        }

        private void btnAgregarDireccion_Click(object sender, EventArgs e)
        {
            try
            {
                string direccion = txtDireccion.Text.Trim();
                string localidad = txtLocalidad.Text.Trim();
                string provincia = txtProvincia.Text.Trim();
                bool activo = chkActivo.Checked;

                if (string.IsNullOrWhiteSpace(direccion))
                {
                    MessageBox.Show("El campo 'Dirección' es obligatorio.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                bool insertado = logicaDireccion.Insertar(
                    _idCliente,
                    direccion,
                    localidad,
                    provincia,
                    activo
                );

                if (insertado)
                {
                    MessageBox.Show("Dirección agregada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK; // Para que el padre refresque el grid
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo agregar la dirección.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar dirección: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
