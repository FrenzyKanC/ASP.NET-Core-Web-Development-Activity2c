using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ASP.NET_Core_Web_Development_Activity2c.Models
{
    public class AppointmentModel
    {
        [Required]
        [StringLength(20, MinimumLength = 4)]
        [DisplayName("Patient's full name")]
        public string PatientName { get; set; }
        [DisplayName("Appointment Request Date")]
        [DataType(DataType.Date)]
        public DateTime AppointmentDate { get; set;}
        [DisplayName("Approximate Net Worth")]
        [DataType(DataType.Currency)]
        public decimal PatientWorth { get; set;}
        [DisplayName("Primary Doctors's Last Name")]
        [Range(1, 10)]
        public string DoctorName { get; set; }
        [DisplayName("Patient's Perceived Level of Pain ( 1 low to 10 high")]
        public int PainLevel { get; set;}
    }
}
