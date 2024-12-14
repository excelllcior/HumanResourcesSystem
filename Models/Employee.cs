using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourcesSystem.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public DateTime BirthDate { get; set; }
        public int PassportSeries { get; set; }
        public int PassportNumber { get; set; }
        public string IssuedBy { get; set; }
        public DateTime IssueDate { get; set; }
        public string RegistrationAddress { get; set; }
        public string ActualAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Telegram { get; set; }
        public int PositionId { get; set; }
        public int LevelId { get; set; }
    }
}
