namespace Ross.ERP.Entity.ERP.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Erp.OrderMsc")]
    public partial class OrderMsc
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(8)]
        public string Company { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderNum { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderLine { get; set; }

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

        [Required]
        [StringLength(2)]
        public string FreqCode { get; set; }

        [Required]
        [StringLength(2)]
        public string Quoting { get; set; }

        public bool Linked { get; set; }

        public int ICPONum { get; set; }

        public int ICPOLine { get; set; }

        public int ICPOSeqNum { get; set; }

        [Required]
        [StringLength(8)]
        public string ExtCompany { get; set; }

        [Required]
        [StringLength(75)]
        public string ChangedBy { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ChangeDate { get; set; }

        public int ChangeTime { get; set; }

        public decimal Rpt1MiscAmt { get; set; }

        public decimal Rpt2MiscAmt { get; set; }

        public decimal Rpt3MiscAmt { get; set; }

        public decimal InMiscAmt { get; set; }

        public decimal DocInMiscAmt { get; set; }

        public decimal Rpt1InMiscAmt { get; set; }

        public decimal Rpt2InMiscAmt { get; set; }

        public decimal Rpt3InMiscAmt { get; set; }

        public decimal Percentage { get; set; }

        [Required]
        [StringLength(1)]
        public string Type { get; set; }

        public bool ChangeTrackApproved { get; set; }

        public decimal ChangeTrackAmount { get; set; }

        [Required]
        [StringLength(50)]
        public string ChangeTrackMemoDesc { get; set; }

        [Required]
        public string ChangeTrackMemoText { get; set; }

        [Required]
        [StringLength(50)]
        public string ChangeTrackStatus { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] SysRevID { get; set; }

        public Guid SysRowID { get; set; }
    }
}
