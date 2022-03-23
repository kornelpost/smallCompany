using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace smallCompany.Models
{
    public class Task
    {
        public int TaskID { get; set; }
        public string TaskName { get; set; }
        public string Details { get; set; }

        public ICollection<Assignment> Assignments { get; set; }
    }
}
