using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpArCrewDemandsToImportToPjjobbudget0227
{
    public string Jobno { get; set; } = null!;

    public string? NewEntityno { get; set; }

    public string? Jobtyp { get; set; }

    public string? Jobdesc { get; set; }

    public DateTime? Fromdate { get; set; }

    public DateTime? Todate { get; set; }

    public decimal? Demand { get; set; }

    public double? EstHours { get; set; }

    public double EstRate { get; set; }

    public double? EstTotal { get; set; }
}
