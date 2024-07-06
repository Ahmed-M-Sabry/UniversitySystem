using AspDotNetCore.Data;
using AspDotNetCore.Models;
using AspDotNetCore.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AspDotNetCore.Controllers
{
    public class TraineeController : Controller
    {
        public ApplicationDbContext _context;
        public TraineeController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Trainee> trainees = _context.Trainees.ToList();

            return View(trainees);
        }

        public IActionResult Details(int id)
        {
            ViewData["red"] = "red";
            ViewData["Green"] = "Green";
            
            TraineeAndCourseWithResultViewModel traineeViewModel = new TraineeAndCourseWithResultViewModel();
            
            Trainee traineeData = _context.Trainees.Include(t=>t.CourseResults).ThenInclude(t=>t.FkCourse).FirstOrDefault(i=>i.Id == id);

            CourseResult courseResult = _context.CourseResults.FirstOrDefault(i => i.Trainee_Id == id);

            if (traineeData == null)
                return RedirectToAction("Index");

            traineeViewModel.id = traineeData.Id;
            traineeViewModel.Name = traineeData.Name;
            traineeViewModel.CourseName = courseResult?.FkCourse.Name;
            traineeViewModel.CourseResult = courseResult?.Drgree;
            traineeViewModel.MinDegree = courseResult.FkCourse.PassDegree;
            return View(traineeViewModel);
        }

        public IActionResult TraineeCourses(int id)
        {
            ViewData["red"] = "red";
            ViewData["Green"] = "Green";

            var traineeData = _context.Trainees
                .Include(t => t.CourseResults)
                    .ThenInclude(cr => cr.FkCourse)
                .FirstOrDefault(t => t.Id == id);

            if (traineeData == null)
                return RedirectToAction("Index");

            ViewData["name"] = traineeData.Name;

            var courses = traineeData.CourseResults.Select(cr => new ResultCoursesViewModel
            {
                CourseNames = cr.FkCourse.Name,
                CourseResults = cr.Drgree,
                MinDegrees = cr.FkCourse.PassDegree
            }).ToList();


            var traineeViewModel = new TraineeCoursesViewModel
            {
                Courses = courses
            };



            return View(traineeViewModel);
        }


    }
}
