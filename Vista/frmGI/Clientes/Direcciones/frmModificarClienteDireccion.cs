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
    public partial class frmModificarClienteDireccion : Form
    {
        private int _idClienteDireccion;
        private L_ClienteDireccion logicaDireccion = new L_ClienteDireccion();
        public frmModificarClienteDireccion(int idClienteDireccion)
        {
            InitializeComponent();
            _idClienteDireccion = idClienteDireccion;

        }

        private void frmModificarClienteDireccion_Load(object sender, EventArgs e)
        {
            CargarDatosDireccion();
        }


        private void CargarDatosDireccion()
        {
            try
            {
                DataRow row = logicaDireccion.ObtenerPorId(_idClienteDireccion);

                if (row != null)
                {
                    txtDireccion.Text = row["Direccion"].ToString();
                    txtLocalidad.Text = row["Localidad"].ToString();
                    txtProvincia.Text = row["Provincia"].ToString();
                    chkActivo.Checked = Convert.ToBoolean(row["Activo"]);
                }
                else
                {
                    MessageBox.Show("No se encontró la dirección seleccionada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos de la dirección: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
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

                bool actualizado = logicaDireccion.Modificar(
                    _idClienteDireccion,
                    direccion,
                    localidad,
                    provincia,
                    activo
                );

                if (actualizado)
                {
                    MessageBox.Show("Dirección modificada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK; // Para actualizar el grid en frmDetalleCliente
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo modificar la dirección.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar la dirección: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
