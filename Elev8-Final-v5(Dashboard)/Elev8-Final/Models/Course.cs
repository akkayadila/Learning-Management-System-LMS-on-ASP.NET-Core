namespace Elev8_Final.Models
{
    public class Course
    {
        public int CourseID { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Category { get; set; }
        public int EnrollmentCount { get; set; }

        //public string ImageUrl
        public List<Assignment>? Assignments { get; set; }
        public List<Enrollment2>? Enrollments { get; set; }

    }
}
