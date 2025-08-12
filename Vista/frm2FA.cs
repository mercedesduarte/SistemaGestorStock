using Logica;
using Sesion;
using System;
using System.Windows.Forms;

namespace Vista
{
    public partial class frm2FA : Form
    {
        public int Id_Usuario { get; set; }
        public frm2FA()
        {
            InitializeComponent();
        }

        private void frm2FA_Load(object sender, EventArgs e)
        {
            label1.Text = "Ingrese el código de verificación enviado a su correo electrónico.";
            button1.Text = "Verificar";
            label2.Text = Id_Usuario.ToString();

            string codigo = GeneradorContraseña.Generar(6);

            // Instancia de la lógica para buscar email
            L_BuscarUsuario logicaBuscar = new L_BuscarUsuario();

            // Obtener el correo del usuario
            string correo = logicaBuscar.ObtenerCorreoPorId(Id_Usuario);


            if (string.IsNullOrEmpty(correo))
            {
                MessageBox.Show("No se encontró correo para el usuario.");
                return;
            }

            // Asignar valores a Sesion.ArmarMail
            Sesion.ArmarMail.DireccionCorreo = correo;
            Sesion.ArmarMail.Asunto = "Credenciales de acceso - Sistema de Gestión";
            Sesion.ArmarMail.ContrasenaSistema = codigo;

            // Acá llamás tu lógica para enviar el mail, ejemplo:
            L_CrearCodigo2FA logica2FA = new L_CrearCodigo2FA();
            var fechaHoy = DateTime.Now;
            logica2FA.CrearCodigo2FA(Id_Usuario, codigo, fechaHoy);

            // Opcional: informar que el mail fue enviado
            MessageBox.Show("Código enviado al correo: " + correo);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string codigoIngresado = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(codigoIngresado))
            {
                MessageBox.Show("Por favor, ingrese el código.");
                return;
            }

            L_VerificarCodigo2FA logicaVerificar = new L_VerificarCodigo2FA();


            bool esValido = logicaVerificar.VerificarCodigo(Id_Usuario, codigoIngresado);

            if (esValido)
            {
                MessageBox.Show("Código verificado correctamente.");

                frmCambiarContra formcc = new frmCambiarContra();

                this.Hide();

                DialogResult res = formcc.ShowDialog();

                if (res == DialogResult.OK)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    this.Show();
                }
            }
            else
            {
                MessageBox.Show("Código incorrecto. Intente nuevamente.");
            }
        }
    }
}
