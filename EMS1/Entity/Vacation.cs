using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Entity
{
    public class Vacation
    {
        [Key]
        [MaxLength(1)]
        public string VacationTypeCode { get; set; }


        [Required]
        [MaxLength(20)]
        public string VacationTypeName { get; set; }

        public ICollection<VacationRequest> VacationRequest { get; set; }

        public Vacation() { }
        public Vacation(string type)
        {
            VacationTypeCode = type;

        }
        public Vacation(string vacationTypeCode, string vacationTypeName)
        {
            VacationTypeCode = vacationTypeCode;
            VacationTypeName = vacationTypeName;
        }

    }
}
