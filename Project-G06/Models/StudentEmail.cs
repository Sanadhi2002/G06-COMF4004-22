using System.ComponentModel.DataAnnotations;

namespace Project_G06.Models
{
    public class StudentEmail
        
    {
        
        [Key]
        public int S_Id { get; set; }

        [Required(ErrorMessage = "Your name Required")]
        [StringLength(50, ErrorMessage = "5 to 50 characters.", MinimumLength = 3)]
        public string S_Name { get; set; }

        
        
        [Required(ErrorMessage = "Email Required")]
        [EmailAddress(ErrorMessage = "Invalid email")]
        public string S_Email { get; set; }

       

    }
}
