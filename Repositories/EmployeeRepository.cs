using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using HumanResourcesSystem.Models;
using HumanResourcesSystem.Repositories.Common;

namespace HumanResourcesSystem.Repositories
{
    public class EmployeeRepository : BaseRepository, IEmployeeRepository
    {
        public List<Employee> GetEmployees()
        {
            var employees = new List<Employee>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * " +
                                     "FROM employee";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Employee employee = new Employee
                                {
                                    EmployeeId = reader.GetInt32(0),
                                    LastName = reader.GetString(1),
                                    FirstName = reader.GetString(2),
                                    MiddleName = reader.GetString(3),
                                    BirthDate = reader.GetDateTime(4),
                                    PassportSeries = reader.GetInt32(5),
                                    PassportNumber = reader.GetInt32(6),
                                    IssuedBy = reader.GetString(7),
                                    IssueDate = reader.GetDateTime(8),
                                    RegistrationAddress = reader.GetString(9),
                                    ActualAddress = reader.GetString(10),
                                    PhoneNumber = reader.GetString(11),
                                    Email = reader.GetString(12),
                                    Telegram = reader.GetString(13),
                                    PositionId = reader.GetInt32(14),
                                    LevelId = reader.GetInt32(15),
                                };

                                employees.Add(employee);
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            return employees;
        }

        public Employee GetEmployee(int employeeId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * " +
                                     "FROM employee " +
                                    "WHERE id_employee = @employeeId";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@employeeId", employeeId);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Employee employee = new Employee
                                {
                                    EmployeeId = reader.GetInt32(0),
                                    LastName = reader.GetString(1),
                                    FirstName = reader.GetString(2),
                                    MiddleName = reader.GetString(3),
                                    BirthDate = reader.GetDateTime(4),
                                    PassportSeries = reader.GetInt32(5),
                                    PassportNumber = reader.GetInt32(6),
                                    IssuedBy = reader.GetString(7),
                                    IssueDate = reader.GetDateTime(8),
                                    RegistrationAddress = reader.GetString(9),
                                    ActualAddress = reader.GetString(10),
                                    PhoneNumber = reader.GetString(11),
                                    Email = reader.GetString(12),
                                    Telegram = reader.GetString(13),
                                    PositionId = reader.GetInt32(14),
                                    LevelId = reader.GetInt32(15),
                                };

                                return employee;
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

        public void InsertEmployee(Employee employee)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO employee (last_name, first_name, middle_name, birth_date, " +
                                                        "passport_series, passport_number, issued_by, issue_date, " +
                                                        "registration_addr, actual_addr, phone_number, email, telegram, " +
                                                        "position_id, level_id) " +
                                   "VALUES(@lastName, @firstName, @middleName, @birthDate, " +
                                          "@passportSeries, @passportNumber, @issuedBy, @issueDate, " +
                                          "@registrationAddress, @actualAddress, @phoneNumber, @email, @telegram, " +
                                          "@positionId, @levelId)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@lastName", employee.LastName);
                        command.Parameters.AddWithValue("@firstName", employee.FirstName);
                        command.Parameters.AddWithValue("@middleName", employee.MiddleName);
                        command.Parameters.AddWithValue("@birthDate", employee.BirthDate);
                        command.Parameters.AddWithValue("@passportSeries", employee.PassportSeries);
                        command.Parameters.AddWithValue("@passportNumber", employee.PassportNumber);
                        command.Parameters.AddWithValue("@issuedBy", employee.IssuedBy);
                        command.Parameters.AddWithValue("@issueDate", employee.IssueDate);
                        command.Parameters.AddWithValue("@registrationAddress", employee.RegistrationAddress);
                        command.Parameters.AddWithValue("@actualAddress", employee.ActualAddress);
                        command.Parameters.AddWithValue("@phoneNumber", employee.PhoneNumber);
                        command.Parameters.AddWithValue("@email", employee.Email);
                        command.Parameters.AddWithValue("@telegram", employee.Telegram);
                        command.Parameters.AddWithValue("@positionId", employee.PositionId);
                        command.Parameters.AddWithValue("@levelId", employee.LevelId);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void UpdateEmployee(Employee employee)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE employee " +
                                      "SET last_name = @lastName, first_name = @firstName, middle_name = @middleName, birth_date = @birthDate, " +
                                          "passport_series = @passportSeries, passport_number = @passportNumber, " +
                                          "issued_by = @issuedBy, issue_date = @issueDate, " +
                                          "registration_addr = @registrationAddress, actual_addr = @actualAddress, " +
                                          "phone_number = @phoneNumber, email = @email, telegram = @telegram, " +
                                          "position_id = @positionId, level_id = @levelId " +
                                    "WHERE id_employee = @employeeId";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@employeeId", employee.EmployeeId);
                        command.Parameters.AddWithValue("@lastName", employee.LastName);
                        command.Parameters.AddWithValue("@firstName", employee.FirstName);
                        command.Parameters.AddWithValue("@middleName", employee.MiddleName);
                        command.Parameters.AddWithValue("@birthDate", employee.BirthDate);
                        command.Parameters.AddWithValue("@passportSeries", employee.PassportSeries);
                        command.Parameters.AddWithValue("@passportNumber", employee.PassportNumber);
                        command.Parameters.AddWithValue("@issuedBy", employee.IssuedBy);
                        command.Parameters.AddWithValue("@issueDate", employee.IssueDate);
                        command.Parameters.AddWithValue("@registrationAddress", employee.RegistrationAddress);
                        command.Parameters.AddWithValue("@actualAddress", employee.ActualAddress);
                        command.Parameters.AddWithValue("@phoneNumber", employee.PhoneNumber);
                        command.Parameters.AddWithValue("@email", employee.Email);
                        command.Parameters.AddWithValue("@telegram", employee.Telegram);
                        command.Parameters.AddWithValue("@positionId", employee.PositionId);
                        command.Parameters.AddWithValue("@levelId", employee.LevelId);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void DeleteEmployee(int employeeId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE " +
                                     "FROM employee " +
                                    "WHERE id_employee = @employeeId";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@employeeId", employeeId);
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
