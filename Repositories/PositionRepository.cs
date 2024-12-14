using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using HumanResourcesSystem.Models;
using HumanResourcesSystem.Repositories.Common;

namespace HumanResourcesSystem.Repositories
{
    public class PositionRepository : BaseRepository, IPositionRepository
    {
        public List<Position> GetPositions()
        {
            var positions = new List<Position>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * " +
                                     "FROM position";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Position position = new Position
                                {
                                    PositionId = reader.GetInt32(0),
                                    PositionName = reader.GetString(1),
                                    Salary = reader.GetDouble(2)
                                };

                                positions.Add(position);
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            return positions;
        }

        public Position GetPosition(int positionId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * " +
                                     "FROM position " +
                                    "WHERE id_position = @positionId";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@positionId", positionId);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Position position = new Position
                                {
                                    PositionId = reader.GetInt32(0),
                                    PositionName = reader.GetString(1),
                                    Salary = reader.GetDouble(2)
                                };

                                return position;
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


        public void InsertPosition(Position position)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO position (position_name, salary) " +
                                   "VALUES(@name, @salary)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@name", position.PositionName);
                        command.Parameters.AddWithValue("@salary", position.Salary);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void UpdatePosition(Position position)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE position " +
                                      "SET position_name = @name, salary = @salary " +
                                    "WHERE id_position = @positionId";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@positionId", position.PositionId);
                        command.Parameters.AddWithValue("@name", position.PositionName);
                        command.Parameters.AddWithValue("@salary", position.Salary);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void DeletePosition(int positionId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE " +
                                     "FROM position " +
                                    "WHERE id_position = @positionId";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@positionId", positionId);
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
