using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    public class Licor
    { 
        public string Nombre { set; get; }
        public string Apellido { set; get; }
        public string Direccion { set; get; }
        public int Precio { set; get; }
        public string Tipo { set; get; }
        public string Grado { set; get; }

        public Licor()
        {
        }

        public Licor(string nombre, string apellido, string direccion, int precio, string tipo, string grado)
        {
            Nombre = nombre;
            Apellido = apellido;
            Direccion = direccion;
            Precio = precio;
            Tipo = tipo;
            Grado = grado;
        }
    }
}
