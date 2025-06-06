using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;

namespace Vista
{
    public partial class frmRegistrarPersonas : Form
    {
        public frmRegistrarPersonas()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmRegistrarPersonas_Load(object sender, EventArgs e)
        {

        }

        private void txtCodigoPostal_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchImg_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtCodigoPostal.Text, out int cp))
            {
                bool encontrado = L_EjecutarBusquedaCP.BuscarCP(cp);

                if (encontrado)
                {
                    txtLocalidad.Text = L_EjecutarBusquedaCP.Localidad;
                    txtPartido.Text = L_EjecutarBusquedaCP.Partido;
                    txtProvincia.Text = L_EjecutarBusquedaCP.Provincia;

                    Console.WriteLine(L_EjecutarBusquedaCP.idLocalidad);
                }
                else
                {
                    MessageBox.Show("No se encontraron datos para ese código postal.");
                    txtLocalidad.Text = "";
                    txtPartido.Text = "";
                    txtProvincia.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Ingrese un código postal válido.");
            }
        }


    }
}
