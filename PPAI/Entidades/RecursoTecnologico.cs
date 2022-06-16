using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Entidades
{
    public class RecursoTecnologico
    {
        private int numeroRT;
        private DateTime fechaAlta;
        private string imagenes;
        private int periodicidadMantenimientoPrev;
        private int duracionMantenimientoPrev;
        private int fraccionHorarioTurnos;
        private List<Turno> turnos;
        private TipoRecursoTecnológico tipoRecurso;
        private Modelo modelo;
        private List<CambioEstadoRT> cambioEstado;
        private List<Mantenimiento> mantenimiento;
        private CambioEstadoRT cambioEstadoActual;
        private List<CambioEstadoTurno> cambioEstadoTurno;

        public int NumeroRT
        {
            get => numeroRT; set => numeroRT = value;
        }

        public DateTime FechaAlta
        {
            get => fechaAlta; set => fechaAlta = value;
        }

        public string Imagenes
        {
            get => imagenes; set => imagenes = value;
        }

        public int Periodicidad
        {
            get => periodicidadMantenimientoPrev; set => periodicidadMantenimientoPrev = value;
        }

        public int Duracion
        {
            get => duracionMantenimientoPrev; set => duracionMantenimientoPrev = value;
        }

        public int FraccionHorarioTurno
        {
            get => fraccionHorarioTurnos; set => fraccionHorarioTurnos = value;
        }

        public List<Turno> Turnos
        {
            get => turnos; set => turnos = value;
        }

        public TipoRecursoTecnológico TipoRecurso
        {
            get => tipoRecurso; set => tipoRecurso = value;
        }

        public Modelo Modelo
        {
            get => modelo; set => modelo = value;
        }

        public List<CambioEstadoRT> CambioEstado
        {
            get => cambioEstado; set => cambioEstado = value;
        }

        public RecursoTecnologico()
        {

        }

        public RecursoTecnologico(int numeroRT, DateTime fechaAlta, string imagenes, int periodicidadMantenimientoPrev, int duracionMantenimientoPrev, int fraccionHorarioTurnos, List<Turno> turnos, TipoRecursoTecnológico tipoRecurso, Modelo modelo, List<CambioEstadoRT> cambioEstado)
        {
            this.numeroRT = numeroRT;
            this.fechaAlta = fechaAlta;
            this.imagenes = imagenes;
            this.periodicidadMantenimientoPrev = periodicidadMantenimientoPrev;
            this.duracionMantenimientoPrev = duracionMantenimientoPrev;
            this.fraccionHorarioTurnos = fraccionHorarioTurnos;
            this.turnos = turnos;
            this.tipoRecurso = tipoRecurso;
            this.modelo = modelo;
            this.cambioEstado = cambioEstado;
        }

        public bool esDisponible(RecursoTecnologico rt)
        {
            cambioEstado = rt.CambioEstado;
            for (int i = 0; i < cambioEstado.Count; i++)
            {
                bool esActual = cambioEstado[i].esActual(cambioEstado[i]);
                if (esActual)
                {
                    bool esDisp = cambioEstado[i].esDisponible(cambioEstado[i]);
                    if (esDisp)
                    {
                        this.cambioEstadoActual = cambioEstado[i];
                        return true;
                    }
                }
            }
            
            return false;
        }

        public (int,string,string,string) mostrarDatosRT(RecursoTecnologico rt)
        {
            int num = getNumero(rt);
            string tipo = rt.TipoRecurso.getNombre().Nombre;
            (string marca, string modelo) = rt.Modelo.mostrarMarcaYModelo();
            
            return (num,tipo,marca,modelo);
        }

        public int getNumero(RecursoTecnologico rt)
        {
            return rt.NumeroRT;
        }

        public List<Turno> obtenerTurnosCancelablesEnPeriodo(RecursoTecnologico rt, int dia, int mes)
        {
            List<Turno> turnoList = new List<Turno>();
            for (int i = 0; i < rt.Turnos.Count; i++)
            {
                CambioEstadoTurno esT = Turnos[i].esCancelableEnPeriodo(Turnos[i], dia, mes);
                if (esT != null)
                {
                    cambioEstadoTurno.Add(esT);
                    turnoList.Add(Turnos[i]);
                }
            }
            return turnoList;
         }

        public List<Turno> mostrarTurnosReserva(List<Turno> turnos)
        {
            for (int i = 0; i < turnos.Count; i++)
            {
                bool esReser = turnos[i].esConReserva(turnos[i]);
                if (!esReser)
                {
                    turnos.Remove(turnos[i]);
                }
            }
            
            for (int i = 0; i < turnos.Count; i++)
            {
                (DateTime fechaHora, string nombreCientifico, string mailCientifico) = turnos[i].mostrarDatosTurno(turnos[i]);
            }
            return turnos;
        }

        public void ingresarEnMantenimientoCorrectivo(RecursoTecnologico rt, DateTime time, DateTime fechaFinPrev, string motivo)
        {
            rt.cambioEstado.Add(new CambioEstadoRT(time, time, new Estado(6, "EnMantenimientoCorrectivo", "Descripcion", "Recurso Tecnologico", false, true)));
            rt.mantenimiento.Add(new Mantenimiento(time, time, fechaFinPrev, motivo));
            
        }

        public void cancelarTurnos(RecursoTecnologico rt, DateTime time)
        {
            for (int i = 0; i < rt.turnos.Count; i++)
            {
                //turnos[i].CambioEstado.cancelarMantenimientoCorrectivo(cambioEstado);
                turnos[i].CambioEstado.Add(new CambioEstadoTurno(time, time, new Estado(5, "CanceladoMantenimientoCorrectivo", "Descripcion", "Turno", true, true)));
            }
        }
    }
}
