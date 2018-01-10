namespace Ross.ERP.Entity.ERP.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Erp.PartClass")]
    public partial class PartClass
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(8)]
        public string Company { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(4)]
        public string ClassID { get; set; }

        [Required]
        [StringLength(30)]
        public string Description { get; set; }

        [Required]
        [StringLength(8)]
        public string BuyerID { get; set; }

        public bool RcvInspectionReq { get; set; }

        [Required]
        [StringLength(12)]
        public string CommodityCode { get; set; }

        public bool AvailForReq { get; set; }

        public decimal MtlBurRate { get; set; }

        public bool SplitPOLine { get; set; }

        [Required]
        [StringLength(4)]
        public string NegQtyAction { get; set; }

        [Required]
        [StringLength(8)]
        public string PurchCode { get; set; }

        public bool ConsolidatedPurchasing { get; set; }

        public bool GlobalPartClass { get; set; }

        public bool GlobalLock { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] SysRevID { get; set; }

        public Guid SysRowID { get; set; }

        public bool MMSInclude { get; set; }

        public bool MMSSales { get; set; }

        public bool MMSIssue { get; set; }

        public int MMSHistory { get; set; }

        public int MMSSafetyFactor { get; set; }

        public decimal MMSMaxFactor { get; set; }

        public int PartLeadTime { get; set; }

        public bool DeferredExp { get; set; }

        [Required]
        [StringLength(30)]
        public string DEACode { get; set; }
    }
}
