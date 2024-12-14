using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourcesSystem.Views.Contracts
{
    public interface IEmployeeSkillRepository
    {
        List<EmployeeSkill> GetEmployeeSkills(int employee);
        void InsertEmployeeSkill(EmployeeSkill employeeSkill);
        void DeleteEmployeeSkill(int employee);
    }
}
