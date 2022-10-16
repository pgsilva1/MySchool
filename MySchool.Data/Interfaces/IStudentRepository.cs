using MySchool.Model;

namespace MySchool.Data.Interfaces
{
    public interface IStudentRepository
    {
        Student GetById(int studentId);
        public IEnumerable<Student> GetAll();
        public bool Save(Student student);
    }
}
