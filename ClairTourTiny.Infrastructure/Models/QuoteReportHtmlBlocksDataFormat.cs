using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class QuoteReportHtmlBlocksDataFormat
{
    public int IdHtmlBlock { get; set; }

    public string Field { get; set; } = null!;

    public string FormatType { get; set; } = null!;
}
