using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareUdeM
{
    internal class Profesor: Usuario
    {
        private int salario;
        public List<Curso> cursos;
        public Horario horario;
        public Profesor(string nombre_, int id_, string Correo_, double cursos_, Horario horario_, int salario_) : base(nombre_, id_, Correo_)
        {
            salario = salario_;
            cursos= cursos_;  
            horario= horario_;
        }


        public void VerCursos()
        {
            foreach (var elemento in cursos)
            {
                Console.WriteLine(elemento.nombre);
            }
        }

        public void AgregarNota(Estudiante estudiante, int nota)
        {
            estudiante.nota.Add(nota);
        }

        public void EliminarNota(Estudiante estudiante, int nota)
        {
            estudiante.nota.Remove(nota);
        }


        public void VerHorario ()
        {
            foreach (var elemento in horario.cu)
            {
                Console.WriteLine(elemento);
            }
        }


    }
