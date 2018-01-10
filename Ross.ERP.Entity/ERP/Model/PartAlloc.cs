namespace Ross.ERP.Entity.ERP.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Erp.PartAlloc")]
    public partial class PartAlloc
    {
        [Required]
        [StringLength(8)]
        public string Company { get; set; }

        [Required]
        [StringLength(50)]
        public string PartNum { get; set; }

        [Required]
        [StringLength(8)]
        public string WarehouseCode { get; set; }

        [Required]
        [StringLength(10)]
        public string BinNum { get; set; }

        [Required]
        [StringLength(14)]
        public string SupplyJobNum { get; set; }

        public int OrderNum { get; set; }

        public int OrderLine { get; set; }

        public int OrderRelNum { get; set; }

        [Required]
        [StringLength(14)]
        public string JobNum { get; set; }

        public int AssemblySeq { get; set; }

        public int MtlSeq { get; set; }

        [Required]
        [StringLength(14)]
        public string TFOrdNum { get; set; }

        public int TFOrdLine { get; set; }

        [Required]
        [StringLength(30)]
        public string LotNum { get; set; }

        [Required]
        [StringLength(6)]
        public string DimCode { get; set; }

        public decimal ReservedQty { get; set; }

        public decimal AllocatedQty { get; set; }

        public decimal PickingQty { get; set; }

        public decimal PickedQty { get; set; }

        [Required]
        [StringLength(8)]
        public string DemandType { get; set; }

        [Required]
        [StringLength(10)]
        public string DistributionType { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CreateDate { get; set; }

        public int CreateTime { get; set; }

        public int WaveNum { get; set; }

        [Required]
        [StringLength(10)]
        public string WaveDestBinNum { get; set; }

        public bool WavePickTicketPrinted { get; set; }

        [Required]
        [StringLength(8)]
        public string ZoneID { get; set; }

        [Required]
        [StringLength(8)]
        public string SearchSort { get; set; }

        [Required]
        [StringLength(8)]
        public string BinType { get; set; }

        [Required]
        [StringLength(10)]
        public string BinNumFirstOption { get; set; }

        [Required]
        [StringLength(8)]
        public string WhseDestWarehouseCode { get; set; }

        [Required]
        [StringLength(20)]
        public string WhseGroupCode { get; set; }

        public int TransPriority { get; set; }

        public bool CrossDocking { get; set; }

        public bool OnHold { get; set; }

        public bool MultiplePartsPerBin { get; set; }

        [Required]
        [StringLength(8)]
        public string PackStation { get; set; }

        [Required]
        [StringLength(10)]
        public string BinNumProductionIn { get; set; }

        [Required]
        [StringLength(8)]
        public string ForwardStageGroup { get; set; }

        public bool HardAllocation { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] SysRevID { get; set; }

        [Key]
        public Guid SysRowID { get; set; }

        [Required]
        [StringLength(12)]
        public string PCID { get; set; }
    }
}
