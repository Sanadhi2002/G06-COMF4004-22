using System.ComponentModel.DataAnnotations;

namespace Project_G06.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string OtherName { get; set; }

        public string Email { get; set; }
        public string Password { get; set; }  
        
        public string ConfirmPassword { get; set; } 

   

    }
}
