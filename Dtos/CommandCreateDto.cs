using System.ComponentModel.DataAnnotations;

namespace commandsAPI.Dtos
{
    public class CommandCreateDto
    {

        [Required]
        public string? HowTo { get; set; }

        [Required]
        [MaxLength(10)]
        public string? Platform { get; set; }

        [Required]
        public string? CommandLine { get; set; }

    }
}