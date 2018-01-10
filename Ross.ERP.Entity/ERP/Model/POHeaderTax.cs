namespace Ross.ERP.Entity.ERP.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Erp.POHeaderTax")]
    public partial class POHeaderTax
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
        [StringLength(10)]
        public string TaxCode { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(10)]
        public string RateCode { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ECAcquisitionSeq { get; set; }

        public decimal ReportableAmt { get; set; }

        public decimal DocReportableAmt { get; set; }

        public decimal TaxableAmt { get; set; }

        public decimal DocTaxableAmt { get; set; }

        public decimal Percent { get; set; }

        public decimal TaxAmt { get; set; }

        public decimal DocTaxAmt { get; set; }

        public bool Manual { get; set; }

        [Required]
        [StringLength(75)]
        public string ChangedBy { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ChangeDate { get; set; }

        public int ChangeTime { get; set; }

        public bool ReverseCharge { get; set; }

        public decimal Rpt1ReportableAmt { get; set; }

        public decimal Rpt2ReportableAmt { get; set; }

        public decimal Rpt3ReportableAmt { get; set; }

        public decimal Rpt1TaxableAmt { get; set; }

        public decimal Rpt2TaxableAmt { get; set; }

        public decimal Rpt3TaxableAmt { get; set; }

        public decimal Rpt1TaxAmt { get; set; }

        public decimal Rpt2TaxAmt { get; set; }

        public decimal Rpt3TaxAmt { get; set; }

        public int CollectionType { get; set; }

        public int Timing { get; set; }

        public int ExemptType { get; set; }

        public decimal ExemptPercent { get; set; }

        [Required]
        [StringLength(40)]
        public string ResolutionNum { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ResolutionDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? TaxRateDate { get; set; }

        public decimal DefTaxableAmt { get; set; }

        public decimal DocDefTaxableAmt { get; set; }

        public decimal Rpt1DefTaxableAmt { get; set; }

        public decimal Rpt2DefTaxableAmt { get; set; }

        public decimal Rpt3DefTaxableAmt { get; set; }

        public decimal DefTaxAmt { get; set; }

        public decimal DocDefTaxAmt { get; set; }

        public decimal Rpt1DefTaxAmt { get; set; }

        public decimal Rpt2DefTaxAmt { get; set; }

        public decimal Rpt3DefTaxAmt { get; set; }

        public bool ManAdd { get; set; }

        public decimal DedTaxAmt { get; set; }

        public decimal DocDedTaxAmt { get; set; }

        public decimal Rpt1DedTaxAmt { get; set; }

        public decimal Rpt2DedTaxAmt { get; set; }

        public decimal Rpt3DedTaxAmt { get; set; }

        public decimal FixedAmount { get; set; }

        public decimal DocFixedAmount { get; set; }

        public decimal Rpt1FixedAmount { get; set; }

        public decimal Rpt2FixedAmount { get; set; }

        public decimal Rpt3FixedAmount { get; set; }

        [Required]
        [StringLength(10)]
        public string TextCode { get; set; }

        public decimal TaxAmtVar { get; set; }

        public decimal DocTaxAmtVar { get; set; }

        public decimal Rpt1TaxAmtVar { get; set; }

        public decimal Rpt2TaxAmtVar { get; set; }

        public decimal Rpt3TaxAmtVar { get; set; }

        public bool SummaryOnly { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] SysRevID { get; set; }

        public Guid SysRowID { get; set; }

        public virtual POHeader POHeader { get; set; }
    }
}
