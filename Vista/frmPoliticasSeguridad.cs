using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


//Capas
using Logica;
using Servicios;
using Sesion;
using static L_Restriccion;


namespace Vista
{

    public partial class frmPoliticasSeguridad : Form
    {
        public frmPoliticasSeguridad()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {

            L_Restriccion Restriccion = new L_Restriccion();


            Restriccion.GuardarRestricciones(
                nudMinCaracteres.Value,
                chkMayusMinus.Checked,
                chkNumerosLetras.Checked,
                chkCaracterEspecial.Checked,
                chkEvitarRepetir.Checked,
                chkDatosPersonales.Checked,
               chkAutenticacionDoble.Checked
            );
        }

        private void frmPoliticasSeguridad_Load(object sender, EventArgs e)
        {
            L_Restriccion Restriccion = new L_Restriccion();

            EstadoRestricciones estado = Restriccion.ConseguirRestricciones();

            chkMayusMinus.Checked = estado.MayusMinus == 1;
            chkNumerosLetras.Checked = estado.NumeroLetras == 1;
            chkCaracterEspecial.Checked = estado.CaracterEsp == 1;
            chkEvitarRepetir.Checked = estado.CaracterEsp == 1;
            chkDatosPersonales.Checked = estado.DatosPersonales == 1;
            chkAutenticacionDoble.Checked = estado.DosFA == 1;
            nudMinCaracteres.Value = estado.CaracteresUtilizados;

        }

        private void chkNumerosLetras_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
