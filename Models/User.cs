using System.ComponentModel.DataAnnotations;
namespace validatingFormSubmission.Models
{
    public class User
    {
        [Required(ErrorMessage="Please enter your first name")]
        [MinLength(4, ErrorMessage= "First name must be at least 4 characters")]
        public string FirstName {get;set;}
        [Required(ErrorMessage="Please enter your last name")]
        [MinLength(4, ErrorMessage="Last name must be at least 4 characters")]
        public string LastName {get;set;}
        [Required(ErrorMessage="Please enter your age")]
        [Range(10,100, ErrorMessage="Enter a valid age between 10-100")]
        public int Age {get;set;}

        [Required(ErrorMessage="Please enter your email")]
        [EmailAddress(ErrorMessage="Please enter a valid email address")]
        public string Email {get;set;}

        [Required(ErrorMessage="Please enter a password")]
        [MinLength(8, ErrorMessage="Please enter a password with a minimum of 8 characters")]
        public string Password {get;set;}
    }
}