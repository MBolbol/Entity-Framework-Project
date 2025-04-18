﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFCRUD.Models;

[Index("Dept_Id", Name = "IX_Instructors_Dept_Id")]
public partial class Instructor
{
    [Key]
    public int Ins_Id { get; set; }

    [StringLength(255)]
    public string Ins_Fname { get; set; }

    [StringLength(255)]
    public string Ins_Lname { get; set; }

    [StringLength(255)]
    public string Ins_Phone { get; set; }

    public int? Dept_Id { get; set; }

    [InverseProperty("Ins")]
    public virtual ICollection<CourseSession> CourseSessions { get; set; } = new List<CourseSession>();

    [InverseProperty("Ins")]
    public virtual ICollection<Course> Courses { get; set; } = new List<Course>();

    [InverseProperty("Dept_ManagerNavigation")]
    public virtual Department Department { get; set; }

    [ForeignKey("Dept_Id")]
    [InverseProperty("Instructors")]
    public virtual Department Dept { get; set; }
}