using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace BID_E.Models
{
    public class Login
    {
        [Key]
        public int UserId { get; set; }

        [Required(ErrorMessage = "This feild is required")]
        [DisplayName("User Name")]
        public string Username { get; set; }
        [Required(ErrorMessage = "This feild is required")]
        [DataType(DataType.Password)]
        [DisplayName("Password")]
        public string Password { get; set; }
        //[Required(ErrorMessage = "This feild is required")]
        [DataType(DataType.Password)]
        [DisplayName("Confirm Password")]
        [Compare(("Password"), ErrorMessage = "Passwords do not match!")]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage = "This feild is required")]
        [DisplayName("E-mail")]
        public string Email { get; set; }

    }
}
