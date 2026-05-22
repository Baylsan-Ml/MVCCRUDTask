using System.ComponentModel.DataAnnotations;
namespace CRUDTask.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Name is required")]
        [MinLength(2,ErrorMessage ="Length must be at least 2 characters")]
        [MaxLength(20,ErrorMessage ="Length must be at most 20 characters")]
        [Display(Name ="Full Name",Prompt ="Enter your full name here...")]
        public string Name { get; set; }
        [Range(15,35,ErrorMessage ="Age must be between 15 and 35")]
        public int Age { get; set; }
        [Display(Name ="Email Address",Prompt ="Enter your email address here...")]
        [Required(ErrorMessage ="City is required")]
        [MinLength(2,ErrorMessage ="Length must be at least 2 characters")]
        [MaxLength(50,ErrorMessage ="Length must be at most 50 characters")]
        public string City { get; set; }
    }
}

