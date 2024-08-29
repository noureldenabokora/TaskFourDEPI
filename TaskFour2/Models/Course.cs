using Microsoft.AspNetCore.Cors.Infrastructure;

namespace TaskFour2.Models
{
    public class Course : BaseEntites
    {
        public int degree { get; set; }
        public int mindDegree { get; set; }
        public int DepartmentId { get; set; }

        public virtual Department department { get; set; }

        public virtual ICollection<Instructor> instructors { get; set; }

        public virtual ICollection<CourseResult> CourseResults { get; set; }


    }
}
