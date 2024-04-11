using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareUdeM
{
    internal class Horario
    {
        public Estudiante estudiante { get; set; }
        public List<Curso> curso { get; set; }

        public Horario(Estudiante estudiante_, List<Curso> curso_) 
        {
            estudiante = estudiante_;
            curso = curso_;     v
        }

        public void AsignarHorarioProfesor(Profesor profesor, Horario horario)
        {
            profesor.horario = horario;
        }

        public void AsignarHorarioEstudiante(Estudiante estudiante1, Horario horario)
        {
            estudiante1.horario=horario;
        }
    }
}

