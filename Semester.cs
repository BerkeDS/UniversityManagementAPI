using System;
using System.Collections.Generic;

namespace UniversityWebAPI;

public partial class Semester
{
    public int Id { get; set; }

    public DateTime Date { get; set; }

    public string Name { get; set; } = null!;
}
