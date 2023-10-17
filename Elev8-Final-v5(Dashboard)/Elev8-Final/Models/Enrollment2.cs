using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace Elev8_Final.Models
{
    public class Enrollment2
    {
        [Key]
        public int EnrollmentID { get; set; } //Primary key

        [ForeignKey("IdentityUser")]
        public string? Id { get; set; } //Foreign Key - User
        public virtual IdentityUser? User { get; set; }

        [ForeignKey("Course")]
        public int? CourseID { get; set; } //Foreign Key - Course
        public Course? Course { get; set; }
        public DateTime EnrollmentDate { get; set; }

    }
}
