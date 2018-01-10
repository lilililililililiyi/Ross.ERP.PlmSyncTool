namespace Ross.ERP.Entity.ERP.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Erp.PartBin")]
    public partial class PartBin
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

        public decimal OnhandQty { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(30)]
        public string LotNum { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(6)]
        public string DimCode { get; set; }

        public decimal AllocatedQty { get; set; }

        public decimal SalesAllocatedQty { get; set; }

        public decimal SalesPickingQty { get; set; }

        public decimal SalesPickedQty { get; set; }

        public decimal JobAllocatedQty { get; set; }

        public decimal JobPickingQty { get; set; }

        public decimal JobPickedQty { get; set; }

        public decimal TFOrdAllocatedQty { get; set; }

        public decimal TFOrdPickingQty { get; set; }

        public decimal TFOrdPickedQty { get; set; }

        public decimal ShippingQty { get; set; }

        public decimal PackedQty { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] SysRevID { get; set; }

        public Guid SysRowID { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(12)]
        public string PCID { get; set; }
    }
}
