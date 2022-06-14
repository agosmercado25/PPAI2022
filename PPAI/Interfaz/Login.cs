using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PPAI.Entidades;

namespace PPAI.Interfaz
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            DateTime horaInicio = DateTime.Now;
            Sesion sesionActual = new Sesion(horaInicio, horaInicio, null);
            Usuario se = sesionActual.esTuUsuario(txtNombreUsuario.Text, txtContraseña.Text);

            sesionActual.UsuarioSeleccionado = se;
            //MessageBox.Show(sesionActual.UsuarioSeleccionado.NombreDeUsuario);

            if (se != null)
            {
                Principal menuPrincipal = new Principal();
                menuPrincipal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Los valores ingresados son incorrectos");
            }

            //Usuario usuario = new Usuario(txtNombreUsuario.Text, txtContraseña.Text);

            //string usuarioCorrecto = "admin";
            //string contraseñaCorrecta = "123456";

            //if (txtNombreUsuario.Text.Equals(usuarioCorrecto) && txtContraseña.Text.Equals(contraseñaCorrecta))
            //{
            //    Principal menuPrincipal = new Principal();
            //    menuPrincipal.Show();
            //    this.Hide();
            //}
            //else
            //{
            //    MessageBox.Show("Los valores ingresados son incorrectos");
            //}
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
