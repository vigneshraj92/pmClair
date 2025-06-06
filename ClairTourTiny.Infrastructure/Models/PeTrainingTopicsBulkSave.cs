using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class PeTrainingTopicsBulkSave
{
    public short SessionId { get; set; }

    public DateTime UpdateTime { get; set; }

    public bool IsInsert { get; set; }

    public bool IsUpdate { get; set; }

    public bool IsDelete { get; set; }

    public string Topic { get; set; } = null!;

    public string? Jobtype { get; set; }

    public string? Note { get; set; }

    public bool Inactive { get; set; }

    public Guid? FileStorageGuid { get; set; }

    public string? ParentNodeDescription { get; set; }
}
