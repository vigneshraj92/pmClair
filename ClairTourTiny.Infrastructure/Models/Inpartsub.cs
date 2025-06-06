using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class Inpartsub
{
    public string Partno { get; set; } = null!;

    public string UniqueNo { get; set; } = null!;

    public string Batchno { get; set; } = null!;

    public string Dept { get; set; } = null!;

    public string Bld { get; set; } = null!;

    public string Area { get; set; } = null!;

    public string Row { get; set; } = null!;

    public string SerialNo { get; set; } = null!;

    public int Onhand { get; set; }

    public DateTime Receipt { get; set; }

    public string Parentpartno { get; set; } = null!;

    public string ParentuniqueNo { get; set; } = null!;

    public string ParentserialNo { get; set; } = null!;

    public int HeldInWarehouse { get; set; }

    public virtual Lessor AreaNavigation { get; set; } = null!;

    public virtual Glentity BatchnoNavigation { get; set; } = null!;

    public virtual Warehouse BldNavigation { get; set; } = null!;

    public virtual EquipmentOwner DeptNavigation { get; set; } = null!;

    public virtual Inpart PartnoNavigation { get; set; } = null!;
}
