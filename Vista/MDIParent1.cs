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
    public partial class MDIParent1 : Form
    {
        private int childFormNumber = 0;


        private string rolUsuario;

        public MDIParent1(string rol)
        {
            InitializeComponent();

            rolUsuario = rol;

            // Mostrar el rol en el Label
            lblRol.Text = $"CARGO: {rolUsuario}";

            Console.WriteLine($"Rol del usuario: {rolUsuario}");

            AplicarPermisosPorRol(rol);

        }



        private void AplicarPermisosPorRol(string rol)
        {
            switch (rol.ToLower())
            {
                case "administrador":
                    // El admin puede ver todo
                    break;

                case "usuario normal":
                    // El usuario común no ve opciones de administración
                    UsuariosToolStripMenuItem.Enabled = false;
                    UsuariosToolStripMenuItem.Visible = false;

                    PersonasToolStripMenuItem.Enabled = false;
                    PersonasToolStripMenuItem.Visible = false;

                    PoliticasSeguridadToolStripMenuItem.Enabled = false;
                    PoliticasSeguridadToolStripMenuItem.Visible = false;
                    break;

                case "invitado":
                    // Invitado ve lo mínimo
                    break;

                default:
                    // Por defecto, ocultar todo por seguridad
                    menuStrip.Enabled = false;
                    break;
            }
        }


        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHoras.Text = DateTime.Now.ToString("HH:mm:ss");
            lblFecha.Text = DateTime.Now.ToString("ddd/dd/MM/yyyy");

        }

        private void PoliticasSeguridadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Verifica si ya hay una instancia del formulario de Políticas de Seguridad abierta dentro del MDI
            foreach (Form form in this.MdiChildren)
            {
                if (form is frmPoliticasSeguridad)
                {
                    form.BringToFront(); // Traer al frente si ya está abierto
                    form.Focus();        // Darle el foco
                    return;              // Salir sin crear una nueva instancia
                }
            }

            // Si no existe una instancia, crear y mostrar una nueva
            frmPoliticasSeguridad formularioPoliticas = new frmPoliticasSeguridad();
            formularioPoliticas.MdiParent = this; // Asignar el formulario MDI padre
            formularioPoliticas.WindowState = FormWindowState.Maximized; // Abrirlo maximizado
            formularioPoliticas.Show(); // Mostrar el formulario

        }

        private void CrearPreguntasSeguridadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Verifica si ya hay una instancia del formulario abierta
            foreach (Form form in this.MdiChildren)
            {
                if (form is frmPreguntasDeSeguridad)
                {
                    form.BringToFront();
                    form.Focus();
                    return;
                }
            }

            // Si no existe una instancia, crear y mostrar una nueva
            frmPreguntasDeSeguridad formularioPreguntas = new frmPreguntasDeSeguridad();
            formularioPreguntas.MdiParent = this; // Asignar el formulario MDI padre
            formularioPreguntas.WindowState = FormWindowState.Maximized;
            formularioPreguntas.Show();
        }

        private void ListarPreguntasSeguridadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Verifica si ya hay una instancia del formulario abierta
            foreach (Form form in this.MdiChildren)
            {
                if (form is frmListadoPreguntasDeSeguridad)
                {
                    form.BringToFront();
                    form.Focus();
                    return;
                }
            }

            // Si no existe una instancia, crear y mostrar una nueva
            frmListadoPreguntasDeSeguridad formularioListado = new frmListadoPreguntasDeSeguridad();
            formularioListado.MdiParent = this; // Asignar el formulario MDI padre
            formularioListado.WindowState = FormWindowState.Maximized;
            formularioListado.Show();
        }

        private void CrearUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Verifica si ya hay una instancia del formulario abierta
            foreach (Form form in this.MdiChildren)
            {
                if (form is frmRegistrarUsuarios)
                {
                    form.BringToFront();
                    form.Focus();
                    return;
                }
            }

            // Si no existe una instancia, crear y mostrar una nueva
            frmRegistrarUsuarios formularioRegistrar = new frmRegistrarUsuarios();
            formularioRegistrar.MdiParent = this; // Asignar el formulario MDI padre
            formularioRegistrar.WindowState = FormWindowState.Maximized;
            formularioRegistrar.Show();
        }

        private void AgregarPersonaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Verifica si ya hay una instancia del formulario abierta
            foreach (Form form in this.MdiChildren)
            {
                if (form is frmRegistrarPersonas)
                {
                    form.BringToFront();
                    form.Focus();
                    return;
                }
            }

            // Si no existe una instancia, crear y mostrar una nueva
            frmRegistrarPersonas formularioPersona = new frmRegistrarPersonas();
            formularioPersona.MdiParent = this; // Asignar el formulario MDI padre
            formularioPersona.WindowState = FormWindowState.Maximized;
            formularioPersona.Show();
        }

        private void ListarPersonasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Verifica si ya hay una instancia del formulario abierta
            foreach (Form form in this.MdiChildren)
            {
                if (form is frmListadoPersonas)
                {
                    form.BringToFront();
                    form.Focus();
                    return;
                }
            }

            // Si no existe una instancia, crear y mostrar una nueva
            frmListadoPersonas formularioListado = new frmListadoPersonas();
            formularioListado.MdiParent = this; // Asignar el formulario MDI padre
            formularioListado.WindowState = FormWindowState.Maximized;
            formularioListado.Show();
        }

    }
}
