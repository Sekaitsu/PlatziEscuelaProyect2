using System;
using System.Collections.Generic;
using PlatziEscuelaProyect.Entidades;
using static System.Console;

namespace PlatziEscuelaProyect
{
    class Program
    {
        static void Main(string[] args)
        {

            var engine = new EscuelaEngine();//() no recibe parametros
            engine.Inicializar();//para inicializae

            WriteLine("==================");
            ImpimirCursosEscuela(engine.Escuela);//imprime
        }
        private static void ImpimirCursosEscuela(Escuela escuela) //FUNCIONA POR QUE  USA escuela.Cursos
        {
            WriteLine("====================");
            WriteLine("Cursos de la Escuela");
            WriteLine("====================");

            if (escuela?.Cursos != null)
            {
                foreach (var Curso in escuela.Cursos)
                {
                    WriteLine($"Nombre {Curso.Nombre}, Id  {Curso.UniqueId}");
                }
            }
        }
    }
}

//se delega la responsabilidad de la logia de la aplicación en el motor