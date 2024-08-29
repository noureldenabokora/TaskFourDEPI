namespace TaskFour2.ViewModel
{
    public class DepartmentVM
    {

        public  int ID { get; set; }
       
        public string Name { get; set; }
    }
    public class CourseVM
    {

        public int ID { get; set; }

        public string Name { get; set; }
    }
    public class ListVM
    {

        public List<DepartmentVM> departmentVM { get; set; }

        public List<CourseVM> courseVM { get; set; }
    }
}
