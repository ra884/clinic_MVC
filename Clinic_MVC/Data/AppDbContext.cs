using Clinic_MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace Clinic_MVC.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions options):base(options) { }
        public DbSet<Doctor> Doctors { get; set; }  
        public DbSet<Patient> Patients { get; set; }    
        public DbSet<Appointment> Appointments { get; set; }    
    }
}
