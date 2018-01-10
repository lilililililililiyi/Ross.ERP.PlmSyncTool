namespace Ross.ERP.Entity.ERP.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Erp.WhseBin")]
    public partial class WhseBin
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(8)]
        public string Company { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(8)]
        public string WarehouseCode { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(10)]
        public string BinNum { get; set; }

        [Required]
        [StringLength(30)]
        public string Description { get; set; }

        public bool NonNettable { get; set; }

        [Required]
        [StringLength(8)]
        public string SizeID { get; set; }

        [Required]
        [StringLength(8)]
        public string ZoneID { get; set; }

        public int BinSeq { get; set; }

        [Required]
        [StringLength(8)]
        public string BinType { get; set; }

        public int CustNum { get; set; }

        public int VendorNum { get; set; }

        [Required]
        [StringLength(8)]
        public string Aisle { get; set; }

        [Required]
        [StringLength(8)]
        public string Face { get; set; }

        public int Elevation { get; set; }

        public decimal MaxFill { get; set; }

        public decimal PctFillable { get; set; }

        public bool InActive { get; set; }

        public bool Portable { get; set; }

        public bool Replenishable { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] SysRevID { get; set; }

        public Guid SysRowID { get; set; }
    }
}
