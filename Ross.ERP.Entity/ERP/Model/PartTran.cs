namespace Ross.ERP.Entity.ERP.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Erp.PartTran")]
    public partial class PartTran
    {
        [Required]
        [StringLength(8)]
        public string Company { get; set; }

        [Column(TypeName = "date")]
        public DateTime? SysDate { get; set; }

        public int SysTime { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TranNum { get; set; }

        [Required]
        [StringLength(50)]
        public string PartNum { get; set; }

        [Required]
        [StringLength(8)]
        public string WareHouseCode { get; set; }

        [Required]
        [StringLength(10)]
        public string BinNum { get; set; }

        [Required]
        [StringLength(2)]
        public string TranClass { get; set; }

        [Required]
        [StringLength(7)]
        public string TranType { get; set; }

        public bool InventoryTrans { get; set; }

        [Column(TypeName = "date")]
        public DateTime? TranDate { get; set; }

        public decimal TranQty { get; set; }

        [Required]
        [StringLength(6)]
        public string UM { get; set; }

        public decimal MtlUnitCost { get; set; }

        public decimal LbrUnitCost { get; set; }

        public decimal BurUnitCost { get; set; }

        public decimal SubUnitCost { get; set; }

        public decimal MtlBurUnitCost { get; set; }

        public decimal ExtCost { get; set; }

        [Required]
        [StringLength(2)]
        public string CostMethod { get; set; }

        [Required]
        [StringLength(14)]
        public string JobNum { get; set; }

        public int AssemblySeq { get; set; }

        [Required]
        [StringLength(2)]
        public string JobSeqType { get; set; }

        public int JobSeq { get; set; }

        [Required]
        [StringLength(2)]
        public string PackType { get; set; }

        public int PackNum { get; set; }

        public int PackLine { get; set; }

        public int PONum { get; set; }

        public int POLine { get; set; }

        public int PORelNum { get; set; }

        [Required]
        [StringLength(8)]
        public string WareHouse2 { get; set; }

        [Required]
        [StringLength(10)]
        public string BinNum2 { get; set; }

        public int OrderNum { get; set; }

        public int OrderLine { get; set; }

        public int OrderRelNum { get; set; }

        [Required]
        [StringLength(75)]
        public string EntryPerson { get; set; }

        [Required]
        public string TranReference { get; set; }

        [Required]
        public string PartDescription { get; set; }

        [Required]
        [StringLength(12)]
        public string RevisionNum { get; set; }

        public int VendorNum { get; set; }

        [Required]
        [StringLength(4)]
        public string PurPoint { get; set; }

        public decimal POReceiptQty { get; set; }

        public decimal POUnitCost { get; set; }

        [Required]
        [StringLength(20)]
        public string PackSlip { get; set; }

        [Required]
        [StringLength(20)]
        public string InvoiceNum { get; set; }

        public int InvoiceLine { get; set; }

        [Required]
        [StringLength(2)]
        public string InvAdjSrc { get; set; }

        [Required]
        [StringLength(8)]
        public string InvAdjReason { get; set; }

        [Required]
        [StringLength(30)]
        public string LotNum { get; set; }

        [Required]
        [StringLength(6)]
        public string DimCode { get; set; }

        [Required]
        [StringLength(6)]
        public string DUM { get; set; }

        public decimal DimConvFactor { get; set; }

        [Required]
        [StringLength(30)]
        public string LotNum2 { get; set; }

        [Required]
        [StringLength(6)]
        public string DimCode2 { get; set; }

        [Required]
        [StringLength(6)]
        public string DUM2 { get; set; }

        public decimal DimConvFactor2 { get; set; }

        public bool GLTrans { get; set; }

        public bool PostedToGL { get; set; }

        public int FiscalYear { get; set; }

        public int FiscalPeriod { get; set; }

        public int JournalNum { get; set; }

        public bool Costed { get; set; }

        public int DMRNum { get; set; }

        public int ActionNum { get; set; }

        public int RMANum { get; set; }

        public bool COSPostingReqd { get; set; }

        [Required]
        [StringLength(4)]
        public string JournalCode { get; set; }

        [Required]
        [StringLength(8)]
        public string Plant { get; set; }

        [Required]
        [StringLength(8)]
        public string Plant2 { get; set; }

        public int CallNum { get; set; }

        public int CallLine { get; set; }

        public int MatNum { get; set; }

        [Required]
        [StringLength(14)]
        public string JobNum2 { get; set; }

        public int AssemblySeq2 { get; set; }

        public int JobSeq2 { get; set; }

        public int CustNum { get; set; }

        public int RMALine { get; set; }

        public int RMAReceipt { get; set; }

        public int RMADisp { get; set; }

        public decimal OtherDivValue { get; set; }

        public int PlantTranNum { get; set; }

        public int NonConfID { get; set; }

        public decimal MtlMtlUnitCost { get; set; }

        public decimal MtlLabUnitCost { get; set; }

        public decimal MtlSubUnitCost { get; set; }

        public decimal MtlBurdenUnitCost { get; set; }

        [Required]
        [StringLength(8)]
        public string RefType { get; set; }

        [Required]
        [StringLength(8)]
        public string RefCode { get; set; }

        [Required]
        [StringLength(30)]
        public string LegalNumber { get; set; }

        public decimal BeginQty { get; set; }

        public decimal AfterQty { get; set; }

        public decimal BegBurUnitCost { get; set; }

        public decimal BegLbrUnitCost { get; set; }

        public decimal BegMtlBurUnitCost { get; set; }

        public decimal BegMtlUnitCost { get; set; }

        public decimal BegSubUnitCost { get; set; }

        public decimal AfterBurUnitCost { get; set; }

        public decimal AfterLbrUnitCost { get; set; }

        public decimal AfterMtlBurUnitCost { get; set; }

        public decimal AfterMtlUnitCost { get; set; }

        public decimal AfterSubUnitCost { get; set; }

        public decimal PlantCostValue { get; set; }

        [Required]
        [StringLength(8)]
        public string EmpID { get; set; }

        public int ReconcileNum { get; set; }

        [Required]
        [StringLength(8)]
        public string CostID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FIFODate { get; set; }

        public int FIFOSeq { get; set; }

        public decimal ActTranQty { get; set; }

        [Required]
        [StringLength(6)]
        public string ActTransUOM { get; set; }

        [Required]
        [StringLength(6)]
        public string InvtyUOM { get; set; }

        [Required]
        [StringLength(6)]
        public string InvtyUOM2 { get; set; }

        [Required]
        [StringLength(4)]
        public string FIFOAction { get; set; }

        [Required]
        [StringLength(8)]
        public string FiscalYearSuffix { get; set; }

        [Required]
        [StringLength(12)]
        public string FiscalCalendarID { get; set; }

        [Required]
        [StringLength(8)]
        public string BinType { get; set; }

        public int CCYear { get; set; }

        public int CCMonth { get; set; }

        public int CycleSeq { get; set; }

        [Required]
        [StringLength(36)]
        public string ABTUID { get; set; }

        [Required]
        [StringLength(2)]
        public string BaseCostMethod { get; set; }

        public int RevertStatus { get; set; }

        [Required]
        [StringLength(36)]
        public string RevertID { get; set; }

        [Required]
        [StringLength(20)]
        public string DropShipPackSlip { get; set; }

        [Required]
        [StringLength(3)]
        public string VarTarget { get; set; }

        public int FIFOSubSeq { get; set; }

        public decimal AltMtlUnitCost { get; set; }

        public decimal AltLbrUnitCost { get; set; }

        public decimal AltBurUnitCost { get; set; }

        public decimal AltSubUnitCost { get; set; }

        public decimal AltMtlBurUnitCost { get; set; }

        public decimal AltExtCost { get; set; }

        public decimal AltMtlMtlUnitCost { get; set; }

        public decimal AltMtlLabUnitCost { get; set; }

        public decimal AltMtlSubUnitCost { get; set; }

        public decimal AltMtlBurdenUnitCost { get; set; }

        [Required]
        [StringLength(12)]
        public string TranDocTypeID { get; set; }

        public int PBInvNum { get; set; }

        [Required]
        [StringLength(1)]
        public string LoanFlag { get; set; }

        [Required]
        [StringLength(20)]
        public string AssetNum { get; set; }

        public int AdditionNum { get; set; }

        public int DisposalNum { get; set; }

        public bool ProjProcessed { get; set; }

        [Column(TypeName = "date")]
        public DateTime? AsOfDate { get; set; }

        public int AsOfSeq { get; set; }

        public int MscNum { get; set; }

        public decimal ODCUnitCost { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] SysRevID { get; set; }

        [Key]
        public Guid SysRowID { get; set; }

        public int TranRefType { get; set; }

        [Required]
        [StringLength(12)]
        public string PCID { get; set; }

        public int PCIDCollapseCounter { get; set; }

        [Required]
        [StringLength(12)]
        public string PCID2 { get; set; }

        [Required]
        [StringLength(50)]
        public string ContractID { get; set; }

        public bool LCFlag { get; set; }

        public decimal ExtMtlCost { get; set; }

        public decimal ExtLbrCost { get; set; }

        public decimal ExtBurCost { get; set; }

        public decimal ExtSubCost { get; set; }

        public decimal ExtMtlBurCost { get; set; }

        public decimal ExtMtlMtlCost { get; set; }

        public decimal ExtMtlLabCost { get; set; }

        public decimal ExtMtlSubCost { get; set; }

        public decimal ExtMtlBurdenCost { get; set; }

        public virtual PartTran_UD PartTran_UD { get; set; }
    }
}
