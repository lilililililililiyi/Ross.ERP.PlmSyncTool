namespace Ross.ERP.Entity.ERP.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Erp.PartRevInspVend")]
    public partial class PartRevInspVend
    {
        [Required]
        [StringLength(8)]
        public string Company { get; set; }

        [Required]
        [StringLength(50)]
        public string PartNum { get; set; }

        [Required]
        [StringLength(12)]
        public string RevisionNum { get; set; }

        [Required]
        [StringLength(12)]
        public string AltMethod { get; set; }

        [Required]
        [StringLength(8)]
        public string VendorID { get; set; }

        [Required]
        [StringLength(8)]
        public string Plant { get; set; }

        public bool SkipLotCtl { get; set; }

        [Required]
        [StringLength(20)]
        public string SkipLotCtlCode { get; set; }

        public int InspCnt { get; set; }

        public int SkipCnt { get; set; }

        public int RptCycles { get; set; }

        public int RejectCnt { get; set; }

        [Required]
        [StringLength(2)]
        public string RejectCntBy { get; set; }

        public int SampleSize { get; set; }

        public decimal SampleSizePct { get; set; }

        public bool ForceInsp { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] SysRevID { get; set; }

        [Key]
        public Guid SysRowID { get; set; }
    }
}
