using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using Manushi_shah_InClassApi.Models;
using Manushi_shah_InClassApi.DTO;
using Manushi_shah_InClassApi.Data;
namespace Manushi_shah_InClassApi.Services
{

    public class CourseService : ICourseService
    {
        private readonly List<CourseDto> _courses;

        public CourseService()
        {
            _courses = new List<CourseDto>
            {
                new CourseDto
                {
                    Id = 1,
                    Name = "Course1",
                    Description = "Description1",

                    StartDate = new DateTime(2024, 7, 30),
                    EndDate = new DateTime(2024, 1, 30)
                },
                new CourseDto
                {
                    Id = 2,
                    Name = "Course2",
                    Description = "Description2",

                    StartDate = new DateTime(2024, 7, 30),
                    EndDate = new DateTime(2024, 1, 30)
                },
                 new CourseDto
                {
                    Id = 3,
                    Name = "Course3",
                    Description = "Description3",

                    StartDate = new DateTime(2024, 7, 30),
                    EndDate = new DateTime(2024, 1, 30)
                }
            };
        }

        public async Task<CourseDto> GetCourseByName(string courseName)
        {
            return await Task.FromResult(_courses.FirstOrDefault(c => c.Name == courseName));
        }

        public async Task<IEnumerable<CourseDto>> GetAllCourses()
        {
            return await Task.FromResult(_courses);
        }

        public async Task<bool> UpdateCourse(CourseDto courseDto)
        {
            var existingData = _courses.FirstOrDefault(c => c.Id == courseDto.Id);
            if (existingData == null)
            {
                return await Task.FromResult(false);
            }

            existingData.Name = courseDto.Name;
            existingData.Description = courseDto.Description;

            existingData.StartDate = courseDto.StartDate;
            existingData.EndDate = courseDto.EndDate;

            return await Task.FromResult(true);
        }

        Task ICourseService.UpdateCourse(CourseDto courseDto)
        {
            throw new NotImplementedException();
        }
    }
}
