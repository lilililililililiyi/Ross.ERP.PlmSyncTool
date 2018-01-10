namespace Ross.ERP.Entity.ERP.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Erp.VendPart")]
    public partial class VendPart
    {
        [Required]
        [StringLength(8)]
        public string Company { get; set; }

        [Required]
        [StringLength(50)]
        public string PartNum { get; set; }

        [Required]
        [StringLength(8)]
        public string OpCode { get; set; }

        [Required]
        [StringLength(6)]
        public string PUM { get; set; }

        [Column(TypeName = "date")]
        public DateTime? EffectiveDate { get; set; }

        public int VendorNum { get; set; }

        public int LeadTime { get; set; }

        public decimal BaseUnitPrice { get; set; }

        [Required]
        [StringLength(50)]
        public string VenPartNum { get; set; }

        [Required]
        [StringLength(2)]
        public string PriceFormat { get; set; }

        [Required]
        [StringLength(2)]
        public string PricePerCode { get; set; }

        public decimal MinimumPrice { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ExpirationDate { get; set; }

        [Required]
        [StringLength(30)]
        public string Reference { get; set; }

        public decimal MiscAmt { get; set; }

        [Required]
        [StringLength(4)]
        public string MiscCode { get; set; }

        [Required]
        public string CommentText { get; set; }

        public decimal DiscountPercent { get; set; }

        [Required]
        public string PartDescription { get; set; }

        public int RFQNum { get; set; }

        public int RFQLine { get; set; }

        [Required]
        [StringLength(4)]
        public string CurrencyCode { get; set; }

        public decimal OnhandQty { get; set; }

        [Column(TypeName = "date")]
        public DateTime? OnHandDate { get; set; }

        public int OnHandTime { get; set; }

        public int ConNum { get; set; }

        public bool SupplierResponseReady { get; set; }

        public bool DefaultPUM { get; set; }

        [Required]
        [StringLength(8)]
        public string ConvOperator { get; set; }

        public decimal ConvFactor { get; set; }

        public bool ConvOverRide { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] SysRevID { get; set; }

        [Key]
        public Guid SysRowID { get; set; }
    }
}
