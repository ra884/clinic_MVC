using Clinic_MVC.Data;
using Clinic_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Clinic_MVC.Controllers
{
    public class DoctorController : Controller
    {
        public AppDbContext context;
        public DoctorController(AppDbContext _context)
        {
            context = _context;
        }
        public IActionResult Index()
        {
            var doctors = context.Doctors.ToList();
            return View(doctors);
        }
        [HttpPost]
        public IActionResult Create(Doctor doctor)
        {
            if (ModelState.IsValid)
            {
                context.Doctors.Add(doctor);
                context.SaveChanges();
                return RedirectToAction("Index");   
            }
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpGet("{id}")]
        public IActionResult Update(int id)
        {
            if (ModelState.IsValid)
            {
                Doctor d = context.Doctors.Find(id);
                if (d != null)
                {
                    context.Doctors.Update(d);  
                    context.SaveChanges();
                    return View(d);
                }
                return NotFound();
            }
            return View();
        }
    }
}
