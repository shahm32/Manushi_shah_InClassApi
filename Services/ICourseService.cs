using System.Collections.Generic;
using System.Threading.Tasks;
using Manushi_shah_InClassApi.DTO;

namespace Manushi_shah_InClassApi.Services
{
    public interface ICourseService
    {
        Task<IEnumerable<CourseDto>> GetAllCourses();
        Task<CourseDto> GetCourseByName(string courseName);
        Task UpdateCourse(CourseDto courseDto);
    
}
}
