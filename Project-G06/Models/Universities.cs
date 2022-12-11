using System.ComponentModel.DataAnnotations;

namespace Project_G06.Models;

public class Universities
{

    [Key]
    public string Name { get; set; }
    [Required]

    public char Email { get; set; }
    [Required]
    public char Password { get; set; }
    [Required]


};
