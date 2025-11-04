using System.ComponentModel.DataAnnotations;

namespace BaseLibrary.DTOs
{
    internal class Register : AccountBase
    {
        [Required]
        [MinLength(5)]
        [MaxLength(100)]
        public string? Fullname { get; set; }
        [DataType(DataType.Password)]
        [Compare(nameof(Password))]
        [Required]
        public string? ConfirmPassword { get; set; } = null;
    }
}
