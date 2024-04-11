using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareUdeM
{
    internal class Gestion_notas
    {
        public Estudiante estudiante;

        public Gestion_notas(Estudiante Estudiante_)
        {
            estudiante = Estudiante_;
        }
        public void Mostrar_notas(Estudiante estudiante)
        {
            foreach (var elemento in estudiante.nota)
            {
                Console.WriteLine(elemento);
            }
        }

        public void Agregar_nota(Estudiante estudiante,int nota) 
        {
            estudiante.nota.Add(nota);
        }

        public void eliminar_notas(Estudiante estudiante,int nota) 
        {
            estudiante.nota.Remove(nota);
        }
    }

}
