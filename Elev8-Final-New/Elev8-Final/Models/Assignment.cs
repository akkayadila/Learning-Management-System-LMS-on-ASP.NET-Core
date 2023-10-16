namespace Elev8_Final.Models
{
    public class Assignment
    {
        public int AssignmentID { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public DateTime DueDate { get; set; }
        public int? CourseID { get; set; }
        public Course? Course { get; set; }


    }
}
