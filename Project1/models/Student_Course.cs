
using System.ComponentModel.DataAnnotations.Schema;


namespace Project1.models
{
    public class Student_Course
    {
        [ForeignKey("Student")]
        public int St_Id { get; set; }
        [ForeignKey("Course")]
        public int Crs_Id { get; set; }

        public Student Student { get; set; } = null!;
        public Course Course { get; set; } = null!;

        public override string ToString()
        {
            return $"St_Id: {St_Id},Crs_Id{Crs_Id}";
        }


    }
}
