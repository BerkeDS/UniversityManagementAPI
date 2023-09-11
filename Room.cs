using System;
using System.Collections.Generic;

namespace UniversityWebAPI;

public partial class Room
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int DivisionId { get; set; }

    public int BuildingId { get; set; }

    public int Capacity { get; set; }
}
