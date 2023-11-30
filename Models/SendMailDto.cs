using System.ComponentModel.DataAnnotations;

namespace Project_01.Models
{
    public class SendMailDto
    {
        [Required]
        public string Name { get; set; }
        
        [Required]
        public string Subject { get; set; }
        [Required]
        public string Message { get; set; }
    }
}
