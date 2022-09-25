using System.ComponentModel.DataAnnotations;

namespace DeanOfficeWebApi.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public int Age { get; set; }
        [Required]
        public string Position { get; set; } = string.Empty;
        public ICollection<Subject> Subjects { get; set; } = Enumerable.Empty<Subject>().ToList();
    }
}
