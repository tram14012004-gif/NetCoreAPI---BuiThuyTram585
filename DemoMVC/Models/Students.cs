using System.ComponentModel.DataAnnotations;

namespace DemoMVC.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        public string FullName { get; set; } = "";

        public string StudentCode { get; set; } = "";
    }
}