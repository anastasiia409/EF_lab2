using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_lab2.Entities
{
    public class EmployeeProject
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int PositionId { get; set; }
        public int ProjectId { get; set; }
        public DateTime? DateOfJoin { get; set; }
        public Employee Employee { get; set; } = null!;
        public Project Project { get; set; } = null!;
        public Position Position { get; set; } = null!;
        
    }
}
