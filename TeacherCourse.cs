using System;
using System.Collections.Generic;

namespace UniversityWebAPI;

public partial class TeacherCourse
{
    public int Id { get; set; }

    public int? SemesterId { get; set; }

    public int? TeacherId { get; set; }

    public int? CourseId { get; set; }
}
