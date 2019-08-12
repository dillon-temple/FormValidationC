using System.ComponentModel.DataAnnotations;
namespace FormSubmission.Models
{

    public class User
    {
        private string fName;
        private string lName;
        private int age;
        private string email;
        private string password;

        [Required]
        [MinLength(2)]
        [Display(Name = "First Name:")]
        public string FName
        {
            get; set;
        }
        [Required]
        [MinLength(2)]
        [Display(Name = "Last Name:")]
        public string LName
        {
            get; set;
        }
        [Required]
        public int Age
        {
            get; set;
        }
        [Required]
        [EmailAddress]
        public string Email
        {
            get; set;
        }
        [Required]
        [DataType(DataType.Password)]
        public string Password
        {
            get; set;
        }
    }
}