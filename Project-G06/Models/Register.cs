using System.ComponentModel.DataAnnotations;

namespace Project_G06.Models
{
    public class Register
    {
        [Key]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
    }


}
