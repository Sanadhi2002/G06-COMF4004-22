using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project_G06.Models
{
    public class Category
    {
        [Key]

        public int U_ID{ get; set; }
        //this is the uni id . it can have many degrees

        [Required]
        
        public string U_UserName { get; set; }

        [Required]
         public string U_Email { get; set; }

    //[Required]
    // [Key, ForeignKey()]
    //public string S_Name { get; set; }
    [Required]
    [DataType(DataType.Password)]

    public string U_Password{ get; set; }





       // public List<classfordegree> Degreespecificfortheuniversity

     

    }
}
