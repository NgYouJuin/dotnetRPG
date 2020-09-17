using System.Linq;
using AutoMapper;
using dotnetRPG.Dtos.Character;
using dotnetRPG.Dtos.Weapon;
using dotnetRPG.Models;

namespace dotnetRPG
{
    public class AutoMapperProfile: Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character, GetCharacterDto>()
            .ForMember(dto => dto.Skills, c => c.MapFrom(c => c.CharacterSkills.Select(cs => cs.Skill)));
            CreateMap<AddCharacterDto, Character>();
            CreateMap<UpdateCharacterDto, Character>();
            CreateMap<Weapon, GetWeaponDto>();
            CreateMap<Skill, GetCharacterDto>();
        }
    }
}