
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Project1.models
{
    public class Department
    {
        [Key]
        public int Dept_Id { get; set; }
        [MaxLength(255)]
        public string? Dept_Name { get; set; }
        [MaxLength(255)]
        public string? Dept_Location { get; set; }
        [ForeignKey("DeptManager")]
        public int? Dept_Manager { get; set; }
        public virtual Instructor DeptManager { get; set; } = null!;

        public virtual ICollection<Course> Courses { get; set; }= new HashSet<Course>();
        public virtual ICollection<Instructor> Instructors { get; set; }= new HashSet<Instructor>();

        public override string ToString()
        {
            return $"Id:{Dept_Id}, Name: {Dept_Name}, Location:{Dept_Location}, Manager: {Dept_Manager}";
        }



    }
}
