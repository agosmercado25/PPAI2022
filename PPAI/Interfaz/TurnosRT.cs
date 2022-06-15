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
    public partial class TurnosRT : Form
    {
        public TurnosRT()
        {
            InitializeComponent();
        }

        private void TurnosRT_Load(object sender, EventArgs e)
        {
            if (btnConfirmar.Enabled == true)
            {
                solicitarConfirmacion();
            }
            
        }

        public void cargarGrillaTurnos(List<Turno> turnos)
        {
            try
            {
                MessageBox.Show(turnos.Count.ToString());
                grillaTurnos.DataSource = turnos;
            }
            catch (Exception)
            {

                MessageBox.Show("Error al obtener listado de estados");
            }
        }

        public void solicitarConfirmacion()
        {
            MessageBox.Show("Por favor confirme.");
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
