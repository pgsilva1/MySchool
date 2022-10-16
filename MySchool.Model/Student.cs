using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MySchool.Model
{
    public class Student
    {
        public int Id { get; set; }

        [DisplayName("Registration number")]
        public string RegNumber { get; set; }

        [DisplayName("First name")]
        [StringLength(250, MinimumLength = 3, ErrorMessage = "First name needs to have at least 3 characters")]
        public string FirstName { get; set; }

        [DisplayName("Surname")]
        [StringLength(250, MinimumLength = 3, ErrorMessage = "Surname needs to have at least 3 characters")]
        public string SurName { get; set; }
        public string Name {
            get { 
                return $"{FirstName} {SurName}";
            }
        }
        public DateTime CreationDate { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}