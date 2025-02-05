using System;
using System.Collections.Generic;

namespace StudentWebAPI.Models;

public partial class Expence
{
    public decimal? Food { get; set; }

    public decimal? Medicine { get; set; }

    public decimal? Drinks { get; set; }

    public decimal? Education { get; set; }

    public decimal? Fuel { get; set; }

    public decimal? Hostal { get; set; }

    public decimal? Pets { get; set; }

    public decimal? Tips { get; set; }

    public decimal? Others { get; set; }

    public int? Id { get; set; }

    public DateTime? Date { get; set; }

    public decimal? RemainingBalance { get; set; }

    public decimal? Sum { get; set; }

    public virtual Profile? IdNavigation { get; set; }
}
