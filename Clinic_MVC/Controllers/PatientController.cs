using Clinic_MVC.Data;
using Clinic_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace Clinic_MVC.Controllers
{
    public class PatientController : Controller
    {
        public AppDbContext context;
        public PatientController(AppDbContext _context)
        {
            context = _context;
        }
        public IActionResult Index()
        {
            var Patients = context.Patients.ToList();
            return View(Patients);
        }
        [HttpPost]
        public IActionResult Create(Patient patient)
        {
            if (ModelState.IsValid)
            {
                context.Patients.Add(patient);
                context.SaveChanges();
              return  RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
    }
}
