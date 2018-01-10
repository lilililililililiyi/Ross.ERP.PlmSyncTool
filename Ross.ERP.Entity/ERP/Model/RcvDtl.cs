namespace Ross.ERP.Entity.ERP.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Erp.RcvDtl")]
    public partial class RcvDtl
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(8)]
        public string Company { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int VendorNum { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(4)]
        public string PurPoint { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(20)]
        public string PackSlip { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PackLine { get; set; }

        public bool Invoiced { get; set; }

        [Required]
        [StringLength(20)]
        public string InvoiceNum { get; set; }

        public int InvoiceLine { get; set; }

        [Required]
        [StringLength(50)]
        public string PartNum { get; set; }

        [Required]
        [StringLength(8)]
        public string WareHouseCode { get; set; }

        [Required]
        [StringLength(10)]
        public string BinNum { get; set; }

        public decimal OurQty { get; set; }

        [Required]
        [StringLength(6)]
        public string IUM { get; set; }

        public decimal OurUnitCost { get; set; }

        [Required]
        [StringLength(14)]
        public string JobNum { get; set; }

        public int AssemblySeq { get; set; }

        [Required]
        [StringLength(2)]
        public string JobSeqType { get; set; }

        public int JobSeq { get; set; }

        public int PONum { get; set; }

        public int POLine { get; set; }

        public int PORelNum { get; set; }

        [Required]
        [StringLength(30)]
        public string TranReference { get; set; }

        [Required]
        public string PartDescription { get; set; }

        [Required]
        [StringLength(12)]
        public string RevisionNum { get; set; }

        public decimal VendorQty { get; set; }

        public decimal VendorUnitCost { get; set; }

        [Required]
        [StringLength(2)]
        public string ReceiptType { get; set; }

        [Required]
        [StringLength(7)]
        public string ReceivedTo { get; set; }

        public bool ReceivedComplete { get; set; }

        public bool IssuedComplete { get; set; }

        [Required]
        [StringLength(6)]
        public string PUM { get; set; }

        [Required]
        [StringLength(50)]
        public string VenPartNum { get; set; }

        [Required]
        [StringLength(2)]
        public string CostPerCode { get; set; }

        [Required]
        [StringLength(30)]
        public string LotNum { get; set; }

        public int NumLabels { get; set; }

        [Required]
        [StringLength(6)]
        public string DimCode { get; set; }

        [Required]
        [StringLength(6)]
        public string DUM { get; set; }

        public decimal DimConvFactor { get; set; }

        public bool InspectionReq { get; set; }

        public bool InspectionPending { get; set; }

        [Required]
        [StringLength(8)]
        public string InspectorID { get; set; }

        [Required]
        [StringLength(75)]
        public string InspectedBy { get; set; }

        [Column(TypeName = "date")]
        public DateTime? InspectedDate { get; set; }

        public int InspectedTime { get; set; }

        public decimal PassedQty { get; set; }

        public decimal FailedQty { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ReceiptDate { get; set; }

        [Required]
        [StringLength(8)]
        public string ReasonCode { get; set; }

        public decimal TotCostVariance { get; set; }

        public decimal Weight { get; set; }

        [Required]
        [StringLength(6)]
        public string WeightUOM { get; set; }

        public bool NonConformnce { get; set; }

        public decimal MtlBurRate { get; set; }

        public decimal OurMtlBurUnitCost { get; set; }

        [Required]
        [StringLength(8)]
        public string RefType { get; set; }

        [Required]
        [StringLength(8)]
        public string RefCode { get; set; }

        [Required]
        [StringLength(8)]
        public string PurchCode { get; set; }

        public bool LCFlag { get; set; }

        [Required]
        [StringLength(8)]
        public string GlbCompany { get; set; }

        public int GlbVendorNum { get; set; }

        [Required]
        [StringLength(4)]
        public string GlbPurPoint { get; set; }

        [Required]
        [StringLength(20)]
        public string GlbPackSlip { get; set; }

        public int GlbPackLine { get; set; }

        public decimal DocUnitCost { get; set; }

        public int ContainerID { get; set; }

        public decimal Volume { get; set; }

        public decimal Rpt1UnitCost { get; set; }

        public decimal Rpt2UnitCost { get; set; }

        public decimal Rpt3UnitCost { get; set; }

        public int OrderNum { get; set; }

        public int OrderLine { get; set; }

        public int OrderRelNum { get; set; }

        public int OrigCountryNum { get; set; }

        public decimal UpliftPercent { get; set; }

        public decimal LCDutyAmt { get; set; }

        public decimal LCIndCost { get; set; }

        public decimal POTransValue { get; set; }

        public decimal ExtTransValue { get; set; }

        public bool Received { get; set; }

        [Required]
        [StringLength(12)]
        public string CommodityCode { get; set; }

        [Required]
        [StringLength(3)]
        public string POType { get; set; }

        public bool AutoReceipt { get; set; }

        [Required]
        [StringLength(6)]
        public string VolumeUOM { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ArrivedDate { get; set; }

        public decimal LCSpecLineDutyAmt { get; set; }

        public decimal AppliedRcptLCAmt { get; set; }

        public decimal LCUpliftIndCost { get; set; }

        public decimal LCAmt { get; set; }

        public decimal AppliedLCVariance { get; set; }

        public decimal LCMtlBurUnitCost { get; set; }

        public decimal DocVendorUnitCost { get; set; }

        public decimal Rpt1VendorUnitCost { get; set; }

        public decimal Rpt2VendorUnitCost { get; set; }

        public decimal Rpt3VendorUnitCost { get; set; }

        public bool NotCompliant { get; set; }

        [Required]
        public string ComplianceMsg { get; set; }

        public int MangCustNum { get; set; }

        [Required]
        [StringLength(30)]
        public string LegalNumber { get; set; }

        public int ICPackNum { get; set; }

        [Required]
        [StringLength(20)]
        public string ShipRcv { get; set; }

        [Required]
        [StringLength(30)]
        public string ImportNum { get; set; }

        public int ImportedFrom { get; set; }

        [Required]
        [StringLength(40)]
        public string ImportedFromDesc { get; set; }

        public decimal GrossWeight { get; set; }

        [Required]
        [StringLength(6)]
        public string GrossWeightUOM { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] SysRevID { get; set; }

        public Guid SysRowID { get; set; }

        [Required]
        [StringLength(10)]
        public string QtyOption { get; set; }

        public bool ConvOverride { get; set; }

        [Required]
        [StringLength(50)]
        public string ContractID { get; set; }

        public int SMITransNum { get; set; }

        [Required]
        [StringLength(12)]
        public string PCID { get; set; }

        [Required]
        [StringLength(75)]
        public string ChangedBy { get; set; }

        public DateTime? ChangeDate { get; set; }

        public bool Delivered { get; set; }

        [Required]
        [StringLength(500)]
        public string DeliveredComments { get; set; }

        public decimal InOurCost { get; set; }

        public decimal DocInUnitCost { get; set; }

        public decimal Rpt1InUnitCost { get; set; }

        public decimal Rpt2InUnitCost { get; set; }

        public decimal Rpt3InUnitCost { get; set; }

        public decimal InVendorUnitCost { get; set; }

        public decimal DocInVendorUnitCost { get; set; }

        public decimal Rpt1InVendorUnitCost { get; set; }

        public decimal Rpt2InVendorUnitCost { get; set; }

        public decimal Rpt3InVendorUnitCost { get; set; }

        public decimal SupplierUnInvcReceiptQty { get; set; }

        public decimal OurUnInvcReceiptQty { get; set; }
    }
}
