using System.ComponentModel.DataAnnotations;

namespace BAFA.Models
{
    public class Email
    {
	    [Required]
	    public string Name;
        [Required]
        public string EmailAddress;
        [Required]
        public string Message;
    }
}
