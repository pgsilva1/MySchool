using MySchool.Model;
using MySchool.Data.Interfaces;
using MySchool.Service.Interfaces;

namespace MySchool.Service
{
    public class StudentService : IStudentService
    {
        private IStudentRepository StudentRepository { get; set; }

        public StudentService(IStudentRepository studentRepository)
        {
            StudentRepository = studentRepository;
        }
        public IEnumerable<Student> GetStudents()
        {
            return StudentRepository.GetStudents();
        }
    }
}