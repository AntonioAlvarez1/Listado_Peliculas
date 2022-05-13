using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace examen_parcial2
{
    public class Pelicula
    {
        public string Titulo { get; set; }
        public int FechaL { get; set; }
        public string Genero { get; set; }
        public string Estudio { get; set; }
        public List<Actores> Elencos { get; set; }

        
    }
}