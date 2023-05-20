namespace DMAWS_T2108E_LeDuyDuoc.Models
{
    public class ProjectEmloyee
    {
        public int ProjectId { get; set; }
        public int EmloyeeId { get; set; }
        public string Tasks { get; set; }
        public virtual Project Projects { get; set; }
        public virtual Emloyee Emloyees { get; set; }

    }
}
