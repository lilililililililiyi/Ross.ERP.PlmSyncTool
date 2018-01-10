namespace Ross.ERP.Entity.ERP.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Erp.ShipDtlInfo")]
    public partial class ShipDtlInfo
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(8)]
        public string Company { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PackNum { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PackLine { get; set; }

        [Key]
        [Column(Order = 3)]
        public long PackLineSeq { get; set; }

        public decimal OurInventoryShipQty { get; set; }

        public decimal OurJobShipQty { get; set; }

        public decimal SellingInventoryShipQty { get; set; }

        public decimal SellingJobShipQty { get; set; }

        public decimal PickedAutoAllocatedQty { get; set; }

        public decimal NotAllocatedQty { get; set; }

        [Required]
        [StringLength(6)]
        public string IUM { get; set; }

        [Required]
        [StringLength(6)]
        public string SalesUM { get; set; }

        [Required]
        [StringLength(6)]
        public string InventoryShipUOM { get; set; }

        [Required]
        [StringLength(6)]
        public string JobShipUOM { get; set; }

        [Required]
        [StringLength(12)]
        public string PCID { get; set; }

        public long PCIDItemSeq { get; set; }

        public int PCIDParentLine { get; set; }

        [Required]
        [StringLength(30)]
        public string LotNum { get; set; }

        [Required]
        [StringLength(30)]
        public string JobLotNum { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] SysRevID { get; set; }

        public Guid SysRowID { get; set; }

        public virtual ShipDtl ShipDtl { get; set; }
    }
}
