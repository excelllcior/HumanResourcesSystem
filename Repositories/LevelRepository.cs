using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using HumanResourcesSystem.Models;
using HumanResourcesSystem.Repositories.Common;
using HumanResourcesSystem.Repositories.Contracts;

namespace HumanResourcesSystem.Repositories
{
    public class LevelRepository : BaseRepository, ILevelRepository
    {
        public List<Level> GetLevels()
        {
            var levels = new List<Level>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * " +
                                     "FROM level";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Level level = new Level
                                {
                                    LevelId = reader.GetInt32(0),
                                    LevelName = reader.GetString(1),
                                    SalaryCoefficient = reader.GetDouble(2)
                                };

                                levels.Add(level);
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            return levels;
        }

        public Level GetLevel(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * " +
                                     "FROM level " +
                                    "WHERE id_level = @levelId";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@levelId", id);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Level level = new Level
                                {
                                    LevelId = reader.GetInt32(0),
                                    LevelName = reader.GetString(1),
                                    SalaryCoefficient = reader.GetDouble(2)
                                };

                                return level;
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

        public void InsertLevel(Level level)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO level (level_name, salary_coefficient) " +
                                   "VALUES(@name, @salaryCoefficient)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@name", level.LevelName);
                        command.Parameters.AddWithValue("@salaryCoefficient", level.SalaryCoefficient);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void UpdateLevel(Level level)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE level " +
                                      "SET level_name = @name, salary_coefficient = @salaryCoefficient " +
                                    "WHERE id_level = @levelId";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@levelId", level.LevelId);
                        command.Parameters.AddWithValue("@name", level.LevelName);
                        command.Parameters.AddWithValue("@salaryCoefficient", level.SalaryCoefficient);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void DeleteLevel(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE " +
                                     "FROM level " +
                                    "WHERE id_level = @levelId";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@levelId", id);
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
