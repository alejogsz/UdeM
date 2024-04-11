using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareUdeM
{
    internal class Asignatura
    {
        public string nombre { get; set; }
        public int curso { get; set; }
        public Asignatura (string nombre_, int curso_)
        {
            nombre = nombre_;
            curso = curso_;
        }
    }
}
