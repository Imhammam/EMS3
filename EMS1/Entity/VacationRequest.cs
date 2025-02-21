using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Entity
{
    public class VacationRequest
    {
        [Key]
        public int RequestId { get; set; }

        [Required]
        public DateOnly RequistSubmitionDate { get; set; }

        [Required]
        [MaxLength(100)]
        public string Description { get; set; }


        public string EmployeeNumber { get; set; }

        [ForeignKey("VacationType")]
        public string VacationTypeCode { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        [Required]
        public int TotalVacationDays { get; set; }

        public string? ApprovedByEmployee { get; set; }

        
        public string? DeclineByEmployee { get; set; }
        public int StateId { get; set; }
        public Employee Employee { get; set; }
        public Vacation VacationType { get; set; }
        public RequestState RequestState { get; set; }

        public VacationRequest() { }
        public VacationRequest(string employeeNumber, string description, string vacationTypeCode,
                           DateTime startDate, DateTime endDate, int totalVacationDays)
        {

            EmployeeNumber = employeeNumber;
            Description = description;
            VacationTypeCode = vacationTypeCode;
            StartDate = startDate;
            EndDate = endDate;
            TotalVacationDays = totalVacationDays;
            RequistSubmitionDate = DateOnly.FromDateTime(DateTime.Now); // Automatically set the submission date to today

        }



    }
}
