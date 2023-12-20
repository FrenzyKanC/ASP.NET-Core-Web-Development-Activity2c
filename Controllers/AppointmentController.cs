using ASP.NET_Core_Web_Development_Activity2c.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_Core_Web_Development_Activity2c.Controllers
{
    public class AppointmentController : Controller
    {
        // list die beim return von der create seite angezeigz wird
        static List<AppointmentModel> appointments = new List<AppointmentModel>();

        // zeigt alle appointments
        public IActionResult Index()
        {
            return View(appointments);
        }
        public IActionResult Create()
        {
            return View();
        }

        // zeigt ein appointment
        public IActionResult Details(AppointmentModel appointment) 
        {
            appointments.Add(appointment);
            return View("Details", appointment);
        }

    }
}
