namespace Ross.ERP.Entity.ERP.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Erp.OPrice")]
    public partial class OPrice
    {
        [Required]
        [StringLength(8)]
        public string Company { get; set; }

        [Required]
        [StringLength(2)]
        public string BreakType { get; set; }

        [Required]
        [StringLength(50)]
        public string PartNum { get; set; }

        [Required]
        [StringLength(8)]
        public string ProdCode { get; set; }

        public int CustNum { get; set; }

        [Column(TypeName = "date")]
        public DateTime? StartDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? EndDate { get; set; }

        [Required]
        [StringLength(10)]
        public string ListCode { get; set; }

        public decimal DiscountPercent2 { get; set; }

        public decimal DiscountPercent3 { get; set; }

        public decimal DiscountPercent4 { get; set; }

        public decimal DiscountPercent5 { get; set; }

        public decimal QtyBreak1 { get; set; }

        public decimal QtyBreak2 { get; set; }

        public decimal QtyBreak3 { get; set; }

        public decimal QtyBreak4 { get; set; }

        public decimal QtyBreak5 { get; set; }

        public decimal DiscountPercent1 { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] SysRevID { get; set; }

        [Key]
        public Guid SysRowID { get; set; }
    }
}
