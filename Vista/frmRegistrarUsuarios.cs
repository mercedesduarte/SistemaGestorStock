using Logica;
using Sesion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Vista
{
    public partial class frmRegistrarUsuarios : Form
    {
        public frmRegistrarUsuarios()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmRegistrarUsuarios_Load(object sender, EventArgs e)
        {
            L_Lista logica = new L_Lista();
            var personas = logica.ObtenerPersonasParaCombo();
            var roles = logica.ObtenerRolesParaCombo();

            cbPersona.DataSource = personas;
            cbRolUsuario.DataSource = roles;
            cbPersona.DisplayMember = "Value";
            cbPersona.ValueMember = "Key";
            cbRolUsuario.DisplayMember = "Value";
            cbRolUsuario.ValueMember = "Key";
        }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                errorProvider1.SetError(txtUsuario, "El nombre de usuario no puede estar vacío.");
                return;
            }
            if(cbPersona.SelectedIndex == -1)
            {
                errorProvider1.SetError(cbPersona, "Debe seleccionar una persona.");
                return;
            }
            if(cbRolUsuario.SelectedIndex == -1)
            {
                errorProvider1.SetError(cbRolUsuario, "Debe seleccionar un rol.");
                return;
            }
            L_Lista lcorreo = new L_Lista();
            int id_persona = (int)cbPersona.SelectedValue;
            string usuario = txtUsuario.Text.Trim();
            int id_rol = (int)cbRolUsuario.SelectedValue;

            string correo = lcorreo.ObtenerCorreoPorId(id_persona);
            string contrasena = GeneradorContraseña.Generar(6);
            string contra_enctriptada = HashconUsu.Hashconusu(usuario, contrasena);

            L_RegistrarUsuario logica = new L_RegistrarUsuario();
            bool registrado = logica.RegistrarUsuario(id_persona, usuario, id_rol, contra_enctriptada);

            if (registrado)
            {
                Sesion.ArmarMail.DireccionCorreo = correo;
                Sesion.ArmarMail.Asunto = "Credenciales de acceso - Sistema de Gestión";
                Sesion.ArmarMail.ContrasenaSistema = contrasena;

                Sesion.ArmarMail.Preparar();

                MessageBox.Show("Usuario creado y correo enviado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al registrar el usuario. Revisá la consola para más detalles.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void cbPersona_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
