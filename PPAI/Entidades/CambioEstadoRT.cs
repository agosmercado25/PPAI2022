﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Entidades
{
    public class CambioEstadoRT
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

        public CambioEstadoRT()
        {

        }

        public CambioEstadoRT(DateTime fechaHoraDesde, DateTime fechaHoraHasta, Estado estado)
        {
            this.fechaHoraHasta = fechaHoraHasta;
            this.estado = estado;
            this.fechaHoraDesde = fechaHoraDesde;
        }

        public bool esActual(CambioEstadoRT cambio)
        {
            if (cambio.FechaHoraDesde.Equals(cambio.FechaHoraHasta))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool esDisponible(CambioEstadoRT cambio)
        {
            bool es;
            return es = cambio.EstadoActual.esDisponible(cambio.EstadoActual);
        }

        public void setFechaFin()
        {

        }

        public void cancelarMantenimientoCorrectivo(CambioEstadoRT e)
        {

        }
    }
}
