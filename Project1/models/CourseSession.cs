using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
namespace Project1.models
{
    public class CourseSession
    {
        [Key]
        public int CourseSessionId { get; set; }
        [ForeignKey("Instructor")]
        public int? Ins_Id { get; set; }
        [ForeignKey("Course")]
        public int? Crs_Id { get; set; }
        [MaxLength(255)]
        public string? Title { get; set; }
        public DateTime Crs_Date { get; set; } = DateTime.Now;
        public Course Course { get; set; } = null!;
        public Instructor Instructor { get; set; } = null!;

        public virtual ICollection<CourseSessionAttendance> CourseSessionAttendances { get; set; } = new HashSet<CourseSessionAttendance>();

        public override string ToString()
        {
            return $"Ins_Id: {Ins_Id},Crs_Id{Crs_Id}, Title: {Title},Date: {Crs_Date}";
        }
    }
}
