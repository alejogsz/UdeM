using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareUdeM
{
    internal class Gestion_de_cursos
    {
    } 
    public void AsignarCurso(Curso curso, Profesor profesor)
    {
        curso.profesor=profesor
        profesor.cursos.Add(curso);
    }

    public void EliminarCurso(Curso curso, Profesor profesor)
    {
        if (profesor.cursos.Contains(curso))
        {
            profesor.cursos.Remove(curso);
            Console.WriteLine($"El curso {curso.nombre} ha sido eliminado.");
        }
        else
        {
            Console.WriteLine($"El curso {curso.nombre} no se encuentra en la lista.");
        }
    }
}
