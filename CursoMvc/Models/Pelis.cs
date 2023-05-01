using System.ComponentModel.DataAnnotations;

namespace CursoMvc.Models
{
    public class Pelis
    {
        [Key]
        public int id { get; set; }
        public string titulo { get; set; }
        public string descripcion { get; set; }
        public string imagenDetras { get; set; }
        public string imagen { get; set; }
        public string fecha { get; set; }
        public string video { get; set; }
    }
}
