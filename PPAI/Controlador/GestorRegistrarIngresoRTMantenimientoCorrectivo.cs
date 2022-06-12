using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PPAI.Entidades;
using PPAI.Interfaz;

namespace PPAI.Controlador
{
    public class GestorRegistrarIngresoRTMantenimientoCorrectivo
    {
        RegistrarIngresoRTMantenimientoCorrectivo pantalla;
        RecursoTecnologico rt;
        Sesion sesion;
        Estado estado;
        AsignaciónResponsableTecnicoRT asigResTecRT;


        public GestorRegistrarIngresoRTMantenimientoCorrectivo()
        {

        }

        public GestorRegistrarIngresoRTMantenimientoCorrectivo(RegistrarIngresoRTMantenimientoCorrectivo pantalla, RecursoTecnologico rt, Sesion sesion, Estado estado, AsignaciónResponsableTecnicoRT asigResTecRT)
        {
            this.pantalla = pantalla;
            this.rt = rt;
            this.sesion = sesion;
            this.estado = estado;
            this.asigResTecRT = asigResTecRT;
        }

        public void registrarIngresoRTMantenimientoCorrectivo()
        {
            Sesion cientifico = obtenerUsuarioLogueado();
            
        }

        public Sesion obtenerUsuarioLogueado()
        {
            Sesion sesionActual = new Sesion();
            this.sesion = sesionActual;
            MessageBox.Show("Cientifico" + this.sesion.mostrarCientifico(sesionActual));
            return sesionActual;
        }

    }    
}
