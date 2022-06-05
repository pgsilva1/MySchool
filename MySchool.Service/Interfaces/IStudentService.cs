using MySchool.Model;

namespace MySchool.Service.Interfaces
{
    public interface IStudentService
    {
        IEnumerable<Student> GetStudents();
    }
}
