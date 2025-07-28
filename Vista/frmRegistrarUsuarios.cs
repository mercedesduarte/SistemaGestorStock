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
using System.Data.SqlClient;


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
            int id_persona = (int)cbPersona.SelectedValue;
            string usuario = txtUsuario.Text.Trim();
            int id_rol = (int)cbRolUsuario.SelectedValue;

            L_RegistrarUsuario logica = new L_RegistrarUsuario();
            var usuarios = logica.RegistrarUsuario(id_persona, usuario, id_rol);
        }

        private void cbPersona_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
