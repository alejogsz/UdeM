namespace SoftwareUdeM
{
    internal class Estudiante : Usuario
    {
        public string carrera;
        public int semestre;
        private Horario horario;
        public List<int> nota;
        public List<Curso> cursos_vistos;
        public List<Curso> cursos;
        public Estudiante(string nombre_, int id_, string Correo_, string carrera_, int semestre_, Horario horario_, List<int> notas_, List<Curso> cursos_vistos_, List<Curso> cursos_) : base(nombre_, id_, Correo_)
        {
            carrera = carrera_;
            semestre = semestre_;
            horario = horario_;
            nota = notas_;
            cursos = cursos_;
            cursos_vistos = cursos_vistos_;
        }

        public void VerCursos()
        {
            foreach (var elemento in cursos)
            {
                Console.WriteLine(elemento.nombre);
            }
        }

        public void VerHorario()
        {
            foreach (var elemento in horario.curso)
            {
                Console.WriteLine(elemento.nombre);
            }
        }

        public void CursosVistos()
        {
            foreach (var elemento in cursos_vistos)
            {
                Console.WriteLine(elemento.nombre);
            }
        }

        public void EscogerCurso(Curso curso)
        {
            cursos.Add(curso);
        }

        public void CancelarCurso(Curso curso)
        {
            if (cursos.Contains(curso))
            {
                cursos.Remove(curso);
                Console.WriteLine($"El curso {curso.nombre} ha sido cancelado.");
            }
            else
            {
                Console.WriteLine($"El curso {curso.nombre} no se encuentra en la lista de cursos.");
            }
        }




    }
