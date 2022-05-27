using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Entidades
{
    public class Usuario
    {
        private string usuario;
        private string clave;

        public Usuario(string nombreUsuario, string password)
        {
            this.usuario = nombreUsuario;
            this.clave = password;
        }

        public string NombreDeUsuario
        {
            get => usuario;
            set => usuario = value;
        }

        public string Password
        {
            get => clave;
            set => clave = value;
        }
    }
}
