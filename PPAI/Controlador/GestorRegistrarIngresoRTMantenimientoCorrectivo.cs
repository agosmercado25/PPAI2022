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
        private List<string> datos;




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
            PersonalCientifico pc = obtenerPersonalCientifico();
            CentroDeInvestigacion ci = Datos.ci;
            //Revisar 
            obtenerUsuarioLogueado(ci);

            ra = obtenerRTCientifico(pc);
            //Obtener RTDisponibles para la asignacion responsable tecnico RT
            (lisRT, datos) = obtenerRTDisponibles(ra);
            //ordenarYAgruparRTPorCI()
            pantalla.cargarGrillaRTDisponibles(lisRT);
            pantalla.solicitarSeleccionRT();
        }       

        public void obtenerUsuarioLogueado(CentroDeInvestigacion ci)
        {
            this.sesion = Datos.sesion;
            this.sesion.mostrarCientifico(sesion);
            //bool esLogueadoCI = ci.esDeCentroDeInvestigacion(ci, sesion);
            //if (esLogueadoCI)
            //{
            //    MessageBox.Show(sesion.ToString());
            //}
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

        private (List<RecursoTecnologico>, List<string>) obtenerRTDisponibles(AsignaciónResponsableTecnicoRT ra)
        {
            (lisRT, datos) = ra.obtenerRTDisponibles(ra);
            return (lisRT,datos);
        }

        public PersonalCientifico obtenerPersonalCientifico()
        {
            pc = Datos.pc;
            return pc;
            
        }

        public void OrdenarYAgruparRTPorCI(List<string[]> listaDatos)
        {
            //listaDatos.Sort((x, y) => x[1].CompareTo(y[1]));
            //lisRT.Sort((x, y) => x.ObtenerCI().GetNombre().CompareTo(y.ObtenerCI().GetNombre()));
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
        }

        public DateTime obtenerFechaHora()
        {
            return timeActual = DateTime.Now;
        }

        public List<Turno> obtenerTurnosRTCancelables()
        {
            //List<Turno> listaTurnos = this.rtSelec.Turnos;
            //for (int i = 0; i < listaTurnos.Count; i++)
            //{
            //    List<CambioEstadoTurno> listaCambio = listaTurnos[i].CambioEstado;
            //    for (int j = 0; j < listaCambio.Count; j++)
            //    {
            //        if (listaCambio[i].FechaHoraDesde == listaCambio[i].FechaHoraHasta)
            //        {
            //            MessageBox.Show("desde" + listaCambio[i].FechaHoraDesde);
            //            MessageBox.Show("Hasta" + listaCambio[i].FechaHoraDesde);
            //        }
            //        Estado estados = listaCambio[i].EstadoActual;
            //        //MessageBox.Show(estados.Nombre.ToString());
            //    }
            //    //MessageBox.Show(listaTurnos.Count.ToString());
            //}

            listaTurnos = this.rtSelec.obtenerTurnosCancelablesEnPeriodo(this.rtSelec, fechaFinPrevistaSeleccionada.Day, fechaFinPrevistaSeleccionada.Month);
            return listaTurnos;
        }

        public void obtenerReservasVigentes()
        {
            this.rtSelec.mostrarTurnosReserva(listaTurnos);
            //pantalla.cargarGrillaTurnos(listaTurnos);
            //return listaTurnos;
        }

        public void agruparPorCientifico()
        {

        }

        public void ingresarRTMantenimientoCorrectivo()
        {
            rtSelec.ingresarEnMantenimientoCorrectivo(rtSelec, timeActual, fechaFinPrevistaSeleccionada, razonMantenimientoIngresado);
            rtSelec.cancelarTurnos(rtSelec, timeActual);
        }

        public void obtenerEstado()
        {
            List<Estado> listaEstado = Datos.conocerEstados();
            for (int i = 0; i < listaEstado.Count; i++)
            {
                bool esAT = listaEstado[i].esAmbitoTurno(listaEstado[i]);
                bool esCMC = listaEstado[i].esCanceladoMantenimientoCorrectivo(listaEstado[i]);
                bool esART = listaEstado[i].esAmbitoRT(listaEstado[i]);
                bool esEnMC = listaEstado[i].esEnMantenimientoCorrectivo(listaEstado[i]);
            }
        }

        public void generarMail()
        {

        }
    }    
}
