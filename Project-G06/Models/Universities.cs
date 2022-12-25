using System.ComponentModel;
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
        [DataType(DataType.Password)]
        public string Password { get; set; }


        [Required(ErrorMessage ="Confirm Password")]
        [DataType(DataType.Password)]
        [Compare("Password")]

        public string ConfirmPassword { get; set; }


        [Required]
        [DisplayName("Date")]
        public DateTime Date { get; set; }

    }
}


