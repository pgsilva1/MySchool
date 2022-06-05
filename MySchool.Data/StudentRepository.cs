using MySchool.Model;
using MySchool.Data.Interfaces;

namespace MySchool.Data
{
    public class StudentRepository : Repository<Student>, IStudentRepository
    {
        private readonly ApplicationDbContext _context;
        public StudentRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
        public IEnumerable<Student> GetStudents()
        {
            return GetAll();
        }
    }
}