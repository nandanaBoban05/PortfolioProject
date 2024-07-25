namespace PortfolioProject.Models
{
    public class Project
    {
        public int ProjectId { get; set; }
        public String Name { get; set; }
        public String Url { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }

    }
}
