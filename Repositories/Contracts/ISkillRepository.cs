using System.Collections.Generic;
using HumanResourcesSystem.Models;

namespace HumanResourcesSystem.Repositories
{
    public interface ISkillRepository
    {
        List<Skill> GetSkills();
        Skill GetSkill(int skillId);
        void InsertSkill(Skill skill);
        void UpdateSkill(Skill skill);
        void DeleteSkill(int skillId);
    }
}
