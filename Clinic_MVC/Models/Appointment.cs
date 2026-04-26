using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Clinic_MVC.Models
{
    public class Appointment
    {
        public int AppointmentId { get; set; } 
        public DateOnly Date {  get; set; } 
        public string Notes { get; set; }
        [ForeignKey("DoctorId")]
        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }
        [ForeignKey("PatientId")]
        public int PatientId { get; set; }  
        public Patient Patient { get; set; }    
    }
}
