namespace Ross.ERP.Entity.ERP.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Erp.PartOpr")]
    public partial class PartOpr
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(8)]
        public string Company { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string PartNum { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(12)]
        public string RevisionNum { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
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

        public int Machines { get; set; }

        public decimal SetUpCrewSize { get; set; }

        public decimal ProdCrewSize { get; set; }

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
        public string SubPartNum { get; set; }

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

        public decimal AddlSetupHours { get; set; }

        public decimal AddlSetUpQty { get; set; }

        public int APSPrepOp { get; set; }

        public int APSNextOp { get; set; }

        public int APSAltOp { get; set; }

        [Required]
        [StringLength(11)]
        public string APSSpecificResource { get; set; }

        public decimal APSCycleTime { get; set; }

        public decimal APSConstantTime { get; set; }

        public int APSSetupGroup { get; set; }

        public int APSMakeFactor { get; set; }

        public decimal APSContainerSize { get; set; }

        [Required]
        [StringLength(11)]
        public string APSSchedulerName { get; set; }

        public decimal APSMaxLength { get; set; }

        public decimal APSTransferTime { get; set; }

        public decimal APSEffectiveness { get; set; }

        [Required]
        [StringLength(1)]
        public string APSOperationClass { get; set; }

        [Required]
        [StringLength(100)]
        public string APSAuxResource { get; set; }

        [Required]
        [StringLength(100)]
        public string APSAddResource { get; set; }

        [Required]
        [StringLength(2)]
        public string LaborEntryMethod { get; set; }

        public decimal FAQty { get; set; }

        public bool RFQNeeded { get; set; }

        public int RFQVendQuotes { get; set; }

        [Required]
        [StringLength(8)]
        public string SetupGroup { get; set; }

        [Required]
        [StringLength(8)]
        public string AnalysisCode { get; set; }

        public int PrimarySetupOpDtl { get; set; }

        public int PrimaryProdOpDtl { get; set; }

        public int RtgGroup { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(12)]
        public string AltMethod { get; set; }

        public bool BaseMethodOverridden { get; set; }

        [Required]
        [StringLength(8)]
        public string StageNumber { get; set; }

        [Required]
        [StringLength(30)]
        public string OpDesc { get; set; }

        [Required]
        [StringLength(12)]
        public string ParentAltMethod { get; set; }

        public int ParentOprSeq { get; set; }

        public decimal PBrkCost01 { get; set; }

        public decimal PBrkCost02 { get; set; }

        public decimal PBrkCost03 { get; set; }

        public decimal PBrkCost04 { get; set; }

        public decimal PBrkCost05 { get; set; }

        public decimal PBrkCost06 { get; set; }

        public decimal PBrkCost07 { get; set; }

        public decimal PBrkCost08 { get; set; }

        public decimal PBrkCost09 { get; set; }

        public decimal PBrkCost10 { get; set; }

        public decimal PBrkStdRate01 { get; set; }

        public decimal PBrkStdRate02 { get; set; }

        public decimal PBrkStdRate03 { get; set; }

        public decimal PBrkStdRate04 { get; set; }

        public decimal PBrkStdRate05 { get; set; }

        public decimal PBrkStdRate06 { get; set; }

        public decimal PBrkStdRate07 { get; set; }

        public decimal PBrkStdRate08 { get; set; }

        public decimal PBrkStdRate09 { get; set; }

        public decimal PBrkStdRate10 { get; set; }

        public decimal BrkQty01 { get; set; }

        public decimal BrkQty02 { get; set; }

        public decimal BrkQty03 { get; set; }

        public decimal BrkQty04 { get; set; }

        public decimal BrkQty05 { get; set; }

        public decimal BrkQty06 { get; set; }

        public decimal BrkQty07 { get; set; }

        public decimal BrkQty08 { get; set; }

        public decimal BrkQty09 { get; set; }

        public decimal BrkQty10 { get; set; }

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

        public bool UseAllRoles { get; set; }

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

        public Guid SysRowID { get; set; }
    }
}
