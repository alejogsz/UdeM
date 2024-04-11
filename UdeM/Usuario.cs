using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareUdeM
{
    internal class Usuario
    {
        public string nombre;
        public int id;
        public string Correo;
        public Usuario(string nombre_, int id_, string Correo_)
        {
            nombre = nombre_;
            id = id_;
            Correo = Correo_;
        }
    }
}
