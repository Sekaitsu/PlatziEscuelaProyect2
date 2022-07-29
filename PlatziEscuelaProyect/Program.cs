using System;
using System.Collections.Generic;
using PlatziEscuelaProyect.Entidades;
using static System.Console;

namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("Platzi Academy", 2012, TiposEscuela.Primaria,
                        ciudad: "Bogotá", pais: "Colombia"
                        );

            //LISTAS
            escuela.Cursos = new List<Curso>()
            {
                new Curso() { Nombre = "101", Jornada = TiposJornada.Mañana },
                new Curso() {Nombre = "201", Jornada = TiposJornada.Mañana},
                new Curso   {Nombre = "301", Jornada = TiposJornada.Mañana}
            };

            escuela.Cursos.Add(new Curso { Nombre = "402", Jornada = TiposJornada.Tarde });
            escuela.Cursos.Add(new Curso { Nombre = "502", Jornada = TiposJornada.Tarde });

            var otrColeccion = new List<Curso>(){
                        new Curso(){ Nombre = "601", Jornada = TiposJornada.Mañana },
                        new Curso() {Nombre = "701", Jornada = TiposJornada.Mañana},
                        new Curso{Nombre = "801", Jornada = TiposJornada.Tarde}
            };

            //Curso tmp = new Curso { Nombre = "101 Vacacional", Jornada = TiposJornada.Noche };
            //escuela.Cursos.Add(tmp);
            //WriteLine("Curso.Hash " + tmp.GetHashCode());

            escuela.Cursos.AddRange(otrColeccion);
            ImpimirCursosEscuela(escuela);

            Predicate<Curso> miAlgoritmo = Predicado;
            escuela.Cursos.RemoveAll(Predicado);

            WriteLine("=======------------======");
            ImpimirCursosEscuela(escuela);
            //otrColeccion.Clear();
        }

        private static bool Predicado(Curso curobj)
        {
            return curobj.Nombre == "301";
        }

        private static void ImpimirCursosEscuela(Escuela escuela) //FUNCIONA POR QUE  USA escuela.Cursos
        {
            WriteLine("====================");
            WriteLine("Cursos de la Escuela");
            WriteLine("====================");

            if (escuela?.Cursos != null)
            {
                foreach (var curso in escuela.Cursos)
                {
                    WriteLine($"Nombre {curso.Nombre}, Id  {curso.UniqueId}");
                }
            }
        }

        //SON ARREGLOS AQUELLOS QUE TIENEN Curso[] por que usaba apuntadores
        private static void ImprimirCursosWhile(Curso[] arregloCursos)
        {
            int contador = 0;
            while (contador < arregloCursos.Length)
            {
                Console.WriteLine($"Nombre {arregloCursos[contador].Nombre}, Id  {arregloCursos[contador].UniqueId}");
                contador++;
            }
        }

        private static void ImprimirCursosDoWhile(Curso[] arregloCursos)
        {
            int contador = 0;
            do
            {
                Console.WriteLine($"Nombre {arregloCursos[contador].Nombre}, Id  {arregloCursos[contador].UniqueId}");
                contador++;
            } while (contador < arregloCursos.Length);
        }

        private static void ImprimirCursosFor(Curso[] arregloCursos)
        {
            for (int i = 0; i < arregloCursos.Length; i++)
            {
                Console.WriteLine($"Nombre {arregloCursos[i].Nombre}, Id  {arregloCursos[i].UniqueId}");
            }
        }

        private static void ImprimirCursosForEach(Curso[] arregloCursos)
        {
            foreach (var curso in arregloCursos)
            {
                Console.WriteLine($"Nombre {curso.Nombre}, Id  {curso.UniqueId}");
            }
        }
    }
}