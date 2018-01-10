namespace Ross.ERP.Entity.ERP.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Erp.PORel")]
    public partial class PORel
    {
        [Required]
        [StringLength(8)]
        public string Company { get; set; }

        public bool OpenRelease { get; set; }

        public bool VoidRelease { get; set; }

        public int PONum { get; set; }

        public int POLine { get; set; }

        public int PORelNum { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DueDate { get; set; }

        public decimal XRelQty { get; set; }

        public decimal PurchasingFactor { get; set; }

        public decimal RelQty { get; set; }

        [Required]
        [StringLength(14)]
        public string JobNum { get; set; }

        public int AssemblySeq { get; set; }

        [Required]
        [StringLength(2)]
        public string JobSeqType { get; set; }

        public int JobSeq { get; set; }

        [Required]
        [StringLength(8)]
        public string WarehouseCode { get; set; }

        public decimal ReceivedQty { get; set; }

        public bool ExpOverride { get; set; }

        public int ReqNum { get; set; }

        public int ReqLine { get; set; }

        [Required]
        [StringLength(8)]
        public string Plant { get; set; }

        [Column(TypeName = "date")]
        public DateTime? PromiseDt { get; set; }

        [Required]
        [StringLength(25)]
        public string ProjectID { get; set; }

        public bool Confirmed { get; set; }

        [Required]
        [StringLength(8)]
        public string ConfirmVia { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ReqChgDate { get; set; }

        public decimal ReqChgQty { get; set; }

        [Required]
        [StringLength(8)]
        public string LockRel { get; set; }

        [Required]
        [StringLength(65)]
        public string RefDisplayAccount { get; set; }

        [Required]
        [StringLength(8)]
        public string RefType { get; set; }

        [Required]
        [StringLength(8)]
        public string RefCode { get; set; }

        [Required]
        [StringLength(30)]
        public string RefCodeDesc { get; set; }

        public int OrderNum { get; set; }

        public int OrderLine { get; set; }

        public int OrderRelNum { get; set; }

        public bool Linked { get; set; }

        [Required]
        [StringLength(8)]
        public string ExtCompany { get; set; }

        public decimal ShippedQty { get; set; }

        [Required]
        [StringLength(7)]
        public string TranType { get; set; }

        [Required]
        [StringLength(8)]
        public string GlbCompany { get; set; }

        [Required]
        [StringLength(8)]
        public string GlbPlant { get; set; }

        [Required]
        [StringLength(8)]
        public string GlbWarehouse { get; set; }

        public bool GlbCreateJobMtl { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ShippedDate { get; set; }

        public int ContainerID { get; set; }

        [Required]
        [StringLength(1)]
        public string PurchasingFactorDirection { get; set; }

        [Column(TypeName = "date")]
        public DateTime? PreviousDueDate { get; set; }

        public decimal BaseQty { get; set; }

        [Required]
        [StringLength(6)]
        public string BaseUOM { get; set; }

        public int BTOOrderNum { get; set; }

        public int BTOOrderLine { get; set; }

        public int BTOOrderRelNum { get; set; }

        public bool DropShip { get; set; }

        [Required]
        [StringLength(14)]
        public string ShipToNum { get; set; }

        public int SoldToNum { get; set; }

        public decimal SMIRcvdQty { get; set; }

        public int ShpConNum { get; set; }

        public int ShipToCustNum { get; set; }

        public int MangCustNum { get; set; }

        public bool UseOTS { get; set; }

        [Required]
        [StringLength(50)]
        public string OTSName { get; set; }

        [Required]
        [StringLength(50)]
        public string OTSAddress1 { get; set; }

        [Required]
        [StringLength(50)]
        public string OTSAddress2 { get; set; }

        [Required]
        [StringLength(50)]
        public string OTSAddress3 { get; set; }

        [Required]
        [StringLength(50)]
        public string OTSCity { get; set; }

        [Required]
        [StringLength(50)]
        public string OTSState { get; set; }

        [Required]
        [StringLength(10)]
        public string OTSZIP { get; set; }

        [Required]
        [StringLength(20)]
        public string OTSResaleID { get; set; }

        [Required]
        [StringLength(50)]
        public string OTSContact { get; set; }

        [Required]
        [StringLength(20)]
        public string OTSFaxNum { get; set; }

        [Required]
        [StringLength(20)]
        public string OTSPhoneNum { get; set; }

        public int OTSCountryNum { get; set; }

        [Required]
        public string ComplianceMsg { get; set; }

        public bool PORelOpen { get; set; }

        public bool Mapping { get; set; }

        [Required]
        [StringLength(12)]
        public string PhaseID { get; set; }

        [Required]
        [StringLength(12)]
        public string WBSPhaseID { get; set; }

        public bool IsMultiRel { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] SysRevID { get; set; }

        [Key]
        public Guid SysRowID { get; set; }

        public decimal SMIRemQty { get; set; }

        public bool LockQty { get; set; }

        public bool LockDate { get; set; }

        public bool DueDateChanged { get; set; }

        [Required]
        [StringLength(50)]
        public string ContractID { get; set; }

        public bool LinkToContract { get; set; }

        [Required]
        [StringLength(1)]
        public string Status { get; set; }

        public decimal ArrivedQty { get; set; }

        public decimal InvoicedQty { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NeedByDate { get; set; }

        public bool LockNeedByDate { get; set; }

        public decimal InspectionQty { get; set; }

        public decimal FailedQty { get; set; }

        public decimal PassedQty { get; set; }

        public bool ProjProcessed { get; set; }

        [Required]
        [StringLength(150)]
        public string DeliverTo { get; set; }

        public bool Taxable { get; set; }

        [Required]
        [StringLength(20)]
        public string TaxExempt { get; set; }

        public bool NoTaxRecalc { get; set; }

        public virtual PORel_UD PORel_UD { get; set; }
    }
}
