﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Entidades
{
    public class Estado
    {
        private int id;
        private string nombre;
        private string descripcion;
        private string ambito;
        private bool esReservable;
        private bool esCancelable;

        public int Id
        {
            get => id; set => id = value; 
        }

        public string Nombre 
        { 
            get => nombre;
            set => nombre = value;
        }

        public string Descripcion 
        { 
            get => descripcion; set => descripcion = value; 
        }

        public string Ambito
        {
            get => ambito; set => ambito = value;
        }

        public bool EsReservable
        {
            get => esReservable; set => esReservable = value;
        }

        public bool EsCancelable
        {
            get => esCancelable; set => esCancelable = value;
        }

        public Estado(int id, string nombre, string descripcion, string ambito, bool esReservable, bool esCancelable)
        {
            this.id = id;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.ambito = ambito;
            this.esReservable = esReservable;
            this.esCancelable = esCancelable;
        }

        public bool esDisponible(Estado e)
        {
            if (e.Ambito.Equals("Recurso Tecnologico") && e.Nombre.Equals("Disponible"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
