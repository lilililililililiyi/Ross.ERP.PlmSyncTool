namespace Ross.ERP.Entity.ERP.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Erp.PlantTran")]
    public partial class PlantTran
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(8)]
        public string Company { get; set; }

        [Column(TypeName = "date")]
        public DateTime? SysDate { get; set; }

        public int SysTime { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TranNum { get; set; }

        [Required]
        [StringLength(8)]
        public string TranStatus { get; set; }

        [Required]
        [StringLength(50)]
        public string PartNum { get; set; }

        [Required]
        public string PartDescription { get; set; }

        [Required]
        [StringLength(12)]
        public string RevisionNum { get; set; }

        [Required]
        [StringLength(8)]
        public string FromPlant { get; set; }

        [Required]
        [StringLength(8)]
        public string ToPlant { get; set; }

        [Required]
        [StringLength(8)]
        public string FromWarehouseCode { get; set; }

        [Required]
        [StringLength(10)]
        public string BinNum { get; set; }

        [Required]
        [StringLength(14)]
        public string FromJobNum { get; set; }

        public int FromAssemblySeq { get; set; }

        [Required]
        [StringLength(8)]
        public string WarehseCodeTo { get; set; }

        [Required]
        [StringLength(14)]
        public string JobNum { get; set; }

        public int AssemblySeq { get; set; }

        public int JobMtl { get; set; }

        public decimal TranQty { get; set; }

        [Column(TypeName = "date")]
        public DateTime? TranDate { get; set; }

        [Required]
        [StringLength(6)]
        public string UM { get; set; }

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
        public string PlntTranReference { get; set; }

        public decimal MtlUnitCost { get; set; }

        public decimal LbrUnitCost { get; set; }

        public decimal BurUnitCost { get; set; }

        public decimal SubUnitCost { get; set; }

        public decimal MtlBurUnitCost { get; set; }

        [Required]
        [StringLength(75)]
        public string EntryPerson { get; set; }

        [Required]
        [StringLength(7)]
        public string TranType { get; set; }

        public decimal InternalPrice { get; set; }

        public int PackNum { get; set; }

        [Column(TypeName = "date")]
        public DateTime? RecSysDate { get; set; }

        public int RecSysTime { get; set; }

        [Column(TypeName = "date")]
        public DateTime? RecTranDate { get; set; }

        [Required]
        [StringLength(75)]
        public string RecEntryPerson { get; set; }

        public bool RecIssuedComplete { get; set; }

        public decimal MtlMtlUnitCost { get; set; }

        public decimal MtlLabUnitCost { get; set; }

        public decimal MtlSubUnitCost { get; set; }

        public decimal MtlBurdenUnitCost { get; set; }

        public decimal MtlMtlBurUnitCost { get; set; }

        public int TFOrdLine { get; set; }

        public int PackLine { get; set; }

        [Required]
        [StringLength(14)]
        public string TFOrdNum { get; set; }

        [Required]
        [StringLength(14)]
        public string TFLineNum { get; set; }

        public decimal AltMtlUnitCost { get; set; }

        public decimal AltLbrUnitCost { get; set; }

        public decimal AltBurUnitCost { get; set; }

        public decimal AltSubUnitCost { get; set; }

        public decimal AltMtlBurUnitCost { get; set; }

        public decimal AltMtlMtlUnitCost { get; set; }

        public decimal AltMtlLabUnitCost { get; set; }

        public decimal AltMtlSubUnitCost { get; set; }

        public decimal AltMtlBurdenUnitCost { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] SysRevID { get; set; }

        public Guid SysRowID { get; set; }
    }
}
