using System.ComponentModel.DataAnnotations;

namespace karbantartas.Models
{
    public class Karbantartasok
    {
        [Key]
        public long? k_id { get; set; }
        public Karbantartasok? karb_id_ik { get; set; }
        public Feladatok? f_id_ik { get; set; }
        public DateTime? k_kezd { get; set; }
        public DateTime? k_vege { get; set; }
        public string? k_tipus { get; set; }

    }
}
