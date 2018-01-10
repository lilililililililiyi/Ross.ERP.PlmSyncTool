namespace Ross.ERP.Entity.ERP.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Erp.JobOper")]
    public partial class JobOper
    {
        [Required]
        [StringLength(8)]
        public string Company { get; set; }

        public bool JobComplete { get; set; }

        public bool OpComplete { get; set; }

        [Required]
        [StringLength(14)]
        public string JobNum { get; set; }

        public int AssemblySeq { get; set; }

        public int OprSeq { get; set; }

        [Required]
        [StringLength(8)]
        public string OpCode { get; set; }

        [Required]
        [StringLength(5)]
        public string OpStdID { get; set; }

        public decimal EstSetHours { get; set; }

        public decimal EstProdHours { get; set; }

        public decimal ProdStandard { get; set; }

        [Required]
        [StringLength(2)]
        public string StdFormat { get; set; }

        [Required]
        [StringLength(2)]
        public string StdBasis { get; set; }

        public int OpsPerPart { get; set; }

        public decimal QtyPer { get; set; }

        [Column(TypeName = "date")]
        public DateTime? QueStartDate { get; set; }

        public decimal QueStartHour { get; set; }

        [Column(TypeName = "date")]
        public DateTime? StartDate { get; set; }

        public decimal StartHour { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DueDate { get; set; }

        public decimal DueHour { get; set; }

        [Column(TypeName = "date")]
        public DateTime? MoveDueDate { get; set; }

        public decimal MoveDueHour { get; set; }

        public decimal ProdLabRate { get; set; }

        public decimal SetupLabRate { get; set; }

        public decimal ProdBurRate { get; set; }

        public decimal SetupBurRate { get; set; }

        public bool AddedOper { get; set; }

        public int Machines { get; set; }

        public decimal SetUpCrewSize { get; set; }

        public decimal ProdCrewSize { get; set; }

        public bool ProdComplete { get; set; }

        public bool SetupComplete { get; set; }

        public decimal ActProdHours { get; set; }

        public decimal ActProdRwkHours { get; set; }

        public decimal ActSetupHours { get; set; }

        public decimal ActSetupRwkHours { get; set; }

        public decimal QtyCompleted { get; set; }

        public int SetupPctComplete { get; set; }

        public decimal EstScrap { get; set; }

        [Required]
        [StringLength(1)]
        public string EstScrapType { get; set; }

        public bool SubContract { get; set; }

        [Required]
        [StringLength(6)]
        public string IUM { get; set; }

        public decimal EstUnitCost { get; set; }

        public decimal DaysOut { get; set; }

        [Required]
        [StringLength(50)]
        public string PartNum { get; set; }

        [Required]
        public string Description { get; set; }

        public int VendorNum { get; set; }

        [Required]
        [StringLength(4)]
        public string PurPoint { get; set; }

        [Required]
        public string CommentText { get; set; }

        [Required]
        [StringLength(4)]
        public string SchedRelation { get; set; }

        public decimal RunQty { get; set; }

        [Required]
        [StringLength(75)]
        public string WIName { get; set; }

        public int WIMachines { get; set; }

        [Column(TypeName = "date")]
        public DateTime? WIQueStartDate { get; set; }

        public decimal WIQueStartHour { get; set; }

        [Column(TypeName = "date")]
        public DateTime? WIStartDate { get; set; }

        public decimal WIStartHour { get; set; }

        [Column(TypeName = "date")]
        public DateTime? WIDueDate { get; set; }

        public decimal WIDueHour { get; set; }

        [Column(TypeName = "date")]
        public DateTime? WIMoveDueDate { get; set; }

        public decimal WIMoveDueHour { get; set; }

        public decimal WIHoursPerMachine { get; set; }

        [Column(TypeName = "date")]
        public DateTime? WILoadDate { get; set; }

        public decimal WILoadHour { get; set; }

        public decimal ActBurCost { get; set; }

        public decimal ActLabCost { get; set; }

        public decimal ReworkBurCost { get; set; }

        public decimal ReworkLabCost { get; set; }

        public decimal MiscAmt { get; set; }

        public decimal HoursPerMachine { get; set; }

        [Column(TypeName = "date")]
        public DateTime? LoadDate { get; set; }

        public decimal LoadHour { get; set; }

        public int ReloadNum { get; set; }

        public bool SndAlrtCmpl { get; set; }

        public bool RcvInspectionReq { get; set; }

        public bool JobEngineered { get; set; }

        public decimal EstSetHoursPerMch { get; set; }

        [Required]
        [StringLength(12)]
        public string RevisionNum { get; set; }

        [Required]
        [StringLength(8)]
        public string AutoReceiptDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? LastLaborDate { get; set; }

        public int CallNum { get; set; }

        public int CallLine { get; set; }

        public decimal LaborRate { get; set; }

        public decimal BillableLaborRate { get; set; }

        public decimal DocLaborRate { get; set; }

        public decimal DocBillableLaborRate { get; set; }

        public bool Billable { get; set; }

        public decimal UnitPrice { get; set; }

        public decimal BillableUnitPrice { get; set; }

        public decimal DocBillableUnitPrice { get; set; }

        public decimal DocUnitPrice { get; set; }

        [Required]
        [StringLength(2)]
        public string LaborEntryMethod { get; set; }

        [Required]
        [StringLength(2)]
        public string PricePerCode { get; set; }

        public decimal FAQty { get; set; }

        public decimal QtyStagedToDate { get; set; }

        public bool RFQNeeded { get; set; }

        public int RFQVendQuotes { get; set; }

        public int RFQNum { get; set; }

        public int RFQLine { get; set; }

        [Required]
        [StringLength(1)]
        public string RFQStat { get; set; }

        [Required]
        [StringLength(8)]
        public string SetupGroup { get; set; }

        [Required]
        [StringLength(14)]
        public string RestoreFlag { get; set; }

        [Required]
        [StringLength(8)]
        public string AnalysisCode { get; set; }

        public int PrimarySetupOpDtl { get; set; }

        public int PrimaryProdOpDtl { get; set; }

        [Required]
        [StringLength(30)]
        public string OpDesc { get; set; }

        [Column(TypeName = "date")]
        public DateTime? KitDate { get; set; }

        public bool GlbRFQ { get; set; }

        public decimal BookedUnitCost { get; set; }

        public bool RecalcExpProdYld { get; set; }

        [Required]
        public string UserMapData { get; set; }

        public bool RoughCutSched { get; set; }

        [Required]
        public string SchedComment { get; set; }

        public decimal Rpt1BillableLaborRate { get; set; }

        public decimal Rpt2BillableLaborRate { get; set; }

        public decimal Rpt3BillableLaborRate { get; set; }

        public decimal Rpt1BillableUnitPrice { get; set; }

        public decimal Rpt2BillableUnitPrice { get; set; }

        public decimal Rpt3BillableUnitPrice { get; set; }

        public decimal Rpt1LaborRate { get; set; }

        public decimal Rpt2LaborRate { get; set; }

        public decimal Rpt3LaborRate { get; set; }

        public decimal Rpt1UnitPrice { get; set; }

        public decimal Rpt2UnitPrice { get; set; }

        public decimal Rpt3UnitPrice { get; set; }

        public bool SNRequiredOpr { get; set; }

        public bool SNRequiredSubConShip { get; set; }

        public decimal Weight { get; set; }

        [Required]
        [StringLength(6)]
        public string WeightUOM { get; set; }

        [Required]
        [StringLength(8)]
        public string SendAheadType { get; set; }

        public decimal SendAheadOffset { get; set; }

        [Required]
        public string PrjRoleList { get; set; }

        [Column(TypeName = "date")]
        public DateTime? TearDwnEndDate { get; set; }

        public decimal TearDwnEndHour { get; set; }

        [Column(TypeName = "date")]
        public DateTime? WITearDwnEndDate { get; set; }

        public decimal WITearDwnEndHour { get; set; }

        public bool UseAllRoles { get; set; }

        [Required]
        [StringLength(50)]
        public string AssetPartNum { get; set; }

        [Required]
        [StringLength(40)]
        public string SerialNumber { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ActualStartDate { get; set; }

        public decimal ActualStartHour { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ActualEndDate { get; set; }

        public decimal ActualEndHour { get; set; }

        public int FSJobStatus { get; set; }

        [Required]
        public string Instructions { get; set; }

        [Required]
        [StringLength(6)]
        public string ProdUOM { get; set; }

        [Required]
        public string GeneralPlanInfo { get; set; }

        [Required]
        public string EstStdDescription { get; set; }

        public bool JDFOpCompleted { get; set; }

        public bool RemovedfromPlan { get; set; }

        public int EstStdType { get; set; }

        public bool ExternalMES { get; set; }

        public decimal PctReg { get; set; }

        public decimal SetupMaterial { get; set; }

        public int MaterialColorRating { get; set; }

        [Required]
        [StringLength(30)]
        public string MiscInfo1 { get; set; }

        [Required]
        [StringLength(30)]
        public string MiscInfo2 { get; set; }

        [Required]
        [StringLength(256)]
        public string SetupURL { get; set; }

        public decimal ExpPctUp { get; set; }

        public decimal ExpCycTm { get; set; }

        public decimal ExpGood { get; set; }

        public decimal NonProdLimit { get; set; }

        public bool AutoSpcEnable { get; set; }

        public int AutoSpcPeriod { get; set; }

        public bool PartQualEnable { get; set; }

        public int AutoSpcSubgroup { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] SysRevID { get; set; }

        [Key]
        public Guid SysRowID { get; set; }

        public bool MobileOperation { get; set; }

        public bool ReWork { get; set; }

        public bool RequestMove { get; set; }

        [Required]
        [StringLength(50)]
        public string ContractID { get; set; }

        [Required]
        [StringLength(20)]
        public string PrinterID { get; set; }

        public DateTime? LastPrintedDate { get; set; }

        [Required]
        [StringLength(12)]
        public string LastPCIDPrinted { get; set; }

        [Required]
        [StringLength(50)]
        public string CurrentPkgCode { get; set; }

        public virtual JobOper_UD JobOper_UD { get; set; }
    }
}
