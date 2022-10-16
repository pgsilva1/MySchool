using MySchool.Model;

namespace MySchool.Service.Interfaces
{
    public interface IStudentService
    {
        Student Get(int studentId);
        IEnumerable<Student> GetStudents();
        bool Save(Student student);
    }
}
