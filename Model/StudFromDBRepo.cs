using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudManagement.Model
{
    public class StudFromDBRepo : IStudRepo
    {
        private readonly AppDBContext _appContext;

        public StudFromDBRepo(AppDBContext appContext)
        {
            _appContext = appContext;
        }

        public IEnumerable<Student> StudentList()
        {
            return _appContext.Students;
        }
    }
}
