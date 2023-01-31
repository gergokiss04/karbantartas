using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace karbantartas.Models
{
    public class Karbantartok
    {
        [Key]
        public long? karb_id { get; set; }
        public string? karb_nev { get; set; }
        public long? karb_fiz { get; set; }
        public string? karb_beoszt { get; set; }
        public string? karb_tipus { get; set; }

    }
}
