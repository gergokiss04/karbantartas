using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace karbantartas.Models
{
    public class Anyagszukseglet
    {
        [Key]
        public long? a_id { get; set; }

        public Feladatok? f_id_ik { get; set; }
        public string? a_nev { get; set; }
        
        public long? a_db { get; set; }

    }
}
