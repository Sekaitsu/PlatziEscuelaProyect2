using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatziEscuelaProyect.Entidades
{
    class Escuela
    {
        //CONSTRUCTOR 1 para crear escuelas debe tener unos parametros
        public Escuela(string nombre, int year)/*se asigna el nombre y el año a las propiedades Nombre , YearCreacion son iguales a los parametros nombre y year*/
        {
            (Nombre, YearCreacion) = (nombre.ToUpper(), year);
            //cuando alguien fuera de la clase quiera asignar un valor el ToUpper es para poner el nombre el mayuscula lo fuerza antes de asignarlo  
        }
        /*CONSTRUCTOR 2*/
        //las comas son separación de objetos dentro de una lista
        public Escuela(string nombre, int year, TiposEscuela tipos, string pais = "", string ciudad = "")
        {
            //AISGNACIÓN DE DUPLAS
            (Nombre, YearCreacion) = (nombre.ToUpper(), year);
            Pais = pais;
            Ciudad = ciudad;
        }
        //propiedad muestra el nombre para identificar
        //se crean las demas propiedades a usar esta es la manera CORRECTA y mas rapida 
        // se hace un get donde se retona la variable, y se especifica que es una copia del nombre
        public string Nombre { get; set; }
        public int YearCreacion { get; set; }
        public string Pais { get; set; }
        public string Ciudad { get; set; }
        public TiposEscuela TipoEscuela { get; set; }
        //se adiciona otra propiedad donde llama a la entidad Cursos[] la cual será usasa en el Program.cs
        // se cambia a lsita 
        public List<Curso> Cursos { get; set; }

        //override es sobre escribir ToString y se añaden las propiedades  y se heredan los atributos
        public override string ToString()
        {
            //el signo $ me permite usar variables en cadenas de texto
            return $"Nombre: {Nombre} \nAño: {YearCreacion} \nTipo: {TipoEscuela} \nPais: {Pais} \nCiudad: {Ciudad}";
        }
    }
}