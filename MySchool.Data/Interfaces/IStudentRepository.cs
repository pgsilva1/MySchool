using MySchool.Model;

namespace MySchool.Data.Interfaces
{
    public interface IStudentRepository
    {
        public IEnumerable<Student> GetStudents();
    }
}
