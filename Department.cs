using System;
using System.Collections.Generic;

namespace UniversityWebAPI;

public partial class Department
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int DivisionId { get; set; }
}
