using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace DMAWS_T2108E_LeDuyDuoc.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }

        [Required]
        [StringLength(100)]
        public string EmployeeName { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Date of Birth")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime EmployeeDOB { get; set; }

        [Required]
        [StringLength(50)]
        public string EmployeeDepartment { get; set; }

        public virtual ICollection<ProjectEmployee> ProjectEmployees { get; set; }

    }
}
