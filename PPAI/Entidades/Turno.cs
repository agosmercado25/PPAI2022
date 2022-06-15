using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Entidades
{
    public class Turno
    {
        private int id;
        private DateTime fechaGeneracion;
        private string diaSemana;
        private DateTime fechaHoraInicio;
        private DateTime fechaHoraFin;
        private List<CambioEstadoTurno> cambioEstado;

        public int Id
        {
            get => id; set => id = value;
        }

        public string DiaSemana
        {
            get => diaSemana;
            set => diaSemana = value;
        }

        public DateTime FechaHoraInicio
        {
            get => fechaHoraInicio; set => fechaHoraInicio = value;
        }

        public DateTime FechaHoraFin
        {
            get => fechaHoraFin; set => fechaHoraFin = value;
        }

        public DateTime FechaGeneracion
        {
            get => fechaGeneracion; set => fechaGeneracion = value;
        }
        public List<CambioEstadoTurno> CambioEstado
        {
            get => cambioEstado; set => cambioEstado = value;
        }

        public Turno()
        {

        }

        public Turno(int id, DateTime fechaGeneracion, string diaSemana, DateTime fechaHoraInicio, DateTime fechaHoraFin, List<CambioEstadoTurno> cambioEstado)
        {
            this.fechaGeneracion = fechaGeneracion;
            this.diaSemana = diaSemana;
            this.fechaHoraInicio = fechaHoraInicio;
            this.fechaHoraFin = fechaHoraFin;
            this.cambioEstado = cambioEstado;
            
            
        }

        public bool esCancelableEnPeriodo(Turno turno, int dia, int mes)
        {
            bool es = esDePeriodo(turno, dia, mes);
            if (es)
            {
                for (int i = 0; i < cambioEstado.Count; i++)
                {
                    bool esAc = cambioEstado[i].esActual(cambioEstado[i]);
                    if (esAc)
                    {
                        bool esCan = cambioEstado[i].esCancelable(cambioEstado[i]);
                        if (esCan)
                        {
                            return true;
                        }
                    }
                    return false;
                }
                return false;
            }
            return false;
        }

        private bool esDePeriodo(Turno turno, int dia, int mes)
        {
            if (turno.fechaHoraFin.Month <= mes && turno.fechaHoraFin.Day <= dia)
            {
                return true;
            }

            return false;
        }
    }
}
