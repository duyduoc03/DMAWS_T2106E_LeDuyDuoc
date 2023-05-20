namespace DMAWS_T2108E_LeDuyDuoc.Models
{
    public class Project
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public DateTime ProjectStartDate { get; set; }
        public DateTime? ProjectEndDate { get; set; }
        public virtual ICollection<ProjectEmloyee> ProjectEmloyees { get; set;}

    }
}
