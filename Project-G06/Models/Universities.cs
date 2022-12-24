using System.ComponentModel.DataAnnotations;

namespace Project_G06.Models
{
    public class Universities
    {

        [Key]
        [Required]
        
        public string Name { get; set; }

        [Required]  
        public string Email { get; set; }

        [Required]

        public string Password { get; set; }

        [Required]
        
        public DateTime Date { get; set; }

    }
}


