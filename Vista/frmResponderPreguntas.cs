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
using static Logica.L_ResponderPreguntas;
using Sesion;

namespace Vista
{
    public partial class frmResponderPreguntas : Form
    {
        private List<PreguntaVista> preguntas = new List<PreguntaVista>();
        private int indiceActual = 0;
        private L_ListarPreguntas logicaPreguntas = new L_ListarPreguntas();

        public frmResponderPreguntas()
        {
            InitializeComponent();
        }

        private void frmResponderPreguntas_Load(object sender, EventArgs e)
        {
            preguntas = logicaPreguntas.ListarPreguntas();

            if (preguntas.Count > 0)
            {
                MostrarPreguntaActual();
            }
            else
            {
                MessageBox.Show("No hay preguntas disponibles.");
                btnResponderPregunta.Enabled = false;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnResponderPregunta_Click(object sender, EventArgs e)
        {
            if (indiceActual >= preguntas.Count)
            {
                MessageBox.Show("No hay más preguntas.");
                return;
            }

            string respuestaUsuario = txtRespuesta.Text.Trim();
            int idUsuario = SesionUsuario.IdUsuario;
            int idPregunta = preguntas[indiceActual].Id;

            L_ResponderPregunta logica = new L_ResponderPregunta();
            string mensaje;

            bool resultado = logica.ResponderPregunta(idUsuario, idPregunta, respuestaUsuario, out mensaje);

            if (resultado)
            {
                MessageBox.Show("Respuesta guardada correctamente.");
                indiceActual++;
                MostrarPreguntaActual();
                txtRespuesta.Clear();

            }
            else
            {
                MessageBox.Show("Error al guardar: " + mensaje);
            }
        }


        private void MostrarPreguntaActual()
        {
            if (indiceActual < preguntas.Count)
            {
                lblPreguntaLista.Text = preguntas[indiceActual].Pregunta;
                lblProgreso.Text = $"{indiceActual + 1} de {preguntas.Count}";
                txtRespuesta.Clear();
            }
            else
            {
                MessageBox.Show("¡Felicitaciones! Has respondido todas las preguntas.");
                btnResponderPregunta.Enabled = false;
                this.Hide();

                frmCambiarContra cambiarContrasenaForm = new frmCambiarContra();
                DialogResult res = cambiarContrasenaForm.ShowDialog();

                if (res == DialogResult.OK)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }


            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
