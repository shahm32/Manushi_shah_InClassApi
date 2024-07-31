using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Manushi_shah_InClassApi.Models;
using Manushi_shah_InClassApi.DTO;
using Manushi_shah_InClassApi.Services;

namespace Manushi_shah_InClassApi.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICourseService _courseService;

        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        [HttpGet("GetCourseByName/{courseName}")]
        public async Task<ActionResult<CourseDto>> GetCourseByName(string courseName)
        {
            var course = await _courseService.GetCourseByNameAsync(courseName);
            if (course == null) return NotFound();
            return Ok(course);
        }

        [HttpGet("GetAllCourses")]
        public async Task<ActionResult<IEnumerable<CourseDto>>> GetAllCourses()
        {
            var courses = await _courseService.GetAllCoursesAsync();
            return Ok(courses);
        }

        [HttpPut("UpdateCourse")]
        public async Task<IActionResult> UpdateCourse(CourseDto courseDto)
        {
            await _courseService.UpdateCourseAsync(courseDto);
            return NoContent();
        }
    }
}
