using System.ComponentModel.DataAnnotations;
using System.Security.Policy;

namespace TEMA_MEDII_ROCA_RARES_GEORGE.Models
{
    public class ServiceAppointment
    {
        public int ID { get; set; }
        public string? Name { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string? Phone { get; set; }

        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }

        public int? ServiceID { get; set; }
        public Service? Service { get; set; }
        public DateTime? Date { get; set; }
    }
}
