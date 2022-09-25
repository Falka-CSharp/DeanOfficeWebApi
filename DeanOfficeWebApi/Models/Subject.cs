using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DeanOfficeWebApi.Models
{
    public class Subject
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Teacher")]
        public int TeacherId { get; set; }

        [ForeignKey("TeacherId")]
        public virtual Teacher Teacher { get; set; } = new Teacher();

        public virtual ICollection<Student> Students { get; set; } = Enumerable.Empty<Student>().ToList();
    }
}
