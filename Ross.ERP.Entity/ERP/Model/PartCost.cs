namespace Ross.ERP.Entity.ERP.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Erp.PartCost")]
    public partial class PartCost
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
        public string CostID { get; set; }

        public decimal AvgLaborCost { get; set; }

        public decimal AvgBurdenCost { get; set; }

        public decimal AvgMaterialCost { get; set; }

        public decimal AvgSubContCost { get; set; }

        public decimal AvgMtlBurCost { get; set; }

        public decimal StdLaborCost { get; set; }

        public decimal StdBurdenCost { get; set; }

        public decimal StdMaterialCost { get; set; }

        public decimal StdSubContCost { get; set; }

        public decimal StdMtlBurCost { get; set; }

        public decimal LastLaborCost { get; set; }

        public decimal LastBurdenCost { get; set; }

        public decimal LastMaterialCost { get; set; }

        public decimal LastSubContCost { get; set; }

        public decimal LastMtlBurCost { get; set; }

        public decimal FIFOAvgLaborCost { get; set; }

        public decimal FIFOAvgBurdenCost { get; set; }

        public decimal FIFOAvgMaterialCost { get; set; }

        public decimal FIFOAvgSubContCost { get; set; }

        public decimal FIFOAvgMtlBurCost { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] SysRevID { get; set; }

        public Guid SysRowID { get; set; }

        public decimal TotalQtyAvg { get; set; }
    }
}
