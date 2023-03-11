using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
     public class Licores
    {
        public List<Licor> ListLicores { set; get; }

        public Licores()
        {
            ListLicores = new List<Licor>();
        }
        

        public void Agregar(Licor licor)
        {
            ListLicores.Add(licor);
        }

        public List<Licor> LicorXNom(string nombre)
        {
            List<Licor> aux = new List<Licor>();
            foreach(Licor licor in ListLicores)
            {
                if(licor.Nombre.Equals(nombre))
                {
                    aux.Add(licor);
                }
            }
            return aux;
        }

        public List<Licor> LicorXApell(string apellido)
        {
            List<Licor> aux = new List<Licor>();
            foreach (Licor licor in ListLicores)
            {
                if (licor.Apellido.Equals(apellido))
                {
                    aux.Add(licor);
                }
            }
            return aux;
        }

        public List<Licor> LicorXDir(string direccion)
        {
            List<Licor> aux = new List<Licor>();
            foreach (Licor licor in ListLicores)
            {
                if (licor.Direccion.Equals(direccion))
                {
                    aux.Add(licor);
                }
            }
            return aux;
        }

        public List<Licor> LicorXPre(int precio)
        {
            List<Licor> aux = new List<Licor>();
            foreach (Licor licor in ListLicores)
            {
                if (licor.Precio == precio)
                {
                    aux.Add(licor);
                }
            }
            return aux;
        }

        public List<Licor> LicorXTipo(string tipo)
        {
            List<Licor> aux = new List<Licor>();
            foreach(Licor licor in ListLicores)
            {
                if(licor.Tipo.StartsWith(tipo))
                {
                    aux.Add(licor);
                }
            }
            return aux;
        }

        public List<Licor> LicorXGrado(string grado)
        {
            List<Licor> aux = new List<Licor>();
            foreach (Licor licor in ListLicores)
            {
                if (licor.Tipo.StartsWith(grado))
                {
                    aux.Add(licor);
                }
            }
            return aux;
        }
    }
}
