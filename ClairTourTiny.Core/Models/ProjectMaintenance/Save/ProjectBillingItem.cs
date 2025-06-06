namespace ClairTourTiny.Core.Models.ProjectMaintenance.Save;

public class ProjectBillingItem
{
    public DateTime UpdateTime { get; set; }
    public bool IsInsert { get; set; }
    public bool IsUpdate { get; set; }
    public bool IsDelete { get; set; }
    public string BidEntityno { get; set; } = null!;
    public short Itemno { get; set; }
    public string? EquipmentEntityno { get; set; }
    public string? ExpenseEntityno { get; set; }
    public int? ExpenseSeqno { get; set; }
    public string? Jobtype { get; set; }
    public string? JobEmpno { get; set; }
    public string? CrewEntityno { get; set; }
    public int? CrewEmplineNo { get; set; }
    public double NominalDailyRate { get; set; }
} 