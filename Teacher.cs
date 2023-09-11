using System;
using System.Collections.Generic;

namespace UniversityWebAPI;

public partial class Teacher
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Number { get; set; } = null!;

    public string SocialNumber { get; set; } = null!;

    public string? Email { get; set; }

    public int? RoomId { get; set; }

    public int DivisionId { get; set; }

    public int DepartmentId { get; set; }

    public DateTime StartDate { get; set; }

    public string? Title { get; set; }
}
