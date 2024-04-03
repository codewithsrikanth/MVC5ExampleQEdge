using System.ComponentModel.DataAnnotations;

namespace DataAnnotations.CustomValidations
{
    public class AgeRangeValidationAttribute : ValidationAttribute
    {
        int _minAge;
        int _maxAge;
        public AgeRangeValidationAttribute(int minAge, int maxAge)
        {
            _minAge = minAge;
            _maxAge = maxAge;
        }

        protected override ValidationResult IsValid(object value,ValidationContext validationContext)
        {
            if(value != null)
            {
                int age;
                if(int.TryParse(value.ToString(),out age))
                {
                    if(age >= _minAge && age <= _maxAge)
                    {
                        return ValidationResult.Success;
                    }
                    else
                    {
                        return new ValidationResult($"The age must be between {_minAge} and {_maxAge}");
                    }
                }
            }
            return new ValidationResult("Please Enter Age");
        }

    }
}