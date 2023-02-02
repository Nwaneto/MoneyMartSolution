using System.ComponentModel.DataAnnotations;

namespace MoneyMart.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}