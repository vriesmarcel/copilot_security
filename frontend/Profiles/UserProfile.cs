using AutoMapper;
using frontend.Models;
using frontend.Models.View;

namespace frontend.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserUpdateViewModel>().ReverseMap()
                .ForMember(dest => dest.IsAdmin, opt => opt.Ignore()); // Exclude IsAdmin from mapping
        }
    }
}
