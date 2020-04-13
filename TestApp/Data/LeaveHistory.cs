using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TestApp.Data
{
    public class LeaveHistory
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("RequestingApplicationUserId")]
        public ApplicationUser RequestingApplicationUser { get; set; }
        public int RequestingApplicationUserId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        [ForeignKey("LeaveTypeId")]
        public LeaveType LeaveType { get; set; }
        public int LeaveTypeId { get; set; }
        public DateTime DateRequested { get; set; }
        public DateTime DateActioned { get; set; }
        public bool? Approved { get; set; }
       
    }
}
