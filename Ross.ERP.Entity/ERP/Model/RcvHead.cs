namespace Ross.ERP.Entity.ERP.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Erp.RcvHead")]
    public partial class RcvHead
    {
        [Required]
        [StringLength(8)]
        public string Company { get; set; }

        public int VendorNum { get; set; }

        [Required]
        [StringLength(4)]
        public string PurPoint { get; set; }

        [Required]
        [StringLength(20)]
        public string PackSlip { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ReceiptDate { get; set; }

        [Required]
        [StringLength(75)]
        public string EntryPerson { get; set; }

        public bool SaveForInvoicing { get; set; }

        public bool Invoiced { get; set; }

        [Required]
        public string ReceiptComment { get; set; }

        [Required]
        [StringLength(75)]
        public string ReceivePerson { get; set; }

        [Required]
        [StringLength(4)]
        public string ShipViaCode { get; set; }

        [Column(TypeName = "date")]
        public DateTime? EntryDate { get; set; }

        [Required]
        [StringLength(8)]
        public string Plant { get; set; }

        public int PONum { get; set; }

        [Required]
        public string LCReference { get; set; }

        [Required]
        public string LCComment { get; set; }

        public decimal LandedCost { get; set; }

        [Required]
        [StringLength(30)]
        public string LegalNumber { get; set; }

        public decimal LCVariance { get; set; }

        public bool ICLinked { get; set; }

        [Required]
        [StringLength(8)]
        public string GlbCompany { get; set; }

        public int GlbVendorNum { get; set; }

        [Required]
        [StringLength(4)]
        public string GlbPurPoint { get; set; }

        [Required]
        [StringLength(20)]
        public string GlbPackSlip { get; set; }

        public int ContainerID { get; set; }

        public decimal Weight { get; set; }

        [Required]
        [StringLength(8)]
        public string LCDisburseMethod { get; set; }

        public bool AutoReceipt { get; set; }

        [Required]
        [StringLength(7)]
        public string AutoTranType { get; set; }

        [Required]
        [StringLength(3)]
        public string POType { get; set; }

        public int AutoTranID { get; set; }

        [Required]
        [StringLength(6)]
        public string WeightUOM { get; set; }

        public decimal UpliftPercent { get; set; }

        public decimal SpecDutyAmt { get; set; }

        public decimal AppliedLCAmt { get; set; }

        public decimal LCDutyAmt { get; set; }

        public decimal LCIndCost { get; set; }

        public bool ApplyToLC { get; set; }

        public bool Received { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ArrivedDate { get; set; }

        public decimal AppliedRcptLCAmt { get; set; }

        public decimal LCUpliftIndCost { get; set; }

        public decimal AppliedLCVariance { get; set; }

        [Required]
        [StringLength(12)]
        public string TranDocTypeID { get; set; }

        [Required]
        [StringLength(30)]
        public string ImportNum { get; set; }

        public int ImportedFrom { get; set; }

        [Required]
        [StringLength(40)]
        public string ImportedFromDesc { get; set; }

        public decimal GrossWeight { get; set; }

        [Required]
        [StringLength(6)]
        public string GrossWeightUOM { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] SysRevID { get; set; }

        [Key]
        public Guid SysRowID { get; set; }

        [Required]
        [StringLength(75)]
        public string ChangedBy { get; set; }

        public DateTime? ChangeDate { get; set; }
    }
}
