using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Mostrar Form1 como ventana de login
            frmIniciarSesion form1 = new frmIniciarSesion();
            DialogResult result = form1.ShowDialog();

            // Si el login fue exitoso
            if (result == DialogResult.OK)
            {
                // Obtener el rol desde la propiedad Tag
                string rol = form1.Tag?.ToString();

                // Iniciar la aplicación con el formulario MDI
                Application.Run(new MDIParent1(rol));
            }
            else
            {
                // Si se canceló el login o fue incorrecto, salir de la aplicación
                Application.Exit();
            }
        }
    }
}
