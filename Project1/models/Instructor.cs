
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project1.models
{
    public class Instructor
    {
        [Key]
        public int Ins_Id { get; set; }
        [MaxLength(255)]
        public string? Ins_Fname { get; set; }
        [MaxLength(255)]
        public string? Ins_Lname { get; set; }
        [MaxLength(255)]
        public string? Ins_Phone { get; set; }
        [ForeignKey(nameof(ManagedDepartment))]
        public int? Dept_Id { get; set; }

        public virtual Department ManagedDepartment { get; set; } = null!;
        public virtual ICollection<CourseSession> CourseSessions { get; set; } = new HashSet<CourseSession>();
        public ICollection<Course> Courses { get; set; } = new HashSet<Course>();

        public override string ToString()
        {
            return $"Id: {Ins_Id}, Full Name: {Ins_Fname}{Ins_Lname}, Phone: {Ins_Phone},  Department: {ManagedDepartment}";
        }

    }
}
