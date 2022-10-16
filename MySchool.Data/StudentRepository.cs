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
        public Student GetById(int studentId)
        {
            return base.GetById(studentId);
        }

        public IEnumerable<Student> GetAll()
        {
            return base.GetAll();
        }

        public bool Save(Student student)
        {
            if(student.Id > 0)
            {
                base.Update(student);
            }
            else
            {
                base.Add(student);
            }

            return base.SaveChanges();
        }
    }
}