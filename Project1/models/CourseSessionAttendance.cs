
using System.ComponentModel.DataAnnotations;


namespace Project1.models
{
    public class CourseSessionAttendance
    {
        [Key] 
        public int CrsAttendance_Id { get; set; }
        public int? Grade { get; set; }
        public string? Notes { get; set; }

        public int? CourseSessionID { get; set; }
        public int? StudentID { get; set; }
        public virtual CourseSession CourseSession { get; set; } = null!;
        public virtual Student Student { get; set; } = null!;
        public override string ToString()
        {
            return $"Id: {CrsAttendance_Id}, Grade: {Grade}, Notes: {Notes}";
        }

    }
}
