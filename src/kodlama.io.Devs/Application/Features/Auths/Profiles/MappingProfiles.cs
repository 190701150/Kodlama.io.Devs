using Application.Features.Auths.Command.Login;
using Application.Features.Auths.Command.Register;
using AutoMapper;
using Core.Security.Entities;

namespace Application.Features.Auths.Profiles;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<User, LoginUserCommand>().ReverseMap();
        CreateMap<User, RegisterUserCommand>().ReverseMap();
    }
}