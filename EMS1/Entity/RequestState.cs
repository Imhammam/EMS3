using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Entity
{
    public class RequestState
    {
        [Key]
        public int StateId { get; set; }

        [MaxLength(10)]
        public string StateName { get; set; } = null!;

        public ICollection<VacationRequest> VacationRequest { get; set; }

        public RequestState() { }
        public RequestState(int id, string name)
        {
            StateId = id;
            StateName = name;
        }


    }
}
