using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Project_G06.Models
{
    public class UpdateUniversity
    {

        public string Name { get; set; }


        public string Email { get; set; }

        public string Password { get; set; }


 

        public string ConfirmPassword { get; set; }


        public DateTime Date { get; set; }
    }
}
