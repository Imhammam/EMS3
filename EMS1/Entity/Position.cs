using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Entity
{
    public class Position
    {
        [Key]
        public int PositionId { get; set; }

        [Required]
        [MaxLength(30)]
        public string PositionName { get; set; } = null!;

        public ICollection<Employee> Employees { get; set; }

        public int DepartmentId { get; set; }
        public Department Department { get; set; }

        public Position(int departmentId, string positionName)
        {
            DepartmentId = departmentId;
            PositionName = positionName;
        }

    }
}
