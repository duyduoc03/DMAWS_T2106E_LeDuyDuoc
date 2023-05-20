namespace DMAWS_T2108E_LeDuyDuoc.Models
{
    public class Emloyee
    {
        public int EmloyeeId { get; set; }
        public string EmloyeeName { get; set; }
        public DateTime EmloyeeDOB { get; set; }
        public string EmloyeeDepartment { get; set; }
        public virtual ICollection<ProjectEmloyee> ProjectEmloyees { get; set; }
    }
}
