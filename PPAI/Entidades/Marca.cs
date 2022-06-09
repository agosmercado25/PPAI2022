using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Entidades
{
    public class Marca
    {
        string nombre;
        List<Modelo> modelos;

        public Marca()
        {

        }

        public Marca(string nombre, List<Modelo> modelos)
        {
            this.nombre = "marca1";
            this.modelos = modelos;
        }

        public string mostrarMisMarcas()
        {
            return this.nombre;
        }
    }
}
