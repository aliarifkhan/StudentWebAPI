using System;
using System.Collections.Generic;

namespace StudentWebAPI.Models;

public partial class Profile
{
    public int Id { get; set; }

    public string? Nmae { get; set; }

    public decimal? Income { get; set; }

    public string? Category { get; set; }

    public DateTime? Date { get; set; }

    public string? PaymentMethod { get; set; }

    public string? Discription { get; set; }
}
