using System;
using System.Collections.Generic;

namespace UniversityWebAPI;

public partial class Class
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int DivisionId { get; set; }

    public int BuildingId { get; set; }

    public int Capacity { get; set; }

    public bool Projector { get; set; }

    public bool Lab { get; set; }
}
