using System.ComponentModel.DataAnnotations;
using TaskFour2.Models;

namespace TaskFour2.ViewModel
{
    public class DepartmentInstructorVM
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "must add name")]
        [MaxLength(100, ErrorMessage = "name must be at least 5 Character")]
        [MinLength(5, ErrorMessage = "name maxlenght 100 character")]
        [NameUnique]

        public string Name { get; set; }
      //  [RegularExpression(@"\w*\.(png | jpg)", ErrorMessage = "image extension must be JPG or PNG")]
        public string ImageURL { get; set; }

        [MaxLength(100, ErrorMessage = "address maxlenght 100 character ")]
        [MinLength(5, ErrorMessage = "address must be at least 5 Character")]
        public string Address { get; set; }
        public int DepartmentID { get; set; }
        public int CourseID { get; set; }


        public List<DepartmentVM> DepartmentsVM { get; set; }

        public List<CourseVM> CourseVM { get; set; }

    }
}
