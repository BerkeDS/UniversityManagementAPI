using System;
using System.Collections.Generic;

namespace UniversityWebAPI;

public partial class ClassCourse
{
    public int Id { get; set; }

    public int? SemesterId { get; set; }

    public int? ClassId { get; set; }

    public int? CourseId { get; set; }
}
