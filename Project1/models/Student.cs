
using System.ComponentModel.DataAnnotations;



namespace Project1.models
{
    public class Student
    {
        public int St_Id { get; set; }
        //*************************************************
        [MinLength(3)]
        [MaxLength(50)]

        public string? St_Fname { get; set; }
        //*************************************************
        [MaxLength(10)]

        public string? St_Lname { get; set; }
        //*************************************************


        public string? St_Phone { get; set; }
        //*************************************************

        public virtual ICollection<Student_Course> Student_Courses { get; set; } = new HashSet<Student_Course>();
        public virtual ICollection<CourseSessionAttendance> CourseSessionAttendances { get; set; } = new HashSet<CourseSessionAttendance>();

        public override string ToString()
        {
            return $"Id: {St_Id}, Full_Name: {St_Fname}{St_Lname}, Phone: {St_Phone}";
        }

    }
}
