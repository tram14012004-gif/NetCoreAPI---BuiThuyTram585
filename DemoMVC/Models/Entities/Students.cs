using System.ComponentModel.DataAnnotations;

namespace DemoMVC.Models.Entities
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FullName { get; set; }

        [Required]
        public string StudentCode { get; set; }
    }
}