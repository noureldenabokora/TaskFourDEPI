using Microsoft.AspNetCore.Mvc;
using TaskFour2.Models;
using TaskFour2.ViewModel;

namespace TaskFour2.Controllers
{
    public class InstructorController : Controller
    {
        DatabaseEntites dbcontext = new DatabaseEntites();

        //Instructor/GetAllInstructors
        public IActionResult GetAllInstructors()
        {

            var allinstructors = dbcontext.Instructors.ToList();
            return View(allinstructors);
        }
        //Instructor/Create

        [HttpGet]
        public IActionResult Create()
        {
            ListVM listVM = new ListVM 
            { departmentVM = dbcontext.Departments.Select(a => new DepartmentVM { ID = a.Id, Name = a.Name }).ToList(), 
                courseVM = dbcontext.Courses.Select(a => new CourseVM { ID = a.Id, Name = a.Name }).ToList() 
            };

            return View(listVM);
        }
        [HttpPost]
        public IActionResult Create(Instructor instructor)
        {
            if (instructor != null)
            {
                dbcontext.Instructors.Add(instructor);
                dbcontext.SaveChanges();
                return RedirectToAction("GetAllInstructors");

            }
            return View();
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            DepartmentInstructorVM departmentInstructorVM = new DepartmentInstructorVM();
            var inst = dbcontext.Instructors.FirstOrDefault(a => a.Id == id);

            departmentInstructorVM.ID = inst.Id;
            departmentInstructorVM.Name = inst.Name;
            departmentInstructorVM.Address = inst.Address;
            departmentInstructorVM.ImageURL = inst.ImageURL;
            departmentInstructorVM.DepartmentID = inst.DepartmentID;
            departmentInstructorVM.CourseID = inst.CourseID;
            departmentInstructorVM.DepartmentsVM = dbcontext.Departments.Select(a => new DepartmentVM { ID = a.Id, Name = a.Name }).ToList();
            departmentInstructorVM.CourseVM = dbcontext.Courses.Select(a => new CourseVM { ID = a.Id, Name = a.Name }).ToList();
            return View(departmentInstructorVM);
        }

        public IActionResult Edit(Instructor instructor, int id)
        {

            instructor.ImageURL = string.Empty;
            if (instructor.Id == id)
            {
                if (ModelState.IsValid)
                {

                    dbcontext.Update(instructor);
                    dbcontext.SaveChanges();
                    return RedirectToAction("GetAllInstructors");
                }
            }
            DepartmentInstructorVM departmentInstructorVM = new DepartmentInstructorVM();

            departmentInstructorVM.ID = instructor.Id;
            departmentInstructorVM.Name = instructor.Name;
            departmentInstructorVM.Address = instructor.Address;
            departmentInstructorVM.ImageURL = instructor.ImageURL;
            departmentInstructorVM.DepartmentID = instructor.DepartmentID;
            departmentInstructorVM.CourseID = instructor.CourseID;
            departmentInstructorVM.DepartmentsVM = dbcontext.Departments.Select(a => new DepartmentVM { ID = a.Id, Name = a.Name }).ToList();
            departmentInstructorVM.CourseVM = dbcontext.Courses.Select(a => new CourseVM { ID = a.Id, Name = a.Name }).ToList();
            return View(departmentInstructorVM);
          

        }

        public IActionResult Delete(int id)
        {
            var deleteinst = dbcontext.Instructors.FirstOrDefault(a => a.Id == id);
            if (deleteinst != null)
            {
                dbcontext.Instructors.Remove(deleteinst);
                dbcontext.SaveChanges();
                return RedirectToAction("GetAllInstructors");

            }
            return RedirectToAction("GetAllInstructors");

        }

    }
}
