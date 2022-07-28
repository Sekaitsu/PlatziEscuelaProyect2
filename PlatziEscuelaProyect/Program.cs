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
                new Curso(){ Nombre = "101", Jornada = TiposJornada.Mañana },
                new Curso() {Nombre = "201", Jornada = TiposJornada.Mañana},
                new Curso{Nombre = "301", Jornada = TiposJornada.Mañana}
            };
            escuela.Cursos.Add(new Curso { Nombre = "402", Jornada = TiposJornada.Tarde });
            escuela.Cursos.Add(new Curso { Nombre = "502", Jornada = TiposJornada.Tarde });

            //ARREGLO
            //escuela.Cursos = new Curso[]
            //{
            //    new Curso(){ Nombre = "101", Jornada = TiposJornada.Mañana },
            //    new Curso() {Nombre = "201", Jornada = TiposJornada.Mañana},
            //    new Curso{Nombre = "301", Jornada = TiposJornada.Mañana}
            //};



            var otrColeccion = new List<Curso>(){
                        new Curso(){ Nombre = "601", Jornada = TiposJornada.Mañana },
                        new Curso() {Nombre = "701", Jornada = TiposJornada.Mañana},
                        new Curso{Nombre = "801", Jornada = TiposJornada.Tarde}
            };

            escuela.Cursos.AddRange(otrColeccion);
            ImpimirCursosEscuela(escuela);

            otrColeccion.Clear();

            //escuela.Cursos.RemoveAll(delegate (Curso cur)
            //                        {
            //                            return cur.Nombre == "301";
            //                        });

            //escuela.Cursos.RemoveAll((cur)=> cur.Nombre == "501" && cur.Jornada == TiposJornada.Mañana );
            
            WriteLine("==================");
            ImpimirCursosEscuela(escuela);

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


//using System;
//using static System.Console; //se añade solo para escribier WriteLine al imprimir
//using PlatziEscuelaProyect.Entidades;// se llaman los otros archivos desde el namespace a este archivo
//using System.Collections.Generic;

//namespace PlatziEscuelaProyect
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var escuela = new Escuela ("Platzi Academy", 2012, TiposEscuela.Primaria,
//                        ciudad: "Bogotá", pais: "Colombia"
//                        );

//            List<Curso> escuelaCursos = new List<Curso>()
//            {
//                new Curso() { Name = "101", Jornada = TiposJornada.Mañana },
//                new Curso() { Name = "201", Jornada = TiposJornada.Mañana },
//                new Curso { Name = "301", Jornada = TiposJornada.Mañana },
//                new Curso { Name = "102", Jornada = TiposJornada.Tarde },
//                new Curso { Name = "202", Jornada = TiposJornada.Tarde }
//            };

//            List<Curso> otroColeccion = new List<Curso>(){
//                        new Curso(){ Name = "401", Jornada = TiposJornada.Mañana },
//                        new Curso() {Name = "501", Jornada = TiposJornada.Mañana},
//                        new Curso{Name = "501", Jornada = TiposJornada.Tarde}
//            };

//            escuelaCursos.Add(new Curso() {Name =" 601", Jornada= TiposJornada.Mañana});

//            WriteLine("==================");
//            ImpimirCursosEscuela(escuela);
//            /*


//            escuela.Cursos.RemoveAll(delegate (Curso cur)
//                                    {
//                                        return cur.Nombre == "301";
//                                    });

//            escuela.Cursos.RemoveAll((cur)=> cur.Nombre == "501" && cur.Jornada == TiposJornada.Mañana );
//            */



//        }

//        private static void ImpimirCursosEscuela(Escuela escuela)
//        {
//            WriteLine("====================");
//            WriteLine("Cursos de la Escuela");
//            WriteLine("====================");

//            if (escuela.Cursos != null)
//            {
//                foreach (var curso in escuela.Cursos)
//                {
//                    WriteLine($"Nombre {curso.Name}, Id  {curso.UniqueId}");
//                }
//            }
//        }


//        private static void ImprimirCursosWhile(Curso[] arregloCursos)
//        {
//            int contador = 0;
//            while (contador < arregloCursos.Length)
//            {
//                Console.WriteLine($"Nombre {arregloCursos[contador].Name}, Id  {arregloCursos[contador].UniqueId}");
//                contador++;
//            }
//        }

//        private static void ImprimirCursosDoWhile(Curso[] arregloCursos)
//        {
//            int contador = 0;
//            do
//            {
//                Console.WriteLine($"Nombre {arregloCursos[contador].Name}, Id  {arregloCursos[contador].UniqueId}");
//                contador++;
//            } while (contador < arregloCursos.Length);
//        }

//        private static void ImprimirCursosFor(Curso[] arregloCursos)
//        {
//            for (int i = 0; i < arregloCursos.Length; i++)
//            {
//                Console.WriteLine($"Nombre {arregloCursos[i].Name}, Id  {arregloCursos[i].UniqueId}");
//            }
//        }

//        private static void ImprimirCursosForEach(Curso[] arregloCursos)
//        {
//            foreach (var curso in arregloCursos)
//            {
//                Console.WriteLine($"Nombre {curso.Name}, Id  {curso.UniqueId}");
//            }
//        }
//    }
//}