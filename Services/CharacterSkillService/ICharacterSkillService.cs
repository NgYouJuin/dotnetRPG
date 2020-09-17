using System.Threading.Tasks;
using dotnetRPG.Dtos.Character;
using dotnetRPG.Dtos.CharacterSkill;
using dotnetRPG.Models;

namespace dotnetRPG.Services.CharacterSkillService
{
    public interface ICharacterSkillService
    {
        Task<ServiceResponse<GetCharacterDto>> AddCharacterSkill(AddCharacterSkillDto newCharacterSkill);
    }
}