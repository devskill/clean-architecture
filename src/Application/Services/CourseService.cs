using Domain.Entities;
using Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class CourseService : ICourseService
    {
        public (IList<Course> courses, int total, int totalAfterFilter) GetFilteredCourses()
        {
            throw new NotImplementedException();
        }
    }
}
