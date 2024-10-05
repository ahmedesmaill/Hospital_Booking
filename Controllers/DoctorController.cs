using ContactDoctor.Models;
using Hospital.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Hospital.Controllers
{
    public class DoctorController : Controller
    {
        DoctorDbContext dBContext=new DoctorDbContext();
        public IActionResult Index()
        {
            var Doctors = dBContext.Doctors.ToList();

            return View(Doctors);
            
        }
        public IActionResult CompleteAppointment(int id)
        {
            var Doctor = dBContext.Doctors.Where(e => e.Id == id).FirstOrDefault();
            return View(Doctor);
           
        }

    }
}
