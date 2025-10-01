using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Logica;
using System;
using System.Windows.Forms;

namespace Vista.frmGI.Proveedores
{
    public partial class frmModificarProveedor : Form
    {
        private int _idProveedor;
        private L_Proveedor logicaProveedor = new L_Proveedor();
        public frmModificarProveedor(int idProveedor)
        {
            InitializeComponent();
            _idProveedor = idProveedor;
        }

        private void frmModificarProveedor_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            string mensaje;
            DataRow dr = logicaProveedor.ObtenerPorId(_idProveedor, out mensaje);

            if (dr != null)
            {
                txtCodigo.Text = dr["Codigo"].ToString();
                txtRazonSocial.Text = dr["RazonSocial"].ToString();
                txtCuit.Text = dr["Cuit"].ToString();
                txtEmail.Text = dr["Email"].ToString();
                cmbFormaPago.Text = dr["FormaPago"].ToString();

                if (dr["TiempoEntrega"] != DBNull.Value)
                    nudTiempoEntrega.Text = dr["TiempoEntrega"].ToString();

                if (dr["Descuento"] != DBNull.Value)
                    txtDescuento.Text = dr["Descuento"].ToString();

                chkActivo.Checked = Convert.ToBoolean(dr["Activo"]);
            }
            else
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            int? tiempoEntrega = null;
            if (!string.IsNullOrWhiteSpace(nudTiempoEntrega.Text))
                tiempoEntrega = Convert.ToInt32(nudTiempoEntrega.Text);

            decimal descuento = 0;
            if (!string.IsNullOrWhiteSpace(txtDescuento.Text))
                descuento = Convert.ToDecimal(txtDescuento.Text);

            bool ok = logicaProveedor.Modificar(
                _idProveedor,
                txtCodigo.Text,
                txtRazonSocial.Text,
                txtCuit.Text,
                txtEmail.Text,
                cmbFormaPago.Text,
                tiempoEntrega,
                descuento,
                chkActivo.Checked,
                out mensaje
            );

            if (ok)
            {
                MessageBox.Show("Proveedor actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
