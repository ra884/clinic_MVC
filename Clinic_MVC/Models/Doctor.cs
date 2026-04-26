namespace Clinic_MVC.Models
{
    public class Doctor
    {
        public int DoctorId { get; set; } 
        public string Name { get; set; }
        public string Speciality { get; set; }
        public List<Appointment> Appointments { get; set; }

    }
}
