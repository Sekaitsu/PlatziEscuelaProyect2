using System;
using System.Collections.Generic;
using System.Linq;
using PlatziEscuelaProyect.Entidades;

namespace PlatziEscuelaProyect
{
    public class EscuelaEngine
    {
        public Escuela Escuela { get; set; }
        public EscuelaEngine()
        {

        }

        //Se crea un metodo donde se va inicializar el listado de curso
        public void Inicializar()
        {
            Escuela = new Escuela ("Platzi Academay", 2012, TiposEscuela.Primaria,ciudad: "Bogotá", pais: "Colombia");
            
            Escuela.Cursos = new List<Curso>()
            {
                new Curso() {Nombre = "101", Jornada = TiposJornada.Mañana},
                new Curso() {Nombre = "201", Jornada = TiposJornada.Mañana},
                new Curso   {Nombre = "301", Jornada = TiposJornada.Mañana},
                new Curso() {Nombre = "401", Jornada = TiposJornada.Tarde},
                new Curso() {Nombre = "501", Jornada = TiposJornada.Tarde}
            };
        }
    }
}