using DataAnnotations.CustomValidations;
using System.ComponentModel.DataAnnotations;

namespace DataAnnotations.Models
{
    public class Register
    {
        [Required(ErrorMessage ="Enter Eno is mandatory")]
        public int Eno { get; set; }

        [Required]
        [StringLength(10,MinimumLength =5,ErrorMessage ="Enter Ename in between 5 to 10 charecters")]
        public string Ename { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public double Salary { get; set; }

        [Required]
        //[Range(18,40,ErrorMessage ="Age should be in between 18 to 40")]
        [AgeRangeValidation(18,40,ErrorMessage="Person age should be 18 to 40")]
        public int Age { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(8,MinimumLength =3)]
        public string Password { get; set; }
        
        [Required]
        [Compare("Password")]
        public string CofirmPassword { get; set; }
    }
}