using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using HumanResourcesSystem.Models;
using HumanResourcesSystem.Repositories.Common;

namespace HumanResourcesSystem.Repositories
{
    public class SkillRepository : BaseRepository, ISkillRepository
    {
        public List<Skill> GetSkills()
        {
            var skills = new List<Skill>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * " +
                                     "FROM skill";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Skill skill = new Skill
                                {
                                    SkillId = reader.GetInt32(0),
                                    SkillName = reader.GetString(1),
                                };

                                skills.Add(skill);
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            return skills;
        }

        public Skill GetSkill(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * " +
                                     "FROM skill " +
                                    "WHERE id_skill = @skillId";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@skillId", id);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Skill skill = new Skill
                                {
                                    SkillId = reader.GetInt32(0),
                                    SkillName = reader.GetString(1),
                                };

                                return skill;
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            return null;
        }

        public void InsertSkill(Skill skill)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO skill (skill_name) " +
                                   "VALUES(@name)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@name", skill.SkillName);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void UpdateSkill(Skill skill)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE skill " +
                                      "SET skill_name = @name " +
                                    "WHERE id_skill = @skillId";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@skillId", skill.SkillId);
                        command.Parameters.AddWithValue("@name", skill.SkillName);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void DeleteSkill(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE " +
                                     "FROM skill " +
                                    "WHERE id_skill = @skillId";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@skillId", id);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
