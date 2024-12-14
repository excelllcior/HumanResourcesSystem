using HumanResourcesSystem.Repositories.Common;
using HumanResourcesSystem.Views.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourcesSystem.Repositories
{
    public class EmployeeSkillRepository : BaseRepository, IEmployeeSkillRepository
    {
        public List<EmployeeSkill> GetEmployeeSkills(int employee)
        {
            throw new NotImplementedException();
        }

        public void InsertEmployeeSkill(EmployeeSkill employeeSkill)
        {
            throw new NotImplementedException();
        }

        public void DeleteEmployeeSkill(int employee)
        {
            throw new NotImplementedException();
        }
    }
}
