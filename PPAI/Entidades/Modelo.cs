using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPAI.AccesoDatos;

namespace PPAI.Entidades
{
    public class Modelo
    {
        private int id;
        private string nombre;

        private int Id
        {
            get => id; set => id = value; 
        }

        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }

        public Modelo()
        {

        }

        public Modelo(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }

        public string mostrarMarcaYModelo(RecursoTecnologico rt)
        {
            Marca marca = Datos.marca1;
            string marcaP = marca.mostrarNombre(rt);
            return Nombre;
        }
    }
}
