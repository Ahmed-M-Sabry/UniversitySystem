using AspDotNetCore.Data;
using AspDotNetCore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
            List<Instructore> instructores = _context.Instructores.Include(i => i.FkDepartment).Include(i => i.FkCourse).ToList();

            return View(instructores);
        }

        public IActionResult Create()
        {
            return View(new Instructore());
        }
        [HttpPost]
        public IActionResult CreateNew(Instructore instructore)
        {
            if(instructore.Name != null)
            {
                _context.Instructores.Add(instructore);
                _context.SaveChanges();
                return RedirectToAction ("Index");
            }
            return View ("Create" , instructore);
        }
        public IActionResult Edit(int id )
        {
            Instructore instructore = _context.Instructores
                .Include(i => i.FkDepartment).Include(i => i.FkCourse)
                .FirstOrDefault(i => i.id == id);


            ViewBag.Departments = _context.Departments.ToList();
            ViewBag.Courses = _context.Courses.ToList();

            if (instructore == null)
            {
                return RedirectToAction("Index");
            }
            return View(instructore);
        }
        public IActionResult SaveEdit(int id , Instructore instructore)
        {
            Instructore ins = _context.Instructores
                .Include(i => i.FkDepartment).Include(i => i.FkCourse)
                .FirstOrDefault(i => i.id == id);

            ViewBag.Departments = _context.Departments.ToList();
            ViewBag.Courses = _context.Courses.ToList();

            if (ins != null)
            {
                ins.Salary = instructore.Salary;
                ins.Address = instructore.Address;
                ins.Department_id = instructore.Department_id;
                ins.Course_id = instructore.Course_id;
                ins.Name = instructore.Name;
                ins.Image = instructore.Image;
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View("Edit" , instructore);
        }

        public IActionResult Detailes(int id )
        {
            Instructore instructore = _context.Instructores
                .Include(i => i.FkDepartment).Include(i => i.FkCourse)
                .FirstOrDefault(i => i.id == id); 
            
            if (instructore == null)
            {
                return RedirectToAction("Index");
            }
            return View(instructore);
        }
        public IActionResult Delete(int id)
        {
            Instructore instructore = _context.Instructores
                .Include(i => i.FkDepartment).Include(i => i.FkCourse)
                .FirstOrDefault(i => i.id == id); if (instructore == null)
            {
                return RedirectToAction("Index");
            }
            return View(instructore);
        }

        public IActionResult ConfirmDelete(int id)
        {
            Instructore instructore = _context.Instructores
                .Include(i=>i.FkDepartment).Include(i=>i.FkCourse)
                .FirstOrDefault(i => i.id == id);

            if (instructore == null)
            {
                return RedirectToAction("Index");
            }
            _context.Remove(instructore);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
