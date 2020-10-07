using System.ComponentModel.DataAnnotations;

public class Soup
{
    [Required]
    [StringLength(10, ErrorMessage = "Name is too long.")]
    public string Name { get; set; }

    [Required]
    [RegularExpression(@"/hot|cold")]
    public string HotCold { get; set; }
}