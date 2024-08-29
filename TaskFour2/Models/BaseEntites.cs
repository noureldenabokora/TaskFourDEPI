using System.ComponentModel.DataAnnotations;

namespace TaskFour2.Models
{
    public class BaseEntites
    {
        public int Id { get; set; }
        [Required (ErrorMessage ="must add name")]
        [MaxLength(100 , ErrorMessage ="name must be at least 5 Character")]
        [MinLength(5, ErrorMessage ="name maxlenght 100 character")]
        [NameUnique]
        public string Name { get; set; }

    }
}
