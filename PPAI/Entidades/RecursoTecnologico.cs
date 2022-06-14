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
                        return true;
                    }
                }
            }

            return false;
        }

        public int mostrarDatosRT(RecursoTecnologico rt)
        {
            string marca;
            //modelo, marca = mostrarMarcaYModelo(rt);
            return rt.NumeroRT;
        }
    }
}
