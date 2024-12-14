using System;
using System.Data;
using System.Linq;
using HumanResourcesSystem.Views;
using HumanResourcesSystem.Models;
using HumanResourcesSystem.Repositories;
using HumanResourcesSystem.Properties;
using HumanResourcesSystem.Presenters.Common;

namespace HumanResourcesSystem.Presenters
{
    public class SkillPresenter
    {
        private readonly ISkillView skillView;
        private readonly ISkillRepository skillRepository;
        private DataTable skillDataTable;

        private readonly string[] skillDataTableColumnNames = {
            "Id", "Наименование"
        };

        public SkillPresenter(ISkillView skillView)
        {
            this.skillView = skillView;
            skillRepository = new SkillRepository();

            LoadSkills();
            AssociateViewEventsWithPresenterEvents();
        }

        private void AssociateViewEventsWithPresenterEvents()
        {
            skillView.AddSkillEvent += AddSkill;
            skillView.EditSkillEvent += EditSkill;
            skillView.RemoveSkillEvent += RemoveSkill;
            skillView.SaveChangesEvent += SaveChanges;
            skillView.CancelChangesEvent += CancelChanges;
        }

        private void LoadSkills()
        {
            var skills = skillRepository.GetSkills();

            skillDataTable = new DataTable();

            foreach (var column in skillDataTableColumnNames)
            {
                skillDataTable.Columns.Add(column);
            }

            foreach (var skill in skills)
            {
                var row = skillDataTable.NewRow();

                row[skillDataTableColumnNames[0]] = skill.SkillId;
                row[skillDataTableColumnNames[1]] = skill.SkillName;

                skillDataTable.Rows.Add(row);
            }
            
            skillView.FillDataGridViewSkills(skillDataTable);
        }

        private void AddSkill(object sender, EventArgs e)
        {
            skillView.IsEdit = false;
        }

        private void EditSkill(object sender, EventArgs e)
        {
            skillView.IsEdit = true;

            DataRow selectedRow = skillDataTable.AsEnumerable()
                .FirstOrDefault(row => Convert.ToInt32(row[0]) == skillView.SelectedSkillId);

            if (selectedRow != null)
            {
                skillView.SkillName = selectedRow[1].ToString();
            }
        }

        private void RemoveSkill(object sender, EventArgs e)
        {
            try
            {
                skillRepository.DeleteSkill(skillView.SelectedSkillId);
                skillView.IsSuccessful = true;
                skillView.Message = Resources.MessageSuccessfulDelete;

                LoadSkills();
            }
            catch (Exception ex)
            {
                skillView.IsSuccessful = false;
                skillView.Message = ex.Message;
            }
        }

        private void SaveChanges(object sender, EventArgs e)
        {
            Skill skill = new Skill();

            try
            {
                if (Validation.ValidateStringValue(skillView.SkillName, skillDataTableColumnNames[1]))
                    skill.SkillName = skillView.SkillName;

                switch (skillView.IsEdit)
                {
                    case false:
                        skillRepository.InsertSkill(skill);
                        skillView.Message = Resources.MessageSuccessfulInsert;
                        break;
                    case true:
                        skillRepository.UpdateSkill(skill);
                        skillView.Message = Resources.MessageSuccessfulUpdate;
                        break;
                }

                LoadSkills();
                ResetViewFields();
                skillView.IsSuccessful = true;
            }
            catch (Exception ex)
            {
                skillView.IsSuccessful = false;
                skillView.Message = ex.Message;
            }
        }

        private void CancelChanges(object sender, EventArgs e)
        {
            ResetViewFields();
        }

        private void ResetViewFields()
        {
            skillView.SkillName = string.Empty;
        }
    }
}
