namespace Ross.ERP.Entity.ERP.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Erp.PartRev")]
    public partial class PartRev
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

        [Required]
        [StringLength(30)]
        public string RevShortDesc { get; set; }

        [Required]
        public string RevDescription { get; set; }

        public bool Approved { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ApprovedDate { get; set; }

        [Required]
        [StringLength(75)]
        public string ApprovedBy { get; set; }

        [Column(TypeName = "date")]
        public DateTime? EffectiveDate { get; set; }

        public decimal TLRLaborCost { get; set; }

        public decimal TLRBurdenCost { get; set; }

        public decimal TLRMaterialCost { get; set; }

        public decimal TLRSubcontractCost { get; set; }

        public decimal TLRMtlBurCost { get; set; }

        public decimal TLRSetupLaborCost { get; set; }

        public decimal TLRSetupBurdenCost { get; set; }

        public decimal LLRLaborCost { get; set; }

        public decimal LLRBurdenCost { get; set; }

        public decimal LLRMaterialCost { get; set; }

        public decimal LLRSubcontractCost { get; set; }

        public decimal LLRMtlBurCost { get; set; }

        public decimal LLRSetupLaborCost { get; set; }

        public decimal LLRSetupBurdenCost { get; set; }

        [Column(TypeName = "date")]
        public DateTime? RollupDate { get; set; }

        [Required]
        [StringLength(25)]
        public string DrawNum { get; set; }

        [Required]
        [StringLength(10)]
        public string ECO { get; set; }

        public bool Method { get; set; }

        public int AutoRecOpr { get; set; }

        public int FinalOpr { get; set; }

        [Required]
        [StringLength(8)]
        public string PDMObjID { get; set; }

        public bool Configured { get; set; }

        public bool WebConfigured { get; set; }

        public bool ShowInputPrice { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(12)]
        public string AltMethod { get; set; }

        [Required]
        [StringLength(30)]
        public string AltMethodDesc { get; set; }

        [Required]
        [StringLength(8)]
        public string Plant { get; set; }

        [Required]
        [StringLength(12)]
        public string ParentAltMethod { get; set; }

        public bool UseStaging { get; set; }

        public bool UseAltRevForParts { get; set; }

        [Required]
        [StringLength(8)]
        public string OwnershipStatus { get; set; }

        public bool ExtConfig { get; set; }

        public bool ValRefDes { get; set; }

        public bool PcGlobalPart { get; set; }

        public bool PcEntprsConf { get; set; }

        public bool GlobalRev { get; set; }

        [Required]
        [StringLength(12)]
        public string RoughCutCode { get; set; }

        [Required]
        [StringLength(50)]
        public string RMAInspPlan { get; set; }

        [Required]
        [StringLength(20)]
        public string RMASpecID { get; set; }

        public decimal RMASampleSize { get; set; }

        public decimal RMASampleSizePct { get; set; }

        [Required]
        [StringLength(50)]
        public string BasePartNum { get; set; }

        [Required]
        [StringLength(12)]
        public string BaseRevisionNum { get; set; }

        [Required]
        [StringLength(100)]
        public string ConfigID { get; set; }

        public bool RegenConfig { get; set; }

        public int SIValuesGroupSeq { get; set; }

        public int SIValuesHeadNum { get; set; }

        public bool ExternalMES { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] SysRevID { get; set; }

        public Guid SysRowID { get; set; }

        [Required]
        [StringLength(1)]
        public string ProcessMode { get; set; }

        public bool DefaultConfigPart { get; set; }

        public decimal CoPartsReqQty { get; set; }

        public decimal MtlCostPct { get; set; }

        public decimal LaborCostPct { get; set; }

        public int CoPartsPerOp { get; set; }
    }
}
