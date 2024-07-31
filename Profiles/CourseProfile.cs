using AutoMapper;
using Manushi_shah_InClassApi.Models;
using Manushi_shah_InClassApi.DTO;
namespace Manushi_shah_InClassApi.Profiles
{
    public class CourseProfile : Profile
    {
        public CourseProfile()
        {
            CreateMap<Course, CourseDto>();
            CreateMap<CourseDto, Course>();
        }
    }
}
