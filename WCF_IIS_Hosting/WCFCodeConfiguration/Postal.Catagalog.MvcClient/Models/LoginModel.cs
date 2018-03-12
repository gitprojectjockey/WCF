using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Postal.Catagalog.MvcClient.Models
{
    public class LoginModel
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; } = "ewnordin@comcast.net";

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; } = "Wr400fg!";

        [HiddenInput]
        public string ReturnUrl { get; set; }

        [HiddenInput]
        public bool RegistrationSuccessful { get; set; } = false;
    }
}