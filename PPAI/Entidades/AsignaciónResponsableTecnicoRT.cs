using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Entidades
{
    public class AsignaciónResponsableTecnicoRT
    {
        private DateTime fechaDesde;
        private DateTime fechaHasta;
        private List<RecursoTecnologico> rt;
        private PersonalCientifico personal;

        public DateTime FechaDesde
        {
            get => fechaDesde;
            set => fechaDesde = value;
        }

        public DateTime FechaHasta
        {
            get => fechaHasta;
            set => fechaHasta = value;
        }

        public List<RecursoTecnologico> RT
        {
            get => rt;
            set => rt = value;
        }

        public PersonalCientifico PersonalCientifico
        {
            get => personal; set => personal = value;
        }

        public AsignaciónResponsableTecnicoRT()
        {

        }
        public AsignaciónResponsableTecnicoRT(DateTime fechaDesde, DateTime fechaHasta, List<RecursoTecnologico> rt, PersonalCientifico personal)
        {
            this.fechaDesde = fechaDesde;
            this.fechaHasta = fechaHasta;
            this.rt = rt;
            this.personal = personal;
        }
        
        public bool esAsignacionVigenteCientifico(AsignaciónResponsableTecnicoRT asignaciones)
        {
            return esViegente(asignaciones);
        }

        private bool esViegente(AsignaciónResponsableTecnicoRT asignaciones)
        {
            if (asignaciones.FechaHasta.Equals(asignaciones.FechaDesde))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<RecursoTecnologico> obtenerRTDisponibles(AsignaciónResponsableTecnicoRT ra)
        {
            rt = ra.RT;
            for (int i = 0; i < rt.Count; i++)
            {
                bool esDispo = rt[i].esDisponible(rt[i]);
                if (!esDispo)
                {
                    rt.RemoveAt(i);
                }
            }

            return rt;
        }
    }
}
