using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Biblioteca.Api.Modelo
{
    public class Pelicula
    {
        [Key]
        public int IdPelicula { get; set; }
        public string Titulo { get; set; }
        public string Productora { get; set; }
        public string Director { get; set; }
        public int Duracion { get; set; }
        public string Descripcion { get; set; }
    }
}
