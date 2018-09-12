using System.ComponentModel.DataAnnotations;

namespace OneWorkFlow.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}