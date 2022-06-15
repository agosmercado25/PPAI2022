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
            

        }

        private void txtBoxRTDisponibles_TextChanged(object sender, EventArgs e)
        {
            
        }

        public bool cargarGrillaRTDisponibles(List<RecursoTecnologico> rts)
        {
            try
            {
                grillaRTDisponibles.DataSource = rts;
                this.Show();
                MessageBox.Show("Por favor seleccionar un recurso tecnologico");
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al obtener listado de estados");
                return false;
            }            
        }

        private void grillaRTDisponibles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            DataGridViewRow filaseleccionada = grillaRTDisponibles.Rows[indice];
            string numero = filaseleccionada.Cells["numeroRT"].Value.ToString();
            gestor.rtSeleccionado(numero);
            groupBoxFin.Enabled = true;
            MessageBox.Show("Ingresar fecha fin prevista y motivo de mantenimiento");
            txtFechaFinPrevista.Focus();

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

        private void btnFechaRazon_Click(object sender, EventArgs e)
        {
            if (txtFechaFinPrevista.Text.Equals("") || txtRazon.Text.Equals(""))
            {
                MessageBox.Show("Ingresar los datos solicitados.");
            }
            else
            {
                DateTime fechaFin = DateTime.Parse(txtFechaFinPrevista.Text.Trim());
                string motivoMantenimiento = txtRazon.Text;
                gestor.fechaFinPrevista(fechaFin);
                gestor.razonMantenimiento(motivoMantenimiento);
                List<Turno> turnos = gestor.obtenerTurnosRTCancelables();
                TurnosRT ventanaTurnos = new TurnosRT();
                ventanaTurnos.cargarGrillaTurnos(turnos);
                ventanaTurnos.Show();
            }
            
        }
    }
}
