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

        public Student Get(int studentId)
        {
            return StudentRepository.GetById(studentId);
        }
        public IEnumerable<Student> GetStudents()
        {
            return StudentRepository.GetAll();
        }

        public bool Save(Student student)
        {
            if(student.Id == 0)
            {
                student.RegNumber = Guid.NewGuid().ToString().Substring(0, 5);
                student.CreationDate = DateTime.Now;
            }

            return StudentRepository.Save(student);
        }
    }
}