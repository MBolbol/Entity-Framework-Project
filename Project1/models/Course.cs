

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project1.models
{
    public class Course
    {
        public int Crs_Id { get; set; }
        [MaxLength(50)]
        public string? Crs_Name { get; set; }
        

        public int? Crs_Duration { get; set; }
        [ForeignKey(nameof(Department))]
        public int? Dept_Id { get; set; }
        [ForeignKey(nameof(Instructor))]
        public int Ins_Id { get; set; }

        public virtual Instructor Instructor { get; set; } = null!;
        public virtual Department Department { get; set; } = null!;
        public virtual ICollection<Student_Course> Student_Courses { get; set; } = new  HashSet<Student_Course>();

        public override string ToString()
        {
            return $"Id:{Crs_Id},Name: {Crs_Name}, Duration: {Crs_Duration} ";
        }


    }
}
