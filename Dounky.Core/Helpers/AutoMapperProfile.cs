using AutoMapper;
using Dounky.Core.Dtos;
using Dounky.Core.Entities;

namespace Dounky.Core.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, UserDto>();
            CreateMap<UserDto, User>();
        }
    }
}
