using System.ComponentModel.DataAnnotations;

namespace Web.Models;

public class EmailModel
{
    [Required]
    [EmailAddress]
    [Display(Name = "Recipient Email")]
    public string To { get; set; } = string.Empty;
    [Required]
    [StringLength(30)]
    [Display(Name = "Subject")]
    public string Subject { get; set; } = string.Empty;
    [Required]
    [DataType(DataType.MultilineText)]
    [Display(Name = "Body")]
    public string Body { get; set; } = string.Empty;
    [Required]
    [Display(Name = "Attachments")]
    public List<IFormFile> Attachments { get; set; } = [];
}