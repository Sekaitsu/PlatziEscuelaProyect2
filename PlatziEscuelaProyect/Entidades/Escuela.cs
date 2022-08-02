using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PlatziEscuelaProyect.Entidades
{
    public class Escuela
    {
        //propiedad muestra el nombre para identificar
        //se crean las demas propiedades a usar esta es la manera CORRECTA y mas rapida 
        // se hace un get donde se retona la variable, y se especifica que es una copia del nombre
        string nombre;
        public string Nombre
        {
            get { return "Copia:" + nombre; }
            set { nombre = value.ToUpper(); }
        }
        public int YearCreacion { get; set; }

        public string Pais { get; set; }
        public string Ciudad { get; set; }
        public TiposEscuela TipoEscuela { get; set; }
        //se adiciona otra propiedad donde llama a la entidad Cursos[] la cual será usasa en el Program.cs
        // se cambia a lista 
        public List<Curso> Cursos { get; set; }
        public Escuela(string nombre, int año) => (Nombre, YearCreacion) = (nombre, año);

        public Escuela(string nombre, int año,
                       TiposEscuela tipo,
                       string pais = "", string ciudad = "")
        {
            (Nombre, YearCreacion) = (nombre, año);
            Pais = pais;
            Ciudad = ciudad;
        }
        public override string ToString()
        {
            return $"Nombre: \"{Nombre}\", Tipo: {TipoEscuela} {System.Environment.NewLine} Pais: {Pais}, Ciudad:{Ciudad}";
        }
    }
}

//{
//    public class Escuela
//{
//    //propiedad muestra el nombre para identificar
//    //se crean las demas propiedades a usar esta es la manera CORRECTA y mas rapida 
//    // se hace un get donde se retona la variable, y se especifica que es una copia del nombre
//    string Nombre
//    {
//        get { return "Copia: " + Nombre; }
//        set { Nombre = value.ToUpper(); }
//    }
//    public int YearCreacion { get; set; }
//    public string Pais { get; set; }
//    public string Ciudad { get; set; }
//    public TiposEscuela TipoEscuela { get; set; }
//    //se adiciona otra propiedad donde llama a la entidad Cursos[] la cual será usasa en el Program.cs
//    // se cambia a lsita 
//    public List<Curso> Cursos { get; set; }

//    //override es sobre escribir ToString y se añaden las propiedades  y se heredan los atributos
//    public override string ToString()
//    {
//        //el signo $ me permite usar variables en cadenas de texto
//        return $"Nombre: {Nombre} \nAño: {YearCreacion} \nTipo: {TipoEscuela} \nPais: {Pais} \nCiudad: {Ciudad}";
//    }
//}
//}