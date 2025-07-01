using System.ComponentModel.DataAnnotations;

namespace Prueba_Api.Entities
{
    public class CatFactEntity
    {
        [Key]
        public int Id { get; set; }

        public string Fact { get; set; }
        public string Palabra1 { get; set; }
        public string Palabra2 { get; set; }
        public string Palabra3 { get; set; }
        public string GifUrl { get; set; }
        public DateTime FechaBusqueda { get; set; }
    }
}
