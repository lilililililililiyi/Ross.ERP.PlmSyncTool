namespace Ross.ERP.Entity.ERP.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Erp.POHeader")]
    public partial class POHeader
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public POHeader()
        {
            POHeaderTax = new HashSet<POHeaderTax>();
        }

        [Key]
        [Column(Order = 0)]
        [StringLength(8)]
        public string Company { get; set; }

        public bool OpenOrder { get; set; }

        public bool VoidOrder { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PONum { get; set; }

        [Required]
        [StringLength(75)]
        public string EntryPerson { get; set; }

        [Column(TypeName = "date")]
        public DateTime? OrderDate { get; set; }

        [Required]
        [StringLength(15)]
        public string FOB { get; set; }

        [Required]
        [StringLength(4)]
        public string ShipViaCode { get; set; }

        [Required]
        [StringLength(4)]
        public string TermsCode { get; set; }

        [Required]
        [StringLength(50)]
        public string ShipName { get; set; }

        [Required]
        [StringLength(50)]
        public string ShipAddress1 { get; set; }

        [Required]
        [StringLength(50)]
        public string ShipAddress2 { get; set; }

        [Required]
        [StringLength(50)]
        public string ShipAddress3 { get; set; }

        [Required]
        [StringLength(50)]
        public string ShipCity { get; set; }

        [Required]
        [StringLength(50)]
        public string ShipState { get; set; }

        [Required]
        [StringLength(10)]
        public string ShipZIP { get; set; }

        [Required]
        [StringLength(50)]
        public string ShipCountry { get; set; }

        [Required]
        [StringLength(8)]
        public string BuyerID { get; set; }

        public bool FreightPP { get; set; }

        public int PrcConNum { get; set; }

        public int VendorNum { get; set; }

        [Required]
        [StringLength(4)]
        public string PurPoint { get; set; }

        [Required]
        public string CommentText { get; set; }

        public bool OrderHeld { get; set; }

        [Required]
        [StringLength(50)]
        public string ShipToConName { get; set; }

        public bool ReadyToPrint { get; set; }

        [Required]
        [StringLength(2)]
        public string PrintAs { get; set; }

        [Required]
        [StringLength(4)]
        public string CurrencyCode { get; set; }

        public decimal ExchangeRate { get; set; }

        public bool LockRate { get; set; }

        public int ShipCountryNum { get; set; }

        public bool LogChanges { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ApprovedDate { get; set; }

        [Required]
        [StringLength(75)]
        public string ApprovedBy { get; set; }

        public bool Approve { get; set; }

        [Required]
        [StringLength(2)]
        public string ApprovalStatus { get; set; }

        public decimal ApprovedAmount { get; set; }

        public bool PostToWeb { get; set; }

        [Column(TypeName = "date")]
        public DateTime? PostDate { get; set; }

        [Required]
        [StringLength(30)]
        public string VendorRefNum { get; set; }

        public bool ConfirmReq { get; set; }

        public bool Confirmed { get; set; }

        [Required]
        [StringLength(8)]
        public string ConfirmVia { get; set; }

        public int OrderNum { get; set; }

        [Required]
        [StringLength(30)]
        public string LegalNumber { get; set; }

        public bool Linked { get; set; }

        [Required]
        [StringLength(8)]
        public string ExtCompany { get; set; }

        [Required]
        [StringLength(50)]
        public string XRefPONum { get; set; }

        public bool ConsolidatedPO { get; set; }

        [Required]
        [StringLength(8)]
        public string GlbCompany { get; set; }

        public bool ContractOrder { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ContractStartDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ContractEndDate { get; set; }

        public bool PrintHeaderAddress { get; set; }

        [Required]
        [StringLength(12)]
        public string RateGrpCode { get; set; }

        [Required]
        [StringLength(3)]
        public string POType { get; set; }

        [Required]
        [StringLength(20)]
        public string APLOCID { get; set; }

        [Required]
        [StringLength(12)]
        public string TranDocTypeID { get; set; }

        public bool AutoPrintReady { get; set; }

        public bool ICPOLocked { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] SysRevID { get; set; }

        public Guid SysRowID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DueDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? PromiseDate { get; set; }

        [Required]
        [StringLength(75)]
        public string ChangedBy { get; set; }

        public DateTime? ChangeDate { get; set; }

        public bool POTaxReadyToProcess { get; set; }

        [Required]
        [StringLength(4)]
        public string TaxRegionCode { get; set; }

        [Column(TypeName = "date")]
        public DateTime? TaxPoint { get; set; }

        [Column(TypeName = "date")]
        public DateTime? TaxRateDate { get; set; }

        public decimal TotalTax { get; set; }

        public decimal DocTotalTax { get; set; }

        public decimal Rpt1TotalTax { get; set; }

        public decimal Rpt2TotalTax { get; set; }

        public decimal Rpt3TotalTax { get; set; }

        public decimal TotalWhTax { get; set; }

        public decimal DocTotalWhTax { get; set; }

        public decimal Rpt1TotalWhTax { get; set; }

        public decimal Rpt2TotalWhTax { get; set; }

        public decimal Rpt3TotalWhTax { get; set; }

        public decimal TotalSATax { get; set; }

        public decimal DocTotalSATax { get; set; }

        public decimal Rpt1TotalSATax { get; set; }

        public decimal Rpt2TotalSATax { get; set; }

        public decimal Rpt3TotalSATax { get; set; }

        public bool InPrice { get; set; }

        public bool HdrTaxNoUpdt { get; set; }

        [Required]
        [StringLength(12)]
        public string TaxRateGrpCode { get; set; }

        public decimal TotalDedTax { get; set; }

        public decimal DocTotalDedTax { get; set; }

        public decimal Rpt1TotalDedTax { get; set; }

        public decimal Rpt2TotalDedTax { get; set; }

        public decimal Rpt3TotalDedTax { get; set; }

        public decimal TotalCharges { get; set; }

        public decimal TotalMiscCharges { get; set; }

        public decimal TotalOrder { get; set; }

        public decimal DocTotalCharges { get; set; }

        public decimal DocTotalMisc { get; set; }

        public decimal DocTotalOrder { get; set; }

        public decimal Rpt1TotalCharges { get; set; }

        public decimal Rpt2TotalCharges { get; set; }

        public decimal Rpt3TotalCharges { get; set; }

        public decimal Rpt1TotalMiscCharges { get; set; }

        public decimal Rpt2TotalMiscCharges { get; set; }

        public decimal Rpt3TotalMiscCharges { get; set; }

        public decimal Rpt1TotalOrder { get; set; }

        public decimal Rpt2TotalOrder { get; set; }

        public decimal Rpt3TotalOrder { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<POHeaderTax> POHeaderTax { get; set; }
    }
}
