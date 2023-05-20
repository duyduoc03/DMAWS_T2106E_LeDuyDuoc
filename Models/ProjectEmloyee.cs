using System.ComponentModel.DataAnnotations;

namespace DMAWS_T2108E_LeDuyDuoc.Models
{
    public class ProjectEmployee
    {
        public int ProjectId { get; set; }
        public int EmployeeId { get; set; }

        [Required]
        public string Tasks { get; set; }

        public virtual Project Projects { get; set; }
        public virtual Employee Employees { get; set; }

    }
}
