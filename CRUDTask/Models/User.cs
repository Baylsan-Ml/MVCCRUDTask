using System.ComponentModel.DataAnnotations;
namespace CRUDTask.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Name is required")]
        [MinLength(2,ErrorMessage ="Length must be at least 2 characters")]
        [MaxLength(20,ErrorMessage ="Length must be at most 20 characters")]
        public string Name { get; set; }
        [Range(15,35,ErrorMessage ="Age must be between 15 and 35")]
        public int Age { get; set; }
        [Required(ErrorMessage ="City is required")]
        [MinLength(2,ErrorMessage ="Length must be at least 2 characters")]
        [MaxLength(50,ErrorMessage ="Length must be at most 50 characters")]
        public string City { get; set; }
    }
}

