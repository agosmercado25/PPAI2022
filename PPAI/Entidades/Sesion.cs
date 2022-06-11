using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PPAI.Entidades
{
    public class Sesion
    {
        DateTime fechaHoraFin;
        DateTime fechaHoraInicio;
        Usuario usuarioSeleccionado;

        public Sesion()
        {

        }

        public Sesion(DateTime fechaHoraFin, DateTime fechaHoraInicio, Usuario usuarioSeleccionado)
        {
            this.fechaHoraFin = fechaHoraFin;
            this.fechaHoraInicio = fechaHoraInicio;
            this.usuarioSeleccionado = usuarioSeleccionado;
        }

        public bool esTuUsuario(string nombreUsuario, string contraseña)
        {
            Usuario logueado = new Usuario(nombreUsuario, contraseña);
            bool usu = logueado.esUsuario(nombreUsuario);
            if (usu)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string mostrarCientifico()
        {
            this.usuarioSeleccionado = new Usuario();
            this.usuarioSeleccionado.obtenerPersonal();
            return this.usuarioSeleccionado.ToString();
            
        }
    }
}
