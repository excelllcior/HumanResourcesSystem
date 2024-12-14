using HumanResourcesSystem.Views;
using HumanResourcesSystem.Views.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourcesSystem.Presenters
{
    public class EmployeeSkillPresenter
    {
        private readonly IEmployeeSkillView employeeSkillView;

        public EmployeeSkillPresenter(IEmployeeSkillView employeeSkillView)
        {
            this.employeeSkillView = employeeSkillView;
        }
    }
}
