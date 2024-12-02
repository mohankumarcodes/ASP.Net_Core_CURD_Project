using System.ComponentModel.DataAnnotations;

namespace CURD_Project_WebAPI.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string Address { get; set; }
        
    }
}
