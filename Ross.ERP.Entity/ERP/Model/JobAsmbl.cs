namespace Ross.ERP.Entity.ERP.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Erp.JobAsmbl")]
    public partial class JobAsmbl
    {
        [Required]
        [StringLength(8)]
        public string Company { get; set; }

        public bool JobComplete { get; set; }

        [Required]
        [StringLength(14)]
        public string JobNum { get; set; }

        public int AssemblySeq { get; set; }

        [Required]
        [StringLength(50)]
        public string PartNum { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        [StringLength(12)]
        public string RevisionNum { get; set; }

        public decimal QtyPer { get; set; }

        [Required]
        [StringLength(6)]
        public string IUM { get; set; }

        public decimal RequiredQty { get; set; }

        public decimal PullQty { get; set; }

        [Required]
        [StringLength(8)]
        public string WarehouseCode { get; set; }

        public decimal MtlBurRate { get; set; }

        public decimal EstUnitCost { get; set; }

        public decimal EstMtlBurUnitCost { get; set; }

        public decimal OverRunQty { get; set; }

        [Column(TypeName = "date")]
        public DateTime? StartDate { get; set; }

        public decimal StartHour { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DueDate { get; set; }

        public decimal DueHour { get; set; }

        public int Parent { get; set; }

        public int PriorPeer { get; set; }

        public int NextPeer { get; set; }

        public int Child { get; set; }

        public decimal TotalCost { get; set; }

        public decimal MtlBurCost { get; set; }

        public decimal IssuedQty { get; set; }

        [Required]
        [StringLength(25)]
        public string DrawNum { get; set; }

        public bool IssuedComplete { get; set; }

        [Required]
        public string CommentText { get; set; }

        public bool InCopyList { get; set; }

        public int BomSequence { get; set; }

        public int BomLevel { get; set; }

        [Column(TypeName = "date")]
        public DateTime? WIStartDate { get; set; }

        public decimal WIStartHour { get; set; }

        [Column(TypeName = "date")]
        public DateTime? WIDueDate { get; set; }

        public decimal WIDueHour { get; set; }

        public decimal TLALaborCost { get; set; }

        public decimal TLABurdenCost { get; set; }

        public decimal TLAMaterialCost { get; set; }

        public decimal TLASubcontractCost { get; set; }

        public decimal TLAMtlBurCost { get; set; }

        public decimal TLASetupHours { get; set; }

        public decimal TLAProdHours { get; set; }

        public decimal TLELaborCost { get; set; }

        public decimal TLEBurdenCost { get; set; }

        public decimal TLEMaterialCost { get; set; }

        public decimal TLESubcontractCost { get; set; }

        public decimal TLEMtlBurCost { get; set; }

        public decimal TLESetupHours { get; set; }

        public decimal TLEProdHours { get; set; }

        public decimal LLALaborCost { get; set; }

        public decimal LLABurdenCost { get; set; }

        public decimal LLAMaterialCost { get; set; }

        public decimal LLASubcontractCost { get; set; }

        public decimal LLAMtlBurCost { get; set; }

        public decimal LLASetupHours { get; set; }

        public decimal LLAProdHours { get; set; }

        public decimal LLELaborCost { get; set; }

        public decimal LLEBurdenCost { get; set; }

        public decimal LLEMaterialCost { get; set; }

        public decimal LLESubcontractCost { get; set; }

        public decimal LLEMtlBurCost { get; set; }

        public decimal LLESetupHours { get; set; }

        public decimal LLEProdHours { get; set; }

        public int AutoRecOpr { get; set; }

        public int FinalOpr { get; set; }

        [Required]
        [StringLength(10)]
        public string FindNum { get; set; }

        public decimal ReceivedToStock { get; set; }

        [Required]
        [StringLength(8)]
        public string Plant { get; set; }

        public bool Direct { get; set; }

        public int RelatedOperation { get; set; }

        public decimal TLAMaterialLabCost { get; set; }

        public decimal TLAMaterialMtlCost { get; set; }

        public decimal TLAMaterialSubCost { get; set; }

        public decimal TLAMaterialBurCost { get; set; }

        public decimal LLAMaterialLabCost { get; set; }

        public decimal LLAMaterialMtlCost { get; set; }

        public decimal LLAMaterialSubCost { get; set; }

        public decimal LLAMaterialBurCost { get; set; }

        public decimal TotalMtlMtlCost { get; set; }

        public decimal TotalMtlLabCost { get; set; }

        public decimal TotalMtlSubCost { get; set; }

        public decimal TotalMtlBurCost { get; set; }

        public int CallNum { get; set; }

        public int CallLine { get; set; }

        [Required]
        [StringLength(14)]
        public string RestoreFlag { get; set; }

        [Required]
        [StringLength(8)]
        public string AnalysisCode { get; set; }

        [Column(TypeName = "date")]
        public DateTime? LastConfigDate { get; set; }

        public int LastConfigTime { get; set; }

        [Required]
        [StringLength(75)]
        public string LastConfigUserID { get; set; }

        public decimal OrigRequiredQty { get; set; }

        [Required]
        public string UserMapData { get; set; }

        public bool WhseAllocFlag { get; set; }

        public decimal TLAMaterialMtlBurCost { get; set; }

        public decimal LLAMaterialMtlBurCost { get; set; }

        public decimal TLAMfgCompLabCost { get; set; }

        public decimal TLAMfgCompMtlCost { get; set; }

        public decimal TLAMfgCompSubCost { get; set; }

        public decimal TLAMfgCompBurCost { get; set; }

        public decimal TLAMfgCompMtlBurCost { get; set; }

        public decimal LLAMfgCompLabCost { get; set; }

        public decimal LLAMfgCompMtlCost { get; set; }

        public decimal LLAMfgCompSubCost { get; set; }

        public decimal LLAMfgCompBurCost { get; set; }

        public decimal LLAMfgCompMtlBurCost { get; set; }

        public decimal Weight { get; set; }

        [Required]
        [StringLength(6)]
        public string WeightUOM { get; set; }

        public int OrigMtlSeq { get; set; }

        [Required]
        public string OrigRuleTag { get; set; }

        public bool ValRefDes { get; set; }

        [Required]
        [StringLength(50)]
        public string BasePartNum { get; set; }

        [Required]
        [StringLength(12)]
        public string BaseRevisionNum { get; set; }

        public decimal EstMtlUnitCost { get; set; }

        public decimal EstLbrUnitCost { get; set; }

        public decimal EstBurUnitCost { get; set; }

        public decimal EstSubUnitCost { get; set; }

        public bool PlanAsAsm { get; set; }

        [Required]
        [StringLength(36)]
        public string PAARef { get; set; }

        public bool PAAFirm { get; set; }

        public decimal EstScrap { get; set; }

        [Required]
        [StringLength(1)]
        public string EstScrapType { get; set; }

        public bool SmartStringProcessed { get; set; }

        [Required]
        public string SmartString { get; set; }

        public int ReqRefDes { get; set; }

        public bool ReassignSNAsm { get; set; }

        public decimal TLAODCCost { get; set; }

        [Required]
        public string AssemblyMatch { get; set; }

        [Required]
        [StringLength(100)]
        public string JdfStatus { get; set; }

        [Required]
        public string PressDevice { get; set; }

        [Required]
        public string DigitalFileName { get; set; }

        [Required]
        [StringLength(100)]
        public string PrepressJobName { get; set; }

        [Required]
        [StringLength(200)]
        public string JdfPrepressAction { get; set; }

        public bool SendToPress { get; set; }

        public bool RemovedFromPlan { get; set; }

        public int SendToPressInitiator { get; set; }

        public int OperationType { get; set; }

        public bool SendToPrePress { get; set; }

        public int GroupSeq { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] SysRevID { get; set; }

        [Key]
        public Guid SysRowID { get; set; }

        [Required]
        public string PartPlanInfo { get; set; }

        [Required]
        [StringLength(250)]
        public string OrigStructTag { get; set; }

        [Required]
        [StringLength(50)]
        public string ContractID { get; set; }

        public bool LinkToContract { get; set; }

        public bool PCLinkRemoved { get; set; }
    }
}
