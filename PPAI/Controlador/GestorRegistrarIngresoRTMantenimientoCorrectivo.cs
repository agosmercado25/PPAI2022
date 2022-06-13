using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PPAI.Entidades;
using PPAI.Interfaz;
using PPAI.AccesoDatos;

namespace PPAI.Controlador
{
    public class GestorRegistrarIngresoRTMantenimientoCorrectivo
    {
        private RegistrarIngresoRTMantenimientoCorrectivo pantalla;
        private List<RecursoTecnologico> lisRT;
        private RecursoTecnologico rt;
        private Sesion sesion;
        private Estado estado;
        private List<AsignaciónResponsableTecnicoRT> asigResTecRT;
        private AsignaciónResponsableTecnicoRT ra;
        private PersonalCientifico pc;
        

        public GestorRegistrarIngresoRTMantenimientoCorrectivo()
        {

        }

        public GestorRegistrarIngresoRTMantenimientoCorrectivo(RegistrarIngresoRTMantenimientoCorrectivo pantalla)
        //, RecursoTecnologico rt, Sesion sesion, Estado estado, List<AsignaciónResponsableTecnicoRT> asigResTecRT
        {
            this.pantalla = pantalla;
        //    this.rt = rt;
        //    this.sesion = sesion;
        //    this.estado = estado;
        //    this.asigResTecRT = asigResTecRT;
        }

        public void registrarIngresoRTMantenimientoCorrectivo()
        {
            obtenerUsuarioLogueado();
            PersonalCientifico pc = obtenerPersonalCientifico();
            ra = obtenerRTCientifico(pc);
            lisRT = obtenerRTDisponibles(ra);
            pantalla.mostrarRTDisponibles(lisRT);
        }

        private List<RecursoTecnologico> obtenerRTDisponibles(AsignaciónResponsableTecnicoRT ra)
        {
            lisRT = ra.obtenerRTDisponibles(ra);
            return lisRT;
        }

        public void obtenerUsuarioLogueado()
        {
            this.sesion = Datos.sesion;
            this.sesion.mostrarCientifico(sesion);
        }

        public AsignaciónResponsableTecnicoRT obtenerRTCientifico(PersonalCientifico pc)
        {
            MessageBox.Show(pc.ToString());
            asigResTecRT = Datos.crearAsignaciones();
            //MessageBox.Show(asigResTecRT.ToString());
            for (int i = 0; i < asigResTecRT.Count; i++)
            {
                //if (asigResTecRT[i].PersonalCientifico.ToString() == pc.ToString())
                if (asigResTecRT[i].PersonalCientifico.ToString().Equals(pc.ToString()))
                {
                    //MessageBox.Show(asigResTecRT[i].esAsignacionVigenteCientifico().ToString());
                    bool es = asigResTecRT[i].esAsignacionVigenteCientifico(asigResTecRT[i]);
                    if (es)
                    {
                        ra = asigResTecRT[i];
                    }
                }
            }

            return ra;
        }

        public PersonalCientifico obtenerPersonalCientifico()
        {
            pc = Datos.pc;
            return pc;
            
        }
    }    
}
