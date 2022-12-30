using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project_G06.Models
{
    public class Category
    {
        [Key]

        public int Id { get; set; }
        //this is the uni id . it can have many degrees

        [Required]
        
        public string Name { get; set; }

        [Required]
         public string OtherName { get; set; }

       //[Required]
       // [Key, ForeignKey()]
        //public string S_Name { get; set; }
        [Required]
        public string Email { get; set; }



        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }


        [Required(ErrorMessage = "Confirm Password")]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; } 

       // public List<classfordegree> Degreespecificfortheuniversity

     

    }
}
