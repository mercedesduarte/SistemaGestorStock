using System;
using System.Windows.Forms;
using Sesion;
using Logica;

namespace Vista
{
    public partial class frmUsuarioNombre : Form
    {
        private L_BuscarUsuario logicaBuscar = new L_BuscarUsuario();

        public frmUsuarioNombre()
        {
            InitializeComponent();
        }

        private void frmUsuarioNombre_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombreUsuario = txtNombreUsuario.Text.Trim();

                int? idUsuario = logicaBuscar.ObtenerIdPorUsuario(nombreUsuario);

                if (!idUsuario.HasValue || idUsuario <= 0)
                {
                    MessageBox.Show("Usuario no encontrado.");
                    return;
                }

                string correo = logicaBuscar.ObtenerCorreoPorId(idUsuario.Value);

                if (string.IsNullOrEmpty(correo))
                {
                    MessageBox.Show("No se encontró correo para el usuario.");
                    return;
                }

                string codigo = GeneradorContraseña.Generar(6);

                L_VerificarCodigo2FA logica2FA = new L_VerificarCodigo2FA();
                var (codigoGenerado, idCodigo2FA) = logica2FA.CrearCodigo2FA(idUsuario.Value, codigo);

                if (idCodigo2FA == 0)
                {
                    MessageBox.Show("Error al generar código 2FA.");
                    return;
                }

                Sesion.ArmarMail.DireccionCorreo = correo;
                Sesion.ArmarMail.Asunto = "Credenciales de acceso - Sistema de Gestión";
                Sesion.ArmarMail.ContrasenaSistema = codigoGenerado;
                Sesion.ArmarMail.Preparar();

                MessageBox.Show($"Correo enviado a: {correo} con código 2FA ID: {idCodigo2FA}");

                frm2FA form2fa = new frm2FA
                {
                    Id_Usuario = idUsuario.Value
                };

                this.Hide();

                DialogResult res = form2fa.ShowDialog();

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
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

    }
}
