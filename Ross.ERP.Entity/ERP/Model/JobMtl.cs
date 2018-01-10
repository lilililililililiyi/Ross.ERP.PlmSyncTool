namespace Ross.ERP.Entity.ERP.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Erp.JobMtl")]
    public partial class JobMtl
    {
        [Required]
        [StringLength(8)]
        public string Company { get; set; }

        public bool JobComplete { get; set; }

        public bool IssuedComplete { get; set; }

        [Required]
        [StringLength(14)]
        public string JobNum { get; set; }

        public int AssemblySeq { get; set; }

        public int MtlSeq { get; set; }

        [Required]
        [StringLength(50)]
        public string PartNum { get; set; }

        [Required]
        public string Description { get; set; }

        public decimal QtyPer { get; set; }

        public decimal RequiredQty { get; set; }

        [Required]
        [StringLength(6)]
        public string IUM { get; set; }

        public int LeadTime { get; set; }

        public int RelatedOperation { get; set; }

        public decimal MtlBurRate { get; set; }

        public decimal EstMtlBurUnitCost { get; set; }

        public decimal EstUnitCost { get; set; }

        public decimal IssuedQty { get; set; }

        public decimal TotalCost { get; set; }

        public decimal MtlBurCost { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ReqDate { get; set; }

        [Required]
        [StringLength(8)]
        public string WarehouseCode { get; set; }

        [Required]
        [StringLength(50)]
        public string SalvagePartNum { get; set; }

        [Required]
        public string SalvageDescription { get; set; }

        public decimal SalvageQtyPer { get; set; }

        [Required]
        [StringLength(6)]
        public string SalvageUM { get; set; }

        public decimal SalvageMtlBurRate { get; set; }

        public decimal SalvageUnitCredit { get; set; }

        public decimal SalvageEstMtlBurUnitCredit { get; set; }

        public decimal SalvageQtyToDate { get; set; }

        public decimal SalvageCredit { get; set; }

        public decimal SalvageMtlBurCredit { get; set; }

        [Required]
        public string MfgComment { get; set; }

        public int VendorNum { get; set; }

        [Required]
        [StringLength(4)]
        public string PurPoint { get; set; }

        public bool BuyIt { get; set; }

        public bool Ordered { get; set; }

        [Required]
        public string PurComment { get; set; }

        public bool BackFlush { get; set; }

        public decimal EstScrap { get; set; }

        [Required]
        [StringLength(1)]
        public string EstScrapType { get; set; }

        public bool FixedQty { get; set; }

        [Required]
        [StringLength(10)]
        public string FindNum { get; set; }

        [Required]
        [StringLength(12)]
        public string RevisionNum { get; set; }

        public bool SndAlrtCmpl { get; set; }

        public bool RcvInspectionReq { get; set; }

        [Required]
        [StringLength(8)]
        public string Plant { get; set; }

        public bool Direct { get; set; }

        public decimal MaterialMtlCost { get; set; }

        public decimal MaterialLabCost { get; set; }

        public decimal MaterialSubCost { get; set; }

        public decimal MaterialBurCost { get; set; }

        public decimal SalvageMtlCredit { get; set; }

        public decimal SalvageLbrCredit { get; set; }

        public decimal SalvageBurCredit { get; set; }

        public decimal SalvageSubCredit { get; set; }

        [Required]
        [StringLength(1)]
        public string APSAddResType { get; set; }

        public int CallNum { get; set; }

        public int CallLine { get; set; }

        [Required]
        [StringLength(8)]
        public string ProdCode { get; set; }

        public decimal UnitPrice { get; set; }

        public decimal BillableUnitPrice { get; set; }

        public decimal DocBillableUnitPrice { get; set; }

        [Required]
        [StringLength(8)]
        public string ResReasonCode { get; set; }

        [Required]
        [StringLength(2)]
        public string PricePerCode { get; set; }

        public bool Billable { get; set; }

        public decimal ShippedQty { get; set; }

        public decimal DocUnitPrice { get; set; }

        public decimal QtyStagedToDate { get; set; }

        public bool AddedMtl { get; set; }

        public bool MiscCharge { get; set; }

        [Required]
        [StringLength(4)]
        public string MiscCode { get; set; }

        [Required]
        [StringLength(4)]
        public string SCMiscCode { get; set; }

        public bool RFQNeeded { get; set; }

        public int RFQVendQuotes { get; set; }

        public int RFQNum { get; set; }

        public int RFQLine { get; set; }

        [Required]
        [StringLength(1)]
        public string RFQStat { get; set; }

        [Required]
        [StringLength(8)]
        public string AnalysisCode { get; set; }

        public bool GlbRFQ { get; set; }

        public bool WhseAllocFlag { get; set; }

        [Column(TypeName = "date")]
        public DateTime? WIReqDate { get; set; }

        public decimal Rpt1BillableUnitPrice { get; set; }

        public decimal Rpt2BillableUnitPrice { get; set; }

        public decimal Rpt3BillableUnitPrice { get; set; }

        public decimal Rpt1UnitPrice { get; set; }

        public decimal Rpt2UnitPrice { get; set; }

        public decimal Rpt3UnitPrice { get; set; }

        public decimal BaseRequiredQty { get; set; }

        [Required]
        [StringLength(6)]
        public string BaseUOM { get; set; }

        public decimal Weight { get; set; }

        [Required]
        [StringLength(6)]
        public string WeightUOM { get; set; }

        public int ReqRefDes { get; set; }

        [Required]
        [StringLength(50)]
        public string BasePartNum { get; set; }

        [Required]
        [StringLength(12)]
        public string BaseRevisionNum { get; set; }

        public bool SelectForPicking { get; set; }

        [Required]
        [StringLength(8)]
        public string StagingWarehouseCode { get; set; }

        [Required]
        [StringLength(10)]
        public string StagingBinNum { get; set; }

        [Required]
        [StringLength(2)]
        public string PickError { get; set; }

        public decimal EstMtlUnitCost { get; set; }

        public decimal EstLbrUnitCost { get; set; }

        public decimal EstBurUnitCost { get; set; }

        public decimal EstSubUnitCost { get; set; }

        public decimal SalvageEstMtlUnitCredit { get; set; }

        public decimal SalvageEstLbrUnitCredit { get; set; }

        public decimal SalvageEstBurUnitCredit { get; set; }

        public decimal SalvageEstSubUnitCredit { get; set; }

        public decimal LoanedQty { get; set; }

        public decimal BorrowedQty { get; set; }

        public bool ReassignSNAsm { get; set; }

        [Required]
        public string GeneralPlanInfo { get; set; }

        [Required]
        public string EstStdDescription { get; set; }

        [Required]
        [StringLength(6)]
        public string PricingUOM { get; set; }

        public bool RemovedFromPlan { get; set; }

        public bool IsPOCostingMaintained { get; set; }

        public int EstStdType { get; set; }

        public decimal POCostingFactor { get; set; }

        public decimal PlannedQtyPerUnit { get; set; }

        public int POCostingDirection { get; set; }

        public decimal POCostingUnitVal { get; set; }

        public int GroupSeq { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] SysRevID { get; set; }

        [Key]
        public Guid SysRowID { get; set; }

        [Required]
        [StringLength(250)]
        public string OrigStructTag { get; set; }

        public int OrigGroupSeq { get; set; }

        [Required]
        [StringLength(10)]
        public string ShowStatusIcon { get; set; }

        [Required]
        [StringLength(50)]
        public string ContractID { get; set; }

        public bool LinkToContract { get; set; }

        [Required]
        [StringLength(30)]
        public string StagingLotNum { get; set; }

        public bool PCLinkRemoved { get; set; }

        public virtual JobMtl_UD JobMtl_UD { get; set; }
    }
}
