namespace MySchool.Model
{
    public class Student
    {
        public int Id { get; set; }
        public string RegNumber { get; set; }
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public string Name {
            get { 
                return $"{FirstName} {SurName}";
            }
        }
    }
}