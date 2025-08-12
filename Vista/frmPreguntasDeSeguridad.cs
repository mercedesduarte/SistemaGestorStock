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
    public partial class frmPreguntasDeSeguridad : Form
    {
        public frmPreguntasDeSeguridad()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCrearPregunta_Click(object sender, EventArgs e)
        {
            AcceptButton.PerformClick();
            string pregunta = txtPregunta.Text.Trim();

            if (string.IsNullOrWhiteSpace(pregunta))
            {
                MessageBox.Show("Por favor, ingrese una pregunta válida.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            L_Pregunta logica = new L_Pregunta();
            string mensaje;

            bool resultado = logica.CrearPregunta(pregunta, out mensaje);

            if (resultado)
            {
                MessageBox.Show(mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPregunta.Clear();
                txtPregunta.Focus();
            }
            else
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmPreguntasDeSeguridad_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            CancelButton.PerformClick();
            this.Close();
        }
    }
}
