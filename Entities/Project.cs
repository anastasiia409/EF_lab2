using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_lab2.Entities
{
    public class Project
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public DateTime? DateOfStart { get; set; } = null;
        public DateTime? DateOfEnd { get; set; } = null;
        public string Description { get; set; } = null!;
    }
}
