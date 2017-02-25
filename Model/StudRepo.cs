using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudManagement.Model
{
    public class StudRepo : IStudRepo
    {
        public IEnumerable<Student> StudentList()
        {
            List<Student> list = new List<Student>();
            Student stud = new Student()
            {
                Id = 1,
                Name = "Abhi"
            };
            Student stud2 = new Student()
            {
                Id = 2,
                Name = "Banu"
            };
            list.Add(stud);
            list.Add(stud2);
            return list;
        }
    }
}
