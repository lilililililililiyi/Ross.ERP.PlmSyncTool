namespace Ross.ERP.Entity.ERP.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Erp.POMisc")]
    public partial class POMisc
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(8)]
        public string Company { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PONum { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int POLine { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SeqNum { get; set; }

        [Required]
        [StringLength(4)]
        public string MiscCode { get; set; }

        [Required]
        [StringLength(30)]
        public string Description { get; set; }

        public decimal MiscAmt { get; set; }

        public decimal DocMiscAmt { get; set; }

        public bool Taxable { get; set; }

        public decimal InvoicedAmt { get; set; }

        public decimal DocInvoicedAmt { get; set; }

        public int OrderNum { get; set; }

        public int OrderLine { get; set; }

        public int OrderSeqNum { get; set; }

        public bool Linked { get; set; }

        [Required]
        [StringLength(8)]
        public string ExtCompany { get; set; }

        public decimal Rpt1InvoicedAmt { get; set; }

        public decimal Rpt2InvoicedAmt { get; set; }

        public decimal Rpt3InvoicedAmt { get; set; }

        public decimal Rpt1MiscAmt { get; set; }

        public decimal Rpt2MiscAmt { get; set; }

        public decimal Rpt3MiscAmt { get; set; }

        public decimal Percentage { get; set; }

        [Required]
        [StringLength(1)]
        public string Type { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] SysRevID { get; set; }

        public Guid SysRowID { get; set; }

        public decimal InMiscAmt { get; set; }

        public decimal DocInMiscAmt { get; set; }

        public decimal Rpt1InMiscAmt { get; set; }

        public decimal Rpt2InMiscAmt { get; set; }

        public decimal Rpt3InMiscAmt { get; set; }

        public decimal InInvoiceAmt { get; set; }

        public decimal DocInInvoiceAmt { get; set; }

        public decimal Rpt1InInvoiceAmt { get; set; }

        public decimal Rpt2InInvoiceAmt { get; set; }

        public decimal Rpt3InInvoiceAmt { get; set; }
    }
}
