using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public interface ICourseManagementService
    {
        (IList<Course> courses, int total, int totalAfterFilter) GetFilteredCourses();
    }
}
