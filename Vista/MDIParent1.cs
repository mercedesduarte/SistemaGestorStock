using Sesion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vista.frmGI.Categorias;
using Vista.frmGI.Clientes;
using Vista.frmGI.Marcas;
using Vista.frmGI.Presupuesto;
using Vista.frmGI.Productos;
using Vista.frmGI.Proveedores;
using Vista.frmGI.ReporteStock;

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


            if (rol == null)
            {

                frmIniciarSesion loginForm = new frmIniciarSesion();
                loginForm.Show();

                this.Close();

                return;
            }

            switch (rol.ToLower())
            {
                case "administrador":

                    break;

                case "usuario normal":

                    //------------ SISTEMA GESTOR USUARIOS START ------------------

                    //GestionUsuariosToolStripMenuItem.Enabled = false;
                    //GestionUsuariosToolStripMenuItem.Visible = false;
                    CrearUsuarioToolStripMenuItem.Enabled = false;
                    CrearUsuarioToolStripMenuItem.Visible = false;


                    //PersonasToolStripMenuItem.Enabled = false;
                    //PersonasToolStripMenuItem.Visible = false;
                    AgregarPersonaToolStripMenuItem.Enabled = false;
                    AgregarPersonaToolStripMenuItem.Visible = false;


                    PoliticasSeguridadToolStripMenuItem.Enabled = false;
                    PoliticasSeguridadToolStripMenuItem.Visible = false;

                    //ReportesToolStripMenuItem.Enabled = false;
                    //ReportesToolStripMenuItem.Visible = false;

                    CrearPreguntasSeguridadToolStripMenuItem.Enabled = false;
                    CrearPreguntasSeguridadToolStripMenuItem.Visible = false;

                    //------------ SISTEMA GESTOR USUARIOS END --------------------


                    //------------ SISTEMA GESTOR INVENTARIO START ----------------

                    //GestionInventarioToolStripMenuItem.Enabled = false;
                    //GestionInventarioToolStripMenuItem.Visible = false;

                    InsertarMarcaToolStripMenuItem.Enabled = false;
                    InsertarMarcaToolStripMenuItem.Visible = false;

                    InsertarCategoriaToolStripMenuItem.Enabled = false;
                    InsertarCategoriaToolStripMenuItem.Visible = false;

                    InsertarProductoToolStripMenuItem.Enabled = false;
                    InsertarProductoToolStripMenuItem.Visible = false;

                    InsertarProveedoresToolStripMenuItem.Enabled = false;
                    InsertarProveedoresToolStripMenuItem.Visible = false;

                    //------------ SISTEMA GESTOR INVENTARIO END ----------------


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

        //private void ReportesToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    foreach (Form form in this.MdiChildren)
        //    {
        //        if (form is frmLogs)
        //        {
        //            form.WindowState = FormWindowState.Maximized;
        //            form.BringToFront();
        //            form.Focus();
        //            return;
        //        }
        //    }

        //    frmLogs formularioListado = new frmLogs();
        //    formularioListado.MdiParent = this;
        //    formularioListado.WindowState = FormWindowState.Maximized;
        //    formularioListado.Show();
        //}

        private void MensajesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            foreach (Form form in this.MdiChildren)
            {
                if (form is frmMensajes)
                {
                    form.BringToFront();
                    form.Focus();
                    return;
                }
            }


            frmMensajes formMensajes = new frmMensajes();
            formMensajes.MdiParent = this;
            formMensajes.Show();
        }


        private void CerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SesionUsuario.Usuario = null;
            SesionUsuario.IdUsuario = 0;
            SesionUsuario.EsAdmin = false;
            SesionUsuario.Rol = null;

            this.Hide();

            using (frmIniciarSesion loginForm = new frmIniciarSesion())
            {
                DialogResult res = loginForm.ShowDialog();

                if (res == DialogResult.OK && loginForm.Tag != null)
                {
                    this.AplicarPermisosPorRol(loginForm.Tag.ToString());
                    this.Show();
                }
                else
                {
                    Application.Exit();
                }
            }
        }

        private void InicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form child in this.MdiChildren)
            {
                child.Close();
            }
        }

        private void ModificarContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form is frmCambiarContra)
                {
                    form.WindowState = FormWindowState.Maximized;
                    form.BringToFront();
                    form.Focus();
                    return;
                }
            }
            frmCambiarContra frmCambiar = new frmCambiarContra();
            frmCambiar.MdiParent = this;
            frmCambiar.StartPosition = FormStartPosition.Manual;
            frmCambiar.Location = new Point(
                (this.ClientSize.Width - frmCambiar.Width) / 2,
                (this.ClientSize.Height - frmCambiar.Height) / 3
            );

            frmCambiar.Show();
        }

        private void AgregarPersonaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            foreach (Form form in this.MdiChildren)
            {
                if (form is frmRegistrarPersonas)
                {
                    form.WindowState = FormWindowState.Maximized;
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
                    form.WindowState = FormWindowState.Maximized;
                    form.BringToFront();
                    form.Focus();
                    return;
                }
            }


            frmListadoPersonas formularioListadoP = new frmListadoPersonas();
            formularioListadoP.MdiParent = this;
            formularioListadoP.StartPosition = FormStartPosition.Manual;
            formularioListadoP.Location = new Point(
                (this.ClientSize.Width - formularioListadoP.Width) / 2,
                (this.ClientSize.Height - formularioListadoP.Height) / 3
            );

            formularioListadoP.Show();
        }

        private void PoliticasSeguridadToolStripMenuItem_Click(object sender, EventArgs e)
        {

            foreach (Form form in this.MdiChildren)
            {
                if (form is frmPoliticasSeguridad)
                {
                    form.WindowState = FormWindowState.Maximized;
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
                    form.WindowState = FormWindowState.Maximized;
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
                    form.WindowState = FormWindowState.Maximized;
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
                    form.WindowState = FormWindowState.Maximized;
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

        private void ListarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            foreach (Form form in this.MdiChildren)
            {
                if (form is frmListadoUsuarios)
                {
                    form.WindowState = FormWindowState.Maximized;
                    form.BringToFront();
                    form.Focus();
                    return;
                }
            }


            frmListadoUsuarios formularioListado = new frmListadoUsuarios(rolUsuario);
            formularioListado.MdiParent = this;
            formularioListado.WindowState = FormWindowState.Maximized;
            formularioListado.Show();
        }

        private void InsertarMarcaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            foreach (Form form in this.MdiChildren)
            {
                if (form is frmInsertarMarca)
                {
                    form.WindowState = FormWindowState.Maximized;
                    form.BringToFront();
                    form.Focus();
                    return;
                }
            }

            frmInsertarMarca formularioMarca = new frmInsertarMarca();
            formularioMarca.MdiParent = this;
            formularioMarca.WindowState = FormWindowState.Maximized;
            formularioMarca.Show();
        }


        private void ListarMarcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form is frmListadoMarcas)
                {
                    form.WindowState = FormWindowState.Maximized;
                    form.BringToFront();
                    form.Focus();
                    return;
                }
            }

            frmListadoMarcas formularioListado = new frmListadoMarcas();
            formularioListado.MdiParent = this;
            formularioListado.WindowState = FormWindowState.Maximized;
            formularioListado.Show();
        }

        private void InsertarCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form is frmInsertarCategoria)
                {
                    form.WindowState = FormWindowState.Maximized;
                    form.BringToFront();
                    form.Focus();
                    return;
                }
            }
            frmInsertarCategoria formularioCategoria = new frmInsertarCategoria();
            formularioCategoria.MdiParent = this;
            formularioCategoria.WindowState = FormWindowState.Maximized;
            formularioCategoria.Show();
        }

        private void ListarCategoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form is frmListadoCategorias)
                {
                    form.WindowState = FormWindowState.Maximized;
                    form.BringToFront();
                    form.Focus();
                    return;
                }
            }
            frmListadoCategorias formularioListado = new frmListadoCategorias();
            formularioListado.MdiParent = this;
            formularioListado.WindowState = FormWindowState.Maximized;
            formularioListado.Show();

        }

        private void InsertarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form is frmInsertarProducto)
                {
                    form.WindowState = FormWindowState.Maximized;
                    form.BringToFront();
                    form.Focus();
                    return;
                }
            }
            frmInsertarProducto formularioProducto = new frmInsertarProducto();
            formularioProducto.MdiParent = this;
            formularioProducto.WindowState = FormWindowState.Maximized;
            formularioProducto.Show();

        }

        private void ListarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form is frmListadoProductos)
                {
                    form.WindowState = FormWindowState.Maximized;
                    form.BringToFront();
                    form.Focus();
                    return;
                }
            }
            frmListadoProductos formularioListado = new frmListadoProductos();
            formularioListado.MdiParent = this;
            formularioListado.WindowState = FormWindowState.Maximized;
            formularioListado.Show();

        }

        private void InsertarProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form is frmInsertarProveedor)
                {
                    form.WindowState = FormWindowState.Maximized;
                    form.BringToFront();
                    form.Focus();
                    return;
                }
            }
            frmInsertarProveedor formularioProveedor = new frmInsertarProveedor();
            formularioProveedor.MdiParent = this;
            formularioProveedor.WindowState = FormWindowState.Maximized;
            formularioProveedor.Show();

        }

        private void ListarProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form is frmListadoProveedores)
                {
                    form.WindowState = FormWindowState.Maximized;
                    form.BringToFront();
                    form.Focus();
                    return;
                }
            }
            frmListadoProveedores formularioListado = new frmListadoProveedores();
            formularioListado.MdiParent = this;
            formularioListado.WindowState = FormWindowState.Maximized;
            formularioListado.Show();

        }

        private void StockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form is frmControlStock)
                {
                    form.WindowState = FormWindowState.Maximized;
                    form.BringToFront();
                    form.Focus();
                    return;
                }
            }
            frmControlStock formulariostock = new frmControlStock();
            formulariostock.MdiParent = this;
            formulariostock.WindowState = FormWindowState.Maximized;
            formulariostock.Show();
        }

        private void UsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

            foreach (Form form in this.MdiChildren)
            {
                if (form is frmLogs)
                {
                    form.WindowState = FormWindowState.Maximized;
                    form.BringToFront();
                    form.Focus();
                    return;
                }
            }
            frmLogs formulariologs= new frmLogs();
            formulariologs.MdiParent = this;
            formulariologs.WindowState = FormWindowState.Maximized;
            formulariologs.Show();

        }

        private void pRESUPUESTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form is frmEmisionPresupuesto)
                {
                    form.WindowState = FormWindowState.Maximized;
                    form.BringToFront();
                    form.Focus();
                    return;
                }
            }
            frmEmisionPresupuesto formularioemisionP = new frmEmisionPresupuesto();
            formularioemisionP.MdiParent = this;
            formularioemisionP.WindowState = FormWindowState.Maximized;
            formularioemisionP.Show();
        }

        private void InsertarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            foreach (Form form in this.MdiChildren)
            {
                if (form is frmInsertarCliente)
                {
                    form.WindowState = FormWindowState.Maximized;
                    form.BringToFront();
                    form.Focus();
                    return;
                }
            }
            frmInsertarCliente formularioinsertarcliente = new frmInsertarCliente();
            formularioinsertarcliente.MdiParent = this;
            formularioinsertarcliente.WindowState = FormWindowState.Maximized;
            formularioinsertarcliente.Show();

        }
    }
}


