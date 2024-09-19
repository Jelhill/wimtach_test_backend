using System.ComponentModel.DataAnnotations;

namespace ProJeliliV1.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}