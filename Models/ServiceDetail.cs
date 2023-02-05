using System.ComponentModel.DataAnnotations;
using System.Text.Json.Nodes;

namespace TEMA_MEDII_ROCA_RARES_GEORGE.Models
{
    public class ServiceDetail
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Serviciul trebuie ales !")]
        public int? ServiceID { get; set; }
        public Service Service { get; set; }

        [Required(ErrorMessage = "Tipul serviciilor trebuie alese !")]
        public string? ServiceTypeIDs { get; set; }
        public ServicesType ServicesType { get; set; }

        public bool PaymentCash { get; set; }
        public bool PaymentCard { get; set; }

        public bool WaitingZone { get; set; }

        [DataType(DataType.Time)]
        public DateTime? LuniStartTime { get; set; }

        [DataType(DataType.Time)]
        public DateTime? LuniEndTime { get; set; }

        public bool LuniClosed { get; set; }

        [DataType(DataType.Time)]
        public DateTime? MartiStartTime { get; set; }

        [DataType(DataType.Time)]
        public DateTime? MartiEndTime { get; set; }

        public bool MartiClosed { get; set; }

        [DataType(DataType.Time)]
        public DateTime? MiercuriStartTime { get; set; }

        [DataType(DataType.Time)]
        public DateTime? MiercuriEndTime { get; set; }

        public bool MiercuriClosed { get; set; }

        [DataType(DataType.Time)]
        public DateTime? JoiStartTime { get; set; }

        [DataType(DataType.Time)]
        public DateTime? JoiEndTime { get; set; }

        public bool JoiClosed { get; set; }

        [DataType(DataType.Time)]
        public DateTime? VineriStartTime { get; set; }

        [DataType(DataType.Time)]
        public DateTime? VineriEndTime { get; set; }

        public bool VineriClosed { get; set; }

        [DataType(DataType.Time)]
        public DateTime? SambataStartTime { get; set; }

        [DataType(DataType.Time)]
        public DateTime? SambataEndTime { get; set; }

        public bool SambataClosed { get; set; }

        [DataType(DataType.Time)]
        public DateTime? DuminicaStartTime { get; set; }

        [DataType(DataType.Time)]
        public DateTime? DuminicaEndTime { get; set; }

        public bool DuminicaClosed { get; set; }
    }
}
    