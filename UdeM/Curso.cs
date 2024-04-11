using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareUdeM
{
    internal class Curso
    {
        public string nombre { get; set; }
        public int id { get; set; }
        public int aula { get; set; }
        public Profesor profesor { get; set; }
        public List<Estudiante> estudiante { get; set; }
        public Curso(string nombre_, int id_, int aula_, Profesor profesor_, double estudiante_) 
        { 
            nombre = nombre_;
            id = id_;   
            aula = aula_;   
            profesor = profesor_;
            estudiante = estudiante_;
        }
        public void AsignarProfesor(Profesor profesor_)
        {
            this.profesor = profesor_;  
        }
        
        public void AsignarAula(int aula)
        { 
            this.aula = aula;
        }

        public void AgregarEstudiante(Estudiante estudiante_)
        {
            estudiante.Add(estudiante_);
        }

        public void EliminarEstudiante(Estudiante estudiante_)
        {
            if (estudiante.Contains(estudiante_))
                estudiante.Remove(estudiante_);
            else
                Console.WriteLine($"El estudiante {estudiante_.nombre} no se encuentra en este curso")
        }

    }
}
