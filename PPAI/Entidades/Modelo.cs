using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Entidades
{
    public class Modelo
    {
        string nombre;

        public Modelo()
        {

        }

        public Modelo(string nombre)
        {
            this.nombre = nombre;
        }

        public string mostrarNombre()
        {
            return nombre;
        }
    }
}
