namespace Ross.ERP.Entity.ERP.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Erp.RcvMisc")]
    public partial class RcvMisc
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(8)]
        public string Company { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int VendorNum { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(4)]
        public string PurPoint { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(20)]
        public string PackSlip { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MiscSeq { get; set; }

        [Required]
        [StringLength(4)]
        public string MiscCode { get; set; }

        public bool ExcludeFromLC { get; set; }

        public bool IncTransValue { get; set; }

        [Required]
        [StringLength(8)]
        public string LCDisburseMethod { get; set; }

        public decimal ActualAmt { get; set; }

        public decimal DocActualAmt { get; set; }

        [Required]
        [StringLength(4)]
        public string CurrencyCode { get; set; }

        public bool LockRate { get; set; }

        [Required]
        public string CommentText { get; set; }

        public decimal Rpt1ActualAmt { get; set; }

        public decimal Rpt2ActualAmt { get; set; }

        public decimal Rpt3ActualAmt { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ApplyDate { get; set; }

        [Required]
        [StringLength(12)]
        public string RateGrpCode { get; set; }

        [Required]
        [StringLength(20)]
        public string InvoiceNum { get; set; }

        public int InvoiceLine { get; set; }

        public int MscNum { get; set; }

        public decimal Percentage { get; set; }

        [Required]
        [StringLength(1)]
        public string Type { get; set; }

        public int APInvVendorNum { get; set; }

        public int PackLine { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] SysRevID { get; set; }

        public Guid SysRowID { get; set; }
    }
}
