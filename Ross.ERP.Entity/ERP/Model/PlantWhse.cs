namespace Ross.ERP.Entity.ERP.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Erp.PlantWhse")]
    public partial class PlantWhse
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(8)]
        public string Company { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(8)]
        public string Plant { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string PartNum { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(8)]
        public string WarehouseCode { get; set; }

        [Required]
        [StringLength(10)]
        public string PrimBin { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] SysRevID { get; set; }

        public Guid SysRowID { get; set; }
    }
}
