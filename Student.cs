using System;
using System.Collections.Generic;

namespace UniversityWebAPI;

public partial class Student
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public int DepartmentId { get; set; }

    public string Number { get; set; } = null!;

    public string? Email { get; set; }

    public string SocialNumber { get; set; } = null!;

    public int ConfirmCredit { get; set; }

    public decimal AvaragePoint { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime GraduateDate { get; set; }
}
