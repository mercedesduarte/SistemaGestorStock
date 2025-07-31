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

        
            lblRol.Text = $"CARGO: {rolUsuario}";

            Console.WriteLine($"Rol del usuario: {rolUsuario}");

            AplicarPermisosPorRol(rol);

        }



        private void AplicarPermisosPorRol(string rol)
        {
            switch (rol.ToLower())
            {
                case "administrador":
            
                    break;

                case "usuario normal":
                
                    UsuariosToolStripMenuItem.Enabled = false;
                    UsuariosToolStripMenuItem.Visible = false;

                    PersonasToolStripMenuItem.Enabled = false;
                    PersonasToolStripMenuItem.Visible = false;

                    PoliticasSeguridadToolStripMenuItem.Enabled = false;
                    PoliticasSeguridadToolStripMenuItem.Visible = false;
                    break;               

                default:
               
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
           
            foreach (Form form in this.MdiChildren)
            {
                if (form is frmPoliticasSeguridad)
                {
                    form.BringToFront(); 
                    form.Focus();        
                    return;            
                }
            }

            frmPoliticasSeguridad formularioPoliticas = new frmPoliticasSeguridad();
            formularioPoliticas.MdiParent = this; 
            formularioPoliticas.WindowState = FormWindowState.Maximized; 
            formularioPoliticas.Show(); 

        }

        private void CrearPreguntasSeguridadToolStripMenuItem_Click(object sender, EventArgs e)
        {

            foreach (Form form in this.MdiChildren)
            {
                if (form is frmPreguntasDeSeguridad)
                {
                    form.BringToFront();
                    form.Focus();
                    return;
                }
            }


            frmPreguntasDeSeguridad formularioPreguntas = new frmPreguntasDeSeguridad();
            formularioPreguntas.MdiParent = this; 
            formularioPreguntas.WindowState = FormWindowState.Maximized;
            formularioPreguntas.Show();
        }

        private void ListarPreguntasSeguridadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form is frmListadoPreguntasDeSeguridad)
                {
                    form.BringToFront();
                    form.Focus();
                    return;
                }
            }

     
            frmListadoPreguntasDeSeguridad formularioListado = new frmListadoPreguntasDeSeguridad();
            formularioListado.MdiParent = this; 
            formularioListado.WindowState = FormWindowState.Maximized;
            formularioListado.Show();
        }

        private void CrearUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

            foreach (Form form in this.MdiChildren)
            {
                if (form is frmRegistrarUsuarios)
                {
                    form.BringToFront();
                    form.Focus();
                    return;
                }
            }


            frmRegistrarUsuarios formularioRegistrar = new frmRegistrarUsuarios();
            formularioRegistrar.MdiParent = this; 
            formularioRegistrar.WindowState = FormWindowState.Maximized;
            formularioRegistrar.Show();
        }

        private void AgregarPersonaToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
            foreach (Form form in this.MdiChildren)
            {
                if (form is frmRegistrarPersonas)
                {
                    form.BringToFront();
                    form.Focus();
                    return;
                }
            }

 
            frmRegistrarPersonas formularioPersona = new frmRegistrarPersonas();
            formularioPersona.MdiParent = this; 
            formularioPersona.WindowState = FormWindowState.Maximized;
            formularioPersona.Show();
        }

        private void ListarPersonasToolStripMenuItem_Click(object sender, EventArgs e)
        {
     
            foreach (Form form in this.MdiChildren)
            {
                if (form is frmListadoPersonas)
                {
                    form.BringToFront();
                    form.Focus();
                    return;
                }
            }


            frmListadoPersonas formularioListado = new frmListadoPersonas();
            formularioListado.MdiParent = this; 
            formularioListado.WindowState = FormWindowState.Maximized;
            formularioListado.Show();
        }

        private void ListarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Verifica si ya hay una instancia del formulario abierta
            foreach (Form form in this.MdiChildren)
            {
                if (form is frmListadoUsuarios)
                {
                    form.BringToFront();
                    form.Focus();
                    return;
                }
            }

            // Si no existe una instancia, crear y mostrar una nueva
            frmListadoUsuarios formularioListado = new frmListadoUsuarios();
            formularioListado.MdiParent = this; // Asignar el formulario MDI padre
            formularioListado.WindowState = FormWindowState.Maximized;
            formularioListado.Show();
        }

        private void MDIParent1_Load(object sender, EventArgs e)
        {

        }

        private void ConfiguracionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
