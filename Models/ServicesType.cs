using System.ComponentModel.DataAnnotations;

namespace TEMA_MEDII_ROCA_RARES_GEORGE.Models
{
    public class ServicesType
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Tipul serviciului trebuie introdus !")]
        public string? Type { get; set; }

        public ICollection<ServiceDetail>? ServiceDetail { get; set; }
    }
}
