using System.ComponentModel.DataAnnotations;

namespace TaskFour2.Models
{
    public class NameUniqueAttribute : ValidationAttribute
    {
        DatabaseEntites databaseEntites = new DatabaseEntites();
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            string name = value.ToString();
            Instructor instructor = databaseEntites.Instructors.FirstOrDefault(a => a.Name == name);
            if (instructor == null)
            {
                return ValidationResult.Success;
            }

            return new ValidationResult("Name already exist");
        }
    }
}
