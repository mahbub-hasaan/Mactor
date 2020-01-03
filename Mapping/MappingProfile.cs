using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Mactor.DAL.Entites;
using Mactor.Models;
namespace Mactor.Mapping
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<User,UserDto>()
                .ForMember(des=>des.FullName,opt=>opt.MapFrom(src=>src.FistName+" "+src.LastName))
                .ForMember(des => des.UserName, opt => opt.MapFrom(src =>src.UserName))
                .ForMember(des => des.Email, opt => opt.MapFrom(src => src.Email))
                .ForMember(des => des.FirstName, opt => opt.MapFrom(src => src.FistName)); ;

            CreateMap<UserCreatDto,User>()
                .ForMember(des => des.PasswordHash, opt => opt.MapFrom(src => src.Password))
                .ForMember(des => des.UserName, opt => opt.MapFrom(src => src.UserName))
                .ForMember(des => des.Email, opt => opt.MapFrom(src => src.Email))
                .ForMember(des => des.FistName, opt => opt.MapFrom(src => src.FirstName));
        }
    }
}
