using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class UserWarehouseGroupsWarehousesBulkSave
{
    public short SessionId { get; set; }

    public DateTime UpdateTime { get; set; }

    public bool IsInsert { get; set; }

    public bool IsUpdate { get; set; }

    public bool IsDelete { get; set; }

    public string WarehouseGroupOld { get; set; } = null!;

    public string WarehouseGroupNew { get; set; } = null!;

    public string WarehouseCode { get; set; } = null!;
}
