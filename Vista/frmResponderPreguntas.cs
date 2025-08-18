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
        private List<PreguntaVista> _preguntas;
        private int _indiceActual = 0;
        private bool _todasRespondidas = false;

        public frmResponderPreguntas()
        {
            InitializeComponent();
            this.FormClosing += (sender, e) =>
            {
                if (!_todasRespondidas && this.DialogResult != DialogResult.OK)
                {
                    e.Cancel = true;
                }
            };
        }

        private void frmResponderPreguntas_Load(object sender, EventArgs e)
        {
            var logica = new L_ListarPreguntas();
            _preguntas = logica.ListarPreguntas();

            if (_preguntas.Count == 0)
            {
                MessageBox.Show("No hay preguntas disponibles.");
                this.Close();
                return;
            }

            MostrarPreguntaActual();
        }

        private void btnResponderPregunta_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRespuesta.Text))
            {
                errorProvider1.SetError(txtRespuesta, "La respuesta no puede estar vacía.");
                return;
            }

            var logica = new L_ResponderPregunta();
            string mensaje;

            bool resultado = logica.ResponderPregunta(
                SesionUsuario.IdUsuario,
                _preguntas[_indiceActual].Id,
                txtRespuesta.Text,
                out mensaje
            );

            if (!resultado)
            {
                errorProvider1.SetError(txtRespuesta, mensaje);
                return;
            }

            _indiceActual++;

            if (_indiceActual >= _preguntas.Count)
            {
                _todasRespondidas = true;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MostrarPreguntaActual();
                txtRespuesta.Clear();
            }
        }

        private void MostrarPreguntaActual()
        {
            lblPreguntaLista.Text = _preguntas[_indiceActual].Pregunta;
            lblProgreso.Text = $"{_indiceActual + 1} de {_preguntas.Count}";
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            var confirmacion = MessageBox.Show(
                "¿Estás seguro de salir sin completar las preguntas?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirmacion == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }
    }
}