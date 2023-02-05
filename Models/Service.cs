using System.ComponentModel.DataAnnotations;
using System.Net.Sockets;

namespace TEMA_MEDII_ROCA_RARES_GEORGE.Models
{
    public class Service
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Numele service-ului trebuie introdus !")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Locatia service-ului trebuie introdusă !")]
        public string? Location { get; set; }

        public ICollection<ServiceAppointment>? ServiceAppointments { get; set; }
        public ICollection<ServiceDetail>? ServiceDetails { get; set; }
    }
}
