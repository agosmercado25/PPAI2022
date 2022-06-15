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
            //List<object> lista = new List<object>();
            //for (int i = 0; i < rts.Count; i++)
            //{
            //    lista.Add(rts[i].NumeroRT);
            //    lista.Add(rts[i].TipoRecurso);
            //    lista.Add(rts[i].Modelo);
            //    MessageBox.Show(lista);
                
            //}
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
            DateTime fechaFin = DateTime.Parse(txtFechaFinPrevista.Text.Trim());
            string motivoMantenimiento = txtRazon.Text;
            gestor.fechaFinPrevista(fechaFin);
            gestor.razonMantenimiento(motivoMantenimiento);
            grupoTurnos.Enabled = true;
            gestor.obtenerTurnosRTCancelables();
        }

        public void cargarGrillaTurnos(List<Turno> turnos)
        {
            try
            {
                grillaTurnos.DataSource = turnos;
            }
            catch (Exception)
            {

                MessageBox.Show("Error al obtener listado de estados");
            }
        }
    }
}
