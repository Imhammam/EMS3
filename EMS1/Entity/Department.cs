using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Entity
{
    public class Department
    {

        [Key]
        public int DepartmentId { get; set; }
        [MaxLength(50)]
        public string DepartmentName { get; set; } = null!;


        public ICollection<Employee> Employees { get; set; }

        public ICollection<Position> Positions { get; set; }
        public Department() { }
        public Department(string name) { DepartmentName = name; }


    }
}
