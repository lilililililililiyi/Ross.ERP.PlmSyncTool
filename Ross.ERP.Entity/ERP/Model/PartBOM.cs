namespace Ross.ERP.Entity.ERP.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Erp.PartBOM")]
    public partial class PartBOM
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string EndPartNum { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(12)]
        public string EndRevision { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BomSequence { get; set; }

        public int BomLevel { get; set; }

        [Required]
        [StringLength(50)]
        public string MtlPartNum { get; set; }

        [Required]
        [StringLength(12)]
        public string MtlRevision { get; set; }

        [Required]
        public string PartDescription { get; set; }

        public decimal QtyPer { get; set; }

        public decimal QtyRequired { get; set; }

        [Required]
        [StringLength(3)]
        public string BOMType { get; set; }

        public bool Approved { get; set; }

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

        public decimal SalvageQtyPer { get; set; }

        public decimal SalvageUnitCredit { get; set; }

        [Required]
        [StringLength(50)]
        public string IndMtlPartNum { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(12)]
        public string EndAltMethod { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] SysRevID { get; set; }

        public Guid SysRowID { get; set; }
    }
}
