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
    public partial class frmResponderPreguntas : Form
    {
        private List<PreguntaVista> preguntasAleatorias;
        private int indicePreguntaActual = 0;
        private L_ResponderPreguntas lpreguntas = new L_ResponderPreguntas();
        public frmResponderPreguntas()
        {
            InitializeComponent();
        }

        private void frmResponderPreguntas_Load(object sender, EventArgs e)
        {
            preguntasAleatorias = lpreguntas.ObtenerPreguntaAleatoria(3); // o el número que quieras

            if (preguntasAleatorias.Count > 0)
            {
                MostrarPreguntaActual();
            }
            else
            {
                MessageBox.Show("No hay preguntas disponibles.");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnResponderPregunta_Click(object sender, EventArgs e)
        {
            {
                string respuestaUsuario = txtRespuesta.Text.Trim().ToLower();
                string respuestaCorrecta = preguntasAleatorias[indicePreguntaActual].Respuesta.ToLower();

                if (lpreguntas.ResponderPregunta(respuestaUsuario, respuestaCorrecta))
                {
                    MessageBox.Show("¡Respuesta correcta!");

                    indicePreguntaActual++;

                    if (indicePreguntaActual < preguntasAleatorias.Count)
                    {
                        MostrarPreguntaActual();
                        txtRespuesta.Clear();
                    }
                    else
                    {
                        MessageBox.Show("¡Has respondido todas las preguntas!");
                        btnResponderPregunta.Enabled = false;
                    }
                }
                else
                {
                    MessageBox.Show("Respuesta incorrecta. Intenta nuevamente.");
                }
            }
        }


        private void MostrarPreguntaActual()
        {
            lblPreguntaLista.Text = preguntasAleatorias[indicePreguntaActual].Pregunta;
        }
    }
}
