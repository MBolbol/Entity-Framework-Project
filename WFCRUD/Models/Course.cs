﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFCRUD.Models;

[Index("Dept_Id", Name = "IX_Courses_Dept_Id")]
[Index("Ins_Id", Name = "IX_Courses_Ins_Id")]
public partial class Course
{
    [Key]
    public int Crs_Id { get; set; }

    [StringLength(50)]
    public string Crs_Name { get; set; }

    public int? Crs_Duration { get; set; }

    public int? Dept_Id { get; set; }

    public int Ins_Id { get; set; }

    [InverseProperty("Crs")]
    public virtual ICollection<CourseSession> CourseSessions { get; set; } = new List<CourseSession>();

    [ForeignKey("Dept_Id")]
    [InverseProperty("Courses")]
    public virtual Department Dept { get; set; }

    [ForeignKey("Ins_Id")]
    [InverseProperty("Courses")]
    public virtual Instructor Ins { get; set; }

    [ForeignKey("Crs_Id")]
    [InverseProperty("Crs")]
    public virtual ICollection<Student> Sts { get; set; } = new List<Student>();
}