using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StudManagement.Model;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StudManagement.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudRepo _studRepo;

        public StudentController(IStudRepo studRepo)
        {
            _studRepo = studRepo;
        } 

        // GET: /<controller>/
        public ViewResult Index()
        {
            IEnumerable<Student> list = _studRepo.StudentList();
            return View(list);
        }
    }
}
