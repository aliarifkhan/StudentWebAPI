using System;
using System.Collections.Generic;

namespace StudentWebAPI.Models;

public partial class StudentDetail
{
    public int Id { get; set; }

    public string? StudentName { get; set; }

    public string? StudentGender { get; set; }

    public int? Age { get; set; }

    public int? Standard { get; set; }

    public string? FatherName { get; set; }
}
