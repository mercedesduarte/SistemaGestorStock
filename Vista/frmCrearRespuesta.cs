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

namespace Vista
{
    public partial class frmCrearRespuesta : Form
    {
        public frmCrearRespuesta()
        {
            InitializeComponent();
        }

        private void frmCrearRespuesta_Load(object sender, EventArgs e)
        {
            CargarPreguntas();
        }

        private void CargarPreguntas()
        {
            L_ListarPreguntas logicaPreguntas = new L_ListarPreguntas();
            DataTable dt = logicaPreguntas.ListarPreguntas();

            cmbPreguntas.DataSource = dt;
            cmbPreguntas.DisplayMember = "Pregunta";
            cmbPreguntas.ValueMember = "Id_Pregunta";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        { 

        }

        private void btnGuardarRespuesta_Click(object sender, EventArgs e)
        {
            string respuesta = txtRespuesta.Text.Trim();

            if (string.IsNullOrEmpty(respuesta))
            {
                MessageBox.Show("Por favor, escribí una respuesta.");
                return;
            }

            int idusuario = 1;
            int idpregunta = Convert.ToInt32(cmbPreguntas.SelectedValue);

            string mensaje;
            bool resultado = L_CrearRespuesta.CrearRespuesta(idusuario, idpregunta, respuesta, out mensaje);

            if (resultado)
            {
                MessageBox.Show("Respuesta guardada correctamente.");
                txtRespuesta.Clear();
            }
            else
            {
                MessageBox.Show("No se pudo guardar la respuesta: " + mensaje);
            }
        }
    }
}