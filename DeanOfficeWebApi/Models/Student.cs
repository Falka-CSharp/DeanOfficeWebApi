using System.ComponentModel.DataAnnotations;

namespace DeanOfficeWebApi.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public int Age { get; set; }

        public virtual ICollection<Subject> Subjects { get; set; } = Enumerable.Empty<Subject>().ToList();
    }
}
