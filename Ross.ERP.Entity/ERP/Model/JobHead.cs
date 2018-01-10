namespace Ross.ERP.Entity.ERP.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Erp.JobHead")]
    public partial class JobHead
    {
        [Required]
        [StringLength(8)]
        public string Company { get; set; }

        public bool JobClosed { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ClosedDate { get; set; }

        public bool JobComplete { get; set; }

        [Column(TypeName = "date")]
        public DateTime? JobCompletionDate { get; set; }

        public bool JobEngineered { get; set; }

        public bool CheckOff1 { get; set; }

        public bool CheckOff2 { get; set; }

        public bool CheckOff3 { get; set; }

        public bool CheckOff4 { get; set; }

        public bool CheckOff5 { get; set; }

        public bool JobReleased { get; set; }

        public bool JobHeld { get; set; }

        [Required]
        [StringLength(1)]
        public string SchedStatus { get; set; }

        [Required]
        [StringLength(14)]
        public string JobNum { get; set; }

        [Required]
        [StringLength(50)]
        public string PartNum { get; set; }

        [Required]
        [StringLength(12)]
        public string RevisionNum { get; set; }

        [Required]
        [StringLength(25)]
        public string DrawNum { get; set; }

        [Required]
        public string PartDescription { get; set; }

        public decimal ProdQty { get; set; }

        [Required]
        [StringLength(6)]
        public string IUM { get; set; }

        [Column(TypeName = "date")]
        public DateTime? StartDate { get; set; }

        public decimal StartHour { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DueDate { get; set; }

        public decimal DueHour { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ReqDueDate { get; set; }

        [Required]
        [StringLength(8)]
        public string JobCode { get; set; }

        public int QuoteNum { get; set; }

        public int QuoteLine { get; set; }

        [Required]
        [StringLength(8)]
        public string ProdCode { get; set; }

        [Required]
        [StringLength(30)]
        public string UserChar1 { get; set; }

        [Required]
        [StringLength(30)]
        public string UserChar2 { get; set; }

        [Required]
        [StringLength(30)]
        public string UserChar3 { get; set; }

        [Required]
        [StringLength(30)]
        public string UserChar4 { get; set; }

        public DateTime? UserDate1 { get; set; }

        public DateTime? UserDate2 { get; set; }

        public DateTime? UserDate3 { get; set; }

        public DateTime? UserDate4 { get; set; }

        public decimal UserDecimal1 { get; set; }

        public decimal UserDecimal2 { get; set; }

        public int UserInteger1 { get; set; }

        public int UserInteger2 { get; set; }

        [Required]
        public string CommentText { get; set; }

        [Required]
        [StringLength(16)]
        public string ExpenseCode { get; set; }

        public bool InCopyList { get; set; }

        [Required]
        [StringLength(75)]
        public string WIName { get; set; }

        [Column(TypeName = "date")]
        public DateTime? WIStartDate { get; set; }

        public decimal WIStartHour { get; set; }

        [Column(TypeName = "date")]
        public DateTime? WIDueDate { get; set; }

        public decimal WIDueHour { get; set; }

        public bool Candidate { get; set; }

        [Required]
        [StringLength(6)]
        public string SchedCode { get; set; }

        public bool SchedLocked { get; set; }

        [Required]
        [StringLength(25)]
        public string ProjectID { get; set; }

        public bool WIPCleared { get; set; }

        public bool JobFirm { get; set; }

        [Required]
        public string PersonList { get; set; }

        [Required]
        [StringLength(8)]
        public string PersonID { get; set; }

        [Required]
        [StringLength(8)]
        public string ProdTeamID { get; set; }

        public decimal QtyCompleted { get; set; }

        [Required]
        [StringLength(8)]
        public string Plant { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DatePurged { get; set; }

        public bool TravelerReadyToPrint { get; set; }

        [Column(TypeName = "date")]
        public DateTime? TravelerLastPrinted { get; set; }

        public bool StatusReadyToPrint { get; set; }

        [Column(TypeName = "date")]
        public DateTime? StatusLastPrinted { get; set; }

        public int CallNum { get; set; }

        public int CallLine { get; set; }

        [Required]
        [StringLength(3)]
        public string JobType { get; set; }

        [Required]
        [StringLength(14)]
        public string RestoreFlag { get; set; }

        [Required]
        [StringLength(12)]
        public string PhaseID { get; set; }

        [Required]
        [StringLength(8)]
        public string AnalysisCode { get; set; }

        public bool LockQty { get; set; }

        public int HDCaseNum { get; set; }

        [Required]
        [StringLength(1)]
        public string ProcessMode { get; set; }

        [Column(TypeName = "date")]
        public DateTime? PlannedActionDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? PlannedKitDate { get; set; }

        [Required]
        [StringLength(10)]
        public string MSPTaskID { get; set; }

        [Required]
        public string MSPPredecessor { get; set; }

        [Required]
        public string UserMapData { get; set; }

        public bool ProductionYield { get; set; }

        public decimal OrigProdQty { get; set; }

        public bool PreserveOrigQtys { get; set; }

        public bool NoAutoCompletion { get; set; }

        public bool NoAutoClosing { get; set; }

        [Required]
        [StringLength(75)]
        public string CreatedBy { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CreateDate { get; set; }

        public bool WhseAllocFlag { get; set; }

        [Required]
        [StringLength(8)]
        public string OwnershipStatus { get; set; }

        [Required]
        [StringLength(8)]
        public string PDMObjID { get; set; }

        [Required]
        [StringLength(8)]
        public string ExportRequested { get; set; }

        public bool SplitMfgCostElements { get; set; }

        [Required]
        [StringLength(50)]
        public string XRefPartNum { get; set; }

        [Required]
        [StringLength(1)]
        public string XRefPartType { get; set; }

        public int XRefCustNum { get; set; }

        [Required]
        [StringLength(50)]
        public string BasePartNum { get; set; }

        [Required]
        [StringLength(12)]
        public string BaseRevisionNum { get; set; }

        public bool RoughCutScheduled { get; set; }

        [Required]
        [StringLength(20)]
        public string EquipID { get; set; }

        public int PlanNum { get; set; }

        [Required]
        [StringLength(2)]
        public string MaintPriority { get; set; }

        public bool SplitJob { get; set; }

        public bool NumberSource { get; set; }

        public int CloseMeterReading { get; set; }

        [Required]
        [StringLength(16)]
        public string IssueTopicID1 { get; set; }

        [Required]
        [StringLength(16)]
        public string IssueTopicID2 { get; set; }

        [Required]
        [StringLength(16)]
        public string IssueTopicID3 { get; set; }

        [Required]
        [StringLength(16)]
        public string IssueTopicID4 { get; set; }

        [Required]
        [StringLength(16)]
        public string IssueTopicID5 { get; set; }

        [Required]
        [StringLength(16)]
        public string IssueTopicID6 { get; set; }

        [Required]
        [StringLength(16)]
        public string IssueTopicID7 { get; set; }

        [Required]
        [StringLength(16)]
        public string IssueTopicID8 { get; set; }

        [Required]
        [StringLength(16)]
        public string IssueTopicID9 { get; set; }

        [Required]
        [StringLength(16)]
        public string IssueTopicID10 { get; set; }

        [Required]
        [StringLength(256)]
        public string IssueTopics { get; set; }

        [Required]
        [StringLength(16)]
        public string ResTopicID1 { get; set; }

        [Required]
        [StringLength(16)]
        public string ResTopicID2 { get; set; }

        [Required]
        [StringLength(16)]
        public string ResTopicID3 { get; set; }

        [Required]
        [StringLength(16)]
        public string ResTopicID4 { get; set; }

        [Required]
        [StringLength(16)]
        public string ResTopicID5 { get; set; }

        [Required]
        [StringLength(16)]
        public string ResTopicID6 { get; set; }

        [Required]
        [StringLength(16)]
        public string ResTopicID7 { get; set; }

        [Required]
        [StringLength(16)]
        public string ResTopicID8 { get; set; }

        [Required]
        [StringLength(16)]
        public string ResTopicID9 { get; set; }

        [Required]
        [StringLength(16)]
        public string ResTopicID10 { get; set; }

        [Required]
        [StringLength(256)]
        public string ResTopics { get; set; }

        public bool Forward { get; set; }

        public int SchedSeq { get; set; }

        public bool PAAExists { get; set; }

        public bool DtlsWithinLeadTime { get; set; }

        public int GroupSeq { get; set; }

        public bool RoughCut { get; set; }

        [Required]
        [StringLength(256)]
        public string PlanGUID { get; set; }

        [Required]
        [StringLength(50)]
        public string PlanUserID { get; set; }

        [Required]
        [StringLength(75)]
        public string LastChangedBy { get; set; }

        [Column(TypeName = "date")]
        public DateTime? LastChangedOn { get; set; }

        public int EPMExportLevel { get; set; }

        [Required]
        [StringLength(50)]
        public string JobWorkflowState { get; set; }

        [Required]
        [StringLength(50)]
        public string JobCSR { get; set; }

        public bool ExternalMES { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] SysRevID { get; set; }

        [Key]
        public Guid SysRowID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? LastExternalMESDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? LastScheduleDate { get; set; }

        [Required]
        [StringLength(20)]
        public string LastScheduleProc { get; set; }

        public int SchedPriority { get; set; }

        public int DaysLate { get; set; }

        [Required]
        [StringLength(50)]
        public string ContractID { get; set; }

        public bool ProjProcessed { get; set; }

        public bool SyncReqBy { get; set; }

        [Required]
        [StringLength(50)]
        public string CustName { get; set; }

        [Required]
        [StringLength(10)]
        public string CustID { get; set; }

        public bool IsCSRSet { get; set; }

        public bool UnReadyCostProcess { get; set; }

        [Required]
        [StringLength(50)]
        public string ProcSuspendedUpdates { get; set; }

        public DateTime? ProjProcessedDate { get; set; }

        public bool PCLinkRemoved { get; set; }

        public virtual JobHead_UD JobHead_UD { get; set; }
    }
}
