using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Entity
{
    public class Employee
    {
        [Key]
        [MaxLength(6)]
        [Required]
        public string EmployeeNumber { get; set; }

        [Required]
        [MaxLength(20)]
        public string EmployeeName { get; set; }

        public int DepartmentId { get; set; }
        public Department Department { get; set; }


        public int PositionID { get; set; }
        public Position Position { get; set; }



        public char Gender { get; set; }

        [MaxLength(6)]
        public string? ReportedToEmployeeNumber { get; set; }

        public int VacationDayLeft { get; set; }


        public decimal Salary { get; set; }

        public int VacationRequestID { get; set; }

        public ICollection<VacationRequest> VacationRequest { get; set; }


        public Employee()
        {

        }
        public Employee(string employeeID, string name, int departmentId, int positionId, char gender, decimal salary)
        {
            EmployeeNumber = employeeID;
            EmployeeName = name;
            DepartmentId = departmentId;
            PositionID = positionId;
            Gender = gender;
            VacationDayLeft = 24;
            Salary = salary;
        }

    }
}
