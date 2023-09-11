using System;
using System.Collections.Generic;

namespace UniversityWebAPI;

public partial class Course
{
    public int Id { get; set; }

    public string CourseName { get; set; } = null!;

    public int DepartmentId { get; set; }

    public short Schedule { get; set; }
}
