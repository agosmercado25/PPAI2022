using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PPAI.Controlador;

namespace PPAI.Interfaz
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btnprobar_Click(object sender, EventArgs e)
        {
            habilitarPantalla();
        }

        private void habilitarPantalla()
        {
            RegistrarIngresoRTMantenimientoCorrectivo ventana = new RegistrarIngresoRTMantenimientoCorrectivo();
            ventana.Show();
            this.Hide();
            GestorRegistrarIngresoRTMantenimientoCorrectivo gestor = new GestorRegistrarIngresoRTMantenimientoCorrectivo();
            
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }
    }
}
