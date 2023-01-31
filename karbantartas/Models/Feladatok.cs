using System.ComponentModel.DataAnnotations;

namespace karbantartas.Models
{
    public class Feladatok
    {
        [Key]
        public long? f_id { get; set; }
        public string? f_nev { get; set; }
        public string? leiras { get; set; }

    }
}
