using Microsoft.AspNetCore.Mvc;
using MySchool.Service;
using MySchool.Service.Interfaces;

namespace MySchool.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index([FromServices] IStudentService studentService)
        {
            var students = studentService.GetStudents();
            return View(students);
        }
    }
}
