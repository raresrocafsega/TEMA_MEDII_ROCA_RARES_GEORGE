using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.Build.Evaluation;
using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Nodes;
using TEMA_MEDII_ROCA_RARES_GEORGE.Controllers;

namespace TEMA_MEDII_ROCA_RARES_GEORGE.Models
{
    public class ServiceDetail
    {
        public int ID { get; set; }

        [Display(Name = "Service")]
        public int? ServiceID { get; set; }
        public Service? Services { get; set; }

        [Display(Name = "Tipul Serviciului")]
        public int? ServiceTypeID { get; set; }
        public ServiceType? ServiceTypes { get; set; }

        [Display(Name = "Plata Cash")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public bool PaymentCash { get; set; }

        [Display(Name = "Plata Card")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public bool PaymentCard { get; set; }

        [Display(Name = "Zona de Așteptare")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public bool WaitingZone { get; set; }

        [RequiredIf("LuniClosed", Operator.EqualTo, false, "Timpul este necesar daca ziua nu este bifată ca program inchis")]
        [Display(Name = "Luni, de la:")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [DataType(DataType.Time)]
        public DateTime? LuniStartTime { get; set; }

        [RequiredIf("LuniClosed", Operator.EqualTo, false, "Timpul este necesar daca ziua nu este bifată ca program inchis")]
        [Display(Name = "Luni, până la:")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [DataType(DataType.Time)]
        public DateTime? LuniEndTime { get; set; }

        [Display(Name = "Luni închis ?")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public bool LuniClosed { get; set; }

        [RequiredIf("MartiClosed", Operator.EqualTo, false, "Timpul este necesar daca ziua nu este bifată ca program inchis")]
        [Display(Name = "Marți, de la:")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [DataType(DataType.Time)]
        public DateTime? MartiStartTime { get; set; }

        [RequiredIf("MartiClosed", Operator.EqualTo, false, "Timpul este necesar daca ziua nu este bifată ca program inchis")]
        [Display(Name = "Marți, până la:")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [DataType(DataType.Time)]
        public DateTime? MartiEndTime { get; set; }

        [Display(Name = "Marți închis ?")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public bool MartiClosed { get; set; }

        [RequiredIf("MiercuriClosed", Operator.EqualTo, false, "Timpul este necesar daca ziua nu este bifată ca program inchis")]
        [Display(Name = "Miercuri, de la:")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [DataType(DataType.Time)]
        public DateTime? MiercuriStartTime { get; set; }

        [RequiredIf("MiercuriClosed", Operator.EqualTo, false, "Timpul este necesar daca ziua nu este bifată ca program inchis")]
        [Display(Name = "Miercuri, până la:")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [DataType(DataType.Time)]
        public DateTime? MiercuriEndTime { get; set; }

        [Display(Name = "Miercuri închis ?")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public bool MiercuriClosed { get; set; }

        [RequiredIf("JoiClosed", Operator.EqualTo, false, "Timpul este necesar daca ziua nu este bifată ca program inchis")]
        [Display(Name = "Joi, de la:")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [DataType(DataType.Time)]
        public DateTime? JoiStartTime { get; set; }

        [RequiredIf("JoiClosed", Operator.EqualTo, false, "Timpul este necesar daca ziua nu este bifată ca program inchis")]
        [Display(Name = "Joi, până la:")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [DataType(DataType.Time)]
        public DateTime? JoiEndTime { get; set; }

        [Display(Name = "Joi închis ?")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public bool JoiClosed { get; set; }

        [RequiredIf("VineriClosed", Operator.EqualTo, false, "Timpul este necesar daca ziua nu este bifată ca program inchis")]
        [Display(Name = "Vineri, de la:")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [DataType(DataType.Time)]
        public DateTime? VineriStartTime { get; set; }

        [RequiredIf("VineriClosed", Operator.EqualTo, false, "Timpul este necesar daca ziua nu este bifată ca program inchis")]
        [Display(Name = "Vineri, până la:")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [DataType(DataType.Time)]
        public DateTime? VineriEndTime { get; set; }

        [Display(Name = "Vineri închis ?")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public bool VineriClosed { get; set; }

        [RequiredIf("SambataClosed", Operator.EqualTo, false, "Timpul este necesar daca ziua nu este bifată ca program inchis")]
        [Display(Name = "Sâmbătă, de la:")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [DataType(DataType.Time)]
        public DateTime? SambataStartTime { get; set; }

        [RequiredIf("SambataClosed", Operator.EqualTo, false, "Timpul este necesar daca ziua nu este bifată ca program inchis")]
        [Display(Name = "Sâmbătă, până la:")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [DataType(DataType.Time)]
        public DateTime? SambataEndTime { get; set; }

        [Display(Name = "Sâmbătă închis ?")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public bool SambataClosed { get; set; }

        [RequiredIf("DuminicaClosed", Operator.EqualTo, false, "Timpul este necesar daca ziua nu este bifată ca program inchis")]
        [Display(Name = "Duminică, de la:")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [DataType(DataType.Time)]
        public DateTime? DuminicaStartTime { get; set; }

        [RequiredIf("DuminicaClosed", Operator.EqualTo, false, "Timpul este necesar daca ziua nu este bifată ca program inchis")]
        [Display(Name = "Duminică, până la:")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [DataType(DataType.Time)]
        public DateTime? DuminicaEndTime { get; set; }

        [Display(Name = "Duminică închis ?")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public bool DuminicaClosed { get; set; }
    }
}
    