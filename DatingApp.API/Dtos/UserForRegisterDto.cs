using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }
        
        [Required]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Password must be between 6 to 20 letters")]
        public string Password { get; set; }
    }
}