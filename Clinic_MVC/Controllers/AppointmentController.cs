using Clinic_MVC.Data;
using Clinic_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace Clinic_MVC.Controllers
{
    public class AppointmentController : Controller
    {
        public AppDbContext context;
        public AppointmentController(AppDbContext _context)
        {
            context = _context;
        }
        public IActionResult Index()
        {
            var app = context.Appointments.ToList();
            return View(app);
        }
        [HttpPost]
        public IActionResult Create(Appointment app)
        {
            if (ModelState.IsValid)
            {
                context.Appointments.Add(app);
                context.SaveChanges();
                return RedirectToAction("Index", "Doctor");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Doctors = context.Doctors.ToList();
            ViewBag.Patients=context.Patients.ToList(); 
            return View();
        }
    }
}
