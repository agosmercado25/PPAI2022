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
            string cientifico = obtenerUsuarioLogueado();
            MessageBox.Show(cientifico.ToString());
        }

        public string obtenerUsuarioLogueado()
        {
            this.sesion = new Sesion();
            this.sesion.mostrarCientifico();
            return this.sesion.ToString();
        }
    }    
}
