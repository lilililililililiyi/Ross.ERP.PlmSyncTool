namespace Ross.ERP.Entity.ERP.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Erp.PartBinInfo")]
    public partial class PartBinInfo
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
        [StringLength(8)]
        public string WarehouseCode { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(10)]
        public string BinNum { get; set; }

        public decimal MinimumQty { get; set; }

        public decimal MaximumQty { get; set; }

        public decimal SafetyQty { get; set; }

        [Required]
        [StringLength(8)]
        public string KBCode { get; set; }

        public int KBPONUM { get; set; }

        public int KBPOLine { get; set; }

        [Required]
        [StringLength(8)]
        public string KBWarehouseCode { get; set; }

        [Required]
        [StringLength(10)]
        public string KBBinNum { get; set; }

        [Required]
        [StringLength(8)]
        public string KBPlant { get; set; }

        public decimal OnhandQty { get; set; }

        public decimal KBQty { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] SysRevID { get; set; }

        public Guid SysRowID { get; set; }
    }
}
