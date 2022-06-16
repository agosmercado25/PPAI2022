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
        private RecursoTecnologico rtSelec;
        private DateTime fechaFinPrevistaSeleccionada;
        private DateTime timeActual;
        private string razonMantenimientoIngresado;
        private List<Turno> listaTurnos;
        private Estado esConfMCorr;
        private Estado esEnMCorr;




        public GestorRegistrarIngresoRTMantenimientoCorrectivo()
        {

        }

        public GestorRegistrarIngresoRTMantenimientoCorrectivo(RegistrarIngresoRTMantenimientoCorrectivo pantalla)
        {
            this.pantalla = pantalla;
        }

        public void registrarIngresoRTMantenimientoCorrectivo()
        {
            PersonalCientifico pc = obtenerPersonalCientifico();
            CentroDeInvestigacion ci = Datos.ci;
            //Revisar 
            obtenerUsuarioLogueado(ci);

            ra = obtenerRTCientifico(pc);
            //Obtener RTDisponibles para la asignacion responsable tecnico RT
            (lisRT) = obtenerRTDisponibles(ra);
            //ordenarYAgruparRTPorCI()
            pantalla.cargarGrillaRTDisponibles(lisRT);
            pantalla.solicitarSeleccionRT();
            
        }       

        public void obtenerUsuarioLogueado(CentroDeInvestigacion ci)
        {
            this.sesion = Datos.sesion;
            this.sesion.mostrarCientifico(sesion);
        }

        public AsignaciónResponsableTecnicoRT obtenerRTCientifico(PersonalCientifico pc)
        {
            asigResTecRT = Datos.crearAsignaciones();
            for (int i = 0; i < asigResTecRT.Count; i++)
            {
                if (asigResTecRT[i].PersonalCientifico.ToString().Equals(pc.ToString()))
                {
                    bool es = asigResTecRT[i].esAsignacionVigenteCientifico(asigResTecRT[i]);
                    if (es)
                    {
                        ra = asigResTecRT[i];
                    }
                }
            }
            return ra;
        }

        private List<RecursoTecnologico> obtenerRTDisponibles(AsignaciónResponsableTecnicoRT ra)
        {
            lisRT = ra.obtenerRTDisponibles(ra);
            return lisRT;
        }

        public PersonalCientifico obtenerPersonalCientifico()
        {
            pc = Datos.pc;
            return pc;
            
        }

        public RecursoTecnologico rtSeleccionado(string numero)
        {
            for (int i = 0; lisRT.Count > i; i++)
            {
                if (lisRT[i].NumeroRT.ToString().Equals(numero))
                {
                    rtSelec = lisRT[i];
                }
            }
            return rtSelec;
        }

        public void fechaFinPrevista(DateTime fechaFin)
        {
            this.fechaFinPrevistaSeleccionada = fechaFin;
        }

        public void razonMantenimiento(string razon)
        {
            this.razonMantenimientoIngresado = razon;
            paso();
        }

        public void paso()
        {
            timeActual = obtenerFechaHora();
            listaTurnos = obtenerTurnosRTCancelables();
            obtenerReservasVigentes();

        }

        public DateTime obtenerFechaHora()
        {
            return timeActual = DateTime.Now;
        }

        public List<Turno> obtenerTurnosRTCancelables()
        {
            listaTurnos = this.rtSelec.obtenerTurnosCancelablesEnPeriodo(listaTurnos, fechaFinPrevistaSeleccionada.Day, fechaFinPrevistaSeleccionada.Month);
            return listaTurnos;
        }

        public void obtenerReservasVigentes()
        {
            listaTurnos = this.rtSelec.mostrarTurnosReserva(listaTurnos);
            pantalla.cargarTurnos(listaTurnos);
        }

        public void agruparPorCientifico()
        {

        }

        public void ingresarRTMantenimientoCorrectivo()
        {
            obtenerEstado();
            rtSelec.ingresarEnMantenimientoCorrectivo(timeActual, fechaFinPrevistaSeleccionada, razonMantenimientoIngresado,esConfMCorr);
            rtSelec.cancelarTurnos(timeActual, esConfMCorr);
        }

        public void obtenerEstado()
        {
            List<Estado> listaEstado = Datos.conocerEstados();
            for (int i = 0; i < listaEstado.Count; i++)
            {
                bool esAT = listaEstado[i].esAmbitoTurno(listaEstado[i]);
                bool esCMC = listaEstado[i].esCanceladoMantenimientoCorrectivo(listaEstado[i]);
                if (esAT && esCMC)
                {
                    esConfMCorr = listaEstado[i];
                }
                bool esART = listaEstado[i].esAmbitoRT(listaEstado[i]);
                bool esEnMC = listaEstado[i].esEnMantenimientoCorrectivo(listaEstado[i]);
                if (esAT && esCMC)
                {
                    esEnMCorr = listaEstado[i];
                }
            }
        }

        public void generarMail()
        {
            Notificacion ventanaN = new Notificacion();
            ventanaN.Show();
            ventanaN.cargarDatos(rtSelec,listaTurnos);
        }

        public void finCU()
        {
            
        }
    }    
}
