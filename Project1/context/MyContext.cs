
using Project1.models;
using Microsoft.EntityFrameworkCore;

namespace Project1.context
{
    public class MyContext : DbContext

    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=MOSTAFA_BOLBOL;Database=EFProject;Trusted_Connection=True;TrustServerCertificate=True;");
        }
        // Fluent API
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Course>().HasKey(c => c.Crs_Id);

            modelBuilder.Entity<Student_Course>()
                .HasKey(sc => new { sc.St_Id, sc.Crs_Id });


            modelBuilder.ApplyConfiguration(new STDConfig());

            // One-to-Many: A Department has many Instructors, an Instructor belongs to one Department

            modelBuilder.Entity<Instructor>()
                .HasOne(d => d.ManagedDepartment)
                .WithMany(i => i.Instructors)
                .HasForeignKey(i => i.Dept_Id)
                .OnDelete(DeleteBehavior.Restrict);// Prevents cascade delete issues
            //One - to - One TT:
            modelBuilder.Entity<Department>()
                .HasOne(d => d.DeptManager)
                .WithOne()
                .HasForeignKey<Department>(i => i.Dept_Manager)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Instructor>()
            //    .HasOne(i => i.Department) // Assuming the Instructor has a navigation property to Department
            //    .WithOne()
            //    .HasForeignKey<Instructor>(i => i.Ins_Id) // Ensures an instructor can be a manager of only one department
            //    .IsRequired()
            //    .OnDelete(DeleteBehavior.Restrict);

            #region Seeding
            //Seeding Instructors
            modelBuilder.Entity<Instructor>().HasData(
                new Instructor { Ins_Id = 1, Ins_Fname = "Ahmed", Ins_Lname = "Ali", Ins_Phone = "0100000001",    Dept_Id = 1},
                new Instructor { Ins_Id = 2, Ins_Fname = "Mona", Ins_Lname = "Hassan", Ins_Phone = "0100000002",  Dept_Id = 2},
                new Instructor { Ins_Id = 3, Ins_Fname = "Khaled", Ins_Lname = "Omar", Ins_Phone = "0100000003",  Dept_Id = 3},
                new Instructor { Ins_Id = 4, Ins_Fname = "Sarah", Ins_Lname = "Mahmoud", Ins_Phone = "0100000004",Dept_Id = 2},
                new Instructor { Ins_Id = 5, Ins_Fname = "Tamer", Ins_Lname = "Fahmy", Ins_Phone = "0100000005", Dept_Id = 3 }
            );
            // Seeding Departments
            modelBuilder.Entity<Department>().HasData(
                new Department { Dept_Id = 1, Dept_Name = "Computer Science", Dept_Location = "Building A", Dept_Manager = 1 },
                new Department { Dept_Id = 2, Dept_Name = "Mathematics", Dept_Location = "Building B", Dept_Manager = 2 },
                new Department { Dept_Id = 3, Dept_Name = "Physics", Dept_Location = "Building C", Dept_Manager = 3 }
            );
            //modelBuilder.Entity<Instructor>().HasData(
            //    new Instructor { Ins_Id = 1, Dept_Id = 1 },
            //    new Instructor { Ins_Id = 2, Dept_Id = 2 },
            //    new Instructor { Ins_Id = 3, Dept_Id = 3 },
            //    new Instructor { Ins_Id = 4, Dept_Id = 2 },
            //    new Instructor { Ins_Id = 5, Dept_Id = 3 }
            //);

            // Seeding Courses
            modelBuilder.Entity<Course>().HasData(
                new Course { Crs_Id = 1, Crs_Name = "Algorithms", Crs_Duration = 45, Dept_Id = 1, Ins_Id = 1 },
                new Course { Crs_Id = 2, Crs_Name = "Data Structures", Crs_Duration = 50, Dept_Id = 1, Ins_Id = 4 },
                new Course { Crs_Id = 3, Crs_Name = "Calculus", Crs_Duration = 40, Dept_Id = 2, Ins_Id = 2 },
                new Course { Crs_Id = 4, Crs_Name = "Linear Algebra", Crs_Duration = 42, Dept_Id = 2, Ins_Id = 5 },
                new Course { Crs_Id = 5, Crs_Name = "Quantum Mechanics", Crs_Duration = 55, Dept_Id = 3, Ins_Id = 3 }
            );

            ////// Seeding Students
            modelBuilder.Entity<Student>().HasData(
                new Student { St_Id = 1, St_Fname = "Youssef", St_Lname = "Hassan", St_Phone = "0111111111" },
                new Student { St_Id = 2, St_Fname = "Nour", St_Lname = "Mohamed", St_Phone = "0111111112" },
                new Student { St_Id = 3, St_Fname = "Hussein", St_Lname = "Sami", St_Phone = "0111111113" },
                new Student { St_Id = 4, St_Fname = "Laila", St_Lname = "Osman", St_Phone = "0111111114" },
                new Student { St_Id = 5, St_Fname = "Mariam", St_Lname = "Zaki", St_Phone = "0111111115" }
            );

            ////// Seeding Student_Courses
            modelBuilder.Entity<Student_Course>().HasData(
                new Student_Course { St_Id = 1, Crs_Id = 1 },
                new Student_Course { St_Id = 1, Crs_Id = 2 },
                new Student_Course { St_Id = 2, Crs_Id = 3 },
                new Student_Course { St_Id = 3, Crs_Id = 4 },
                new Student_Course { St_Id = 4, Crs_Id = 5 },
                new Student_Course { St_Id = 5, Crs_Id = 1 },
                new Student_Course { St_Id = 5, Crs_Id = 3 }
            );

            ////// Seeding CourseSessions
            modelBuilder.Entity<CourseSession>().HasData(
                new CourseSession { CourseSessionId = 1, Ins_Id = 1, Crs_Id = 1, Title = "Intro to Algorithms", Crs_Date = new DateTime(2024, 1, 1) },
                new CourseSession { CourseSessionId = 2, Ins_Id = 2, Crs_Id = 3, Title = "Calculus Basics", Crs_Date = new DateTime(2025, 2, 2) },
                new CourseSession { CourseSessionId = 3, Ins_Id = 3, Crs_Id = 5, Title = "Quantum Principles", Crs_Date = new DateTime(2020, 3, 3) }
            );

            ////// Seeding CourseSessionAttendance
            modelBuilder.Entity<CourseSessionAttendance>().HasData(
                new CourseSessionAttendance { CrsAttendance_Id = 1, CourseSessionID = 1, StudentID = 1, Grade = 90, Notes = "Excellent" },
                new CourseSessionAttendance { CrsAttendance_Id = 2, CourseSessionID = 1, StudentID = 2, Grade = 85, Notes = "Very Good" },
                new CourseSessionAttendance { CrsAttendance_Id = 3, CourseSessionID = 2, StudentID = 3, Grade = 88, Notes = "Good" },
                new CourseSessionAttendance { CrsAttendance_Id = 4, CourseSessionID = 3, StudentID = 4, Grade = 92, Notes = "Outstanding" },
                new CourseSessionAttendance { CrsAttendance_Id = 5, CourseSessionID = 3, StudentID = 5, Grade = 78, Notes = "Needs Improvement" }
            );
            #endregion

            base.OnModelCreating(modelBuilder);
        }


        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Instructor> Instructors { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Student_Course> Student_Courses { get; set; }
        public virtual DbSet<CourseSession> CourseSessions { get; set; }
        public virtual DbSet<CourseSessionAttendance> CourseSessionAttendances { get; set; }


    }
}
