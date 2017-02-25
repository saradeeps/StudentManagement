using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudManagement.Model
{
    public interface IStudRepo
    {
         IEnumerable<Student> StudentList();
    }
}
