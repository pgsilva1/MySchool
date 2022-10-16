using Microsoft.AspNetCore.Mvc;
using MySchool.Model;
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

        public IActionResult Create()
        {
            return View(new Student());
        }

        [HttpPost]
        public IActionResult Create([FromServices] IStudentService studentService, Student student)
        {
            ModelState.Remove("RegNumber");
            if(ModelState.IsValid == false)
            {
                return View(student);
            }
            studentService.Save(student);
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("Student/Edit/{studentId:int}")]
        public IActionResult Edit([FromServices] IStudentService studentService, int studentId)
        {
            var student = studentService.Get(studentId);

            if(student != null)
            {
                return View(student);
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Edit([FromServices] IStudentService studentService, Student student)
        {
            ModelState.Remove("RegNumber");
            if (ModelState.IsValid == false)
            {
                return View(student);
            }

            var studentUpdated = new Student
            {
                Id = student.Id,
                FirstName = student.FirstName,
                SurName = student.SurName,
                UpdateDate = DateTime.Now
            };

            studentService.Save(studentUpdated);
            return RedirectToAction("Index");
        }
    }
}
