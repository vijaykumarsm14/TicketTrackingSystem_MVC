using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TTS_MVC.Data;
using TTS_MVC.Models;

namespace TTS_MVC.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly TTS_MVCContext _context;

        public EmployeesController(TTS_MVCContext context)
        {
            this._context = context;
        }
        public IActionResult EmployeeView()
        {
            Employee employee = new Employee();
            return EmployeeView();
        }
     
    }
}
