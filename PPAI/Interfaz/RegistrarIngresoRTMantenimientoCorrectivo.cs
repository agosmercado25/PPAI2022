using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PPAI.AccesoDatos;
using PPAI.Controlador;
using PPAI.Entidades;

namespace PPAI.Interfaz
{
    public partial class RegistrarIngresoRTMantenimientoCorrectivo : Form
    {
        GestorRegistrarIngresoRTMantenimientoCorrectivo gestor;

        public RegistrarIngresoRTMantenimientoCorrectivo()
        {
            InitializeComponent();
        }

        private void RegistrarIngresoRTMantenimientoCorrectivo_Load(object sender, EventArgs e)
        {
            gestor = new GestorRegistrarIngresoRTMantenimientoCorrectivo(this);
            gestor.registrarIngresoRTMantenimientoCorrectivo();
            MessageBox.Show("Por favor seleccionar un recurso tecnologico");

        }

        private void txtBoxRTDisponibles_TextChanged(object sender, EventArgs e)
        {
            
        }

        public void cargarGrillaRTDisponibles(List<RecursoTecnologico> rt)
        {
            
            try
            {
                grillaRTDisponibles.DataSource = rt;
                
            }
            catch (Exception)
            {

                MessageBox.Show("Error al obtener listado de estados");
            }

            
        }

        private void grillaRTDisponibles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            DataGridViewRow filaseleccionada = grillaRTDisponibles.Rows[indice];
            string numero = filaseleccionada.Cells["numeroRT"].Value.ToString();
            gestor.rtSeleccionado(numero);
            groupBoxFin.Enabled = true;


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        public void solicitarFechaFinPrevista()
        {
            MessageBox.Show("Por favor ingrese la fecha");

        }
    }
}
