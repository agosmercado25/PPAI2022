using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Entidades
{
    public class CambioEstadoTurno
    {
        private DateTime fechaHoraDesde;
        private DateTime fechaHoraHasta;
        private Estado estado;

        public DateTime FechaHoraDesde
        {
            get => fechaHoraDesde; set => fechaHoraDesde = value;
        }

        public DateTime FechaHoraHasta
        {
            get => fechaHoraHasta; set => fechaHoraHasta = value;
        }

        public Estado EstadoActual
        {
            get => estado; set => estado = value;
        }

        public CambioEstadoTurno()
        {

        }

        public CambioEstadoTurno(DateTime fechaHoraDesde, DateTime fechaHoraHasta, Estado estado)
        {
            this.fechaHoraHasta = fechaHoraHasta;
            this.estado = estado;
            this.fechaHoraDesde = fechaHoraDesde;
        }

        public bool esActual(CambioEstadoTurno ce)
        {
            if (this.FechaHoraDesde == this.FechaHoraHasta)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool esCancelable(CambioEstadoTurno ce)
        {
            return ce.EstadoActual.sCancelable(EstadoActual);
        }

        public bool esConReserva(CambioEstadoTurno ce)
        {
            bool esReserv = ce.EstadoActual.esReservado(estado);
            bool esPendi = ce.EstadoActual.esPendienteConfirmacionReserva(estado);

            if (esReserv && esPendi)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void setFechaFin()
        {

        }
    }
}
