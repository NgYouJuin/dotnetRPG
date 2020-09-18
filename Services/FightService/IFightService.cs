using System.Threading.Tasks;
using dotnetRPG.Dtos.Fight;
using dotnetRPG.Models;

namespace dotnetRPG.Services.FightService
{
    public interface IFightService
    {
         Task<ServiceResponse<AttackResultDto>> WeaponAttack(WeaponAttackDto request);

         Task<ServiceResponse<AttackResultDto>> SkillAttack(SkillAttackDto request);

         Task<ServiceResponse<FightResultDto>> Fight(FightRequestDto request);
    }
}