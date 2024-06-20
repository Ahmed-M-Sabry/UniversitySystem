using AspDotNetCore.Data;
using AspDotNetCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspDotNetCore.Controllers
{
    public class InstructoreController : Controller
    {
        public ApplicationDbContext _context;
        public InstructoreController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Instructore> instructores = _context.Instructores.ToList();

            return View(instructores);
        }
        public IActionResult Details(int id)
        {
            Instructore instructoreData = _context.Instructores.FirstOrDefault(i => i.id == id);
            if(instructoreData == null)
            {
                return RedirectToAction("Index"); 
            }
            return View(instructoreData);
        }
    }
}
