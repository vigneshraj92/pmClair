namespace ClairTourTiny.Infrastructure.Models;

public partial class PurchaseOrder1
{
    public int IdPurchaseOrder { get; set; }

    public int Ponumber { get; set; }

    public string? Podescription { get; set; }

    public string Company { get; set; } = null!;

    public string? Entityno { get; set; }

    public string RequestedBy { get; set; } = null!;

    public DateOnly DueDate { get; set; }

    public string Currency { get; set; } = null!;

    public string TaxType { get; set; } = null!;

    public double DiscountPct { get; set; }

    public decimal TaxAmount { get; set; }

    public decimal TotalAmount { get; set; }

    public string? PayTerms { get; set; }

    public string? Ponotes { get; set; }

    public string? Purchaser { get; set; }

    public DateTime? OrderedDate { get; set; }

    public string? PostedBy { get; set; }

    public DateTime? PostedDate { get; set; }

    public DateTime? InvoiceReceived { get; set; }

    public DateTime? InvoiceDate { get; set; }

    public string? InvoiceNo { get; set; }

    public decimal? InvoiceAmount { get; set; }

    public string? PayAuthorizedBy { get; set; }

    public DateTime? PayAuthorizedDate { get; set; }

    public string? PaidBy { get; set; }

    public DateTime? PaidDate { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public string? Vendno { get; set; }

    public string? VendsiteNo { get; set; }

    public string? Vendaddr1 { get; set; }

    public string? Vendaddr2 { get; set; }

    public string? Vendaddr3 { get; set; }

    public string? Vendcity { get; set; }

    public string? Vendcounty { get; set; }

    public string? Vendstatecd { get; set; }

    public string? Vendzipcode { get; set; }

    public string? Vendcountrycd { get; set; }

    public string? Vendcontact { get; set; }

    public string? Vendofficephone { get; set; }

    public string? Venddirectphone { get; set; }

    public string? Vendmobilephone { get; set; }

    public string? Vendemail { get; set; }

    public string? Vendfax { get; set; }

    public string? DeliveryWarehouse { get; set; }

    public string? RecipientName { get; set; }

    public string? RecipientPhone { get; set; }

    public string? RecipientEmail { get; set; }

    public string? DestinationName { get; set; }

    public string? DelAddr1 { get; set; }

    public string? DelAddr2 { get; set; }

    public string? DelAddr3 { get; set; }

    public string? DelCity { get; set; }

    public string? DelStateCd { get; set; }

    public string? DelProvince { get; set; }

    public string? DelZip { get; set; }

    public string? DelCountryCd { get; set; }

    public string? DestinationPhone { get; set; }

    public string? DeliveryInstructions { get; set; }

    public string? DeliveryServiceTypeDisplayName { get; set; }

    public string? DeliveryOtherBillName { get; set; }

    public string? DeliveryOtherBillAcctNo { get; set; }

    public string? CollContactName { get; set; }

    public string? CollContactPhone { get; set; }

    public string? CollContactEmail { get; set; }

    public string? CollCompanyName { get; set; }

    public string? CollAddr1 { get; set; }

    public string? CollAddr2 { get; set; }

    public string? CollAddr3 { get; set; }

    public string? CollCity { get; set; }

    public string? CollStateCd { get; set; }

    public string? CollProvince { get; set; }

    public string? CollZip { get; set; }

    public string? CollCountryCd { get; set; }

    public string? CollCompanyPhone { get; set; }

    public string? CollectionInstructions { get; set; }

    public string? CanceledBy { get; set; }

    public DateTime? CanceledDate { get; set; }

    public string? VendorName { get; set; }

    public decimal ShippingAmount { get; set; }

    public string? VendVatidentificationNumber { get; set; }

    public string? Vendemail2 { get; set; }

    public bool ShouldPushToSyspro { get; set; }

    public DateTimeOffset? PushedToSyspro { get; set; }

    public virtual Pjtfrusr? CanceledByNavigation { get; set; }

    public virtual Country? CollCountryCdNavigation { get; set; }

    public virtual State? CollStateCdNavigation { get; set; }

    public virtual Company CompanyNavigation { get; set; } = null!;

    public virtual Pjtfrusr CreatedByNavigation { get; set; } = null!;

    public virtual Currency CurrencyNavigation { get; set; } = null!;

    public virtual Country? DelCountryCdNavigation { get; set; }

    public virtual State? DelStateCdNavigation { get; set; }

    public virtual Warehouse? DeliveryWarehouseNavigation { get; set; }

    public virtual Glentity? EntitynoNavigation { get; set; }

    public virtual Pjtfrusr ModifiedByNavigation { get; set; } = null!;

    public virtual Pjtfrusr? PaidByNavigation { get; set; }

    public virtual Pjtfrusr? PayAuthorizedByNavigation { get; set; }

    public virtual Popayterm? PayTermsNavigation { get; set; }

    public virtual Pjtfrusr? PostedByNavigation { get; set; }

    public virtual ICollection<PurchaseOrderInvoice> PurchaseOrderInvoices { get; set; } = new List<PurchaseOrderInvoice>();

    public virtual ICollection<PurchaseOrderLineItems> PurchaseOrderLineItems { get; set; } = new List<PurchaseOrderLineItems>();

    public virtual Pjtfrusr? PurchaserNavigation { get; set; }

    public virtual Pjtfrusr RequestedByNavigation { get; set; } = null!;

    public virtual InvoicingTaxType TaxTypeNavigation { get; set; } = null!;

    public virtual Country? VendcountrycdNavigation { get; set; }

    public virtual State? VendstatecdNavigation { get; set; }
}
