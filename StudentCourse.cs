using System;
using System.Collections.Generic;

namespace UniversityWebAPI;

public partial class StudentCourse
{
    public int Id { get; set; }

    public int StudentId { get; set; }

    public int SemesterId { get; set; }

    public int CourseId { get; set; }

    public int? Grade1 { get; set; }

    public int? Grade2 { get; set; }

    public int? FinalGrade { get; set; }

    public int? ProjectGrade1 { get; set; }

    public int? ProjectGrade2 { get; set; }

    public decimal? AvarageGrade { get; set; }

    public int? Nonattendance { get; set; }

    public string? Status { get; set; }
}
