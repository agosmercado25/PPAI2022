﻿using System;
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
        public RegistrarIngresoRTMantenimientoCorrectivo()
        {
            InitializeComponent();
        }

        private void RegistrarIngresoRTMantenimientoCorrectivo_Load(object sender, EventArgs e)
        {
            GestorRegistrarIngresoRTMantenimientoCorrectivo gestor = new GestorRegistrarIngresoRTMantenimientoCorrectivo(this);
            gestor.registrarIngresoRTMantenimientoCorrectivo();
            //obtenerRTDisponibles();
        }

        private void txtBoxRTDisponibles_TextChanged(object sender, EventArgs e)
        {
            
        }

        public void mostrarRTDisponibles(List<RecursoTecnologico> rt)
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
    }
}
