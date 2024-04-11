wusing System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareUdeM
{
    internal class Administrativo : Usuario
    {
        private string cargo;
        public List<Estudiante> estudiantes_matriculados;
        public List<Profesor> profesores_universidad;



        public Administrativo(string nombre_, int id_, string Correo_, string cargo_, double estudiantes_matriculados_, double profesores_universidad_) : base(nombre_, id_, Correo_)
        {
            estudiantes_matriculados = estudiantes_matriculados_;
            cargo = cargo_;
            profesores_universidad = profesores_universidad_;
        }
    }

        public void AgregarEstudiante(Estudiante nuevoEstudiante)
        {
            estudiantes_matriculados.Add(nuevoEstudiante);
        }


        public void CancelarMatricula(Estudiante Estudiante)
        {
            if (estudiantes_matriculados.Contains(Estudiante))
            {
                estudiantes_matriculados.Remove(Estudiante);
                Console.WriteLine($"El estudiante {Estudiante.nombre} ha sido eliminado.");
            }
            else
            {
                Console.WriteLine($"El estudiante {Estudiante.nombre} no se encuentra en la lista.");
            }
        }


        public void AgregarProfesor(Profesor nuevoProfesor)
        {
            profesores_universidad.Add(nuevoProfesor);
        }



        public void EliminarProfesor(Profesor Profesor)
        {
            if (profesores_universidad.Contains(Profesor))
            {
                estudiantes_matriculados.Remove(Profesor);
                Console.WriteLine($"El estudiante {Profesor.nombre} ha sido eliminado.");
            }
            else
            {
                Console.WriteLine($"El estudiante {Profesor.nombre} no se encuentra en la lista.");
            }
        }

        public void CrearAsignatura(string nombre, int curso)
         {
            Asignatura asignatura=new Asignatura(nombre,curso)
         }

           
}
